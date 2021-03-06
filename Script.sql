use master
go
create database dbInventarios
go


USE [dbInventarios]
GO
/****** Object:  Table [dbo].[tblColmados]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblColmados](
	[IdColmado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NULL,
	[NombrePropietario] [varchar](50) NULL,
	[CapitalInversion] [int] NULL,
	[Telefono] [varchar](13) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdColmado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCuentaXCobrar]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCuentaXCobrar](
	[IdCuentaXCobrar] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Monto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCuentaXCobrar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCuentaXPagar]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCuentaXPagar](
	[IdCuentaXPagar] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Monto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCuentaXPagar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEfectivos]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEfectivos](
	[IdEfectivo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Monto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEfectivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblGastos]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblGastos](
	[IdGasto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Monto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdGasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblInventarios]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblInventarios](
	[IdInventario] [int] IDENTITY(1,1) NOT NULL,
	[Ventas] [int] NULL DEFAULT ((0)),
	[Mercancia] [int] NULL DEFAULT ((0)),
	[CuentaXCobrar] [int] NULL DEFAULT ((0)),
	[CuentaXPagar] [int] NULL DEFAULT ((0)),
	[Efectivo] [int] NULL DEFAULT ((0)),
	[Gasto] [int] NULL DEFAULT ((0)),
	[IdColmado] [int] NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdInventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMercancias]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMercancias](
	[IdMercancia] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Precio] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMercancia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblVentas]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblVentas](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](40) NULL,
	[Monto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblColmados] ON 

GO
INSERT [dbo].[tblColmados] ([IdColmado], [Nombre], [Direccion], [NombrePropietario], [CapitalInversion], [Telefono]) VALUES (59, N'Colmado M y M', N'Calle tal', N'Fauto Moreno', 176000, N'8096815695')
GO
SET IDENTITY_INSERT [dbo].[tblColmados] OFF
GO
SET IDENTITY_INSERT [dbo].[tblInventarios] ON 

GO
INSERT [dbo].[tblInventarios] ([IdInventario], [Ventas], [Mercancia], [CuentaXCobrar], [CuentaXPagar], [Efectivo], [Gasto], [IdColmado], [Fecha]) VALUES (68, 1203500, 191112, 304573, 218869, 22500, 107815, 59, CAST(N'2019-01-14 18:29:29.503' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tblInventarios] OFF
GO
ALTER TABLE [dbo].[tblCuentaXCobrar] ADD  CONSTRAINT [DF_tblCuentaXCobrar_Monto]  DEFAULT ((0)) FOR [Monto]
GO
ALTER TABLE [dbo].[tblCuentaXPagar] ADD  CONSTRAINT [DF_tblCuentaXPagar_Monto]  DEFAULT ((0)) FOR [Monto]
GO
ALTER TABLE [dbo].[tblEfectivos] ADD  CONSTRAINT [DF_tblEfectivos_Monto]  DEFAULT ((0)) FOR [Monto]
GO
ALTER TABLE [dbo].[tblGastos] ADD  CONSTRAINT [DF_tblGastos_Monto]  DEFAULT ((0)) FOR [Monto]
GO
ALTER TABLE [dbo].[tblVentas] ADD  CONSTRAINT [DF_tblVentas_Monto]  DEFAULT ((0)) FOR [Monto]
GO
ALTER TABLE [dbo].[tblInventarios]  WITH CHECK ADD FOREIGN KEY([IdColmado])
REFERENCES [dbo].[tblColmados] ([IdColmado])
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[paActualizarColmado]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[paActualizarColmado]
@IdColmado int,
@Nombre varchar(50),
@Direccion varchar(50),
@NombrePropietario varchar(50),
@CapitalInversion int,
@Telefono varchar(13)
AS
update tblColmados set Nombre=@Nombre, Direccion=@Direccion, NombrePropietario=@NombrePropietario, CapitalInversion=@CapitalInversion, Telefono=@Telefono where IdColmado=@IdColmado


GO
/****** Object:  StoredProcedure [dbo].[paActualizarCuentaXCobrar]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paActualizarCuentaXCobrar]
@IdCuentaXCobrar int,
@Descripcion varchar(50),
@Monto int
AS
update tblCuentaXCobrar set Descripcion=@Descripcion, Monto=@Monto where IdCuentaXCobrar=@IdCuentaXCobrar


GO
/****** Object:  StoredProcedure [dbo].[paActualizarCuentaXPagar]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paActualizarCuentaXPagar]
@IdCuentaXPagar int,
@Descripcion varchar(50),
@Monto int
AS
update tblCuentaXPagar set Descripcion=@Descripcion, Monto=@Monto where IdCuentaXPagar=@IdCuentaXPagar


GO
/****** Object:  StoredProcedure [dbo].[paActualizarEfectivo]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paActualizarEfectivo]
@IdEfectivo int,
@Descripcion varchar(50),
@Monto int
AS
update tblEfectivos set Descripcion=@Descripcion, Monto=@Monto where IdEfectivo=@IdEfectivo


GO
/****** Object:  StoredProcedure [dbo].[paActualizarGasto]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paActualizarGasto]
@IdGasto int,
@Descripcion varchar(50),
@Monto int
AS
update tblGastos set Descripcion=@Descripcion, Monto=@Monto where IdGasto=@IdGasto


GO
/****** Object:  StoredProcedure [dbo].[paActualizarInventario]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[paActualizarInventario]
@IdInventario int
AS
Declare @Venta int, @Mercancia int, @CuentaXCobrar int, @CuentaXPagar int, @Efectivo int, @Gasto int
select @Venta=sum(Monto) from tblVentas
select @Mercancia=sum(Cantidad*Precio) from tblMercancias
select @CuentaXCobrar=sum(Monto)from tblCuentaXCobrar
select @CuentaXPagar=sum(Monto)from tblCuentaXPagar
select @Efectivo=sum(Monto)from tblEfectivos
select @Gasto=sum(Monto)from tblGastos

 IF(@Venta)=0
  SET @Venta=null;

 IF(@Mercancia)is NULL
 SET @Mercancia=0;

 IF(@CuentaXCobrar)is NULL
 SET  @CuentaXCobrar=0;

 IF(@CuentaXPagar)is NULL
 SET @CuentaXPagar=0;

 IF(@Efectivo)is NULL
 SET @Efectivo=0;

 IF(@Gasto)is NULL
 SET @Gasto=0;
update tblInventarios set Ventas=@Venta, Mercancia=@Mercancia, CuentaXCobrar=@CuentaXCobrar, CuentaXPagar=@CuentaXPagar 
      ,Efectivo=@Efectivo,Gasto=@Gasto where IdInventario=@IdInventario

















 



GO
/****** Object:  StoredProcedure [dbo].[paActualizarMercancia]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[paActualizarMercancia]
@IdMercancia int,
@Nombre varchar(50),
@Precio int,
@Cantidad int 
AS
update tblMercancias set Nombre=@Nombre, Precio=@Precio, Cantidad=@Cantidad where IdMercancia=@IdMercancia


GO
/****** Object:  StoredProcedure [dbo].[paActualizarVenta]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paActualizarVenta]
@IdVenta int,
@Descripcion varchar(40),
@Monto int
AS
update tblVentas set Descripcion=@Descripcion, Monto=@Monto where IdVenta=@IdVenta


GO
/****** Object:  StoredProcedure [dbo].[paBuscarColmadoporNombre]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paBuscarColmadoporNombre]
@Nombre varchar(50)
as
select * from tblColmados where Nombre like @Nombre+'%'
GO
/****** Object:  StoredProcedure [dbo].[paBuscarInventario]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paBuscarInventario]
@txtBuscar varchar(50)
AS
SELECT TOP 100 c.Nombre as [Nombre Colmado], i.Fecha FROM tblInventarios i inner join tblColmados c on i.IdColmado=c.IdColmado where c.Nombre like @txtBuscar+'%'
GO
/****** Object:  StoredProcedure [dbo].[paBuscarInventarioFecha]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paBuscarInventarioFecha]
@fecha datetime
AS
SELECT TOP 100 c.Nombre as [Nombre Colmado], i.Fecha FROM tblInventarios i inner join tblColmados c on i.IdColmado=c.IdColmado where i.Fecha like @fecha+'%'

GO
/****** Object:  StoredProcedure [dbo].[paCrearInventario]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[paCrearInventario]
@IdColmado int null
as
declare @Ventas int,@Mercancia int, @CxC int, @CxP int, @Efectivo int, @Gasto int
select @Ventas=sum(Monto)from tblVentas
select @Mercancia=sum(Cantidad*Precio) from tblMercancias
select @CxC=sum(Monto)from tblCuentaXCobrar
select @CxP=sum(Monto)from tblCuentaXPagar
select @Efectivo=sum(Monto) from tblEfectivos
select @Gasto=sum(Monto)from tblGastos

IF(@Ventas)=0
 set @Ventas=null;

 IF(@Mercancia)is NULL
 set @Mercancia=0;

 IF(@CxC)is NULL
 SET @CxC=0;

 IF(@CxP)is NULL
 SET @CxP=0;

 IF(@Efectivo)is NULL
 SET @Efectivo=0;

 IF(@Gasto)is NULl
 SET @Gasto=0;

INSERT INTO tblInventarios (Ventas, Mercancia, CuentaXCobrar, CuentaXPagar, Efectivo,
Gasto,IdColmado, Fecha) values (@Ventas,@Mercancia,@CxC,@CxP,@Efectivo,@Gasto,@IdColmado,GETDATE())

GO
/****** Object:  StoredProcedure [dbo].[paEliminarColmado]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[paEliminarColmado]
@IdColmado int
AS
DELETE FROM tblColmados where IdColmado=@IdColmado



 



GO
/****** Object:  StoredProcedure [dbo].[paEliminarCuentaXCobrar]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paEliminarCuentaXCobrar]
@IdCuentaXCobrar int
AS
delete from tblCuentaXCobrar where IdCuentaXCobrar=@IdCuentaXCobrar


GO
/****** Object:  StoredProcedure [dbo].[paEliminarCuentaXPagar]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paEliminarCuentaXPagar]
@IdCuentaXPagar int
AS
delete from tblCuentaXPagar where IdCuentaXPagar=@IdCuentaXPagar


GO
/****** Object:  StoredProcedure [dbo].[paEliminarEfectivo]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paEliminarEfectivo]
@IdEfectivo int
as
DELETE FROM tblEfectivos where IdEfectivo=@IdEfectivo




















 



GO
/****** Object:  StoredProcedure [dbo].[paEliminarGasto]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paEliminarGasto]
@IdGasto int
AS
delete from tblGastos where IdGasto=@IdGasto


GO
/****** Object:  StoredProcedure [dbo].[paEliminarInventario]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[paEliminarInventario]
@IdInventario int
AS
delete from tblInventarios where IdInventario=@IdInventario
GO
/****** Object:  StoredProcedure [dbo].[paEliminarMercancia]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paEliminarMercancia]
@IdMercancia int
AS
Delete from tblMercancias where IdMercancia=@IdMercancia


GO
/****** Object:  StoredProcedure [dbo].[paEliminarVenta]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paEliminarVenta]
@IdVenta int
AS
Delete from tblVentas where IdVenta=@IdVenta


GO
/****** Object:  StoredProcedure [dbo].[paInsertarColmado]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*



     --Tabla de la entidad Colmado
create TABLE tblColmados(
IdColmado int identity primary key,
Nombre varchar(50) not null,
Direccion varchar(50),
NombrePropietario varchar(50),
CapitalInversion int,
Telefono varchar(13)
)

go
-- Registro de prueba insert into tblColmados (Nombre, Direccion, NombrePropietario, CapitalInversion, Telefono) values('jdsfjjlsf','asfjsdf','',5000000,'')

       --Table Inventarios
Create table tblInventarios(
IdInventario int identity primary key,
Ventas int,
Mercancia int,
CuentaXCobrar int,
CuentaXPagar int,
Efectivo int,
Gasto int 
)

go
       --Tabla de Detalle de Inventarios
Create table tblDetalle_Inventarios(
IdDetalle_Inventario int identity primary key,
IdColmado int,
IdInventario int,
Fecha datetime,
foreign key(IdColmado) references tblColmados(IdColmado),
foreign key(IdInventario) references tblInventarios(IdInventario)
)

go 
   
   --Table Ventas--
Create table tblVentas(
IdVenta int identity primary key,
Descripcion varchar(40),
Monto int not null
)

go

--Tabla 

Create table tblMercancias(
IdMercancia int identity primary key,
Nombre varchar(50) not null,
Precio int not null,
Cantidad int not null
)
go

---Tabla Cuenta por Cobrar
Create table tblCuentaXCobrar(
IdCuentaXCobrar int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)

go 
--Tabla Cuenta por Pagar
Create table tblCuentaXPagar(
IdCuentaXPagar int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)
go 

--Tabla Efectivos 
Create table tblEfectivos(
IdEfectivo int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)
go

---Tabla Gastos 
Create table tblGastos(
IdGasto int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)*/

