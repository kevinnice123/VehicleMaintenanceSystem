# Vehicle Maintenance System

Student: Niyomugabo Nice Kevin (ID 26708)

A Windows Forms application (C#, .NET 8) with a PostgreSQL database.

## How to run
1. Open `VehicleMaintenanceSystem.sln` in Visual Studio 2022.
2. Make sure PostgreSQL is running on localhost, port 5432.
3. Press F5. The first time, the program creates the database `vehicle_db`, the tables and four default users.

The database settings (user `postgres`, password `nicekevin`) are at the top of `Data/Db.cs`.

## Accounts
| Username | Password   | Role                |
|----------|------------|---------------------|
| admin    | admin123   | Administrator       |
| fleet    | fleet123   | Fleet Manager       |
| officer  | officer123 | Maintenance Officer |
| manager  | manager123 | Management          |

A new user can click **Register** on the login screen. New accounts get the Management role, and the administrator can change it in User Accounts.

## Folders
- `Models` and `Data`: classes and the PostgreSQL queries
- `Views`: the forms (open them in the Visual Studio designer)
- `Controllers`: validation and role checks

## Changing the design
Double-click any file in `Views` (for example `LoginForm.cs`) to open it in the designer. Drag controls from the Toolbox and change them in the Properties window. Do not rename the existing controls (`btnSave`, `dgv`, `txtSearch`, ...) because the code uses those names.
