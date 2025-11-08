-- ================================================
--  CREACIÓN DE BASE DE DATOS
-- ================================================
CREATE DATABASE RestauranteBD;
GO

USE RestauranteBD;
GO

-- ================================================
--  TABLA: Clientes
-- ================================================
CREATE TABLE Clientes (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(15),
    Email NVARCHAR(100),
    Preferencias NVARCHAR(200)
);
GO

-- ================================================
--  TABLA: Mesas
-- ================================================
CREATE TABLE Mesas (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Capacidad INT NOT NULL,
    Ubicacion NVARCHAR(100),
    Combinable BIT DEFAULT(0),
    Disponible BIT DEFAULT(1)
);
GO

-- ================================================
--  TABLA: Reservas
-- ================================================
CREATE TABLE Reservas (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ClienteID INT NOT NULL,
    MesaID INT NULL,
    FechaReserva DATETIME NOT NULL,
    HoraInicio DATETIME NOT NULL,
    HoraFin DATETIME NOT NULL,
    Estado NVARCHAR(50) DEFAULT('Pendiente'),
    NumeroPersonas INT NOT NULL,
    Observaciones NVARCHAR(200),

    FOREIGN KEY (ClienteID) REFERENCES Clientes(ID),
    FOREIGN KEY (MesaID) REFERENCES Mesas(ID)
);
GO

-- ================================================
--  TABLA: Menus
-- ================================================
CREATE TABLE Menus (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(200),
    Precio DECIMAL(10,2) NOT NULL,
    Disponible BIT DEFAULT(1)
);
GO

-- ================================================
--  TABLA: Promociones
-- ================================================
CREATE TABLE Promociones (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(200),
    Descuento DECIMAL(5,2),
    FechaInicio DATE,
    FechaFin DATE
);
GO

-- ================================================
--  TABLA: Celebraciones
-- ================================================
CREATE TABLE Celebraciones (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ReservaID INT NOT NULL,
    Tipo NVARCHAR(100),
    Detalles NVARCHAR(200),

    FOREIGN KEY (ReservaID) REFERENCES Reservas(ID)
);
GO

-- ================================================
--  TABLA: Recordatorios
-- ================================================
CREATE TABLE Recordatorios (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ReservaID INT NOT NULL,
    FechaEnvio DATETIME NOT NULL,
    Mensaje NVARCHAR(300),
    Estado NVARCHAR(50) DEFAULT('Pendiente'),

    FOREIGN KEY (ReservaID) REFERENCES Reservas(ID)
);
GO

-- ================================================
--  DATOS DE PRUEBA
-- ================================================

-- Clientes
INSERT INTO Clientes (Nombre, Telefono, Email, Preferencias)
VALUES 
('Juan Pérez', '555-1234', 'juan@example.com', 'Ventana'),
('María López', '555-5678', 'maria@example.com', 'Silenciosa'),
('Carlos Ramírez', '555-9999', 'carlos@example.com', 'Balcón');

-- Mesas
INSERT INTO Mesas (Capacidad, Ubicacion, Combinable, Disponible)
VALUES
(2, 'Ventana', 1, 1),
(4, 'Centro', 0, 1),
(6, 'Balcón', 1, 1),
(8, 'Privado', 0, 1);

-- Menús
INSERT INTO Menus (Nombre, Descripcion, Precio)
VALUES
('Menú Ejecutivo', 'Plato fuerte, bebida y postre', 250.00),
('Menú Infantil', 'Plato pequeño y jugo', 150.00),
('Cena Gourmet', 'Entrada, plato fuerte, vino y postre', 480.00);

-- Promociones
INSERT INTO Promociones (Nombre, Descripcion, Descuento, FechaInicio, FechaFin)
VALUES
('Descuento de cumpleaños', '10% en la cuenta final', 10.00, '2025-01-01', '2025-12-31'),
('2x1 en bebidas', 'Solo los viernes', 50.00, '2025-01-01', '2025-12-31');

-- Reservas
INSERT INTO Reservas (ClienteID, MesaID, FechaReserva, HoraInicio, HoraFin, Estado, NumeroPersonas, Observaciones)
VALUES
(1, 1, '2025-11-07', '2025-11-07 19:00', '2025-11-07 20:30', 'Confirmada', 2, 'Mesa cerca de la ventana'),
(2, 2, '2025-11-07', '2025-11-07 20:00', '2025-11-07 21:30', 'Pendiente', 4, 'Celebración familiar');

-- Celebraciones
INSERT INTO Celebraciones (ReservaID, Tipo, Detalles)
VALUES
(2, 'Cumpleaños', 'Decoración y pastel');

-- Recordatorios
INSERT INTO Recordatorios (ReservaID, FechaEnvio, Mensaje, Estado)
VALUES
(2, '2025-11-06 10:00', 'Recordatorio: tienes una reserva mañana a las 8 PM', 'Enviado');
GO

PRINT '✅ Base de datos RestauranteBD creada exitosamente con datos de ejemplo.';