-- Para autorizar el digrama alter authorization on database:: dbInventarios to sa

/*Procedimiento Almacenado  a Utilizar*/

---Para la tabla tblColmados Mantenimiento

create procedure [dbo].[paInsertarColmado]
@IdColmado int output,
@Nombre varchar(50),
@Direccion varchar(50),
@NombrePropietario varchar(50),
@CapitalInversion int,
@Telefono varchar(13)
 AS 
 insert into tblColmados (Nombre,Direccion,NombrePropietario,CapitalInversion,Telefono)
  values (@Nombre,@Direccion,@NombrePropietario,@CapitalInversion,@Telefono)


GO
/****** Object:  StoredProcedure [dbo].[paInsertarCuentaXCobrar]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Create database dbInventarios

use dbInventarios


     --Tabla de la entidad Colmado
create TABLE tblColmados(
IdColmado int identity primary key,
Nombre varchar(50) not null,
Direccion varchar(50),
NombrePropietario varchar(50),
CapitalInversion int,
Telefono varchar(13)
)

go
-- Registro de prueba insert into tblColmados (Nombre, Direccion, NombrePropietario, CapitalInversion, Telefono) values('jdsfjjlsf','asfjsdf','',5000000,'')

       --Table Inventarios
Create table tblInventarios(
IdInventario int identity primary key,
Ventas int,
Mercancia int,
CuentaXCobrar int,
CuentaXPagar int,
Efectivo int,
Gasto int 
)

go
       --Tabla de Detalle de Inventarios
Create table tblDetalle_Inventarios(
IdDetalle_Inventario int identity primary key,
IdColmado int,
IdInventario int,
Fecha datetime,
foreign key(IdColmado) references tblColmados(IdColmado),
foreign key(IdInventario) references tblInventarios(IdInventario)
)

go 
   
   --Table Ventas--
Create table tblVentas(
IdVenta int identity primary key,
Descripcion varchar(40),
Monto int not null
)

go

--Tabla 

Create table tblMercancias(
IdMercancia int identity primary key,
Nombre varchar(50) not null,
Precio int not null,
Cantidad int not null
)
go

---Tabla Cuenta por Cobrar
Create table tblCuentaXCobrar(
IdCuentaXCobrar int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)

go 
--Tabla Cuenta por Pagar
Create table tblCuentaXPagar(
IdCuentaXPagar int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)
go 

--Tabla Efectivos 
Create table tblEfectivos(
IdEfectivo int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)
go

---Tabla Gastos 
Create table tblGastos(
IdGasto int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)*/

