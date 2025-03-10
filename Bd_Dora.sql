USE [master]
GO
/****** Object:  Database [transporte_dora]    Script Date: 2/06/2024 18:54:19 ******/
CREATE DATABASE [transporte_dora]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'transporte_dora', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\transporte_dora.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'transporte_dora_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\transporte_dora_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [transporte_dora] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [transporte_dora].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [transporte_dora] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [transporte_dora] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [transporte_dora] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [transporte_dora] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [transporte_dora] SET ARITHABORT OFF 
GO
ALTER DATABASE [transporte_dora] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [transporte_dora] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [transporte_dora] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [transporte_dora] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [transporte_dora] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [transporte_dora] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [transporte_dora] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [transporte_dora] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [transporte_dora] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [transporte_dora] SET  ENABLE_BROKER 
GO
ALTER DATABASE [transporte_dora] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [transporte_dora] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [transporte_dora] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [transporte_dora] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [transporte_dora] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [transporte_dora] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [transporte_dora] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [transporte_dora] SET RECOVERY FULL 
GO
ALTER DATABASE [transporte_dora] SET  MULTI_USER 
GO
ALTER DATABASE [transporte_dora] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [transporte_dora] SET DB_CHAINING OFF 
GO
ALTER DATABASE [transporte_dora] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [transporte_dora] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [transporte_dora] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [transporte_dora] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'transporte_dora', N'ON'
GO
ALTER DATABASE [transporte_dora] SET QUERY_STORE = ON
GO
ALTER DATABASE [transporte_dora] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [transporte_dora]
GO
/****** Object:  Table [dbo].[Vendedores]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendedores](
	[VendedorID] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VendedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[TicketID] [int] NOT NULL,
	[VendedorID] [int] NOT NULL,
	[Costo] [decimal](10, 2) NOT NULL,
	[FechaCompra] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pasajeros]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasajeros](
	[PasajeroID] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [varchar](20) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PasajeroID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vista_Tickets]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Tickets] AS
SELECT t.TicketID, p.Nombre AS Pasajero, d.Nombre AS Destino, v.Nombre AS Vendedor, t.Costo, t.FechaCompra
FROM Tickets t
INNER JOIN Pasajeros p ON t.PasajeroID = p.PasajeroID
INNER JOIN Destinos d ON t.DestinoID = d.DestinoID
INNER JOIN Vendedores v ON t.VendedorID = v.VendedorID;
GO
/****** Object:  View [dbo].[Vista_Pasajeros]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Crear vista para mostrar detalles sobre los pasajeros
CREATE VIEW [dbo].[Vista_Pasajeros] AS
SELECT PasajeroID, DNI, Nombre, Apellido, Telefono
FROM Pasajeros;
GO
/****** Object:  View [dbo].[Vista_Destinos]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Crear vista para mostrar información sobre los destinos disponibles
CREATE VIEW [dbo].[Vista_Destinos] AS
SELECT DestinoID, Nombre, Precio
FROM Destinos;
GO
/****** Object:  Table [dbo].[viaje]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[viaje](
	[ViajeID] [int] IDENTITY(1,1) NOT NULL,
	[Destino] [varchar](50) NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ViajeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD FOREIGN KEY([VendedorID])
REFERENCES [dbo].[Vendedores] ([VendedorID])
GO
/****** Object:  StoredProcedure [dbo].[ActualizarDestino]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarDestino]
    @DestinoID INT,
    @Nombre VARCHAR(50),
    @Precio DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el destino
    UPDATE Destinos 
    SET Nombre = @Nombre, Precio = @Precio 
    WHERE DestinoID = @DestinoID;

    -- Verificar si la actualización afectó alguna fila
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('DestinoID no encontrado.', 16, 1);
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[ActualizarPasajero]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarPasajero]
    @PasajeroID INT,
    @DNI VARCHAR(20),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Telefono VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el pasajero
    UPDATE Pasajeros 
    SET DNI = @DNI, Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono 
    WHERE PasajeroID = @PasajeroID;

    -- Verificar si la actualización afectó alguna fila
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('PasajeroID no encontrado.', 16, 1);
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[ActualizarTicket]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarTicket]
    @TicketID INT,
    @PasajeroID INT,
    @DestinoID INT,
    @VendedorID INT,
    @Costo DECIMAL(10, 2),
    @FechaCompra DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el ticket
    UPDATE Tickets 
    SET PasajeroID = @PasajeroID, DestinoID = @DestinoID, VendedorID = @VendedorID, Costo = @Costo, FechaCompra = @FechaCompra
    WHERE TicketID = @TicketID;

    -- Verificar si la actualización afectó alguna fila
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('TicketID no encontrado.', 16, 1);
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[ActualizarVendedor]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarVendedor]
    @VendedorID INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el vendedor
    UPDATE Vendedores 
    SET Nombre = @Nombre, Apellido = @Apellido 
    WHERE VendedorID = @VendedorID;

    -- Verificar si la actualización afectó alguna fila
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('VendedorID no encontrado.', 16, 1);
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarDestino]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarDestino]
    @Nombre VARCHAR(50),
    @Precio DECIMAL(10, 2),
    @DestinoID INT OUTPUT -- Parámetro de salida para obtener el ID generado
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar el nuevo destino
    INSERT INTO Destinos (Nombre, Precio) 
    VALUES (@Nombre, @Precio);

    -- Obtener el ID del destino insertado y asignarlo al parámetro de salida
    SET @DestinoID = SCOPE_IDENTITY();
END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarPasajero]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarPasajero]
    @DNI VARCHAR(20),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Telefono VARCHAR(15),
    @PasajeroID INT OUTPUT -- Parámetro de salida para obtener el ID generado
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar el nuevo pasajero
    INSERT INTO Pasajeros (DNI, Nombre, Apellido, Telefono) 
    VALUES (@DNI, @Nombre, @Apellido, @Telefono);

    -- Obtener el ID del pasajero insertado y asignarlo al parámetro de salida
    SET @PasajeroID = SCOPE_IDENTITY();
END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarTicket]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarTicket]
    @PasajeroID INT,
    @DestinoID INT,
    @VendedorID INT,
    @Costo DECIMAL(10, 2),
    @FechaCompra DATETIME,
    @TicketID INT OUTPUT -- Parámetro de salida para obtener el ID generado
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar el nuevo ticket
    INSERT INTO Tickets (PasajeroID, DestinoID, VendedorID, Costo, FechaCompra) 
    VALUES (@PasajeroID, @DestinoID, @VendedorID, @Costo, @FechaCompra);

    -- Obtener el ID del ticket insertado y asignarlo al parámetro de salida
    SET @TicketID = SCOPE_IDENTITY();
END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarVendedor]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarVendedor]
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @VendedorID INT OUTPUT -- Parámetro de salida para obtener el ID generado
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar el nuevo vendedor
    INSERT INTO Vendedores (Nombre, Apellido) 
    VALUES (@Nombre, @Apellido);

    -- Obtener el ID del vendedor insertado y asignarlo al parámetro de salida
    SET @VendedorID = SCOPE_IDENTITY();
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarDestino]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarDestino]
    @DestinoID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si el destino tiene tickets asociados
    IF EXISTS (SELECT 1 FROM Tickets WHERE DestinoID = @DestinoID)
    BEGIN
        RAISERROR ('No se puede eliminar el destino porque tiene tickets asociados.', 16, 1);
        RETURN;
    END

    -- Eliminar el destino
    DELETE FROM Destinos WHERE DestinoID = @DestinoID;

    -- Verificar si la eliminación afectó alguna fila
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('DestinoID no encontrado.', 16, 1);
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarPasajero]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarPasajero]
    @PasajeroID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si el pasajero tiene tickets asociados
    IF EXISTS (SELECT 1 FROM Tickets WHERE PasajeroID = @PasajeroID)
    BEGIN
        RAISERROR ('No se puede eliminar el pasajero porque tiene tickets asociados.', 16, 1);
        RETURN;
    END

    -- Eliminar el pasajero
    DELETE FROM Pasajeros WHERE PasajeroID = @PasajeroID;

    -- Verificar si la eliminación afectó alguna fila
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('PasajeroID no encontrado.', 16, 1);
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarTicket]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarTicket]
    @TicketID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Eliminar el ticket
    DELETE FROM Tickets WHERE TicketID = @TicketID;

    -- Verificar si la eliminación afectó alguna fila
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('TicketID no encontrado.', 16, 1);
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarVendedor]    Script Date: 2/06/2024 18:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarVendedor]
    @VendedorID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar si el vendedor tiene tickets asociados
    IF EXISTS (SELECT 1 FROM Tickets WHERE VendedorID = @VendedorID)
    BEGIN
        RAISERROR ('No se puede eliminar el vendedor porque tiene tickets asociados.', 16, 1);
        RETURN;
    END

    -- Eliminar el vendedor
    DELETE FROM Vendedores WHERE VendedorID = @VendedorID;

    -- Verificar si la eliminación afectó alguna fila
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('VendedorID no encontrado.', 16, 1);
    END
END;
GO
USE [master]
GO
ALTER DATABASE [transporte_dora] SET  READ_WRITE 
GO
