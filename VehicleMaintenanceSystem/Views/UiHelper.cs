using System.Data;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Views;

public static class UiHelper
{
    public static void FormatGrid(DataGridView g)
    {
        g.CellFormatting += Grid_CellFormatting;
    }

    private static void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        var g = (DataGridView)sender;
        if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null || e.Value == DBNull.Value) return;
        string header = g.Columns[e.ColumnIndex].HeaderText;

        if (e.Value is DateTime dt)
        {
            e.Value = dt.ToString("yyyy-MM-dd");
            e.FormattingApplied = true;
        }
        else if (header.Contains("RWF") && (e.Value is decimal || e.Value is double))
        {
            e.CellStyle.Format = "N2";
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }

    public static void HideColumns(DataGridView g, params string[] names)
    {
        foreach (var n in names)
            if (g.Columns.Contains(n)) g.Columns[n].Visible = false;
    }

    public static int? SelectedId(DataGridView g, string column)
    {
        if (g.CurrentRow == null || g.CurrentRow.Index < 0 || !g.Columns.Contains(column)) return null;
        var v = g.CurrentRow.Cells[column].Value;
        return v == null || v == DBNull.Value ? null : Convert.ToInt32(v);
    }

    public static void SelectRowById(DataGridView g, string column, int id)
    {
        foreach (DataGridViewRow row in g.Rows)
        {
            if (row.Cells[column].Value != null && Convert.ToInt32(row.Cells[column].Value) == id)
            {
                row.Selected = true;
                g.CurrentCell = row.Cells.Cast<DataGridViewCell>().First(c => c.Visible);
                return;
            }
        }
    }

    public static void BindVehicles(ComboBox combo, DataTable lookup)
    {
        combo.DataSource = lookup;
        combo.DisplayMember = "display";
        combo.ValueMember = "vehicle_id";
        if (lookup.Rows.Count > 0) combo.SelectedIndex = 0; else combo.SelectedIndex = -1;
    }

    public static int SelectedVehicleId(ComboBox combo)
    {
        if (combo.SelectedValue == null) return 0;
        return int.TryParse(combo.SelectedValue.ToString(), out int id) ? id : 0;
    }

    public static DateTime? OptionalDate(DateTimePicker p) => p.Checked ? (DateTime?)p.Value.Date : null;

    public static void Info(string message) =>
        MessageBox.Show(message, "Vehicle Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Information);

    public static void Error(string message) =>
        MessageBox.Show(message, "Vehicle Maintenance System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

    public static bool Confirm(string message) =>
        MessageBox.Show(message, "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

    public static bool Show(OperationResult result)
    {
        if (result.Success) Info(result.Message); else Error(result.Message);
        return result.Success;
    }

    public static void Guard(Action action)
    {
        try { action(); }
        catch (Exception ex) { Error("Database error: " + ex.Message); }
    }
}