-- Para autorizar el digrama alter authorization on database:: dbInventarios to sa

/*Procedimiento Almacenado  a Utilizar

---Para la tabla tblColmados Mantenimiento Colmados--

create procedure paInsertarColmado
@IdColmado int output,
@Nombre varchar(50),
@Direccion varchar(50),
@NombrePropietario varchar(50),
@CapitalInversion int,
@Telefono varchar(13)
 AS 
 insert into tblColmados (Nombre,Direccion,NombrePropietario,CapitalInversion,Telefono)
  values (@Nombre,@Direccion,@NombrePropietario,@CapitalInversion,@Telefono)

go

Create procedure paActualizarColmado
@IdColmado int,
@Nombre varchar(50),
@Direccion varchar(50),
@NombrePropietario varchar(50),
@CapitalInversion int,
@Telefono varchar(13)
AS
update tblColmados set Nombre=@Nombre, Direccion=@Direccion, NombrePropietario=@NombrePropietario, CapitalInversion=@CapitalInversion, Telefono=@Telefono where IdColmado=@IdColmado

go 

CREATE PROCEDURE paMostrarColmados
as
select * from tblColmados

go

Create procedure paEliminarColmado
@IdColmado int
AS
DELETE FROM tblColmados where IdColmado=@IdColmado

CREATE PROCEDURE paBuscarColmadoporNombre
@Nombre varchar(50)
as
select * from tblColmados where Nombre like @Nombre+'%'

go

   --Mantenimiento de los Inventarios--

CREATE procedure paInsertarInventario
@IdInventario int output,
@Venta int,
@Mercancia int,
@CuentaXCobrar int,
@CuentaXPagar int,
@Efectivo int,
@Gasto int
AS
INSERT INTO tblInventarios (Ventas,Mercancia,CuentaXCobrar,CuentaXPagar,Efectivo,Gasto) 
  values (@Venta,@Mercancia,@CuentaXCobrar,@CuentaXPagar,@Efectivo,@Gasto)

go

CREATE procedure paActualizarInventario
@IdInventario int,
@Venta int,
@Mercancia int,
@CuentaXCobrar int,
@CuentaXPagar int,
@Efectivo int,
@Gasto int
AS

update tblInventarios set Ventas=@Venta, Mercancia=@Mercancia, CuentaXCobrar=@CuentaXCobrar, CuentaXPagar=@CuentaXPagar 
      ,Efectivo=@Efectivo,Gasto=@Gasto where IdInventario=@IdInventario*/

	  --Mantenimento CuentaXCobrar--

