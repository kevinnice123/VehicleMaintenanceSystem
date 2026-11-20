-- Tables for the Vehicle Maintenance System (PostgreSQL).
-- The program also runs this file by itself when it starts.

CREATE TABLE IF NOT EXISTS users (
    user_id        SERIAL PRIMARY KEY,
    full_name      VARCHAR(100) NOT NULL,
    username       VARCHAR(50)  NOT NULL,
    email          VARCHAR(100) NOT NULL,
    password_hash  VARCHAR(200) NOT NULL,
    role           VARCHAR(30)  NOT NULL
                   CHECK (role IN ('Administrator','Fleet Manager','Maintenance Officer','Management')),
    is_active      BOOLEAN      NOT NULL DEFAULT TRUE,
    created_at     TIMESTAMP    NOT NULL DEFAULT NOW()
);
CREATE UNIQUE INDEX IF NOT EXISTS ux_users_username ON users (LOWER(username));
CREATE UNIQUE INDEX IF NOT EXISTS ux_users_email    ON users (LOWER(email));

CREATE TABLE IF NOT EXISTS drivers (
    driver_id        SERIAL PRIMARY KEY,
    full_name        VARCHAR(100) NOT NULL,
    phone            VARCHAR(30)  NOT NULL,
    email            VARCHAR(100),
    licence_number   VARCHAR(50)  NOT NULL UNIQUE,
    licence_category VARCHAR(10)  NOT NULL,
    licence_expiry   DATE         NOT NULL,
    created_at       TIMESTAMP    NOT NULL DEFAULT NOW()
);

CREATE TABLE IF NOT EXISTS vehicles (
    vehicle_id          SERIAL PRIMARY KEY,
    registration_number VARCHAR(20) NOT NULL UNIQUE,
    make                VARCHAR(50) NOT NULL,
    model               VARCHAR(50) NOT NULL,
    manufacture_year    INT         NOT NULL CHECK (manufacture_year BETWEEN 1950 AND 2100),
    vehicle_type        VARCHAR(30) NOT NULL,
    mileage             INT         NOT NULL CHECK (mileage >= 0),
    driver_id           INT REFERENCES drivers(driver_id) ON DELETE SET NULL,
    created_at          TIMESTAMP   NOT NULL DEFAULT NOW()
);

CREATE TABLE IF NOT EXISTS maintenance_schedules (
    schedule_id      SERIAL PRIMARY KEY,
    vehicle_id       INT          NOT NULL REFERENCES vehicles(vehicle_id) ON DELETE CASCADE,
    planned_date     DATE         NOT NULL,
    expected_mileage INT          NOT NULL CHECK (expected_mileage >= 0),
    description      VARCHAR(500) NOT NULL,
    status           VARCHAR(20)  NOT NULL DEFAULT 'Planned'
                     CHECK (status IN ('Planned','In Progress','Completed','Cancelled')),
    created_at       TIMESTAMP    NOT NULL DEFAULT NOW()
);

CREATE TABLE IF NOT EXISTS service_records (
    record_id        SERIAL PRIMARY KEY,
    vehicle_id       INT           NOT NULL REFERENCES vehicles(vehicle_id) ON DELETE CASCADE,
    schedule_id      INT           REFERENCES maintenance_schedules(schedule_id) ON DELETE SET NULL,
    service_date     DATE          NOT NULL,
    mileage          INT           NOT NULL CHECK (mileage >= 0),
    maintenance_type VARCHAR(50)   NOT NULL,
    description      VARCHAR(1000) NOT NULL,
    service_provider VARCHAR(100)  NOT NULL,
    cost             NUMERIC(14,2) NOT NULL CHECK (cost >= 0),
    created_by       INT           REFERENCES users(user_id) ON DELETE SET NULL,
    created_at       TIMESTAMP     NOT NULL DEFAULT NOW()
);

CREATE INDEX IF NOT EXISTS ix_records_vehicle  ON service_records (vehicle_id, service_date);
CREATE INDEX IF NOT EXISTS ix_schedules_vehicle ON maintenance_schedules (vehicle_id, planned_date);
