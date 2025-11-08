-- ================================================
--  CREACIÓN DE BASE DE DATOS (si no existe)
-- ================================================
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'RestauranteBD')
BEGIN
    CREATE DATABASE RestauranteBD;
END
GO

USE RestauranteBD;
GO

-- ================================================
--  TABLA: Clientes (si no existe)
-- ================================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Clientes]') AND type IN (N'U'))
BEGIN
    CREATE TABLE Clientes (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(100) NOT NULL,
        Telefono NVARCHAR(15),
        Email NVARCHAR(100),
        Preferencias NVARCHAR(200)
    );
END
GO

-- ================================================
--  TABLA: Mesas (si no existe)
-- ================================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mesas]') AND type IN (N'U'))
BEGIN
    CREATE TABLE Mesas (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        Capacidad INT NOT NULL,
        Ubicacion NVARCHAR(100),
        Combinable BIT DEFAULT(0),
        Disponible BIT DEFAULT(1)
    );
END
GO

-- ================================================
--  TABLA: Reservas (si no existe)
-- ================================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reservas]') AND type IN (N'U'))
BEGIN
    CREATE TABLE Reservas (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        ClienteID INT NOT NULL,
        MesaID INT NULL,
        FechaReserva DATE NOT NULL,
        HoraInicio TIME NOT NULL,
        HoraFin TIME NOT NULL,
        Estado NVARCHAR(50) DEFAULT('Pendiente'),
        NumeroPersonas INT NOT NULL,
        Observaciones NVARCHAR(200),

        FOREIGN KEY (ClienteID) REFERENCES Clientes(ID),
        FOREIGN KEY (MesaID) REFERENCES Mesas(ID),
        CONSTRAINT CHK_HoraFin CHECK (HoraFin > HoraInicio)
    );
END
GO

-- ================================================
--  TABLA: Menus (si no existe)
-- ================================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Menus]') AND type IN (N'U'))
BEGIN
    CREATE TABLE Menus (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(100) NOT NULL,
        Descripcion NVARCHAR(200),
        Precio DECIMAL(10,2) NOT NULL,
        Disponible BIT DEFAULT(1)
    );
END
GO

-- ================================================
--  TABLA: Promociones (si no existe)
-- ================================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Promociones]') AND type IN (N'U'))
BEGIN
    CREATE TABLE Promociones (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(100) NOT NULL,
        Descripcion NVARCHAR(200),
        Descuento DECIMAL(5,2),
        FechaInicio DATE,
        FechaFin DATE
    );
END
GO

-- ================================================
--  TABLA: Celebraciones (si no existe)
-- ================================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Celebraciones]') AND type IN (N'U'))
BEGIN
    CREATE TABLE Celebraciones (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        ReservaID INT NOT NULL,
        Tipo NVARCHAR(100),
        Detalles NVARCHAR(200),

        FOREIGN KEY (ReservaID) REFERENCES Reservas(ID)
    );
END
GO

-- ================================================
--  TABLA: Recordatorios (si no existe)
-- ================================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Recordatorios]') AND type IN (N'U'))
BEGIN
    CREATE TABLE Recordatorios (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        ReservaID INT NOT NULL,
        FechaEnvio DATETIME NOT NULL,
        Mensaje NVARCHAR(300),
        Estado NVARCHAR(50) DEFAULT('Pendiente'),

        FOREIGN KEY (ReservaID) REFERENCES Reservas(ID)
    );
END
GO

-- ================================================
--  DATOS DE PRUEBA (solo si las tablas están vacías)
-- ================================================

-- Clientes (insertar solo si vacío)
IF NOT EXISTS (SELECT 1 FROM Clientes)
BEGIN
    INSERT INTO Clientes (Nombre, Telefono, Email, Preferencias)
    VALUES 
    ('Juan Pérez', '555-1234', 'juan@example.com', 'Ventana'),
    ('María López', '555-5678', 'maria@example.com', 'Silenciosa'),
    ('Carlos Ramírez', '555-9999', 'carlos@example.com', 'Balcón');
END

-- Mesas (insertar solo si vacío)
IF NOT EXISTS (SELECT 1 FROM Mesas)
BEGIN
    INSERT INTO Mesas (Capacidad, Ubicacion, Combinable, Disponible)
    VALUES
    (2, 'Ventana', 1, 1),
    (4, 'Centro', 0, 1),
    (6, 'Balcón', 1, 1),
    (8, 'Privado', 0, 1);
END

-- Menús (insertar solo si vacío)
IF NOT EXISTS (SELECT 1 FROM Menus)
BEGIN
    INSERT INTO Menus (Nombre, Descripcion, Precio)
    VALUES
    ('Menú Ejecutivo', 'Plato fuerte, bebida y postre', 250.00),
    ('Menú Infantil', 'Plato pequeño y jugo', 150.00),
    ('Cena Gourmet', 'Entrada, plato fuerte, vino y postre', 480.00);
END

-- Promociones (insertar solo si vacío)
IF NOT EXISTS (SELECT 1 FROM Promociones)
BEGIN
    INSERT INTO Promociones (Nombre, Descripcion, Descuento, FechaInicio, FechaFin)
    VALUES
    ('Descuento de cumpleaños', '10% en la cuenta final', 10.00, '2025-01-01', '2025-12-31'),
    ('2x1 en bebidas', 'Solo los viernes', 50.00, '2025-01-01', '2025-12-31');
END

-- Reservas (insertar solo si vacío)
IF NOT EXISTS (SELECT 1 FROM Reservas)
BEGIN
    INSERT INTO Reservas (ClienteID, MesaID, FechaReserva, HoraInicio, HoraFin, Estado, NumeroPersonas, Observaciones)
    VALUES
    (1, 1, '2025-11-07', '19:00:00', '20:30:00', 'Confirmada', 2, 'Mesa cerca de la ventana'),
    (2, 2, '2025-11-07', '20:00:00', '21:30:00', 'Pendiente', 4, 'Celebración familiar');
END

-- Celebraciones (insertar solo si vacío)
IF NOT EXISTS (SELECT 1 FROM Celebraciones)
BEGIN
    INSERT INTO Celebraciones (ReservaID, Tipo, Detalles)
    VALUES
    (2, 'Cumpleaños', 'Decoración y pastel');
END

-- Recordatorios (insertar solo si vacío)
IF NOT EXISTS (SELECT 1 FROM Recordatorios)
BEGIN
    INSERT INTO Recordatorios (ReservaID, FechaEnvio, Mensaje, Estado)
    VALUES
    (2, '2025-11-06 10:00:00', 'Recordatorio: tienes una reserva mañana a las 8 PM', 'Enviado');
END
GO

PRINT '✅ Base de datos RestauranteBD creada exitosamente con datos de ejemplo.';