CREATE PROCEDURE [dbo].[paInsertarCuentaXCobrar]
@IdCuentaXCobrar int output,
@Descripcion varchar(50),
@Monto int
AS
Insert  into tblCuentaXCobrar (Descripcion,Monto) values (@Descripcion,@Monto)


GO
/****** Object:  StoredProcedure [dbo].[paInsertarCuentaXPagar]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Create database dbInventarios

use dbInventarios


     --Tabla de la entidad Colmado
create TABLE tblColmados(
IdColmado int identity primary key,
Nombre varchar(50) not null,
Direccion varchar(50),
NombrePropietario varchar(50),
CapitalInversion int,
Telefono varchar(13)
)

go
-- Registro de prueba insert into tblColmados (Nombre, Direccion, NombrePropietario, CapitalInversion, Telefono) values('jdsfjjlsf','asfjsdf','',5000000,'')

       --Table Inventarios
Create table tblInventarios(
IdInventario int identity primary key,
Ventas int,
Mercancia int,
CuentaXCobrar int,
CuentaXPagar int,
Efectivo int,
Gasto int 
)

go
       --Tabla de Detalle de Inventarios
Create table tblDetalle_Inventarios(
IdDetalle_Inventario int identity primary key,
IdColmado int,
IdInventario int,
Fecha datetime,
foreign key(IdColmado) references tblColmados(IdColmado),
foreign key(IdInventario) references tblInventarios(IdInventario)
)

go 
   
   --Table Ventas--
Create table tblVentas(
IdVenta int identity primary key,
Descripcion varchar(40),
Monto int not null
)

go

--Tabla 

Create table tblMercancias(
IdMercancia int identity primary key,
Nombre varchar(50) not null,
Precio int not null,
Cantidad int not null
)
go

---Tabla Cuenta por Cobrar
Create table tblCuentaXCobrar(
IdCuentaXCobrar int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)

go 
--Tabla Cuenta por Pagar
Create table tblCuentaXPagar(
IdCuentaXPagar int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)
go 

--Tabla Efectivos 
Create table tblEfectivos(
IdEfectivo int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)
go

---Tabla Gastos 
Create table tblGastos(
IdGasto int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)*/

-- Para autorizar el digrama alter authorization on database:: dbInventarios to sa

/*Procedimiento Almacenado  a Utilizar

---Para la tabla tblColmados Mantenimiento Colmados--

create procedure paInsertarColmado
@IdColmado int output,
@Nombre varchar(50),
@Direccion varchar(50),
@NombrePropietario varchar(50),
@CapitalInversion int,
@Telefono varchar(13)
 AS 
 insert into tblColmados (Nombre,Direccion,NombrePropietario,CapitalInversion,Telefono)
  values (@Nombre,@Direccion,@NombrePropietario,@CapitalInversion,@Telefono)

go

Create procedure paActualizarColmado
@IdColmado int,
@Nombre varchar(50),
@Direccion varchar(50),
@NombrePropietario varchar(50),
@CapitalInversion int,
@Telefono varchar(13)
AS
update tblColmados set Nombre=@Nombre, Direccion=@Direccion, NombrePropietario=@NombrePropietario, CapitalInversion=@CapitalInversion, Telefono=@Telefono where IdColmado=@IdColmado

go 

CREATE PROCEDURE paMostrarColmados
as
select * from tblColmados

go

Create procedure paEliminarColmado
@IdColmado int
AS
DELETE FROM tblColmados where IdColmado=@IdColmado

CREATE PROCEDURE paBuscarColmadoporNombre
@Nombre varchar(50)
as
select * from tblColmados where Nombre like @Nombre+'%'

go

   --Mantenimiento de los Inventarios--

CREATE procedure paInsertarInventario
@IdInventario int output,
@Venta int,
@Mercancia int,
@CuentaXCobrar int,
@CuentaXPagar int,
@Efectivo int,
@Gasto int
AS
INSERT INTO tblInventarios (Ventas,Mercancia,CuentaXCobrar,CuentaXPagar,Efectivo,Gasto) 
  values (@Venta,@Mercancia,@CuentaXCobrar,@CuentaXPagar,@Efectivo,@Gasto)

go

CREATE procedure paActualizarInventario
@IdInventario int,
@Venta int,
@Mercancia int,
@CuentaXCobrar int,
@CuentaXPagar int,
@Efectivo int,
@Gasto int
AS

update tblInventarios set Ventas=@Venta, Mercancia=@Mercancia, CuentaXCobrar=@CuentaXCobrar, CuentaXPagar=@CuentaXPagar 
      ,Efectivo=@Efectivo,Gasto=@Gasto where IdInventario=@IdInventario

	  --Mantenimento CuentaXCobrar--

CREATE PROCEDURE paInsertarCuentaXCobrar
@IdCuentaXCobrar int output,
@Descripcion varchar(50),
@Monto int
AS
Insert  into tblCuentaXCobrar (Descripcion,Monto) values (@Descripcion,@Monto)

go

CREATE PROCEDURE paActualizarCuentaXCobrar
@IdCuentaXCobrar int,
@Descripcion varchar(50),
@Monto int
AS
update tblCuentaXCobrar set Descripcion=@Descripcion, Monto=@Monto where IdCuentaXCobrar=@IdCuentaXCobrar

go

CREATE PROCEDURE paEliminarCuentaXCobrar
@IdCuentaXCobrar int
AS
delete from tblCuentaXCobrar where IdCuentaXCobrar=@IdCuentaXCobrar

go

CREATE PROCEDURE paMostrarCuentaXCobrar
AS
select * from tblCuentaXCobrar*/

   --Mantenimiento CuentaXPagar----
CREATE PROCEDURE [dbo].[paInsertarCuentaXPagar]
@IdCuentaXPagar int output,
@Descripcion varchar(50),
@Monto int
AS
Insert  into tblCuentaXPagar(Descripcion,Monto) values (@Descripcion,@Monto)


GO
/****** Object:  StoredProcedure [dbo].[paInsertarEfectivo]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Create database dbInventarios

use dbInventarios


     --Tabla de la entidad Colmado
create TABLE tblColmados(
IdColmado int identity primary key,
Nombre varchar(50) not null,
Direccion varchar(50),
NombrePropietario varchar(50),
CapitalInversion int,
Telefono varchar(13)
)

go
-- Registro de prueba insert into tblColmados (Nombre, Direccion, NombrePropietario, CapitalInversion, Telefono) values('jdsfjjlsf','asfjsdf','',5000000,'')

       --Table Inventarios
Create table tblInventarios(
IdInventario int identity primary key,
Ventas int,
Mercancia int,
CuentaXCobrar int,
CuentaXPagar int,
Efectivo int,
Gasto int 
)

go
       --Tabla de Detalle de Inventarios
Create table tblDetalle_Inventarios(
IdDetalle_Inventario int identity primary key,
IdColmado int,
IdInventario int,
Fecha datetime,
foreign key(IdColmado) references tblColmados(IdColmado),
foreign key(IdInventario) references tblInventarios(IdInventario)
)

go 
   
   --Table Ventas--
Create table tblVentas(
IdVenta int identity primary key,
Descripcion varchar(40),
Monto int not null
)

go

--Tabla 

Create table tblMercancias(
IdMercancia int identity primary key,
Nombre varchar(50) not null,
Precio int not null,
Cantidad int not null
)
go

---Tabla Cuenta por Cobrar
Create table tblCuentaXCobrar(
IdCuentaXCobrar int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)

go 
--Tabla Cuenta por Pagar
Create table tblCuentaXPagar(
IdCuentaXPagar int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)
go 

--Tabla Efectivos 
Create table tblEfectivos(
IdEfectivo int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)
go

---Tabla Gastos 
Create table tblGastos(
IdGasto int identity primary key,
Descripcion varchar(50) not null,
Monto int not null
)   go

-- Para autorizar el digrama alter authorization on database:: dbInventarios to sa

/*Procedimiento Almacenado  a Utilizar

---Para la tabla tblColmados Mantenimiento Colmados--

create procedure paInsertarColmado
@IdColmado int output,
@Nombre varchar(50),
@Direccion varchar(50),
@NombrePropietario varchar(50),
@CapitalInversion int,
@Telefono varchar(13)
 AS 
 insert into tblColmados (Nombre,Direccion,NombrePropietario,CapitalInversion,Telefono)
  values (@Nombre,@Direccion,@NombrePropietario,@CapitalInversion,@Telefono)

go

Create procedure paActualizarColmado
@IdColmado int,
@Nombre varchar(50),
@Direccion varchar(50),
@NombrePropietario varchar(50),
@CapitalInversion int,
@Telefono varchar(13)
AS
update tblColmados set Nombre=@Nombre, Direccion=@Direccion, NombrePropietario=@NombrePropietario, CapitalInversion=@CapitalInversion, Telefono=@Telefono where IdColmado=@IdColmado

go 

CREATE PROCEDURE paMostrarColmados
as
select * from tblColmados

go

Create procedure paEliminarColmado
@IdColmado int
AS
DELETE FROM tblColmados where IdColmado=@IdColmado

go

CREATE PROCEDURE paBuscarColmadoporNombre
@Nombre varchar(50)
as
select * from tblColmados where Nombre like @Nombre+'%'

go

   --Mantenimiento de los Inventarios--

CREATE procedure paInsertarInventario
@IdInventario int output,
@Venta int,
@Mercancia int,
@CuentaXCobrar int,
@CuentaXPagar int,
@Efectivo int,
@Gasto int
AS
INSERT INTO tblInventarios (Ventas,Mercancia,CuentaXCobrar,CuentaXPagar,Efectivo,Gasto) 
  values (@Venta,@Mercancia,@CuentaXCobrar,@CuentaXPagar,@Efectivo,@Gasto)

go

CREATE procedure paActualizarInventario
@IdInventario int,
@Venta int,
@Mercancia int,
@CuentaXCobrar int,
@CuentaXPagar int,
@Efectivo int,
@Gasto int
AS

update tblInventarios set Ventas=@Venta, Mercancia=@Mercancia, CuentaXCobrar=@CuentaXCobrar, CuentaXPagar=@CuentaXPagar 
      ,Efectivo=@Efectivo,Gasto=@Gasto where IdInventario=@IdInventario

go

	  --Mantenimento CuentaXCobrar--

CREATE PROCEDURE paInsertarCuentaXCobrar
@IdCuentaXCobrar int output,
@Descripcion varchar(50),
@Monto int
AS
Insert  into tblCuentaXCobrar (Descripcion,Monto) values (@Descripcion,@Monto)

go

CREATE PROCEDURE paActualizarCuentaXCobrar
@IdCuentaXCobrar int,
@Descripcion varchar(50),
@Monto int
AS
update tblCuentaXCobrar set Descripcion=@Descripcion, Monto=@Monto where IdCuentaXCobrar=@IdCuentaXCobrar

go

CREATE PROCEDURE paEliminarCuentaXCobrar
@IdCuentaXCobrar int
AS
delete from tblCuentaXCobrar where IdCuentaXCobrar=@IdCuentaXCobrar

go

CREATE PROCEDURE paMostrarCuentaXCobrar
AS
select * from tblCuentaXCobrar

go

   --Mantenimiento CuentaXPagar----

CREATE PROCEDURE paInsertarCuentaXPagar
@IdCuentaXPagar int output,
@Descripcion varchar(50),
@Monto int
AS
Insert  into tblCuentaXPagar(Descripcion,Monto) values (@Descripcion,@Monto)

go

CREATE PROCEDURE paActualizarCuentaXPagar
@IdCuentaXPagar int,
@Descripcion varchar(50),
@Monto int
AS
update tblCuentaXPagar set Descripcion=@Descripcion, Monto=@Monto where IdCuentaXPagar=@IdCuentaXPagar

go

CREATE PROCEDURE paEliminarCuentaXPagar
@IdCuentaXPagar int
AS
delete from tblCuentaXPagar where IdCuentaXPagar=@IdCuentaXPagar

go

CREATE PROCEDURE paMostrarCuentaXPagar
AS
select * from tblCuentaXPagar*/

--Mantenimiento Detalle_Inventarios---

CREATE PROCEDURE [dbo].[paInsertarEfectivo]
@IdDetalle_Inventario int output,
@IdColmado int,
@IdInventario int,
@Fecha datetime
AS
insert into tblDetalle_Inventarios (IdColmado,IdInventario,Fecha) values (@IdColmado,@IdInventario,@Fecha)*/

---Mantenimientos table tblEfectivos---

CREATE PROCEDURE paInsertarEfectivo
@IdEfectivo int output,
@Descripcion varchar(50),
@Monto int
AS
insert into tblEfectivos (Descripcion,Monto) values (@Descripcion,@Monto)


GO
/****** Object:  StoredProcedure [dbo].[paInsertarGasto]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---Mantenimiento table Gasto 


CREATE PROCEDURE [dbo].[paInsertarGasto]
@IdGasto int output,
@Descripcion varchar(50),
@Monto int
AS
insert into tblGastos (Descripcion,Monto) values (@Descripcion,@Monto)


GO
/****** Object:  StoredProcedure [dbo].[paInsertarMercancia]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paInsertarMercancia]
@IdMercancia int output,
@Nombre varchar(50),
@Precio int,
@Cantidad int 
AS
Insert into tblMercancias (Nombre,Precio,Cantidad) values (@Nombre,@Precio,@Cantidad)


GO
/****** Object:  StoredProcedure [dbo].[paInsertarVenta]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paInsertarVenta]
@IdVenta int output,
@Descripcion varchar(40),
@Monto int
AS
insert into tblVentas (Descripcion,Monto) values (@Descripcion,@Monto)


GO
/****** Object:  StoredProcedure [dbo].[paMostraLastIdInventario]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[paMostraLastIdInventario]
@IdInventario int=null output
as
DECLARE @valor int
SELECT top 1 @valor=IdInventario from tblInventarios order by IdInventario desc
set @IdInventario=@valor
GO
/****** Object:  StoredProcedure [dbo].[paMostrarColmados]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paMostrarColmados]
as
select IdColmado, Nombre, NombrePropietario as Propietario, CapitalInversion as Inversion, Telefono, Direccion from tblColmados 
order by IdColmado desc
GO
/****** Object:  StoredProcedure [dbo].[paMostrarCuentaXCobrar]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paMostrarCuentaXCobrar]
AS
select * from tblCuentaXCobrar order by IdCuentaXCobrar desc




















 



GO
/****** Object:  StoredProcedure [dbo].[paMostrarCuentaXPagar]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paMostrarCuentaXPagar]
AS
select * from tblCuentaXPagar




















 



GO
/****** Object:  StoredProcedure [dbo].[paMostrarEfectivos]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paMostrarEfectivos]
as
SELECT * FROM tblEfectivos
GO
/****** Object:  StoredProcedure [dbo].[paMostrarGasto]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paMostrarGasto]
AS
select * from tblGastos


















 



GO
/****** Object:  StoredProcedure [dbo].[paMostrarHistoryInventarios]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[paMostrarHistoryInventarios]
as
select top 50 IdInventario,c.Nombre as Colmado, convert(decimal(14,2),convert(decimal(14,2),(((Mercancia+Efectivo+CuentaXCobrar)-CuentaXPagar)-c.CapitalInversion)+Gasto)/Ventas)*100 as [%Bruto]
,i.Fecha from tblInventarios i inner join tblColmados c on i.IdColmado=c.IdColmado where i.Ventas>0 order by i.IdInventario desc
GO
/****** Object:  StoredProcedure [dbo].[paMostrarInventarios]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paMostrarInventarios]
AS
SELECT TOP 6 i.IdInventario, c.Nombre as [Nombre Colmado], i.Fecha  FROM tblInventarios i inner join 
 tblColmados c on i.IdColmado=c.IdColmado order by i.IdInventario desc
GO
/****** Object:  StoredProcedure [dbo].[paMostrarInventariosDetalle]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paMostrarInventariosDetalle]
@IdInventario int
AS
SELECT IdInventario,c.Nombre, c.NombrePropietario,Mercancia,CuentaXCobrar,CuentaXPagar,Ventas, Efectivo, Gasto, Fecha,c.CapitalInversion,
(Mercancia+Efectivo+CuentaXCobrar) as Activos,(Mercancia+Efectivo+CuentaXCobrar)-CuentaXPagar as [Global],
((Mercancia+Efectivo+CuentaXCobrar)-CuentaXPagar)-c.CapitalInversion as Neto, 
 (((Mercancia+Efectivo+CuentaXCobrar)-CuentaXPagar)-c.CapitalInversion)+Gasto as Bruto,
 convert(decimal(14,2),convert(decimal(14,2),(((Mercancia+Efectivo+CuentaXCobrar)-CuentaXPagar)-c.CapitalInversion)+Gasto)/Ventas)*100 as pctBruto
 FROM tblInventarios i inner join tblColmados c on i.IdColmado=c.IdColmado where IdInventario=@IdInventario
GO
/****** Object:  StoredProcedure [dbo].[paMostrarMercancia]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paMostrarMercancia]
AS
Select IdMercancia, Cantidad, Nombre, Precio, (Cantidad * Precio)as Total from tblMercancias
order by IdMercancia desc



















 



GO
/****** Object:  StoredProcedure [dbo].[paMostrarVentas]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[paMostrarVentas]
AS
SELECT * FROM tblVentas

GO
/****** Object:  StoredProcedure [dbo].[paVaciarTablas]    Script Date: 14/1/2019 6:34:16 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[paVaciarTablas]
as
truncate table tblCuentaXCobrar
truncate table tblCuentaXPagar
truncate table tblEfectivos
truncate table tblGastos
truncate table tblMercancias
truncate table tblVentas
GO
