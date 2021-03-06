CREATE DATABASE [VETERINARIA_EL_BOSQUE]
GO

USE [VETERINARIA_EL_BOSQUE]
GO
/****** Object:  Table [dbo].[ANUNCIOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ANUNCIOS](
	[ID_Anuncios] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_ANUNCIOS] PRIMARY KEY CLUSTERED 
(
	[ID_Anuncios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ANUNCIOS_ENVIADOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ANUNCIOS_ENVIADOS](
	[ID_Anuncios_Enviados] [int] IDENTITY(1,1) NOT NULL,
	[ID_Anuncios] [int] NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Fecha] [timestamp] NOT NULL,
 CONSTRAINT [PK_ANUNCIOS_ENVIADOS] PRIMARY KEY CLUSTERED 
(
	[ID_Anuncios_Enviados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[ID_Articulos] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[ID_Articulos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ARTICULOS_PROVEEDOR]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULOS_PROVEEDOR](
	[ID_Articulos_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[ID_Proveedor] [int] NOT NULL,
	[ID_Articulos] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ARTICULOS_PROVEEDOR] PRIMARY KEY CLUSTERED 
(
	[ID_Articulos_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAJAS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAJAS](
	[ID_Caja] [int] IDENTITY(1,1) NOT NULL,
	[ID_Personal] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_CAJAS] PRIMARY KEY CLUSTERED 
(
	[ID_Caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAMPA_AS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAMPA_AS](
	[ID_Campa_as] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Fecha_Inicio] [date] NOT NULL,
	[Fecha_Fin] [date] NOT NULL,
	[Cantidad_Pacientes] [varchar](50) NULL,
	[ID_Distritos] [int] NOT NULL,
	[Descripcion] [varchar](150) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_CAMPA_AS] PRIMARY KEY CLUSTERED 
(
	[ID_Campa_as] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAMPA_AS_PARTICIPANTES]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAMPA_AS_PARTICIPANTES](
	[ID_Campa_as_Participantes] [int] IDENTITY(1,1) NOT NULL,
	[ID_Campa_as] [int] NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Fecha] [timestamp] NULL,
 CONSTRAINT [PK_CAMPA_AS_PARTICIPANTES] PRIMARY KEY CLUSTERED 
(
	[ID_Campa_as_Participantes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CANTONES]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CANTONES](
	[ID_Cantones] [int] NOT NULL,
	[ID_Provincias] [int] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
 CONSTRAINT [PK_CANTONES] PRIMARY KEY CLUSTERED 
(
	[ID_Cantones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CITAS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CITAS](
	[ID_Cita] [int] IDENTITY(1,1) NOT NULL,
	[ID_Mascota] [int] NOT NULL,
	[ID_Consultorio] [int] NOT NULL,
	[ID_Motivo_Cita] [int] NOT NULL,
	[Fecha_Inicio] [date] NOT NULL,
	[Fecha_Fin] [date] NOT NULL,
	[Hora_Inicio] [time](7) NOT NULL,
	[Hora_Fin] [time](7) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_CITAS] PRIMARY KEY CLUSTERED 
(
	[ID_Cita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](20) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido_1] [varchar](50) NOT NULL,
	[Apellido_2] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NULL,
	[ID_Provincias] [int] NOT NULL,
	[ID_Cantones] [int] NOT NULL,
	[ID_Distritos] [int] NOT NULL,
	[Direccion] [varchar](150) NULL,
	[Credito] [int] NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COBROS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COBROS](
	[ID_Cobro] [int] IDENTITY(1,1) NOT NULL,
	[ID_Caja] [int] NOT NULL,
	[ID_Factura] [int] NOT NULL,
	[Metodo_Pago] [tinyint] NOT NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_COBROS] PRIMARY KEY CLUSTERED 
(
	[ID_Cobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONSULTORIO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONSULTORIO](
	[ID_Consultorio] [int] IDENTITY(1,1) NOT NULL,
	[ID_Tipo_Consultorio] [int] NOT NULL,
	[ID_Personal] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[CreateAt] [datetime] NOT NULL,
 CONSTRAINT [PK_CONSULTORIO] PRIMARY KEY CLUSTERED 
(
	[ID_Consultorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CREDITOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CREDITOS](
	[ID_Creditos] [int] IDENTITY(1,1) NOT NULL,
	[ID_Factura] [int] NOT NULL,
	[Monto_Anterior] [decimal](10, 2) NULL,
	[Monto_Actual] [decimal](10, 2) NULL,
	[Abono] [decimal](10, 2) NULL,
 CONSTRAINT [PK_CREDITOS] PRIMARY KEY CLUSTERED 
(
	[ID_Creditos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEPARTAMENTOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPARTAMENTOS](
	[ID_Departamento] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_DEPARTAMENTOS] PRIMARY KEY CLUSTERED 
(
	[ID_Departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DESPACHO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DESPACHO](
	[ID_Despacho] [int] IDENTITY(1,1) NOT NULL,
	[ID_Factura] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_DESPACHO] PRIMARY KEY CLUSTERED 
(
	[ID_Despacho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_ARTICULOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_ARTICULOS](
	[ID_Detalle_Articulos] [int] IDENTITY(1,1) NOT NULL,
	[ID_Factura] [int] NOT NULL,
	[ID_Articulos] [int] NOT NULL,
	[Cantidad] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_DETALLE_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[ID_Detalle_Articulos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_SERVICIO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_SERVICIO](
	[ID_Detalle_Servicio] [int] IDENTITY(1,1) NOT NULL,
	[ID_Factura] [int] NOT NULL,
	[ID_Servicios] [int] NOT NULL,
	[ID_Cita] [int] NOT NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_DETALLE_SERVICIO] PRIMARY KEY CLUSTERED 
(
	[ID_Detalle_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DISTRITOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DISTRITOS](
	[ID_Distritos] [int] NOT NULL,
	[ID_Cantones] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
 CONSTRAINT [PK_DISTRITOS] PRIMARY KEY CLUSTERED 
(
	[ID_Distritos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADOS](
	[ID_Estados] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_ESTADOS] PRIMARY KEY CLUSTERED 
(
	[ID_Estados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADOS_TABLAS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADOS_TABLAS](
	[ID_Estados] [int] NOT NULL,
	[ID_Tabla] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA_COMPRA]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA_COMPRA](
	[ID_Factura_Compra] [int] IDENTITY(1,1) NOT NULL,
	[ID_Solicitud_Compra] [int] NOT NULL,
	[Numero_Factura] [int] NOT NULL,
	[Referencia_Bancaria] [varchar](50) NULL,
	[Fecha] [date] NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Total] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_FACTURA_COMPRA] PRIMARY KEY CLUSTERED 
(
	[ID_Factura_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA_PROMOCION]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA_PROMOCION](
	[ID_Factura_Promocion] [int] IDENTITY(1,1) NOT NULL,
	[ID_Promocion] [int] NOT NULL,
	[ID_Factura] [int] NOT NULL,
 CONSTRAINT [PK_FACTURA_PROMOCION] PRIMARY KEY CLUSTERED 
(
	[ID_Factura_Promocion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURAS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURAS](
	[ID_Facturas] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[ID_Caja] [int] NOT NULL,
	[Numero_Factura] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Total] [decimal](10, 2) NOT NULL,
	[Tipo_Pago] [tinyint] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_FACTURAS] PRIMARY KEY CLUSTERED 
(
	[ID_Facturas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVENTARIO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVENTARIO](
	[ID_Inventario] [int] IDENTITY(1,1) NOT NULL,
	[ID_Articulos] [int] NOT NULL,
	[Cantidad] [decimal](10, 2) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_INVENTARIO] PRIMARY KEY CLUSTERED 
(
	[ID_Inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MARCAS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MARCAS](
	[ID_Marcas] [int] IDENTITY(1,1) NOT NULL,
	[ID_Personal] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [time](7) NOT NULL,
	[Tipo] [tinyint] NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[ID_Marcas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MASCOTAS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MASCOTAS](
	[ID_Mascota] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Tipo_Animal] [int] NOT NULL,
	[Raza] [varchar](50) NOT NULL,
	[Sexo] [varchar](30) NULL,
	[Edad] [int] NULL,
	[Peso] [decimal](10, 2) NULL,
	[Tamaño] [decimal](10, 2) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_MASCOTAS] PRIMARY KEY CLUSTERED 
(
	[ID_Mascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[METODO_PAGO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[METODO_PAGO](
	[ID] [tinyint] NOT NULL,
	[Metodo] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Metodo_Pago] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOTIVO_CITA]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOTIVO_CITA](
	[ID_Motivo_Cita] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[CreateAt] [datetime] NOT NULL,
 CONSTRAINT [PK_MOTIVO_CITA] PRIMARY KEY CLUSTERED 
(
	[ID_Motivo_Cita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NOMINA]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOMINA](
	[ID_Nomina] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Fecha_Inicio] [date] NOT NULL,
	[Fecha_Fin] [date] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_NOMINA] PRIMARY KEY CLUSTERED 
(
	[ID_Nomina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NOMINA_PERSONAL]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOMINA_PERSONAL](
	[ID_Nomina_Personal] [int] IDENTITY(1,1) NOT NULL,
	[ID_Nomina] [int] NOT NULL,
	[ID_Personal] [int] NOT NULL,
	[Total_Horas] [decimal](10, 2) NULL,
	[Salario_Bruto] [decimal](10, 2) NULL,
	[Salario_Neto] [decimal](10, 2) NULL,
 CONSTRAINT [PK_NOMINA_PERSONAL] PRIMARY KEY CLUSTERED 
(
	[ID_Nomina_Personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OBSERVACIONES]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBSERVACIONES](
	[ID_Observaciones] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cita] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[CreateAt] [datetime] NOT NULL,
 CONSTRAINT [PK_OBSERVACIONES] PRIMARY KEY CLUSTERED 
(
	[ID_Observaciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PARTICIPANTES]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PARTICIPANTES](
	[ID_Participantes] [int] IDENTITY(1,1) NOT NULL,
	[ID_Reclutamiento] [int] NOT NULL,
	[Cedula_] [varchar](20) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Apellido_1] [varchar](30) NOT NULL,
	[Apellido_2] [varchar](30) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Telefono] [varchar](8) NULL,
	[ID_Provincia] [int] NOT NULL,
	[ID_Canton] [int] NOT NULL,
	[ID_Distrito] [int] NOT NULL,
	[Direccion] [varchar](150) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_PARTICIPANTES] PRIMARY KEY CLUSTERED 
(
	[ID_Participantes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERSONAL]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAL](
	[ID_Personal] [int] IDENTITY(1,1) NOT NULL,
	[ID_Puesto] [int] NULL,
	[Cedula] [varchar](20) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Apellido_1] [varchar](30) NULL,
	[Apellido_2] [varchar](30) NULL,
	[Salario_Hora] [decimal](10, 2) NULL,
	[Salario_Mensual] [decimal](10, 2) NULL,
	[Fecha_Contratacion] [date] NULL,
	[created_at] [datetime] NOT NULL,
	[Estado] [int] NOT NULL,
	[ID_Provincia] [int] NULL,
	[ID_Canton] [int] NULL,
	[ID_Distrito] [int] NULL,
	[Direccion] [varchar](150) NULL,
	[Correo_Electronico] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
 CONSTRAINT [PK_PERSONAL] PRIMARY KEY CLUSTERED 
(
	[ID_Personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROMOCIONES]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROMOCIONES](
	[ID_Promocion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Fecha_Inicio] [date] NOT NULL,
	[Fecha_Fin] [date] NOT NULL,
	[Descuento] [decimal](10, 2) NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_PROMOCIONES] PRIMARY KEY CLUSTERED 
(
	[ID_Promocion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDOR]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDOR](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_PROVEEDOR] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVINCIAS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVINCIAS](
	[ID_Provincias] [int] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
 CONSTRAINT [PK_PROVINCIAS] PRIMARY KEY CLUSTERED 
(
	[ID_Provincias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRUEBAS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRUEBAS](
	[ID_Pruebas] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_PRUEBAS] PRIMARY KEY CLUSTERED 
(
	[ID_Pruebas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRUEBAS_LABORATORIO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRUEBAS_LABORATORIO](
	[ID_Pruebas_Laboratorio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[CreateAt] [datetime] NOT NULL,
 CONSTRAINT [PK_PRUEBAS_LABORATORIO] PRIMARY KEY CLUSTERED 
(
	[ID_Pruebas_Laboratorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRUEBAS_PARTICIPANTES]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRUEBAS_PARTICIPANTES](
	[ID_Pruebas_Participantes] [int] IDENTITY(1,1) NOT NULL,
	[ID_Pruebas] [int] NOT NULL,
	[ID_Participantes] [int] NOT NULL,
	[nota] [int] NULL,
 CONSTRAINT [PK_PRUEBAS_PARTICIPANTES] PRIMARY KEY CLUSTERED 
(
	[ID_Pruebas_Participantes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PUESTOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PUESTOS](
	[ID_Puestos] [int] NOT NULL,
	[ID_Departamento] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Salario_Base] [decimal](10, 2) NULL,
	[Descripcion] [varchar](30) NULL,
 CONSTRAINT [PK_PUESTOS] PRIMARY KEY CLUSTERED 
(
	[ID_Puestos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECETAS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECETAS](
	[ID_Receta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cita] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[CreateAt] [datetime] NOT NULL,
 CONSTRAINT [PK_RECETAS] PRIMARY KEY CLUSTERED 
(
	[ID_Receta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECLUTAMIENTO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECLUTAMIENTO](
	[ID_Reclutamiento] [int] IDENTITY(1,1) NOT NULL,
	[ID_Puestos] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_RECLUTAMIENTO] PRIMARY KEY CLUSTERED 
(
	[ID_Reclutamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REQUISITOS_PARTICIPANTES]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REQUISITOS_PARTICIPANTES](
	[ID_Requisitos_Participantes] [int] IDENTITY(1,1) NOT NULL,
	[ID_Requisitos] [int] NOT NULL,
	[ID_Participantes] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_REQUISITOS_PARTICIPANTES] PRIMARY KEY CLUSTERED 
(
	[ID_Requisitos_Participantes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REQUISITOS_PUESTO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REQUISITOS_PUESTO](
	[ID_Requisitos] [int] IDENTITY(1,1) NOT NULL,
	[ID_Puestos] [int] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_REQUISITOS_PUESTO] PRIMARY KEY CLUSTERED 
(
	[ID_Requisitos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RESULTADO_LABORATORIO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RESULTADO_LABORATORIO](
	[ID_Resultado_Laboratorio] [int] IDENTITY(1,1) NOT NULL,
	[ID_Pruebas_Laboratorio] [int] NOT NULL,
	[ID_Cita] [int] NOT NULL,
	[Resultado] [varchar](50) NOT NULL,
	[Estado] [int] NULL,
	[CreateAt] [datetime] NOT NULL,
 CONSTRAINT [PK_RESULTADO_LABORATORIO] PRIMARY KEY CLUSTERED 
(
	[ID_Resultado_Laboratorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROLES]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLES](
	[ID_Roles] [int] NOT NULL,
	[Nombre] [varchar](40) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_ROLES] PRIMARY KEY CLUSTERED 
(
	[ID_Roles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVICIOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICIOS](
	[ID_Servicios] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Precio] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_SERVICIOS] PRIMARY KEY CLUSTERED 
(
	[ID_Servicios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVICIOS_EXPRESS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICIOS_EXPRESS](
	[ID_Servicios] [int] IDENTITY(1,1) NOT NULL,
	[ID_Factura] [int] NOT NULL,
	[Descripcion] [varchar](150) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_SERVICIOS_EXPRESS] PRIMARY KEY CLUSTERED 
(
	[ID_Servicios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SOLICITUD_ARTICULOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SOLICITUD_ARTICULOS](
	[ID_Solicitud_Articulos] [int] IDENTITY(1,1) NOT NULL,
	[ID_Articulo_Proveedor] [int] NOT NULL,
	[ID_Solicitud_Compra] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Cantidad] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_SOLICITUD_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[ID_Solicitud_Articulos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SOLICITUD_COMPRA]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SOLICITUD_COMPRA](
	[ID_Solicitud_Compra] [int] IDENTITY(1,1) NOT NULL,
	[Encabezado] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_SOLICITUD_COMPRA] PRIMARY KEY CLUSTERED 
(
	[ID_Solicitud_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLAS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLAS](
	[ID_Tabla] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
 CONSTRAINT [PK_TABLAS] PRIMARY KEY CLUSTERED 
(
	[ID_Tabla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_ANIMAL]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_ANIMAL](
	[ID_Tipo_Animal] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TIPO_ANIMAL] PRIMARY KEY CLUSTERED 
(
	[ID_Tipo_Animal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_CONSULTORIO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_CONSULTORIO](
	[ID_Tipo_Consultorio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[CreateAt] [datetime] NOT NULL,
 CONSTRAINT [PK_TIPO_CONSULTORIO] PRIMARY KEY CLUSTERED 
(
	[ID_Tipo_Consultorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_MARCA]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_MARCA](
	[ID_Tipo] [tinyint] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Tipo_Marca] PRIMARY KEY CLUSTERED 
(
	[ID_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_PAGO]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_PAGO](
	[ID] [tinyint] NOT NULL,
	[Tipo] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Tipo_Pago] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO_ROL]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO_ROL](
	[ID_Usuario_Rol] [int] IDENTITY(1,1) NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[ID_Roles] [int] NOT NULL,
 CONSTRAINT [PK_USUARIO_ROL] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[ID_Personal] [int] NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[Pass] [varchar](20) NOT NULL,
	[Created_at] [datetime] NOT NULL,
	[Last_Login] [varchar](20) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VACACIONES]    Script Date: 9/4/2020 6:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VACACIONES](
	[ID_Vacaciones] [int] IDENTITY(1,1) NOT NULL,
	[ID_Personal] [int] NOT NULL,
	[Cantidad] [decimal](10, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Descripcion] [varchar](15) NULL,
 CONSTRAINT [PK_VACACIONES] PRIMARY KEY CLUSTERED 
(
	[ID_Vacaciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ARTICULOS] ON 

INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (1, N'Hyalorcal 25 mg ', N'Medicamentos', CAST(5000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (2, N'Apoquel 30 mg', N'Medicamentos', CAST(780.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (3, N'Total f Perros grandes', N'Medicamentos', CAST(6550.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (4, N'Total f Perros medianos', N'Medicamentos', CAST(4600.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (5, N'Total f Perros pequeños', N'Medicamentos', CAST(3440.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (6, N'Aciflux 500 mg', N'Medicamentos', CAST(5800.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (7, N'Analgésico 250 mg', N'Medicamentos', CAST(4000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (8, N'Analgésico 750 mg', N'Medicamentos', CAST(5700.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (9, N'Dog chow 1kg', N'Alimentos', CAST(5700.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (10, N'Ascan 5kg', N'Alimentos', CAST(5700.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ARTICULOS] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [Estado]) VALUES (11, N'Super Perro 10kg', N'Alimentos', CAST(5700.00 AS Decimal(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[ARTICULOS] OFF
SET IDENTITY_INSERT [dbo].[ARTICULOS_PROVEEDOR] ON 

INSERT [dbo].[ARTICULOS_PROVEEDOR] ([ID_Articulos_Proveedor], [ID_Proveedor], [ID_Articulos], [Descripcion]) VALUES (1, 1, 9, N'Proveedor de alimento Dog chow')
SET IDENTITY_INSERT [dbo].[ARTICULOS_PROVEEDOR] OFF
SET IDENTITY_INSERT [dbo].[CAJAS] ON 

INSERT [dbo].[CAJAS] ([ID_Caja], [ID_Personal], [Nombre], [Descripcion], [Estado]) VALUES (1, 1, N'Caja1', N'Caja1', 38)
SET IDENTITY_INSERT [dbo].[CAJAS] OFF
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (1, 1, N'SAN JOSE')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (2, 1, N'ESCAZU')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (3, 1, N'DESAMPARADOS')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (4, 1, N'PURISCAL')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (5, 1, N'TARRAZU')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (6, 1, N'ASERRI')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (7, 1, N'MORA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (8, 1, N'GOICOECHEA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (9, 1, N'SANTA ANA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (10, 1, N'ALAJUELITA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (11, 1, N'VAZQUEZ DE CORONADO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (12, 1, N'ACOSTA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (13, 1, N'TIBAS')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (14, 1, N'MORAVIA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (15, 1, N'MONTES DE OCA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (16, 1, N'TURRUBARES')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (17, 1, N'DOTA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (18, 1, N'CURRIDABAT')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (19, 1, N'PEREZ ZELEDON')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (20, 1, N'LEON CORTES')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (21, 2, N'ALAJUELA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (22, 2, N'SAN RAMON')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (23, 2, N'GRECIA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (24, 2, N'SAN MATEO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (25, 2, N'ATENAS')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (26, 2, N'NARANJO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (27, 2, N'PALMARES')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (28, 2, N'POAS')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (29, 2, N'OROTINA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (30, 2, N'SAN CARLOS')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (31, 2, N'ALFARO RUIZ')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (32, 2, N'VALVERDE VEGA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (33, 2, N'UPALA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (34, 2, N'LOS CHILES')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (35, 2, N'GUATUSO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (36, 3, N'CARTAGO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (37, 3, N'PARAISO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (38, 3, N'LA UNION')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (39, 3, N'JIMENEZ')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (40, 3, N'TURRIALBA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (41, 3, N'ALVARADO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (42, 3, N'OREAMUNO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (43, 3, N'EL GUARCO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (44, 4, N'HEREDIA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (45, 4, N'BARVA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (46, 4, N'SANTO DOMINGO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (47, 4, N'SANTA BARBARA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (48, 4, N'SAN RAFAEL')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (49, 4, N'SAN ISIDRO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (50, 4, N'BELEN')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (51, 4, N'FLORES')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (52, 4, N'SAN PABLO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (53, 4, N'SARAPIQUI')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (54, 5, N'LIBERIA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (55, 5, N'NICOYA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (56, 5, N'SANTA CRUZ')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (57, 5, N'BAGACES')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (58, 5, N'CARRILLO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (59, 5, N'CAÑAS')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (60, 5, N'ABANGARES')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (61, 5, N'TILARAN')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (62, 5, N'NANDAYURE')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (63, 5, N'LA CRUZ')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (64, 5, N'HOJANCHA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (65, 6, N'PUNTARENAS')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (66, 6, N'ESPARZA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (67, 6, N'BUENOS AIRES')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (68, 6, N'MONTES DE ORO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (69, 6, N'OSA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (70, 6, N'AGUIRRE')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (71, 6, N'GOLFITO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (72, 6, N'COTO BRUS')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (73, 6, N'PARRITA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (74, 6, N'CORREDORES')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (75, 6, N'GARABITO')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (76, 7, N'LIMON')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (77, 7, N'POCOCI')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (78, 7, N'SIQUIRRES')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (79, 7, N'TALAMANCA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (80, 7, N'MATINA')
INSERT [dbo].[CANTONES] ([ID_Cantones], [ID_Provincias], [Nombre]) VALUES (81, 7, N'GUACIMO')
SET IDENTITY_INSERT [dbo].[CITAS] ON 

INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (4, 1, 2, 1, CAST(N'2020-08-22' AS Date), CAST(N'2020-08-22' AS Date), CAST(N'07:00:00' AS Time), CAST(N'07:30:00' AS Time), 2)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (5, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (6, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (7, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (8, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (9, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (10, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (11, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (12, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (13, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (14, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (15, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (16, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (17, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (18, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (19, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (20, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (21, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (22, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (23, 1, 3, 1, CAST(N'2020-08-23' AS Date), CAST(N'2020-08-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'10:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (24, 1, 2, 1, CAST(N'2020-08-24' AS Date), CAST(N'2020-08-24' AS Date), CAST(N'07:00:00' AS Time), CAST(N'07:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (1024, 1, 2, 1, CAST(N'2020-09-05' AS Date), CAST(N'2020-09-05' AS Date), CAST(N'08:00:00' AS Time), CAST(N'08:30:00' AS Time), 34)
INSERT [dbo].[CITAS] ([ID_Cita], [ID_Mascota], [ID_Consultorio], [ID_Motivo_Cita], [Fecha_Inicio], [Fecha_Fin], [Hora_Inicio], [Hora_Fin], [Estado]) VALUES (1025, 1, 2, 1, CAST(N'2020-09-05' AS Date), CAST(N'2020-09-05' AS Date), CAST(N'08:00:00' AS Time), CAST(N'08:30:00' AS Time), 34)
SET IDENTITY_INSERT [dbo].[CITAS] OFF
SET IDENTITY_INSERT [dbo].[CLIENTES] ON 

INSERT [dbo].[CLIENTES] ([ID_Cliente], [Cedula], [Nombre], [Apellido_1], [Apellido_2], [Correo], [Telefono], [ID_Provincias], [ID_Cantones], [ID_Distritos], [Direccion], [Credito], [Estado]) VALUES (1, N'123456789', N'Pedro', N'Mora', N'Rojas', N'pedro@gmail.com', N'88882020', 1, 1, 561, N'25 este de la plaza', 0, 5)
SET IDENTITY_INSERT [dbo].[CLIENTES] OFF
SET IDENTITY_INSERT [dbo].[CONSULTORIO] ON 

INSERT [dbo].[CONSULTORIO] ([ID_Consultorio], [ID_Tipo_Consultorio], [ID_Personal], [Nombre], [Descripcion], [CreateAt]) VALUES (2, 1, 1, N'Consultorio 1', NULL, CAST(N'2020-08-17T15:00:41.147' AS DateTime))
INSERT [dbo].[CONSULTORIO] ([ID_Consultorio], [ID_Tipo_Consultorio], [ID_Personal], [Nombre], [Descripcion], [CreateAt]) VALUES (3, 1, 1, N'Consultorio 2', NULL, CAST(N'2020-08-17T15:00:59.437' AS DateTime))
INSERT [dbo].[CONSULTORIO] ([ID_Consultorio], [ID_Tipo_Consultorio], [ID_Personal], [Nombre], [Descripcion], [CreateAt]) VALUES (4, 1, 1, N'Consultorio movil', NULL, CAST(N'2020-08-17T15:00:59.437' AS DateTime))
INSERT [dbo].[CONSULTORIO] ([ID_Consultorio], [ID_Tipo_Consultorio], [ID_Personal], [Nombre], [Descripcion], [CreateAt]) VALUES (5, 2, 1, N'Laboratorio 1', NULL, CAST(N'2020-08-17T15:01:33.797' AS DateTime))
INSERT [dbo].[CONSULTORIO] ([ID_Consultorio], [ID_Tipo_Consultorio], [ID_Personal], [Nombre], [Descripcion], [CreateAt]) VALUES (6, 3, 1, N'Cirugias 1', NULL, CAST(N'2020-08-17T15:01:48.927' AS DateTime))
SET IDENTITY_INSERT [dbo].[CONSULTORIO] OFF
INSERT [dbo].[DEPARTAMENTOS] ([ID_Departamento], [Nombre], [Descripcion]) VALUES (1, N'Administracion', NULL)
INSERT [dbo].[DEPARTAMENTOS] ([ID_Departamento], [Nombre], [Descripcion]) VALUES (2, N'Asistencia Medica', NULL)
INSERT [dbo].[DEPARTAMENTOS] ([ID_Departamento], [Nombre], [Descripcion]) VALUES (3, N'Suministros', NULL)
INSERT [dbo].[DEPARTAMENTOS] ([ID_Departamento], [Nombre], [Descripcion]) VALUES (4, N'Contabilidad', NULL)
INSERT [dbo].[DEPARTAMENTOS] ([ID_Departamento], [Nombre], [Descripcion]) VALUES (5, N'RRHH', NULL)
INSERT [dbo].[DEPARTAMENTOS] ([ID_Departamento], [Nombre], [Descripcion]) VALUES (6, N'Marketing', NULL)
INSERT [dbo].[DEPARTAMENTOS] ([ID_Departamento], [Nombre], [Descripcion]) VALUES (7, N'Limpieza', NULL)
INSERT [dbo].[DEPARTAMENTOS] ([ID_Departamento], [Nombre], [Descripcion]) VALUES (8, N'Seguridad', NULL)
SET IDENTITY_INSERT [dbo].[DETALLE_ARTICULOS] ON 

INSERT [dbo].[DETALLE_ARTICULOS] ([ID_Detalle_Articulos], [ID_Factura], [ID_Articulos], [Cantidad]) VALUES (1, 1, 1, CAST(1.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[DETALLE_ARTICULOS] OFF
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (561, 1, N'CARMEN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (562, 1, N'MERCED')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (563, 1, N'HOSPITAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (564, 1, N'CATEDRAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (565, 1, N'ZAPOTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (566, 1, N'SAN FRANCISCO DE DOS RIOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (567, 1, N'URUCA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (568, 1, N'MATA REDONDA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (569, 1, N'PAVAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (570, 1, N'HATILLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (571, 1, N'SAN SEBASTIAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (572, 2, N'ESCAZU')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (573, 2, N'SAN ANTONIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (574, 2, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (575, 3, N'DESAMPARADOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (576, 3, N'SAN MIGUEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (577, 3, N'SAN JUAN DE DIOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (578, 3, N'SAN RAFAEL ARRIBA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (579, 3, N'SAN ANTONIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (580, 3, N'FRAILES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (581, 3, N'PATARRA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (582, 3, N'SAN CRISTOBAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (583, 3, N'ROSARIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (584, 3, N'DAMAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (585, 3, N'SAN RAFAEL ABAJO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (586, 3, N'GRAVILIAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (587, 3, N'LOS GUIDO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (588, 4, N'SANTIAGO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (589, 4, N'MERCEDES SUR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (590, 4, N'BARBACOAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (591, 4, N'GRIFO ALTO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (592, 4, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (593, 4, N'CANDELARITA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (594, 4, N'DESAMPARADITOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (595, 4, N'SAN ANTONIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (596, 4, N'CHIRES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (597, 5, N'SAN MARCOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (598, 5, N'SAN LORENZO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (599, 5, N'SAN CARLOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (600, 6, N'ASERRI')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (601, 6, N'TARBACA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (602, 6, N'VUELTA DE JORCO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (603, 6, N'SAN GABRIEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (604, 6, N'LEGUA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (605, 6, N'MONTERREY')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (606, 6, N'SALITRILLOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (607, 7, N'COLON')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (608, 7, N'GUAYABO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (609, 7, N'TABARCIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (610, 7, N'PIEDRAS NEGRAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (611, 7, N'PICAGRES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (612, 8, N'GUADALUPE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (613, 8, N'SAN FRANCISCO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (614, 8, N'CALLE BLANCOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (615, 8, N'MATA DE PLATANO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (616, 8, N'IPIS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (617, 8, N'RANCHO REDONDO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (618, 8, N'PURRAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (619, 9, N'SANTA ANA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (620, 9, N'SALITRAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (621, 9, N'POZOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (622, 9, N'URUCA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (623, 9, N'PIEDADES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (624, 9, N'BRASIL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (625, 10, N'ALAJUELITA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (626, 10, N'SAN JOCESITO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (627, 10, N'SAN ANTONIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (628, 10, N'CONCEPCION')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (629, 10, N'SAN FELIPE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (630, 11, N'SAN ISIDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (631, 11, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (632, 11, N'DULCE NOMBRE DE JESUS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (633, 11, N'PATALILLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (634, 11, N'CASCAJAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (635, 12, N'SAN IGNACIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (636, 12, N'GUAITIL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (637, 12, N'PALMICHAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (638, 12, N'CANGREJAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (639, 12, N'SABANILLAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (640, 13, N'SAN JUAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (641, 13, N'CINCO ESQUINAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (642, 13, N'ANSELMO LLORENTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (643, 13, N'LEON XIII')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (644, 13, N'COLIMA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (645, 14, N'SAN VICENTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (646, 14, N'SAN JERONIMO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (647, 14, N'TRINIDAD')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (648, 15, N'SAN PEDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (649, 15, N'SABANILLA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (650, 15, N'MERCEDES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (651, 15, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (652, 16, N'SAN PABLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (653, 16, N'SAN PEDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (654, 16, N'SAN JUAN DE MATA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (655, 16, N'SAN LUIS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (656, 16, N'CARARA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (657, 17, N'SANTA MARIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (658, 17, N'JARDIN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (659, 17, N'COPEY')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (660, 18, N'CURRIDABAT')
GO
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (661, 18, N'GRANADILLA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (662, 18, N'SANCHEZ')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (663, 18, N'TIRRASES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (664, 19, N'SAN ISIDRO DEL GENERAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (665, 19, N'GENERAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (666, 19, N'DANIEL FLORES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (667, 19, N'RIVAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (668, 19, N'SAN PEDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (669, 19, N'PLATANARES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (670, 19, N'PEJIBAYE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (671, 19, N'CAJON')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (672, 19, N'BARU')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (673, 19, N'RIO NUEVO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (674, 19, N'PARAMO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (675, 20, N'SAN PABLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (676, 20, N'SAN ANDRES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (677, 20, N'LLANO BONITO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (678, 20, N'SAN ISIDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (679, 20, N'SANTA CRUZ')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (680, 20, N'SAN ANTONIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (681, 21, N'ALAJUELA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (682, 21, N'SAN JOSE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (683, 21, N'CARRIZAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (684, 21, N'SAN ANTONIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (685, 21, N'GUACIMA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (686, 21, N'SAN ISIDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (687, 21, N'SABANILLA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (688, 21, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (689, 21, N'RIO SEGUNDO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (690, 21, N'DESAMPARADOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (691, 21, N'TURRUCARES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (692, 21, N'TAMBOR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (693, 21, N'GARITA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (694, 21, N'SARAPIQUI')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (695, 22, N'SAN RAMON')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (696, 22, N'SANTIAGO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (697, 22, N'SAN JUAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (698, 22, N'PIEDADES NORTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (699, 22, N'PIEDADES SUR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (700, 22, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (701, 22, N'SAN ISIDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (702, 22, N'ANGELES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (703, 22, N'ALFARO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (704, 22, N'VOLIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (705, 22, N'CONCEPCION')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (706, 22, N'ZAPOTAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (707, 22, N'PENAS BLANCAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (708, 23, N'GRECIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (709, 23, N'SAN ISIDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (710, 23, N'SAN JOSE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (711, 23, N'SAN ROQUE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (712, 23, N'TACARES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (713, 23, N'RIO CUARTO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (714, 23, N'PUENTE DE PIEDRA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (715, 23, N'BOLIVAR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (716, 24, N'SAN MATEO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (717, 24, N'DESMONTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (718, 24, N'JESUS MARIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (719, 25, N'ATENAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (720, 25, N'JESUS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (721, 25, N'MERCEDES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (722, 25, N'SAN ISIDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (723, 25, N'CONCEPCION')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (724, 25, N'SAN JOSE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (725, 25, N'SANTA EULALIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (726, 25, N'ESCOBAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (727, 26, N'NARANJO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (728, 26, N'SAN MIGUEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (729, 26, N'SAN JOSE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (730, 26, N'CIRRI SUR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (731, 26, N'SAN JERONIMO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (732, 26, N'SAN JUAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (733, 26, N'ROSARIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (734, 26, N'PALMITOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (735, 27, N'PALMARES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (736, 27, N'ZARAGOZA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (737, 27, N'BUENOS AIRES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (738, 27, N'SANTIAGO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (739, 27, N'CANDELARIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (740, 27, N'ESQUIPULAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (741, 27, N'LA GRANJA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (742, 28, N'SAN PEDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (743, 28, N'SAN JUAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (744, 28, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (745, 28, N'CARRILLOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (746, 28, N'SABANA REDONDA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (747, 29, N'OROTINA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (748, 29, N'EL MASTATE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (749, 29, N'HACIENDA VIEJA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (750, 29, N'COYOLAR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (751, 29, N'LA CEIBA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (752, 30, N'QUESADA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (753, 30, N'FLORENCIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (754, 30, N'BUENA VISTA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (755, 30, N'AGUAS ZARCAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (756, 30, N'VENECIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (757, 30, N'PITAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (758, 30, N'LA FORTUNA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (759, 30, N'LA TIGRA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (760, 30, N'LA PALMERA')
GO
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (761, 30, N'VENADO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (762, 30, N'CUTRIS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (763, 30, N'MONTERREY')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (764, 30, N'POCOSOL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (765, 31, N'ZARCERO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (766, 31, N'LAGUNA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (767, 31, N'TAPESCO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (768, 31, N'GUADALUPE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (769, 31, N'PALMIRA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (770, 31, N'ZAPOTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (771, 31, N'BRISAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (772, 32, N'SARCHI NORTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (773, 32, N'SARCHI SUR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (774, 32, N'TORO AMARILLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (775, 32, N'SAN PEDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (776, 32, N'RODRIGUEZ')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (777, 33, N'UPALA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (778, 33, N'AGUAS CLARAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (779, 33, N'SAN JOSE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (780, 33, N'BIJAGUA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (781, 33, N'DELICIAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (782, 33, N'DOS RIOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (783, 33, N'YOLILLAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (784, 34, N'LOS CHILES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (785, 34, N'CANO NEGRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (786, 34, N'EL AMPARO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (787, 34, N'SAN JORGE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (788, 35, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (789, 35, N'BUENAVISTA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (790, 35, N'COTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (791, 35, N'KATIRA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (792, 36, N'ORIENTAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (793, 36, N'OCCIDENTAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (794, 36, N'CARMEN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (795, 36, N'SAN NICOLAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (796, 36, N'AGUACALIENTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (797, 36, N'GUADALUPE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (798, 36, N'CORRALILLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (799, 36, N'TIERRA BLANCA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (800, 36, N'DULCE NOMBRE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (801, 36, N'LLANO GRANDE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (802, 36, N'QUEBRADILLA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (803, 37, N'PARAISO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (804, 37, N'SANTIAGO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (805, 37, N'OROSI')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (806, 37, N'CACHI')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (807, 37, N'LLANOS DE SANTA LUCIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (808, 38, N'TRES RIOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (809, 38, N'SAN DIEGO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (810, 38, N'SAN JUAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (811, 38, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (812, 38, N'CONCEPCION')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (813, 38, N'DULCE NOMBRE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (814, 38, N'SAN RAMON')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (815, 38, N'RIO AZUL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (816, 39, N'JUAN VIÑAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (817, 39, N'TUCURRIQUE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (818, 39, N'PEJIBAYE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (819, 40, N'TURRIALBA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (820, 40, N'LA SUIZA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (821, 40, N'PERALTA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (822, 40, N'SANTA CRUZ')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (823, 40, N'SANTA TERESITA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (824, 40, N'PAVONES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (825, 40, N'TUIS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (826, 40, N'TAYUTIC')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (827, 40, N'SANTA ROSA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (828, 40, N'TRES EQUIS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (829, 40, N'LA ISABEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (830, 40, N'CHIRRIPÒ')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (831, 41, N'PACAYAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (832, 41, N'CERVANTES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (833, 41, N'CAPELLADES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (834, 42, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (835, 42, N'COT')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (836, 42, N'POTRERO CERRADO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (837, 42, N'CIPRESES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (838, 42, N'SANTA ROSA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (839, 43, N'TEJAR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (840, 43, N'SAN ISIDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (841, 43, N'TOBOSI')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (842, 43, N'PATIO DE AGUA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (843, 44, N'HEREDIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (844, 44, N'MERCEDES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (845, 44, N'SAN FRANCISCO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (846, 44, N'ULLOA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (847, 44, N'VARABLANCA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (848, 45, N'BARVA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (849, 45, N'SAN PEDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (850, 45, N'SAN PABLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (851, 45, N'SAN ROQUE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (852, 45, N'SANTA LUCIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (853, 45, N'SAN JOSE DE LA MONTAÑA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (854, 46, N'SANTO DOMINGO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (855, 46, N'SAN VICENTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (856, 46, N'SAN MIGUEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (857, 46, N'PARACITO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (858, 46, N'SANTO TOMAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (859, 46, N'SANTA ROSA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (860, 46, N'TURES')
GO
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (861, 46, N'PARA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (862, 47, N'SANTA BARBARA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (863, 47, N'SAN PEDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (864, 47, N'SAN JUAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (865, 47, N'JESUS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (866, 47, N'SANTO DOMINGO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (867, 47, N'PURABA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (868, 48, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (869, 48, N'SAN JOSECITO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (870, 48, N'SANTIAGO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (871, 48, N'ANGELES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (872, 48, N'CONCEPCION')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (873, 49, N'SAN ISIDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (874, 49, N'SAN JOSE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (875, 49, N'CONCEPCION')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (876, 49, N'SAN FRANCISCO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (877, 50, N'SAN ANTONIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (878, 50, N'LA RIBERA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (879, 50, N'LA ASUNCION')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (880, 51, N'SAN JOAQUIN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (881, 51, N'BARRANTES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (882, 51, N'LLORENTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (883, 52, N'SAN PABLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (884, 52, N'RINCON DE SEBADILLA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (885, 53, N'PUERTO VIEJO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (886, 53, N'LA VIRGEN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (887, 53, N'LAS HORQUETAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (888, 53, N'LLANURAS DEL GASPAR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (889, 53, N'CUREÑA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (890, 54, N'LIBERIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (891, 54, N'CANAS DULCES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (892, 54, N'MAYORGA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (893, 54, N'NACASCOLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (894, 54, N'CURUBANDE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (895, 55, N'NICOYA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (896, 55, N'MANSION')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (897, 55, N'SAN ANTONIO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (898, 55, N'QUEBRADA HONDA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (899, 55, N'SAMARA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (900, 55, N'NOSARA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (901, 55, N'BELEN DE NOSARITA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (902, 56, N'SANTA CRUZ')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (903, 56, N'BOLSON')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (904, 56, N'VEINTISIETE DE ABRIL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (905, 56, N'TEMPATE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (906, 56, N'CARTAGENA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (907, 56, N'CUAJINIQUIL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (908, 56, N'DIRIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (909, 56, N'CABO VELAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (910, 56, N'TAMARINDO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (911, 57, N'BAGACES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (912, 57, N'LA FORTUNA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (913, 57, N'MOGOTE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (914, 57, N'RIO NARANJO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (915, 58, N'FILADELFIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (916, 58, N'PALMIRA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (917, 58, N'SARDINAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (918, 58, N'BELEN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (919, 59, N'CAÑAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (920, 59, N'PALMIRA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (921, 59, N'SAN MIGUEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (922, 59, N'BEBEDERO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (923, 59, N'POROZAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (924, 60, N'JUNTAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (925, 60, N'SIERRA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (926, 60, N'SAN JUAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (927, 60, N'COLORADO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (928, 61, N'TILARAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (929, 61, N'QUEBRADA GRANDE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (930, 61, N'TRONADORA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (931, 61, N'SANTA ROSA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (932, 61, N'LIBANO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (933, 61, N'TIERRAS MORENAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (934, 61, N'ARENAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (935, 62, N'CARMONA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (936, 62, N'SANTA RITA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (937, 62, N'ZAPOTAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (938, 62, N'SAN PABLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (939, 62, N'PORVENIR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (940, 62, N'BEJUCO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (941, 63, N'LA CRUZ')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (942, 63, N'SANTA CECILIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (943, 63, N'LA GARITA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (944, 63, N'SANTA ELENA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (945, 64, N'HOJANCHA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (946, 64, N'MONTE ROMO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (947, 64, N'PUERTO CARRILLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (948, 64, N'HUACAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (949, 65, N'PUNTARENAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (950, 65, N'PITAHAYA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (951, 65, N'CHOMES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (952, 65, N'LEPANTO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (953, 65, N'PAQUERA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (954, 65, N'MANZANILLO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (955, 65, N'GUACIMAL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (956, 65, N'BARRANCA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (957, 65, N'MONTE VERDE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (958, 65, N'ISLA DEL COCO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (959, 65, N'COBANO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (960, 65, N'CHACARITA')
GO
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (961, 65, N'CHIRA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (962, 65, N'ACAPULCO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (963, 65, N'EL ROBLE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (964, 65, N'ARANCIBIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (965, 66, N'ESPIRITU SANTO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (966, 66, N'SAN JUAN GRANDE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (967, 66, N'MACACONA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (968, 66, N'SAN RAFAEL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (969, 66, N'SAN JERONIMO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (970, 67, N'BUENOS AIRES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (971, 67, N'VOLCAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (972, 67, N'POTRERO GRANDE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (973, 67, N'BORUCA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (974, 67, N'PILAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (975, 67, N'COLINAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (976, 67, N'CHANGUENA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (977, 67, N'BIOLLEY')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (978, 67, N'BRUNKA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (979, 68, N'MIRAMAR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (980, 68, N'LA UNION')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (981, 68, N'SAN ISIDRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (982, 69, N'PUERTO CORTES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (983, 69, N'PALMAR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (984, 69, N'SIERPE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (985, 69, N'BAHIA BALLENA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (986, 69, N'PIEDRAS BLANCAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (987, 70, N'QUEPOS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (988, 70, N'SAVEGRE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (989, 70, N'NARANJITO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (990, 71, N'GOLFITO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (991, 71, N'PUERTO JIMENEZ')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (992, 71, N'GUAYCARA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (993, 71, N'PAVON')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (994, 72, N'SAN VITO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (995, 72, N'SABALITO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (996, 72, N'AGUABUENA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (997, 72, N'LIMONCITO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (998, 72, N'PITTIER')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (999, 73, N'PARRITA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1000, 74, N'CORREDOR')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1001, 74, N'LA CUESTA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1002, 74, N'CANOAS')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1003, 74, N'LAUREL')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1004, 75, N'JACO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1005, 75, N'TARCOLES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1006, 76, N'LIMON')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1007, 76, N'VALLE DE LA ESTRELLA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1008, 76, N'RIO BLANCO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1009, 76, N'MATAMA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1010, 77, N'GUAPILES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1011, 77, N'JIMENEZ')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1012, 77, N'RITA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1013, 77, N'ROXANA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1014, 77, N'CARIARI')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1015, 77, N'COLORADO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1016, 78, N'SIQUIRRES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1017, 78, N'PACUARITO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1018, 78, N'FLORIDA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1019, 78, N'GERMANIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1020, 78, N'EL CAIRO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1021, 78, N'ALEGRIA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1022, 79, N'BRATSI')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1023, 79, N'SIXAOLA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1024, 79, N'CAHUITA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1025, 79, N'TELIRE')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1026, 80, N'MATINA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1027, 80, N'BATAN')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1028, 80, N'CARRANDI')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1029, 81, N'GUACIMO')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1030, 81, N'MERCEDES')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1031, 81, N'POCORA')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1032, 81, N'RIO JIMENEZ')
INSERT [dbo].[DISTRITOS] ([ID_Distritos], [ID_Cantones], [Nombre]) VALUES (1033, 81, N'DUACARI')
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (1, N'Pendiente', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (2, N'En curso', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (3, N'Entregado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (4, N'Bloqueado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (5, N'Activo', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (6, N'Despedido', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (7, N'Suspendido', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (8, N'Habilitado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (9, N'Bloqueado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (10, N'Desabilitado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (11, N'Creado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (12, N'Finalizado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (13, N'Disponible', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (14, N'Enviado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (15, N'Iniciado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (16, N'Lleno', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (17, N'Finalizado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (18, N'Aceptado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (19, N'Rechazado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (20, N'Aprobado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (21, N'Pagado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (22, N'Cerrado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (23, N'Verde', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (24, N'Amarillo', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (25, N'Rojo', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (26, N'Por Agotarse', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (27, N'Por Entregar', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (28, N'Entregado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (29, N'Sano', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (30, N'Problemas Menores', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (31, N'Enfermo', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (32, N'Muerto', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (33, N'Vetado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (34, N'Agendado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (35, N'Cancelado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (36, N'En credito', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (37, N'Anulado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (38, N'Abierta', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (39, N'Eliminado', NULL)
INSERT [dbo].[ESTADOS] ([ID_Estados], [Nombre], [Descripcion]) VALUES (40, N'Agotado', NULL)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (1, 18)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (2, 18)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (3, 18)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (4, 18)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (5, 1)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (6, 1)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (7, 1)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (8, 2)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (9, 2)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (10, 2)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (11, 14)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (12, 14)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (13, 3)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (39, 3)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (11, 15)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (14, 15)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (11, 6)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (15, 6)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (16, 6)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (17, 6)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (18, 7)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (19, 7)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (1, 10)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (20, 10)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (21, 10)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (22, 10)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (23, 17)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (24, 17)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (25, 17)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (13, 8)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (26, 8)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (40, 8)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (27, 9)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (28, 9)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (5, 16)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (12, 16)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (29, 5)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (30, 5)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (31, 5)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (32, 5)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (5, 4)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (33, 4)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (34, 11)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (2, 11)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (17, 11)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (35, 11)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (20, 12)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (21, 12)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (36, 12)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (37, 12)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (38, 13)
INSERT [dbo].[ESTADOS_TABLAS] ([ID_Estados], [ID_Tabla]) VALUES (22, 13)
SET IDENTITY_INSERT [dbo].[FACTURAS] ON 

INSERT [dbo].[FACTURAS] ([ID_Facturas], [ID_Cliente], [ID_Caja], [Numero_Factura], [Fecha], [Descripcion], [Total], [Tipo_Pago], [Estado]) VALUES (1, 1, 1, 0, CAST(N'2020-08-21' AS Date), N'prueba', CAST(1000.00 AS Decimal(10, 2)), 1, 21)
SET IDENTITY_INSERT [dbo].[FACTURAS] OFF
SET IDENTITY_INSERT [dbo].[INVENTARIO] ON 

INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (1, 1, CAST(49.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (2, 2, CAST(49.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (3, 3, CAST(49.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (4, 4, CAST(49.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (5, 5, CAST(49.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (6, 6, CAST(49.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (7, 7, CAST(49.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (8, 8, CAST(49.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (9, 9, CAST(49.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (10, 10, CAST(49.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[INVENTARIO] ([ID_Inventario], [ID_Articulos], [Cantidad], [Estado]) VALUES (11, 11, CAST(49.00 AS Decimal(10, 2)), 13)
SET IDENTITY_INSERT [dbo].[INVENTARIO] OFF
SET IDENTITY_INSERT [dbo].[MARCAS] ON 

INSERT [dbo].[MARCAS] ([ID_Marcas], [ID_Personal], [Fecha], [Hora], [Tipo]) VALUES (1, 1, CAST(N'2020-09-04' AS Date), CAST(N'02:32:50' AS Time), 1)
SET IDENTITY_INSERT [dbo].[MARCAS] OFF
SET IDENTITY_INSERT [dbo].[MASCOTAS] ON 

INSERT [dbo].[MASCOTAS] ([ID_Mascota], [ID_Cliente], [Nombre], [Tipo_Animal], [Raza], [Sexo], [Edad], [Peso], [Tamaño], [Estado]) VALUES (1, 1, N'Pitu', 1, N'A', N'Macho', 2, CAST(2.00 AS Decimal(10, 2)), CAST(75.00 AS Decimal(10, 2)), 29)
SET IDENTITY_INSERT [dbo].[MASCOTAS] OFF
INSERT [dbo].[METODO_PAGO] ([ID], [Metodo]) VALUES (1, N'Efectivo')
INSERT [dbo].[METODO_PAGO] ([ID], [Metodo]) VALUES (2, N'Tarjeta')
SET IDENTITY_INSERT [dbo].[MOTIVO_CITA] ON 

INSERT [dbo].[MOTIVO_CITA] ([ID_Motivo_Cita], [Nombre], [Descripcion], [CreateAt]) VALUES (1, N'Consulta General', NULL, CAST(N'2020-08-17T15:13:49.450' AS DateTime))
INSERT [dbo].[MOTIVO_CITA] ([ID_Motivo_Cita], [Nombre], [Descripcion], [CreateAt]) VALUES (2, N'Cirugia', NULL, CAST(N'2020-08-17T15:14:11.027' AS DateTime))
INSERT [dbo].[MOTIVO_CITA] ([ID_Motivo_Cita], [Nombre], [Descripcion], [CreateAt]) VALUES (3, N'Laboratorio', NULL, CAST(N'2020-08-17T15:14:11.027' AS DateTime))
SET IDENTITY_INSERT [dbo].[MOTIVO_CITA] OFF
SET IDENTITY_INSERT [dbo].[OBSERVACIONES] ON 

INSERT [dbo].[OBSERVACIONES] ([ID_Observaciones], [ID_Cita], [Descripcion], [CreateAt]) VALUES (2, 4, N'ascdxasc', CAST(N'2020-08-21T16:54:10.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[OBSERVACIONES] OFF
SET IDENTITY_INSERT [dbo].[PARTICIPANTES] ON 

INSERT [dbo].[PARTICIPANTES] ([ID_Participantes], [ID_Reclutamiento], [Cedula_], [Nombre], [Apellido_1], [Apellido_2], [Correo], [Telefono], [ID_Provincia], [ID_Canton], [ID_Distrito], [Direccion], [Estado]) VALUES (1, 2, N'987654321', N'David', N'Montero', N'Cerdas', N'yo@loquesea', N'8888888', 3, 37, 803, N'100mtszs', 18)
SET IDENTITY_INSERT [dbo].[PARTICIPANTES] OFF
SET IDENTITY_INSERT [dbo].[PERSONAL] ON 

INSERT [dbo].[PERSONAL] ([ID_Personal], [ID_Puesto], [Cedula], [Nombre], [Apellido_1], [Apellido_2], [Salario_Hora], [Salario_Mensual], [Fecha_Contratacion], [created_at], [Estado], [ID_Provincia], [ID_Canton], [ID_Distrito], [Direccion], [Correo_Electronico], [Telefono]) VALUES (1, NULL, N'0', N'Admin', N'-', N'-', NULL, NULL, NULL, CAST(N'2020-07-18T19:48:39.170' AS DateTime), 5, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[PERSONAL] ([ID_Personal], [ID_Puesto], [Cedula], [Nombre], [Apellido_1], [Apellido_2], [Salario_Hora], [Salario_Mensual], [Fecha_Contratacion], [created_at], [Estado], [ID_Provincia], [ID_Canton], [ID_Distrito], [Direccion], [Correo_Electronico], [Telefono]) VALUES (2, 2, N'305050426', N'Gregory', N'Fallas', N'Inces', CAST(1000.00 AS Decimal(10, 2)), CAST(250000.00 AS Decimal(10, 2)), CAST(N'2020-08-21' AS Date), CAST(N'2020-08-21T16:40:40.103' AS DateTime), 5, NULL, NULL, NULL, N'100', N'gfallas@vetelbosque.com', N'88888888')
SET IDENTITY_INSERT [dbo].[PERSONAL] OFF
SET IDENTITY_INSERT [dbo].[PROVEEDOR] ON 

INSERT [dbo].[PROVEEDOR] ([ID_Proveedor], [Nombre], [Descripcion]) VALUES (1, N'Dog chow', N'Proveedor de alimento')
SET IDENTITY_INSERT [dbo].[PROVEEDOR] OFF
INSERT [dbo].[PROVINCIAS] ([ID_Provincias], [Nombre]) VALUES (1, N'SAN JOSE')
INSERT [dbo].[PROVINCIAS] ([ID_Provincias], [Nombre]) VALUES (2, N'ALAJUELA')
INSERT [dbo].[PROVINCIAS] ([ID_Provincias], [Nombre]) VALUES (3, N'CARTAGO')
INSERT [dbo].[PROVINCIAS] ([ID_Provincias], [Nombre]) VALUES (4, N'HEREDIA')
INSERT [dbo].[PROVINCIAS] ([ID_Provincias], [Nombre]) VALUES (5, N'GUANACASTE')
INSERT [dbo].[PROVINCIAS] ([ID_Provincias], [Nombre]) VALUES (6, N'PUNTARENAS')
INSERT [dbo].[PROVINCIAS] ([ID_Provincias], [Nombre]) VALUES (7, N'LIMON')
SET IDENTITY_INSERT [dbo].[PRUEBAS] ON 

INSERT [dbo].[PRUEBAS] ([ID_Pruebas], [Nombre], [Descripcion]) VALUES (1, N'Prueba 1', N'Decip de la prueba 1')
INSERT [dbo].[PRUEBAS] ([ID_Pruebas], [Nombre], [Descripcion]) VALUES (2, N'Psicologica', N'Prueba Psicologica')
SET IDENTITY_INSERT [dbo].[PRUEBAS] OFF
SET IDENTITY_INSERT [dbo].[PRUEBAS_LABORATORIO] ON 

INSERT [dbo].[PRUEBAS_LABORATORIO] ([ID_Pruebas_Laboratorio], [Nombre], [Descripcion], [CreateAt]) VALUES (1, N'Sanguíneo', N'13', CAST(N'2020-08-21T11:39:50.230' AS DateTime))
INSERT [dbo].[PRUEBAS_LABORATORIO] ([ID_Pruebas_Laboratorio], [Nombre], [Descripcion], [CreateAt]) VALUES (2, N'Disbiosis', N'14', CAST(N'2020-08-21T11:39:50.230' AS DateTime))
INSERT [dbo].[PRUEBAS_LABORATORIO] ([ID_Pruebas_Laboratorio], [Nombre], [Descripcion], [CreateAt]) VALUES (3, N'Citología', N'15', CAST(N'2020-08-21T11:39:50.230' AS DateTime))
INSERT [dbo].[PRUEBAS_LABORATORIO] ([ID_Pruebas_Laboratorio], [Nombre], [Descripcion], [CreateAt]) VALUES (4, N'Raspados de piel', N'16', CAST(N'2020-08-21T11:39:50.230' AS DateTime))
INSERT [dbo].[PRUEBAS_LABORATORIO] ([ID_Pruebas_Laboratorio], [Nombre], [Descripcion], [CreateAt]) VALUES (5, N'Heces', N'17', CAST(N'2020-08-21T11:39:50.230' AS DateTime))
INSERT [dbo].[PRUEBAS_LABORATORIO] ([ID_Pruebas_Laboratorio], [Nombre], [Descripcion], [CreateAt]) VALUES (6, N'Orina', N'18', CAST(N'2020-08-21T11:39:50.230' AS DateTime))
SET IDENTITY_INSERT [dbo].[PRUEBAS_LABORATORIO] OFF
SET IDENTITY_INSERT [dbo].[PRUEBAS_PARTICIPANTES] ON 

INSERT [dbo].[PRUEBAS_PARTICIPANTES] ([ID_Pruebas_Participantes], [ID_Pruebas], [ID_Participantes], [nota]) VALUES (9, 1, 1, 45)
SET IDENTITY_INSERT [dbo].[PRUEBAS_PARTICIPANTES] OFF
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (1, 1, N'Administrador', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (2, 1, N'Gerente', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (3, 1, N'Asistente Administrativo', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (4, 2, N'Asistente Medico', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (5, 2, N'Medico General', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (6, 2, N'Medico Especialista', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (7, 2, N'Encargado de laboratorio', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (8, 1, N'Mensajero', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (9, 3, N'Encargado de bodega', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (10, 4, N'Tosoreria', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (11, 4, N'Cajero', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (12, 5, N'Encargada de RRHH', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (13, 5, N'Asistente de RRHH', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (14, 6, N'Encargada de Marketing', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (15, 7, N'Miselanio', NULL, NULL)
INSERT [dbo].[PUESTOS] ([ID_Puestos], [ID_Departamento], [Nombre], [Salario_Base], [Descripcion]) VALUES (16, 8, N'Guarda', NULL, NULL)
SET IDENTITY_INSERT [dbo].[RECLUTAMIENTO] ON 

INSERT [dbo].[RECLUTAMIENTO] ([ID_Reclutamiento], [ID_Puestos], [Nombre], [Descripcion], [Estado]) VALUES (1, 1, N'DAL.Entidades.PUESTOS', N'Loquesea', 11)
INSERT [dbo].[RECLUTAMIENTO] ([ID_Reclutamiento], [ID_Puestos], [Nombre], [Descripcion], [Estado]) VALUES (2, 4, N'Asistente Medico', N'Loquesea2', 11)
SET IDENTITY_INSERT [dbo].[RECLUTAMIENTO] OFF
INSERT [dbo].[ROLES] ([ID_Roles], [Nombre], [Descripcion], [Estado]) VALUES (0, N'Administrador', NULL, NULL)
INSERT [dbo].[ROLES] ([ID_Roles], [Nombre], [Descripcion], [Estado]) VALUES (1, N'Gerente', NULL, NULL)
INSERT [dbo].[ROLES] ([ID_Roles], [Nombre], [Descripcion], [Estado]) VALUES (2, N'Medico', NULL, NULL)
INSERT [dbo].[ROLES] ([ID_Roles], [Nombre], [Descripcion], [Estado]) VALUES (3, N'Medico Especialista', NULL, NULL)
INSERT [dbo].[ROLES] ([ID_Roles], [Nombre], [Descripcion], [Estado]) VALUES (4, N'Encargado Laboratorio', NULL, NULL)
INSERT [dbo].[ROLES] ([ID_Roles], [Nombre], [Descripcion], [Estado]) VALUES (5, N'Asistente Administrativo/Servicios', NULL, NULL)
INSERT [dbo].[ROLES] ([ID_Roles], [Nombre], [Descripcion], [Estado]) VALUES (6, N'Encargado de Bodega', NULL, NULL)
INSERT [dbo].[ROLES] ([ID_Roles], [Nombre], [Descripcion], [Estado]) VALUES (7, N'Tesorero', NULL, NULL)
INSERT [dbo].[ROLES] ([ID_Roles], [Nombre], [Descripcion], [Estado]) VALUES (8, N'Cajero', NULL, NULL)
INSERT [dbo].[ROLES] ([ID_Roles], [Nombre], [Descripcion], [Estado]) VALUES (9, N'Recursos Humanos', NULL, NULL)
SET IDENTITY_INSERT [dbo].[SERVICIOS] ON 

INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (1, N'Limpieza oidos', N'1', CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (2, N'Desparacitación', N'1', CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (3, N'Limpieza dental', N'1', CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (4, N'Corte uñas', N'1', CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (5, N'Rinotraqueitis', N'1', CAST(6500.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (6, N'Panleucopenia', N'1', CAST(6500.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (7, N'Parvovirosis', N'1', CAST(8550.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (8, N'Rabia', N'1', CAST(9800.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (9, N'Leptospirosis', N'1', CAST(9800.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (10, N'tetravalente', N'1', CAST(11800.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (11, N'Moquillo', N'1', CAST(11800.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (12, N'Panleucopenia', N'1', CAST(11800.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (13, N'Sanguíneo', N'1', CAST(22000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (14, N'Disbiosis', N'1', CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (15, N'Citología', N'1', CAST(38000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (16, N'Raspados de piel', N'1', CAST(22800.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (17, N'Heces', N'1', CAST(7500.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (18, N'Orina', N'1', CAST(5050.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (19, N'Oncológica ', N'1', CAST(55000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (20, N'Cataratas', N'1', CAST(78000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (21, N'Digestiva', N'1', CAST(95000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (22, N'Traumatológica ', N'1', CAST(46000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (23, N'Hernias', N'1', CAST(34400.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (24, N'Urinario', N'1', CAST(68000.00 AS Decimal(10, 2)))
INSERT [dbo].[SERVICIOS] ([ID_Servicios], [Nombre], [Descripcion], [Precio]) VALUES (25, N'Cesáreas', N'1', CAST(49000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[SERVICIOS] OFF
SET IDENTITY_INSERT [dbo].[SOLICITUD_ARTICULOS] ON 

INSERT [dbo].[SOLICITUD_ARTICULOS] ([ID_Solicitud_Articulos], [ID_Articulo_Proveedor], [ID_Solicitud_Compra], [Descripcion], [Cantidad]) VALUES (1, 1, 1, N'sxasxsa', CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[SOLICITUD_ARTICULOS] ([ID_Solicitud_Articulos], [ID_Articulo_Proveedor], [ID_Solicitud_Compra], [Descripcion], [Cantidad]) VALUES (2, 1, 5, N'sadsad', CAST(5.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[SOLICITUD_ARTICULOS] OFF
SET IDENTITY_INSERT [dbo].[SOLICITUD_COMPRA] ON 

INSERT [dbo].[SOLICITUD_COMPRA] ([ID_Solicitud_Compra], [Encabezado], [Descripcion], [Estado]) VALUES (1, N'Compra de vacunas', NULL, 1)
INSERT [dbo].[SOLICITUD_COMPRA] ([ID_Solicitud_Compra], [Encabezado], [Descripcion], [Estado]) VALUES (2, N'Compra de Alimento', NULL, 20)
INSERT [dbo].[SOLICITUD_COMPRA] ([ID_Solicitud_Compra], [Encabezado], [Descripcion], [Estado]) VALUES (3, N'Compra de Collares', NULL, 1)
INSERT [dbo].[SOLICITUD_COMPRA] ([ID_Solicitud_Compra], [Encabezado], [Descripcion], [Estado]) VALUES (4, N'Compra de juuetes', NULL, 20)
INSERT [dbo].[SOLICITUD_COMPRA] ([ID_Solicitud_Compra], [Encabezado], [Descripcion], [Estado]) VALUES (5, N'saxsd', NULL, 20)
SET IDENTITY_INSERT [dbo].[SOLICITUD_COMPRA] OFF
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (1, N'Peronal')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (2, N'Usuarios')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (3, N'Roles')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (4, N'Clientes')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (5, N'Mascotas')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (6, N'Reclutamiento')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (7, N'Participantes')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (8, N'Inventario')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (9, N'Despacho')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (10, N'Solicitud de Compra')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (11, N'Citas')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (12, N'Facturas')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (13, N'Cajas')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (14, N'Campañas')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (15, N'Anuncios')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (16, N'Promociones')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (17, N'Resultado Laboratorio')
INSERT [dbo].[TABLAS] ([ID_Tabla], [Nombre]) VALUES (18, N'Servicio Expres')
SET IDENTITY_INSERT [dbo].[TIPO_ANIMAL] ON 

INSERT [dbo].[TIPO_ANIMAL] ([ID_Tipo_Animal], [Tipo]) VALUES (1, N'Perro')
INSERT [dbo].[TIPO_ANIMAL] ([ID_Tipo_Animal], [Tipo]) VALUES (2, N'Gatos')
INSERT [dbo].[TIPO_ANIMAL] ([ID_Tipo_Animal], [Tipo]) VALUES (3, N'Aves')
INSERT [dbo].[TIPO_ANIMAL] ([ID_Tipo_Animal], [Tipo]) VALUES (4, N'Ganado')
INSERT [dbo].[TIPO_ANIMAL] ([ID_Tipo_Animal], [Tipo]) VALUES (5, N'Roedor')
INSERT [dbo].[TIPO_ANIMAL] ([ID_Tipo_Animal], [Tipo]) VALUES (6, N'Pez')
SET IDENTITY_INSERT [dbo].[TIPO_ANIMAL] OFF
SET IDENTITY_INSERT [dbo].[TIPO_CONSULTORIO] ON 

INSERT [dbo].[TIPO_CONSULTORIO] ([ID_Tipo_Consultorio], [Nombre], [Descripcion], [CreateAt]) VALUES (1, N'Medico', NULL, CAST(N'2020-07-18T19:48:39.157' AS DateTime))
INSERT [dbo].[TIPO_CONSULTORIO] ([ID_Tipo_Consultorio], [Nombre], [Descripcion], [CreateAt]) VALUES (2, N'Laboratorio', NULL, CAST(N'2020-07-18T19:48:39.157' AS DateTime))
INSERT [dbo].[TIPO_CONSULTORIO] ([ID_Tipo_Consultorio], [Nombre], [Descripcion], [CreateAt]) VALUES (3, N'Cirugia', NULL, CAST(N'2020-07-18T19:48:39.157' AS DateTime))
SET IDENTITY_INSERT [dbo].[TIPO_CONSULTORIO] OFF
INSERT [dbo].[TIPO_MARCA] ([ID_Tipo], [Nombre]) VALUES (1, N'Entrada')
INSERT [dbo].[TIPO_MARCA] ([ID_Tipo], [Nombre]) VALUES (2, N'Salida')
INSERT [dbo].[TIPO_PAGO] ([ID], [Tipo]) VALUES (1, N'Contado')
INSERT [dbo].[TIPO_PAGO] ([ID], [Tipo]) VALUES (2, N'Credito')
SET IDENTITY_INSERT [dbo].[USUARIO_ROL] ON 

INSERT [dbo].[USUARIO_ROL] ([ID_Usuario_Rol], [ID_Usuario], [ID_Roles]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[USUARIO_ROL] OFF
SET IDENTITY_INSERT [dbo].[USUARIOS] ON 

INSERT [dbo].[USUARIOS] ([ID_Usuario], [ID_Personal], [UserName], [Pass], [Created_at], [Last_Login], [Estado]) VALUES (1, 1, N'admin', N'admin', CAST(N'2020-07-18T19:48:39.173' AS DateTime), NULL, 8)
SET IDENTITY_INSERT [dbo].[USUARIOS] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNIQ_ClientesCedula]    Script Date: 9/4/2020 6:03:52 PM ******/
ALTER TABLE [dbo].[CLIENTES] ADD  CONSTRAINT [UNIQ_ClientesCedula] UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__FACTURA___BD91FFFC64E9BAC2]    Script Date: 9/4/2020 6:03:52 PM ******/
ALTER TABLE [dbo].[FACTURA_COMPRA] ADD UNIQUE NONCLUSTERED 
(
	[Numero_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__FACTURAS__BD91FFFCD397A169]    Script Date: 9/4/2020 6:03:52 PM ******/
ALTER TABLE [dbo].[FACTURAS] ADD UNIQUE NONCLUSTERED 
(
	[Numero_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNIQ_Cedula_ID_Reclutamiento]    Script Date: 9/4/2020 6:03:52 PM ******/
ALTER TABLE [dbo].[PARTICIPANTES] ADD  CONSTRAINT [UNIQ_Cedula_ID_Reclutamiento] UNIQUE NONCLUSTERED 
(
	[Cedula_] ASC,
	[ID_Reclutamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNIQ_PersonalCedula]    Script Date: 9/4/2020 6:03:52 PM ******/
ALTER TABLE [dbo].[PERSONAL] ADD  CONSTRAINT [UNIQ_PersonalCedula] UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CLIENTES] ADD  DEFAULT ((0)) FOR [Credito]
GO
ALTER TABLE [dbo].[CONSULTORIO] ADD  DEFAULT (getdate()) FOR [CreateAt]
GO
ALTER TABLE [dbo].[MOTIVO_CITA] ADD  DEFAULT (getdate()) FOR [CreateAt]
GO
ALTER TABLE [dbo].[OBSERVACIONES] ADD  DEFAULT (getdate()) FOR [CreateAt]
GO
ALTER TABLE [dbo].[PERSONAL] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[PRUEBAS_LABORATORIO] ADD  DEFAULT (getdate()) FOR [CreateAt]
GO
ALTER TABLE [dbo].[RECETAS] ADD  DEFAULT (getdate()) FOR [CreateAt]
GO
ALTER TABLE [dbo].[RESULTADO_LABORATORIO] ADD  DEFAULT (getdate()) FOR [CreateAt]
GO
ALTER TABLE [dbo].[TIPO_CONSULTORIO] ADD  DEFAULT (getdate()) FOR [CreateAt]
GO
ALTER TABLE [dbo].[USUARIOS] ADD  DEFAULT (getdate()) FOR [Created_at]
GO
ALTER TABLE [dbo].[ANUNCIOS]  WITH CHECK ADD  CONSTRAINT [FK_AnunciosEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[ANUNCIOS] CHECK CONSTRAINT [FK_AnunciosEstados]
GO
ALTER TABLE [dbo].[ANUNCIOS_ENVIADOS]  WITH CHECK ADD  CONSTRAINT [AnunciosAnunciosEnviados] FOREIGN KEY([ID_Anuncios])
REFERENCES [dbo].[ANUNCIOS] ([ID_Anuncios])
GO
ALTER TABLE [dbo].[ANUNCIOS_ENVIADOS] CHECK CONSTRAINT [AnunciosAnunciosEnviados]
GO
ALTER TABLE [dbo].[ANUNCIOS_ENVIADOS]  WITH CHECK ADD  CONSTRAINT [ClientesAnunciosEnviados] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[CLIENTES] ([ID_Cliente])
GO
ALTER TABLE [dbo].[ANUNCIOS_ENVIADOS] CHECK CONSTRAINT [ClientesAnunciosEnviados]
GO
ALTER TABLE [dbo].[ARTICULOS_PROVEEDOR]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosArticulosProveedor] FOREIGN KEY([ID_Articulos])
REFERENCES [dbo].[ARTICULOS] ([ID_Articulos])
GO
ALTER TABLE [dbo].[ARTICULOS_PROVEEDOR] CHECK CONSTRAINT [FK_ArticulosArticulosProveedor]
GO
ALTER TABLE [dbo].[ARTICULOS_PROVEEDOR]  WITH CHECK ADD  CONSTRAINT [FK_ProveedoresArticulosProveedor] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[PROVEEDOR] ([ID_Proveedor])
GO
ALTER TABLE [dbo].[ARTICULOS_PROVEEDOR] CHECK CONSTRAINT [FK_ProveedoresArticulosProveedor]
GO
ALTER TABLE [dbo].[CAJAS]  WITH CHECK ADD  CONSTRAINT [FK_CajasEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[CAJAS] CHECK CONSTRAINT [FK_CajasEstados]
GO
ALTER TABLE [dbo].[CAJAS]  WITH CHECK ADD  CONSTRAINT [FK_PersonalCajas] FOREIGN KEY([ID_Personal])
REFERENCES [dbo].[PERSONAL] ([ID_Personal])
GO
ALTER TABLE [dbo].[CAJAS] CHECK CONSTRAINT [FK_PersonalCajas]
GO
ALTER TABLE [dbo].[CAMPA_AS]  WITH CHECK ADD  CONSTRAINT [FK_CampanasEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[CAMPA_AS] CHECK CONSTRAINT [FK_CampanasEstados]
GO
ALTER TABLE [dbo].[CAMPA_AS]  WITH CHECK ADD  CONSTRAINT [FK_DistritosCampanas] FOREIGN KEY([ID_Distritos])
REFERENCES [dbo].[DISTRITOS] ([ID_Distritos])
GO
ALTER TABLE [dbo].[CAMPA_AS] CHECK CONSTRAINT [FK_DistritosCampanas]
GO
ALTER TABLE [dbo].[CAMPA_AS_PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [FK_CampanasCampanasParticipantes] FOREIGN KEY([ID_Campa_as])
REFERENCES [dbo].[CAMPA_AS] ([ID_Campa_as])
GO
ALTER TABLE [dbo].[CAMPA_AS_PARTICIPANTES] CHECK CONSTRAINT [FK_CampanasCampanasParticipantes]
GO
ALTER TABLE [dbo].[CAMPA_AS_PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [FK_ClientesCampanasParticipantes] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[CLIENTES] ([ID_Cliente])
GO
ALTER TABLE [dbo].[CAMPA_AS_PARTICIPANTES] CHECK CONSTRAINT [FK_ClientesCampanasParticipantes]
GO
ALTER TABLE [dbo].[CANTONES]  WITH CHECK ADD  CONSTRAINT [FK_ProvinciaCantones] FOREIGN KEY([ID_Provincias])
REFERENCES [dbo].[PROVINCIAS] ([ID_Provincias])
GO
ALTER TABLE [dbo].[CANTONES] CHECK CONSTRAINT [FK_ProvinciaCantones]
GO
ALTER TABLE [dbo].[CITAS]  WITH CHECK ADD  CONSTRAINT [FK_CitasEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[CITAS] CHECK CONSTRAINT [FK_CitasEstados]
GO
ALTER TABLE [dbo].[CITAS]  WITH CHECK ADD  CONSTRAINT [FK_ConsultorioCitas] FOREIGN KEY([ID_Consultorio])
REFERENCES [dbo].[CONSULTORIO] ([ID_Consultorio])
GO
ALTER TABLE [dbo].[CITAS] CHECK CONSTRAINT [FK_ConsultorioCitas]
GO
ALTER TABLE [dbo].[CITAS]  WITH CHECK ADD  CONSTRAINT [FK_MascotaCitas] FOREIGN KEY([ID_Mascota])
REFERENCES [dbo].[MASCOTAS] ([ID_Mascota])
GO
ALTER TABLE [dbo].[CITAS] CHECK CONSTRAINT [FK_MascotaCitas]
GO
ALTER TABLE [dbo].[CITAS]  WITH CHECK ADD  CONSTRAINT [FK_MotivoCitas] FOREIGN KEY([ID_Motivo_Cita])
REFERENCES [dbo].[MOTIVO_CITA] ([ID_Motivo_Cita])
GO
ALTER TABLE [dbo].[CITAS] CHECK CONSTRAINT [FK_MotivoCitas]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_ClientesCantones] FOREIGN KEY([ID_Cantones])
REFERENCES [dbo].[CANTONES] ([ID_Cantones])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [FK_ClientesCantones]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_ClientesEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [FK_ClientesEstados]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_DistritosClientes] FOREIGN KEY([ID_Distritos])
REFERENCES [dbo].[DISTRITOS] ([ID_Distritos])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [FK_DistritosClientes]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_ProvinciaClientes] FOREIGN KEY([ID_Provincias])
REFERENCES [dbo].[PROVINCIAS] ([ID_Provincias])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [FK_ProvinciaClientes]
GO
ALTER TABLE [dbo].[COBROS]  WITH CHECK ADD  CONSTRAINT [FK_CajasCobros] FOREIGN KEY([ID_Caja])
REFERENCES [dbo].[CAJAS] ([ID_Caja])
GO
ALTER TABLE [dbo].[COBROS] CHECK CONSTRAINT [FK_CajasCobros]
GO
ALTER TABLE [dbo].[COBROS]  WITH CHECK ADD  CONSTRAINT [FK_FacturasCobros] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[FACTURAS] ([ID_Facturas])
GO
ALTER TABLE [dbo].[COBROS] CHECK CONSTRAINT [FK_FacturasCobros]
GO
ALTER TABLE [dbo].[COBROS]  WITH CHECK ADD  CONSTRAINT [FK_MetodoPagoFacturas] FOREIGN KEY([Metodo_Pago])
REFERENCES [dbo].[METODO_PAGO] ([ID])
GO
ALTER TABLE [dbo].[COBROS] CHECK CONSTRAINT [FK_MetodoPagoFacturas]
GO
ALTER TABLE [dbo].[CONSULTORIO]  WITH CHECK ADD  CONSTRAINT [FK_PersonalConsultorio] FOREIGN KEY([ID_Personal])
REFERENCES [dbo].[PERSONAL] ([ID_Personal])
GO
ALTER TABLE [dbo].[CONSULTORIO] CHECK CONSTRAINT [FK_PersonalConsultorio]
GO
ALTER TABLE [dbo].[CONSULTORIO]  WITH CHECK ADD  CONSTRAINT [FK_TipoConsultorioConsultorio] FOREIGN KEY([ID_Tipo_Consultorio])
REFERENCES [dbo].[TIPO_CONSULTORIO] ([ID_Tipo_Consultorio])
GO
ALTER TABLE [dbo].[CONSULTORIO] CHECK CONSTRAINT [FK_TipoConsultorioConsultorio]
GO
ALTER TABLE [dbo].[CREDITOS]  WITH CHECK ADD  CONSTRAINT [FK_FacturasCreditos] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[FACTURAS] ([ID_Facturas])
GO
ALTER TABLE [dbo].[CREDITOS] CHECK CONSTRAINT [FK_FacturasCreditos]
GO
ALTER TABLE [dbo].[DESPACHO]  WITH CHECK ADD  CONSTRAINT [FK_DespachoEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[DESPACHO] CHECK CONSTRAINT [FK_DespachoEstados]
GO
ALTER TABLE [dbo].[DESPACHO]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDespacho] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[FACTURAS] ([ID_Facturas])
GO
ALTER TABLE [dbo].[DESPACHO] CHECK CONSTRAINT [FK_FacturasDespacho]
GO
ALTER TABLE [dbo].[DETALLE_ARTICULOS]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalleArticulos] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[FACTURAS] ([ID_Facturas])
GO
ALTER TABLE [dbo].[DETALLE_ARTICULOS] CHECK CONSTRAINT [FK_FacturasDetalleArticulos]
GO
ALTER TABLE [dbo].[DETALLE_ARTICULOS]  WITH CHECK ADD  CONSTRAINT [FK_InventarioDetalleArticulos] FOREIGN KEY([ID_Articulos])
REFERENCES [dbo].[INVENTARIO] ([ID_Inventario])
GO
ALTER TABLE [dbo].[DETALLE_ARTICULOS] CHECK CONSTRAINT [FK_InventarioDetalleArticulos]
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO]  WITH CHECK ADD  CONSTRAINT [FK_CitasDetalleServicio] FOREIGN KEY([ID_Cita])
REFERENCES [dbo].[CITAS] ([ID_Cita])
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO] CHECK CONSTRAINT [FK_CitasDetalleServicio]
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalleServicio] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[FACTURAS] ([ID_Facturas])
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO] CHECK CONSTRAINT [FK_FacturasDetalleServicio]
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO]  WITH CHECK ADD  CONSTRAINT [FK_ServiciosDetalleServicio] FOREIGN KEY([ID_Servicios])
REFERENCES [dbo].[SERVICIOS] ([ID_Servicios])
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO] CHECK CONSTRAINT [FK_ServiciosDetalleServicio]
GO
ALTER TABLE [dbo].[DISTRITOS]  WITH CHECK ADD  CONSTRAINT [FK_CantonesDistritos] FOREIGN KEY([ID_Cantones])
REFERENCES [dbo].[CANTONES] ([ID_Cantones])
GO
ALTER TABLE [dbo].[DISTRITOS] CHECK CONSTRAINT [FK_CantonesDistritos]
GO
ALTER TABLE [dbo].[ESTADOS_TABLAS]  WITH CHECK ADD  CONSTRAINT [FK_EstadosTablasEstados] FOREIGN KEY([ID_Estados])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[ESTADOS_TABLAS] CHECK CONSTRAINT [FK_EstadosTablasEstados]
GO
ALTER TABLE [dbo].[ESTADOS_TABLAS]  WITH CHECK ADD  CONSTRAINT [FK_TablasTablasEstados] FOREIGN KEY([ID_Tabla])
REFERENCES [dbo].[TABLAS] ([ID_Tabla])
GO
ALTER TABLE [dbo].[ESTADOS_TABLAS] CHECK CONSTRAINT [FK_TablasTablasEstados]
GO
ALTER TABLE [dbo].[FACTURA_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_SolicitudCompraFactura_Compra] FOREIGN KEY([ID_Solicitud_Compra])
REFERENCES [dbo].[SOLICITUD_COMPRA] ([ID_Solicitud_Compra])
GO
ALTER TABLE [dbo].[FACTURA_COMPRA] CHECK CONSTRAINT [FK_SolicitudCompraFactura_Compra]
GO
ALTER TABLE [dbo].[FACTURA_PROMOCION]  WITH CHECK ADD  CONSTRAINT [FK_FacturasFacturaPromocion] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[FACTURAS] ([ID_Facturas])
GO
ALTER TABLE [dbo].[FACTURA_PROMOCION] CHECK CONSTRAINT [FK_FacturasFacturaPromocion]
GO
ALTER TABLE [dbo].[FACTURA_PROMOCION]  WITH CHECK ADD  CONSTRAINT [FK_PromocionesFacturaPromocion] FOREIGN KEY([ID_Promocion])
REFERENCES [dbo].[PROMOCIONES] ([ID_Promocion])
GO
ALTER TABLE [dbo].[FACTURA_PROMOCION] CHECK CONSTRAINT [FK_PromocionesFacturaPromocion]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_ClientesFacturas] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[CLIENTES] ([ID_Cliente])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_ClientesFacturas]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FacturasEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_FacturasEstados]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_TipoPagoFacturas] FOREIGN KEY([Tipo_Pago])
REFERENCES [dbo].[TIPO_PAGO] ([ID])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_TipoPagoFacturas]
GO
ALTER TABLE [dbo].[INVENTARIO]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosInventario] FOREIGN KEY([ID_Articulos])
REFERENCES [dbo].[ARTICULOS] ([ID_Articulos])
GO
ALTER TABLE [dbo].[INVENTARIO] CHECK CONSTRAINT [FK_ArticulosInventario]
GO
ALTER TABLE [dbo].[INVENTARIO]  WITH CHECK ADD  CONSTRAINT [FK_InventarioEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[INVENTARIO] CHECK CONSTRAINT [FK_InventarioEstados]
GO
ALTER TABLE [dbo].[MARCAS]  WITH CHECK ADD  CONSTRAINT [FK_PersonalMarcas] FOREIGN KEY([ID_Personal])
REFERENCES [dbo].[PERSONAL] ([ID_Personal])
GO
ALTER TABLE [dbo].[MARCAS] CHECK CONSTRAINT [FK_PersonalMarcas]
GO
ALTER TABLE [dbo].[MARCAS]  WITH CHECK ADD  CONSTRAINT [FK_TipoMarca_Marcas] FOREIGN KEY([Tipo])
REFERENCES [dbo].[TIPO_MARCA] ([ID_Tipo])
GO
ALTER TABLE [dbo].[MARCAS] CHECK CONSTRAINT [FK_TipoMarca_Marcas]
GO
ALTER TABLE [dbo].[MASCOTAS]  WITH CHECK ADD  CONSTRAINT [FK_ClientesMascotas] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[CLIENTES] ([ID_Cliente])
GO
ALTER TABLE [dbo].[MASCOTAS] CHECK CONSTRAINT [FK_ClientesMascotas]
GO
ALTER TABLE [dbo].[MASCOTAS]  WITH CHECK ADD  CONSTRAINT [FK_MascotasEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[MASCOTAS] CHECK CONSTRAINT [FK_MascotasEstados]
GO
ALTER TABLE [dbo].[MASCOTAS]  WITH CHECK ADD  CONSTRAINT [FK_TipoAnimalMascotas] FOREIGN KEY([Tipo_Animal])
REFERENCES [dbo].[TIPO_ANIMAL] ([ID_Tipo_Animal])
GO
ALTER TABLE [dbo].[MASCOTAS] CHECK CONSTRAINT [FK_TipoAnimalMascotas]
GO
ALTER TABLE [dbo].[NOMINA_PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_NominaNominaPersonal] FOREIGN KEY([ID_Nomina])
REFERENCES [dbo].[NOMINA] ([ID_Nomina])
GO
ALTER TABLE [dbo].[NOMINA_PERSONAL] CHECK CONSTRAINT [FK_NominaNominaPersonal]
GO
ALTER TABLE [dbo].[NOMINA_PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_PersonalNominaPersonal] FOREIGN KEY([ID_Personal])
REFERENCES [dbo].[PERSONAL] ([ID_Personal])
GO
ALTER TABLE [dbo].[NOMINA_PERSONAL] CHECK CONSTRAINT [FK_PersonalNominaPersonal]
GO
ALTER TABLE [dbo].[OBSERVACIONES]  WITH CHECK ADD  CONSTRAINT [FK_CitasObservaciones] FOREIGN KEY([ID_Cita])
REFERENCES [dbo].[CITAS] ([ID_Cita])
GO
ALTER TABLE [dbo].[OBSERVACIONES] CHECK CONSTRAINT [FK_CitasObservaciones]
GO
ALTER TABLE [dbo].[PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [FK_CantonesParticipantes] FOREIGN KEY([ID_Canton])
REFERENCES [dbo].[CANTONES] ([ID_Cantones])
GO
ALTER TABLE [dbo].[PARTICIPANTES] CHECK CONSTRAINT [FK_CantonesParticipantes]
GO
ALTER TABLE [dbo].[PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [FK_DistritosParticipantes] FOREIGN KEY([ID_Distrito])
REFERENCES [dbo].[DISTRITOS] ([ID_Distritos])
GO
ALTER TABLE [dbo].[PARTICIPANTES] CHECK CONSTRAINT [FK_DistritosParticipantes]
GO
ALTER TABLE [dbo].[PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [FK_ParticipantesEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[PARTICIPANTES] CHECK CONSTRAINT [FK_ParticipantesEstados]
GO
ALTER TABLE [dbo].[PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [FK_ProvinciaParticipantes] FOREIGN KEY([ID_Provincia])
REFERENCES [dbo].[PROVINCIAS] ([ID_Provincias])
GO
ALTER TABLE [dbo].[PARTICIPANTES] CHECK CONSTRAINT [FK_ProvinciaParticipantes]
GO
ALTER TABLE [dbo].[PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [ReclutamientoParticipantes] FOREIGN KEY([ID_Reclutamiento])
REFERENCES [dbo].[RECLUTAMIENTO] ([ID_Reclutamiento])
GO
ALTER TABLE [dbo].[PARTICIPANTES] CHECK CONSTRAINT [ReclutamientoParticipantes]
GO
ALTER TABLE [dbo].[PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_CantonesPersonal] FOREIGN KEY([ID_Canton])
REFERENCES [dbo].[CANTONES] ([ID_Cantones])
GO
ALTER TABLE [dbo].[PERSONAL] CHECK CONSTRAINT [FK_CantonesPersonal]
GO
ALTER TABLE [dbo].[PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_DistritosPersonal] FOREIGN KEY([ID_Distrito])
REFERENCES [dbo].[DISTRITOS] ([ID_Distritos])
GO
ALTER TABLE [dbo].[PERSONAL] CHECK CONSTRAINT [FK_DistritosPersonal]
GO
ALTER TABLE [dbo].[PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_PersonalEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[PERSONAL] CHECK CONSTRAINT [FK_PersonalEstados]
GO
ALTER TABLE [dbo].[PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_ProvinciaPersonal] FOREIGN KEY([ID_Provincia])
REFERENCES [dbo].[PROVINCIAS] ([ID_Provincias])
GO
ALTER TABLE [dbo].[PERSONAL] CHECK CONSTRAINT [FK_ProvinciaPersonal]
GO
ALTER TABLE [dbo].[PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_PuestosPersonal] FOREIGN KEY([ID_Puesto])
REFERENCES [dbo].[PUESTOS] ([ID_Puestos])
GO
ALTER TABLE [dbo].[PERSONAL] CHECK CONSTRAINT [FK_PuestosPersonal]
GO
ALTER TABLE [dbo].[PROMOCIONES]  WITH CHECK ADD  CONSTRAINT [FK_PromocionesEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[PROMOCIONES] CHECK CONSTRAINT [FK_PromocionesEstados]
GO
ALTER TABLE [dbo].[PRUEBAS_PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [ParticipantesPruebasParticipantes] FOREIGN KEY([ID_Participantes])
REFERENCES [dbo].[PARTICIPANTES] ([ID_Participantes])
GO
ALTER TABLE [dbo].[PRUEBAS_PARTICIPANTES] CHECK CONSTRAINT [ParticipantesPruebasParticipantes]
GO
ALTER TABLE [dbo].[PRUEBAS_PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [PruebasPruebasParticipantes] FOREIGN KEY([ID_Pruebas])
REFERENCES [dbo].[PRUEBAS] ([ID_Pruebas])
GO
ALTER TABLE [dbo].[PRUEBAS_PARTICIPANTES] CHECK CONSTRAINT [PruebasPruebasParticipantes]
GO
ALTER TABLE [dbo].[PUESTOS]  WITH CHECK ADD  CONSTRAINT [FK_DepartamentosPuestos] FOREIGN KEY([ID_Departamento])
REFERENCES [dbo].[DEPARTAMENTOS] ([ID_Departamento])
GO
ALTER TABLE [dbo].[PUESTOS] CHECK CONSTRAINT [FK_DepartamentosPuestos]
GO
ALTER TABLE [dbo].[RECETAS]  WITH CHECK ADD  CONSTRAINT [FK_CitasRecetas] FOREIGN KEY([ID_Cita])
REFERENCES [dbo].[CITAS] ([ID_Cita])
GO
ALTER TABLE [dbo].[RECETAS] CHECK CONSTRAINT [FK_CitasRecetas]
GO
ALTER TABLE [dbo].[RECLUTAMIENTO]  WITH CHECK ADD  CONSTRAINT [FK_ReclutamientolEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[RECLUTAMIENTO] CHECK CONSTRAINT [FK_ReclutamientolEstados]
GO
ALTER TABLE [dbo].[REQUISITOS_PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [ParticipantesRequisitosParticipanes] FOREIGN KEY([ID_Participantes])
REFERENCES [dbo].[PARTICIPANTES] ([ID_Participantes])
GO
ALTER TABLE [dbo].[REQUISITOS_PARTICIPANTES] CHECK CONSTRAINT [ParticipantesRequisitosParticipanes]
GO
ALTER TABLE [dbo].[REQUISITOS_PARTICIPANTES]  WITH CHECK ADD  CONSTRAINT [RequisitosPuestoRequisitosParticipanes] FOREIGN KEY([ID_Requisitos])
REFERENCES [dbo].[REQUISITOS_PUESTO] ([ID_Requisitos])
GO
ALTER TABLE [dbo].[REQUISITOS_PARTICIPANTES] CHECK CONSTRAINT [RequisitosPuestoRequisitosParticipanes]
GO
ALTER TABLE [dbo].[REQUISITOS_PUESTO]  WITH CHECK ADD  CONSTRAINT [FK_PuestosRequisitosPuesto] FOREIGN KEY([ID_Puestos])
REFERENCES [dbo].[PUESTOS] ([ID_Puestos])
GO
ALTER TABLE [dbo].[REQUISITOS_PUESTO] CHECK CONSTRAINT [FK_PuestosRequisitosPuesto]
GO
ALTER TABLE [dbo].[RESULTADO_LABORATORIO]  WITH CHECK ADD  CONSTRAINT [FK_CitasResultadoLaboratorio] FOREIGN KEY([ID_Cita])
REFERENCES [dbo].[CITAS] ([ID_Cita])
GO
ALTER TABLE [dbo].[RESULTADO_LABORATORIO] CHECK CONSTRAINT [FK_CitasResultadoLaboratorio]
GO
ALTER TABLE [dbo].[RESULTADO_LABORATORIO]  WITH CHECK ADD  CONSTRAINT [FK_PruebasLaboratorioResultadoLaboratorio] FOREIGN KEY([ID_Pruebas_Laboratorio])
REFERENCES [dbo].[PRUEBAS_LABORATORIO] ([ID_Pruebas_Laboratorio])
GO
ALTER TABLE [dbo].[RESULTADO_LABORATORIO] CHECK CONSTRAINT [FK_PruebasLaboratorioResultadoLaboratorio]
GO
ALTER TABLE [dbo].[RESULTADO_LABORATORIO]  WITH CHECK ADD  CONSTRAINT [FK_ResultadoLaboratorioEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[RESULTADO_LABORATORIO] CHECK CONSTRAINT [FK_ResultadoLaboratorioEstados]
GO
ALTER TABLE [dbo].[ROLES]  WITH CHECK ADD  CONSTRAINT [FK_RolesEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[ROLES] CHECK CONSTRAINT [FK_RolesEstados]
GO
ALTER TABLE [dbo].[SERVICIOS_EXPRESS]  WITH CHECK ADD  CONSTRAINT [FK_FacturasServicioExpres] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[FACTURAS] ([ID_Facturas])
GO
ALTER TABLE [dbo].[SERVICIOS_EXPRESS] CHECK CONSTRAINT [FK_FacturasServicioExpres]
GO
ALTER TABLE [dbo].[SERVICIOS_EXPRESS]  WITH CHECK ADD  CONSTRAINT [FK_ServicioExpressEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[SERVICIOS_EXPRESS] CHECK CONSTRAINT [FK_ServicioExpressEstados]
GO
ALTER TABLE [dbo].[SOLICITUD_ARTICULOS]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosProveedorSolicitudArticulos] FOREIGN KEY([ID_Articulo_Proveedor])
REFERENCES [dbo].[ARTICULOS_PROVEEDOR] ([ID_Articulos_Proveedor])
GO
ALTER TABLE [dbo].[SOLICITUD_ARTICULOS] CHECK CONSTRAINT [FK_ArticulosProveedorSolicitudArticulos]
GO
ALTER TABLE [dbo].[SOLICITUD_ARTICULOS]  WITH CHECK ADD  CONSTRAINT [FK_SolicitudCompraSolicitudArticulos] FOREIGN KEY([ID_Solicitud_Compra])
REFERENCES [dbo].[SOLICITUD_COMPRA] ([ID_Solicitud_Compra])
GO
ALTER TABLE [dbo].[SOLICITUD_ARTICULOS] CHECK CONSTRAINT [FK_SolicitudCompraSolicitudArticulos]
GO
ALTER TABLE [dbo].[SOLICITUD_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_SolicitudCompraEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[SOLICITUD_COMPRA] CHECK CONSTRAINT [FK_SolicitudCompraEstados]
GO
ALTER TABLE [dbo].[USUARIO_ROL]  WITH CHECK ADD  CONSTRAINT [FK_RolUsuariosRol] FOREIGN KEY([ID_Roles])
REFERENCES [dbo].[ROLES] ([ID_Roles])
GO
ALTER TABLE [dbo].[USUARIO_ROL] CHECK CONSTRAINT [FK_RolUsuariosRol]
GO
ALTER TABLE [dbo].[USUARIO_ROL]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosUsuariosRol] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[USUARIOS] ([ID_Usuario])
GO
ALTER TABLE [dbo].[USUARIO_ROL] CHECK CONSTRAINT [FK_UsuariosUsuariosRol]
GO
ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_PersonalUsuarios] FOREIGN KEY([ID_Personal])
REFERENCES [dbo].[PERSONAL] ([ID_Personal])
GO
ALTER TABLE [dbo].[USUARIOS] CHECK CONSTRAINT [FK_PersonalUsuarios]
GO
ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosEstados] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADOS] ([ID_Estados])
GO
ALTER TABLE [dbo].[USUARIOS] CHECK CONSTRAINT [FK_UsuariosEstados]
GO
ALTER TABLE [dbo].[VACACIONES]  WITH CHECK ADD  CONSTRAINT [FK_PersonalVacaciones] FOREIGN KEY([ID_Personal])
REFERENCES [dbo].[PERSONAL] ([ID_Personal])
GO
ALTER TABLE [dbo].[VACACIONES] CHECK CONSTRAINT [FK_PersonalVacaciones]
GO
/****** Object:  StoredProcedure [dbo].[MODIFICAR_ABONOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MODIFICAR_ABONOS]
(
@ID_Factura int,
@Monto_Anterior decimal,
@Abono decimal,
@Monto_Actual decimal
)
as
begin
INSERT INTO [dbo].[CREDITOS]
           ([ID_Factura]
           ,[Monto_Anterior]
		   ,[Abono]
		   ,[Monto_Actual] )       
     VALUES
           (@ID_Factura,@Monto_Anterior,@Abono,@Monto_Actual)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Clientes_Eliminar]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PA_Clientes_Eliminar]
@cedula varchar(15)
AS
BEGIN
	DELETE FROM CLIENTES
	WHERE Cedula = @cedula
END
GO
/****** Object:  StoredProcedure [dbo].[PA_Clientes_Modificar]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[PA_Clientes_Modificar]
@ced varchar(20),
@nombre varchar(50),
@ape1   varchar(50),
@ape2  varchar(50),
@correo  varchar(50),
@telefono  varchar(20),
@prov  int,
@cant  int,
@dis   int,
@direccion  varchar(150)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE CLIENTES
	SET Cedula=@ced, Nombre=@nombre,Apellido_1=@ape1,Apellido_2=@ape2,Correo=@correo,Telefono=@telefono,
	ID_Provincias=@prov,ID_Cantones=@cant, ID_Distritos=@dis,Direccion=@direccion
	WHERE Cedula = @ced
END
GO
/****** Object:  StoredProcedure [dbo].[PA_TipoMascota_Consultar]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PA_TipoMascota_Consultar]

AS
BEGIN	
	SET NOCOUNT ON;	
	SELECT ID_Tipo_Animal, Tipo 
	FROM   dbo.TIPO_ANIMAL
	END
GO
/****** Object:  StoredProcedure [dbo].[PA_Usuarios_Eliminar]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[PA_Usuarios_Eliminar]
@cedula varchar(15)
AS
BEGIN
	DELETE FROM CLIENTES
	WHERE Cedula = @cedula
END
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_articulo]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_actualizar_articulo]
(
@ID_Solicitud_Articulo int,
@ID_Articulo_Proveedor int,
@ID_Solicitud_Compra int,
@Descripcion varchar(100),
@Cantidad decimal(10,2)
)
as
begin 
	update dbo.SOLICITUD_ARTICULOS
	set
	ID_Articulo_Proveedor = @ID_Articulo_Proveedor,
	ID_Solicitud_Compra = @ID_Solicitud_Compra,
	Descripcion = @Descripcion,
	Cantidad = @Cantidad
	where ID_Solicitud_Articulos = @ID_Solicitud_Articulo
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_despacho]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_actualizar_despacho]
(
@ID_despacho int,
@ID_factura int,
@fecha date,
@Estado int
)
as
begin 
	update dbo.DESPACHO
	set
	ID_Factura = @ID_factura,
	Fecha = @fecha,
	Estado = @Estado
	where ID_Despacho = @ID_despacho
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Actualizar_Estado_Cita]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SP Actualizar Estado Cita
CREATE PROC [dbo].[SP_Actualizar_Estado_Cita] @id_cita int,@id_estado int
AS
BEGIN
update CITAS set Estado = @id_estado where ID_Cita = @id_cita
end
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_CLIENTES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_AGREGAR_CLIENTES]
(
@ced int,
@nom varchar(20),
@ape1 varchar(50),
@ape2 varchar(50),
@correo varchar(50),
@tel varchar(50),
@provincia int,
@canton int,
@distrito int,
@dire varchar(150),
@est int

)
AS
BEGIN
INSERT INTO CLIENTES 
	(Cedula,Nombre,Apellido_1,Apellido_2,Correo,Telefono,ID_Provincias,ID_Cantones,ID_Distritos,Direccion,Estado) 
	
	VALUES 
	(@ced ,
     @nom ,
	 @ape1 ,
	 @ape2 ,
	 @correo,
	 @tel ,
	 @provincia ,
	 @canton ,
	 @distrito ,
	 @dire ,
	 @est )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_despacho]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_agregar_despacho]
(
@ID_Factura int,
@Fecha date,
@Estado int
)
as
begin 
	 insert into dbo.DESPACHO
	 (ID_Factura, Fecha, Estado)
	 values(@ID_Factura, @Fecha, @Estado)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_FACTURA]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[SP_AGREGAR_FACTURA]
(
@idCliente int,
@idCaja int,
@numeroFactura int,
@fecha date,
@descripcion varchar(100),
@total decimal,
@tipoPago tinyint,
@estado int
)
AS
BEGIN
INSERT INTO [dbo].[FACTURAS]
           ([ID_Cliente]
           ,[ID_Caja]
           ,[Numero_Factura]
           ,[Fecha]
           ,[Descripcion]
           ,[Total]
           ,[Tipo_Pago]
           ,[Estado])
    VALUES 
    (@idCliente,
    @idCaja,
    @numeroFactura,
    @fecha,
    @descripcion,
    @total,
    @tipoPago,
    @estado )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_MARCAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------5

CREATE PROCEDURE [dbo].[SP_AGREGAR_MARCAS]
(
@ID_Personal int,
@Fecha date,
@Hora time(7),
@Tipo tinyint
)
AS
BEGIN
INSERT INTO MARCAS 
    (ID_Personal, Fecha, Hora, Tipo) 
    
    VALUES 
    (
	@ID_Personal,
    @Fecha,
    @Hora,
    @Tipo
	 )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_NOMINA]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------3

CREATE PROCEDURE [dbo].[SP_AGREGAR_NOMINA]
(
@Nombre varchar(30),
@Fecha_Inicio date,
@Fecha_Fin date,
@Descripcion varchar(50)
)
AS
BEGIN
INSERT INTO NOMINA 
    (Nombre, Fecha_Inicio, Fecha_Fin, Descripcion) 
    
    VALUES 
    (
	@Nombre,
    @Fecha_Inicio,
    @Fecha_Fin,
    @Descripcion
	 )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_OBSERVACIONES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_AGREGAR_OBSERVACIONES]
(
@idcita int,
@des varchar(100)
)
AS
BEGIN
INSERT INTO OBSERVACIONES 
	(ID_Cita,Descripcion) 
	VALUES 
	(@idcita ,
     @des )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_PARTICIPANTES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------------------------------------------4

CREATE PROCEDURE [dbo].[SP_AGREGAR_PARTICIPANTES]
(
@ID_Reclutamiento int,
@Cedula_ varchar(20),
@Nombre varchar(30),
@Apellido_1 varchar(30),
@Apellido_2 varchar(30),
@Correo varchar(100),
@Telefono varchar(8),
@ID_Provincia int,
@ID_Canton int,
@ID_Distrito int,
@Direccion varchar(150),
@Estado int
)
AS
BEGIN
INSERT INTO PARTICIPANTES 
    (ID_Reclutamiento, Cedula_, Nombre, Apellido_1, Apellido_2, Correo, Telefono, ID_Provincia,
	ID_Canton, ID_Distrito, Direccion, Estado) 
    
    VALUES 
    (
	@ID_Reclutamiento,
    @Cedula_,
    @Nombre,
    @Apellido_1,
    @Apellido_2,
    @Correo,
    @Telefono,
    @ID_Provincia,
    @ID_Canton,
    @ID_Distrito,
    @Direccion,
    @Estado 
	 )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_PERSONAL]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--*************************************************************************1

CREATE PROCEDURE [dbo].[SP_AGREGAR_PERSONAL]
(
@ID_Puesto int,
@Cedula varchar(20),
@Nombre varchar(30),
@Apellido_1 varchar(30),
@Apellido_2 varchar(30),
@Salario_Hora decimal(10,2),
@Salario_Mensual decimal(10,2),
@Fecha_Contratacion date,
@Estado int,
@Direccion varchar(150),
@Correo_Electronico varchar(50),
@Telefono varchar(50)
)
AS
BEGIN
INSERT INTO PERSONAL 
    (ID_Puesto, Cedula, Nombre, Apellido_1, Apellido_2, Salario_Hora, Salario_Mensual, 
	Fecha_Contratacion, Estado, Direccion, Correo_Electronico, Telefono) 
    
    VALUES 
    (
	@ID_Puesto,
    @Cedula,
    @Nombre, 
    @Apellido_1,
    @Apellido_2,
    @Salario_Hora,
    @Salario_Mensual,
    @Fecha_Contratacion,
    @Estado,
    @Direccion,
    @Correo_Electronico,
    @Telefono
	 )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_PRUEBAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------------------------------------------24

CREATE PROCEDURE [dbo].[SP_AGREGAR_PRUEBAS]
(
@Nombre varchar(30),
@Descripcion varchar(100)
)
AS
BEGIN
INSERT INTO PRUEBAS 
    (Nombre,Descripcion) 
    
    VALUES 
    (@Nombre ,
     @Descripcion)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_PRUEBAS_PARTICIPANTES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AGREGAR_PRUEBAS_PARTICIPANTES]
(
@ID_Pruebas int,
@ID_Participantes int,
@Nota int
)
AS
BEGIN
INSERT INTO PRUEBAS_PARTICIPANTES 
    (ID_Pruebas, ID_Participantes, Nota) 
    VALUES 
    (
	@ID_Pruebas,
    @ID_Participantes,
    @Nota
	 )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_RECLUTAMIENTO3]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_AGREGAR_RECLUTAMIENTO3]
(
@ID_Puestos int,
@Nombre varchar(30),
@Descripcion varchar(100),
@Estado int
)
AS
BEGIN
INSERT INTO RECLUTAMIENTO 
    (ID_Puestos,Nombre,Descripcion,Estado) 
    
    VALUES 
    (@ID_Puestos,
	@Nombre ,
	@Descripcion,
     @Estado )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_RESULTADOS_EXAMENES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_AGREGAR_RESULTADOS_EXAMENES]
(
@idPrueba int,
@idcita int,
@resultado varchar(50),
@estado int
)
AS
BEGIN
INSERT INTO RESULTADO_LABORATORIO 
	(ID_Pruebas_Laboratorio,ID_Cita,Resultado,Estado) 
	
	VALUES 
	(@idPrueba ,
     @idcita ,
	 @resultado ,
	 @estado 
	 )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AGREGAR_USUARIOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------------------2

CREATE PROCEDURE [dbo].[SP_AGREGAR_USUARIOS]
(
@ID_Personal int,
@UserName varchar(20),
@Pass varchar(20),
@Last_Login varchar(20),
@Estado int
)
AS
BEGIN
INSERT INTO USUARIOS 
    (ID_Personal, UserName, Pass, Last_Login, Estado) 
    
    VALUES 
    (
	@ID_Personal,
    @UserName,
    @Pass,
    @Last_Login,
    @Estado
	 )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Consulta_Citas]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SP para cargar todas las citas
CREATE PROC [dbo].[SP_Consulta_Citas]
as
begin
SELECT ct.ID_Cita, 
		m.ID_Mascota,
		m.Nombre,
		ct.ID_Consultorio, 
		ct.ID_Motivo_Cita,
		mc.Nombre,
		ct.Fecha_Inicio,
		ct.Hora_Inicio,
		ct.Hora_Fin,
		ct.Estado, 
		e.Nombre,
		CONCAT(c.Nombre,' ',c.Apellido_1,' ',c.Apellido_2) Cliente
			FROM CLIENTES c, 
				MASCOTAS m, 
				citas ct,
				MOTIVO_CITA mc,
				ESTADOS e
			WHERE ct.ID_Mascota = m.ID_Mascota and m.ID_Cliente = c.ID_Cliente and
				ct.ID_Motivo_Cita = mc.ID_Motivo_Cita and ct.Estado = e.ID_Estados 
			ORDER BY ct.Fecha_Inicio, ct.Hora_Inicio ASC;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Consulta_Consultorios]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- SP para consultar los consultorios
create proc [dbo].[SP_Consulta_Consultorios]
AS
begin
select [ID_Consultorio],[Nombre] from CONSULTORIO
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_Consulta_Macota_Cliente]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Consulta_Macota_Cliente]
@Cedula varchar(20)
AS
begin
SELECT m.ID_Mascota, m.Nombre, CONCAT(c.Nombre,' ',c.Apellido_1,' ',c.Apellido_2) Nombre_Cliente FROM CLIENTES c, MASCOTAS M
	WHERE m.ID_Cliente = c.ID_Cliente and c.Cedula = @Cedula; 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Consulta_Motivos]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SP para consultar los motivos
create proc [dbo].[SP_Consulta_Motivos]
AS
begin
select [ID_Motivo_Cita],[Nombre] from MOTIVO_CITA
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_solicitud_para_aprov]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_consulta_solicitud_para_aprov]
as
begin
select ID_Solicitud_Compra,Encabezado from SOLICITUD_COMPRA where Estado = 1;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_consulta_usuarios]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_consulta_usuarios]
AS
begin
	select u.UserName,
		u.Pass,
		CONCAT(p.Nombre,' ' ,p.Apellido_1,' ',p.Apellido_2) Nombre,
		p.ID_Personal 
	from USUARIOS u, PERSONAL p 
	where u.ID_Personal = p.ID_Personal and 
		u.Estado = 8;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_articulo_proveedor]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_consultar_articulo_proveedor]
as
begin
	select ID_Articulos_Proveedor, Descripcion from dbo.ARTICULOS_PROVEEDOR;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ARTICULOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_ARTICULOS]
(
@Nombre varchar(50)
)
AS
BEGIN
SELECT [ID_Articulos]
      ,[Nombre]
      ,[Descripcion]
      ,[Precio]
      ,[Estado]
  FROM [dbo].[ARTICULOS]
   WHERE [Nombre] LIKE '%' + @Nombre + '%'
   END
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_articulos_id]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_consultar_articulos_id]
(
@ID_ARTICULO INT
)
as
begin
	select * from dbo.SOLICITUD_ARTICULOS where ID_Solicitud_Articulos like @ID_ARTICULO;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CAJAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_CAJAS]
(
@ID_Caja int
)
AS
BEGIN
SELECT [ID_Caja]      
      ,[Estado]
  FROM [dbo].[CAJAS]

   WHERE ID_Caja = @ID_Caja
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CANTONES_POR_PROVINCIA]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_CANTONES_POR_PROVINCIA]
(
@PROV int
)
AS
BEGIN
SELECT ID_Cantones 
      ,[Nombre]      
      
   FROM [dbo].[CANTONES]
   WHERE [ID_Provincias]= @PROV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CITAS_EN_CURSO]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_CITAS_EN_CURSO]

AS
BEGIN
SELECT C.ID_Cita,
       C.ID_Mascota, 
       M.Nombre    
      
   FROM [dbo].[CITAS] C INNER JOIN MASCOTAS M ON
   C.ID_Mascota=M.ID_Mascota
   WHERE C.[Estado]= 2
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CLIENTES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES]
(
@Cedula varchar(20)
)
AS
BEGIN
SELECT [ID_Cliente]
      ,[Cedula]
      ,[Nombre]
      ,[Apellido_1]
      ,[Apellido_2]      
      
  FROM [dbo].[CLIENTES]
   WHERE [Cedula] LIKE '%' + @Cedula + '%' or [Nombre] LIKE '%' + @Cedula + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CLIENTES_FACTURA]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES_FACTURA]
(
@Nombre varchar(20)
)
AS
BEGIN
SELECT [ID_Cliente]
      ,[Cedula]
      ,[Nombre]
      ,[Apellido_1]
      ,[Apellido_2]     
	  ,[Correo]
	  ,[Telefono]
	  ,[Credito]
      
  FROM [dbo].[CLIENTES]
   WHERE [Nombre] LIKE '%' + @Nombre + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CLIENTES_PANTALLACLIENTE]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_CLIENTES_PANTALLACLIENTE]
(
@Cedula varchar(20)
)
AS
BEGIN
select C.ID_Cliente,
       C.Cedula,
	   C.Nombre,
	   C.Apellido_1,
	   C.Apellido_2,
	   C.Correo,
       C.Telefono,
	   P.Nombre,
	   CA.Nombre,
	   D.Nombre,
	   C.Direccion,
	   E.Nombre
      from CLIENTES C inner join PROVINCIAS P on C.ID_Provincias=P.ID_Provincias
      inner join CANTONES CA ON C.ID_Cantones=CA.ID_Cantones 
	  inner join DISTRITOS D on C.ID_Distritos=D.ID_Distritos
	  inner join ESTADOS E on C.Estado= E.ID_Estados 
      WHERE [Cedula] LIKE '%' + @Cedula + '%' or C.[Nombre] LIKE '%' + @Cedula + '%'

END

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_COBROS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_COBROS]
(
@Nom varchar(50)
)
AS
BEGIN
 
 SELECT c.Cedula,c.Nombre,c.Apellido_1,c.Apellido_2,Fecha,f.Numero_Factura,f.Total,f.Estado,f.Tipo_Pago,cr.Monto_Actual from CLIENTES AS c inner join FACTURAS AS f on c.ID_Cliente= f.ID_Cliente inner join CREDITOS AS cr on f.Numero_Factura =cr.ID_Factura
  WHERE F.Estado NOT IN('21')AND F.Estado NOT IN ('37') AND c.Nombre LIKE '%' + @Nom + '%'
 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_COBROS_CONTADO]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_COBROS_CONTADO]
(
@Nom varchar(50)
)
AS
BEGIN
 
 SELECT c.Cedula,c.Nombre,c.Apellido_1,c.Apellido_2,Fecha,f.Numero_Factura,f.Total,f.Estado,f.Tipo_Pago from CLIENTES AS c inner join FACTURAS AS f on c.ID_Cliente= f.ID_Cliente
 WHERE F.Estado NOT IN('21')AND F.Estado NOT IN ('37') AND f.Tipo_Pago NOT IN ('2') AND c.Nombre LIKE '%' + @Nom + '%'
 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_COBROS_Credito]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_COBROS_Credito]
(
@Nom varchar(50)
)
AS
BEGIN
 SELECT c.Cedula, c.Nombre, c.Apellido_1, c.Apellido_2, Fecha, cr.ID_Factura AS Factura, f.total AS Total, f.Estado, f.Tipo_Pago, MIN(CR.Monto_Actual) as Monto_Actual
FROM CLIENTES AS c inner join FACTURAS AS f ON c.ID_Cliente = f.ID_Cliente inner join CREDITOS AS cr ON cr.ID_Factura = f.Numero_Factura
WHERE F.Estado NOT IN('21') AND F.Estado NOT IN ('37') AND f.Tipo_Pago NOT IN ('1')AND c.Nombre LIKE '%' + @Nom + '%'
GROUP BY cr.ID_Factura, c.Cedula, c.Nombre, c.Apellido_1, c.Apellido_2, Fecha, f.Estado, f.Tipo_Pago, f.Total 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_despacho]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_consultar_despacho]
as
begin
	select * from dbo.DESPACHO;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_despacho_id]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_consultar_despacho_id]
(
@ID_DESPACHO INT
)
as
begin
	select * from dbo.DESPACHO where ID_Despacho like @ID_DESPACHO;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_DISTRITOS_POR_CANTON]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_DISTRITOS_POR_CANTON]
(
@CAN int
)
AS
BEGIN
SELECT [ID_Distritos] 
      ,[Nombre]      
      
   FROM [dbo].[DISTRITOS]
   WHERE [ID_Cantones]= @CAN
END
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_estados]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_consultar_estados]
as
begin
	select * from dbo.ESTADOS;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ESTADOS_EXAMENES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_ESTADOS_EXAMENES]

AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 23 OR [ID_Estados]= 24 OR [ID_Estados]= 25
   

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ESTADOS_MASCOTAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_ESTADOS_MASCOTAS]

AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 29 OR [ID_Estados]= 30 OR [ID_Estados]= 31
   OR [ID_Estados]= 32

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ESTADOSCLIENTES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_ESTADOSCLIENTES]

AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 5 OR [ID_Estados]= 33
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_EXPRESS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_EXPRESS]
(
@Estado int
)
AS
BEGIN
SELECT E.ID_Servicios,E.ID_Factura as Factura,E.Descripcion,E.Estado,F.Fecha,C.Nombre,C.Apellido_1 AS PrimerApellido,C.Apellido_2 AS SegundoApellido  FROM SERVICIOS_EXPRESS AS E INNER JOIN FACTURAS AS F on F.ID_Facturas= E.ID_Factura INNER JOIN CLIENTES AS C ON F.ID_Cliente= C.ID_Cliente
  WHERE E.Estado =@Estado
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_FACTURAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_FACTURAS]
(
@ID_Facturas int

)
AS
BEGIN
SELECT [ID_Facturas]
      ,[ID_Cliente]
      ,[ID_Caja]
      ,[Numero_Factura]
      ,[Fecha]
      ,[Descripcion]
      ,[Total]
      ,[Tipo_Pago]
      ,[Estado]
  FROM [dbo].[FACTURAS]
  WHERE [ID_Facturas] = @ID_Facturas
  END 
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_IdCanton]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_IdCanton]
(
@nombreCanton varchar(20)
)
AS
BEGIN
SELECT [ID_Cantones]
      
  FROM [dbo].[CANTONES]
   WHERE [Nombre] =@nombreCanton
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_INVENTARIO]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_INVENTARIO]
(
@Nom varchar(50)
)
AS
BEGIN
 
 select i.ID_Articulos,a.Nombre,a.Precio,i.Cantidad,i.Estado from dbo.INVENTARIO i
  inner join dbo.ARTICULOS a on i.ID_Articulos = a.ID_Articulos  WHERE a.Nombre LIKE '%' + @Nom + '%'
 end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_INVENTARIO_MENOR_CANTIDAD]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_INVENTARIO_MENOR_CANTIDAD]

AS
BEGIN
 
 select i.ID_Inventario,i.ID_Articulos,a.Nombre,a.Precio,i.Cantidad,i.Estado from dbo.INVENTARIO i
  inner join dbo.ARTICULOS a on i.ID_Articulos = a.ID_Articulos  WHERE i.Cantidad < 10

 end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_INVENTARIOTOTAL]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_INVENTARIOTOTAL]

AS
BEGIN
 
 select i.ID_Inventario,i.ID_Articulos,a.Nombre,a.Precio,i.Cantidad,i.Estado from dbo.INVENTARIO i
  inner join dbo.ARTICULOS a on i.ID_Articulos = a.ID_Articulos  WHERE i.Cantidad >10

 end
 


GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_Mascotas]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_Mascotas]
(
@nombre varchar(50)
)
AS
BEGIN
SELECT M.[ID_Mascota],
       M.[ID_Cliente],
       M.[Nombre]
      ,TA.[Tipo]
	  ,M.[Raza]
      ,M.[Sexo]   
	  
      
  FROM [dbo].[MASCOTAS] M INNER JOIN [TIPO_ANIMAL] TA
  on M.Tipo_Animal=TA.ID_Tipo_Animal
   WHERE [Nombre] LIKE '%' + @nombre + '%' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_MEDICAMENTOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_MEDICAMENTOS]

AS
BEGIN
 
 select A.ID_Articulos, A.Nombre from dbo.ARTICULOS A
  inner join dbo.INVENTARIO I on I.ID_Articulos=A.ID_Articulos  WHERE I.Estado=13 AND A.Descripcion='Medicamentos' 

 end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_NoFactura]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_NoFactura]
AS
BEGIN
SELECT MAX(Numero_Factura)        
  FROM [dbo].[FACTURAS] 
  END 
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_OBSERVACIONES_POR_CITAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_OBSERVACIONES_POR_CITAS]

AS
BEGIN
SELECT O.ID_Cita,
	   O.Descripcion
	  FROM [dbo].[OBSERVACIONES] O 
	    inner join CITAS c on O.ID_Cita=c.ID_Cita
  
   WHERE c.Estado=2
   END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PARTICIPANTES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------22

CREATE PROCEDURE [dbo].[SP_CONSULTAR_PARTICIPANTES]
(
@Cedula varchar(20)
)
AS
BEGIN
SELECT P.ID_Participantes
      ,PRE.Nombre
      ,P.Cedula_
      ,P.Nombre
      ,P.Apellido_1
      ,P.Apellido_2
      ,P.Correo
      ,P.Telefono
      ,PR.Nombre
      ,PC.Nombre
      ,PD.Nombre
      ,P.Direccion
      ,PE.Nombre    
      
  FROM dbo.PARTICIPANTES P
      inner join RECLUTAMIENTO PRE on P.ID_Reclutamiento = PRE.ID_Reclutamiento 
      inner join PROVINCIAS PR on P.ID_Provincia = PR.ID_Provincias
      inner join CANTONES PC ON P.ID_Canton = PC.ID_Cantones
	  inner join DISTRITOS PD on P.ID_Distrito = PD.ID_Distritos
	  inner join ESTADOS PE on P.Estado = PE.ID_Estados 
      WHERE [Cedula_] LIKE '%' + @Cedula + '%' or P.[Nombre] LIKE '%' + @Cedula + '%'
 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PARTICIPANTES2]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------------------------------------------21

CREATE PROCEDURE [dbo].[SP_CONSULTAR_PARTICIPANTES2]
(
@Cedula varchar(20)
)
AS
BEGIN
SELECT ID_Participantes
      ,ID_Reclutamiento
      ,Cedula_
      ,Nombre
      ,Apellido_1

      ,Apellido_2
      ,Correo
      ,Telefono
      ,ID_Provincia
      ,ID_Canton
      ,ID_Distrito
      ,Direccion
      ,Estado 
      
  FROM [dbo].[PARTICIPANTES]
   WHERE [Cedula_] LIKE '%' + @Cedula + '%' or [Nombre] LIKE '%' + @Cedula + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PERSONAL]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------------------------------------------23

CREATE PROCEDURE [dbo].[SP_CONSULTAR_PERSONAL]
(
@Cedula varchar(20)
)
AS
BEGIN
SELECT P.ID_Personal
      ,PP.Nombre
      ,P.Cedula
      ,P.Nombre
      ,P.Apellido_1
      ,P.Apellido_2
      ,P.Salario_Hora
      ,P.Salario_Mensual
      ,P.Fecha_Contratacion
      ,PE.Nombre
      ,P.Direccion
      ,P.Correo_Electronico
      ,P.Telefono    
      
  FROM dbo.PERSONAL P
      inner join PUESTOS PP on P.ID_Puesto = PP.ID_Puestos 
	  inner join ESTADOS PE on P.Estado = PE.ID_Estados
      WHERE [Cedula] LIKE '%' + @Cedula + '%' or P.[Nombre] LIKE '%' + @Cedula + '%'
 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PRODUCTOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_PRODUCTOS]
(
@Nombre varchar(50)
)
AS
BEGIN
SELECT [ID_Articulos]
      ,[Nombre]
      ,[Descripcion]
      ,[Precio]
      ,[Estado]
  FROM [dbo].[ARTICULOS]
   WHERE [Nombre] LIKE '%' + @Nombre + '%'
   END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PROVINCIA]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_PROVINCIA]

AS
BEGIN
SELECT [ID_Provincias]
      ,[Nombre]      
      
  FROM [dbo].[PROVINCIAS]
 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PRUEBAS_LABORATORIO]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_CONSULTAR_PRUEBAS_LABORATORIO]
(
@nombre varchar(50)
)
AS
BEGIN
SELECT [ID_Pruebas_Laboratorio]
      ,[Nombre]
      ,[Descripcion]
      FROM [dbo].[PRUEBAS_LABORATORIO]
   WHERE [Nombre]=@nombre
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_RESULTADOSexamenes_POR_CITAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[SP_CONSULTAR_RESULTADOSexamenes_POR_CITAS]

AS
BEGIN
SELECT O.Resultado,
	   P.Nombre
	   
	  
	  FROM [dbo].[RESULTADO_LABORATORIO] O 
	    inner join CITAS c on O.ID_Cita=c.ID_Cita
		INNER JOIN PRUEBAS_LABORATORIO P on 
		o.ID_Pruebas_Laboratorio= P.ID_Pruebas_Laboratorio
        WHERE c.Estado=2 
		end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_SERVICIOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS]
(
@nombre varchar(50)
)
AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
      ,[Descripcion]
      ,[Precio]      
      
  FROM [dbo].[SERVICIOS]
   WHERE [Nombre]=@nombre
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_SERVICIOS_CIRUGIA]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS_CIRUGIA]
(
@nombre varchar(50)
)
AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
      ,[Descripcion]
      ,[Precio]      
      
  FROM [dbo].[SERVICIOS]
   WHERE [Nombre]=@nombre
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_SERVICIOS_CIRUJIAS_IDNOMBRE]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS_CIRUJIAS_IDNOMBRE]

AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
       
      
  FROM [dbo].[SERVICIOS]
    WHERE [ID_Servicios] BETWEEN  19 AND 25
	
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_SERVICIOS_EXAMENES_IDNOMBRE]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS_EXAMENES_IDNOMBRE]

AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
       
      
  FROM [dbo].[SERVICIOS]
    WHERE [ID_Servicios] BETWEEN  13 AND 18
	
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_SERVICIOS_IDNOMBRE]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS_IDNOMBRE]

AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
       
      
  FROM [dbo].[SERVICIOS]
    WHERE [ID_Servicios]=1 or [ID_Servicios]=2 or [ID_Servicios]=3 or [ID_Servicios]=4
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_SERVICIOS_VACUNAS_IDNOMBRE]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_CONSULTAR_SERVICIOS_VACUNAS_IDNOMBRE]

AS
BEGIN
SELECT [ID_Servicios]
      ,[Nombre]
       
      
  FROM [dbo].[SERVICIOS]
    WHERE [ID_Servicios] BETWEEN  5 AND 12
	
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_todos_articulos]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultar_todos_articulos]
as
begin
	select * from dbo.SOLICITUD_ARTICULOS;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CREAR_ARTICULOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CREAR_ARTICULOS]
(
@Nombre varchar(20),
@Descripcion varchar(100),
@Precio decimal(10,2),
@Estado int
)
AS
BEGIN
INSERT INTO [dbo].[ARTICULOS]
           ([Nombre]
           ,[Descripcion]
           ,[Precio]
           ,[Estado])
     VALUES
           (@Nombre
           ,@Descripcion
           ,@Precio
           ,@Estado)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CREAR_CAJAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CREAR_CAJAS]
(
@ID_Personal int,
@Nombre varchar(50),
@Descripcion varchar(50),
@Estado int
)
AS
BEGIN
INSERT INTO [dbo].[CAJAS]
           ([ID_Personal]
           ,[Nombre]
           ,[Descripcion]
           ,[Estado])
     VALUES
           (1,'Caja1','Caja1',22 )

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CREAR_ingreso_suministro]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CREAR_ingreso_suministro]
(
@ID_Solicitud_Articulos int,
@ID_Articulo_Proveedor int,
@ID_Solicitud_Compra int,
@Cantidad decimal(10,2),
@Descripcion varchar(100)
)
AS
BEGIN
INSERT INTO [dbo].[SOLICITUD_ARTICULOS]
           ([ID_Solicitud_Articulos]
		   ,[ID_Articulo_Proveedor]
		   ,[ID_Solicitud_Compra]
           ,[Cantidad]
		   ,[Descripcion]
		    )
     VALUES
           (
			@ID_Solicitud_Articulos,
			@ID_Articulo_Proveedor,
			@ID_Solicitud_Compra ,
			@Cantidad ,
			@Descripcion
			)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CREAR_INVENTARIO]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CREAR_INVENTARIO]
(

@ID_ARTICULO int,
@Cantidad decimal,
@Estado int
)
AS
BEGIN
INSERT INTO [dbo].[INVENTARIO]
           ([ID_Articulos]
           ,[Cantidad]
    
           ,[Estado])
     VALUES
           (@ID_ARTICULO
           ,@Cantidad
           
           ,@Estado)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CREAR_MASCOTA]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_CREAR_MASCOTA]
(
@IdCliente int,
@Nombre varchar(50),
@Tipo int,
@Raza varchar(50),
@Sexo varchar(30),
@Estado int
)
AS
BEGIN
INSERT INTO [dbo].[MASCOTAS]
           ([ID_Cliente]
           ,[Nombre]
           ,[Tipo_Animal]
           ,[Raza]
		   ,[Sexo]
		   ,[Estado]
		   
		   )
     VALUES
           (@IdCliente ,
            @Nombre ,
            @Tipo ,
            @Raza ,
            @Sexo ,
            @Estado )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_IDRECLUTAMIENTO_POSTULANTES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------14

CREATE PROCEDURE [dbo].[SP_IDRECLUTAMIENTO_POSTULANTES]
AS
BEGIN
SELECT [ID_Reclutamiento],
       [Nombre]      
      
  FROM [dbo].[RECLUTAMIENTO]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INGRESO_SUMINISTROS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INGRESO_SUMINISTROS]
(
@ID_Articulo_Proveedor int,
@ID_Solicitud_Compra int,
@Descripcion varchar(100),
@Cantidad decimal(10,2),
@Encab varchar(100),
@estado int
)
AS
BEGIN
INSERT INTO [dbo].[SOLICITUD_COMPRA] (Encabezado,Estado) values (@Encab,@estado);
declare @a int;
select @a =  MAX(ID_Solicitud_Compra) from SOLICITUD_COMPRA;

INSERT INTO [dbo].[SOLICITUD_ARTICULOS]
           ([ID_Articulo_Proveedor]
		   ,[ID_Solicitud_Compra]
		   ,[Descripcion]
           ,[Cantidad]
		   
		    )
     VALUES
           (
			@ID_Articulo_Proveedor,
			@a,
			@Descripcion,
			@Cantidad 
			);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insertar_Cita]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--SP para crear citas

CREATE PROC [dbo].[SP_Insertar_Cita] 
@id_mascota int, 
@id_consultorio int,
@id_Motivo int,
@Fecha_Inicio date,
@Hora_Inicio time,
@Hora_Fin time,
@Estado int
AS
begin
INSERT INTO CITAS 
(ID_Mascota,ID_Consultorio,ID_Motivo_Cita,Fecha_Inicio,Fecha_Fin,Hora_Inicio,Hora_Fin,Estado)
values (@id_mascota,@id_consultorio,@id_Motivo,@Fecha_Inicio,@Fecha_Inicio,@Hora_Inicio,@Hora_Fin,@Estado)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_CREDITOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_CREDITOS]
(
@ID_Factura int,
@Monto_Anterior decimal,
@Monto_Actual decimal
)
AS
BEGIN
INSERT INTO [dbo].[CREDITOS]
           ([ID_Factura]
           ,[Monto_Anterior]
           ,[Monto_Actual])
     VALUES
           (@ID_Factura,@Monto_Anterior,@Monto_Actual)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLE_ARTICULOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE_ARTICULOS]
(

@ID_Factura int,
@ID_Articulos int,
@Cantidad decimal(10,2)

)
AS
BEGIN
INSERT INTO [dbo].[DETALLE_ARTICULOS]
           ([ID_Factura]
           ,[ID_Articulos]
           ,[Cantidad])
     VALUES
           (@ID_Factura,@ID_Articulos,@Cantidad)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_EXPRESS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_INSERTAR_EXPRESS]
(
@ID_Factura int, 
@Descripcion varchar(150),
@Estado int
)
AS
BEGIN
INSERT INTO [dbo].[SERVICIOS_EXPRESS]
           ([ID_Factura]
           ,[Descripcion]
           ,[Estado])
     VALUES
           (@ID_Factura,@Descripcion,@Estado)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Mascotas_Eliminar]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_Mascotas_Eliminar]
@idMascota varchar(15)
AS
BEGIN
	DELETE FROM MASCOTAS
	WHERE  ID_Mascota= @idMascota
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Modidicar_Cita]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SP para Modificar citas

CREATE PROC [dbo].[SP_Modidicar_Cita] 
@id_cita int,
@id_mascota int, 
@id_consultorio int,
@id_Motivo int,
@Fecha_Inicio date,
@Hora_Inicio time,
@Hora_Fin time,
@Estado int
AS
begin
UPDATE CITAS set
		ID_Mascota = @id_mascota,
		ID_Consultorio=@id_consultorio ,
		ID_Motivo_Cita=@id_Motivo,
		Fecha_Inicio=@Fecha_Inicio,
		Fecha_Fin=@Fecha_Inicio,
		Hora_Inicio=@Hora_Inicio,
		Hora_Fin= @Hora_Fin,
		Estado=@Estado
	WHERE ID_Cita = @id_cita
end
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_CREDITOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_CREDITOS]
(
@Cedula varchar(20),
@Credito int
)
AS
BEGIN
UPDATE [dbo].[CLIENTES]
   SET [Credito] = @Credito
 WHERE [Cedula]= @Cedula
 END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_ESTADO_CAJAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_ESTADO_CAJAS]
(
@ID_Caja int,
@ID_Estado int
)
AS
BEGIN
UPDATE [dbo].[CAJAS]
   SET[Estado]=@ID_Estado
 WHERE ID_Caja = @ID_Caja
 END
GO
/****** Object:  StoredProcedure [dbo].[SP_Modificar_Estado_Cita]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SP para modificar estado citas

CREATE PROC [dbo].[SP_Modificar_Estado_Cita] 
@id_cita int, 
@Estado int
AS
begin
update CITAS set Estado = @Estado where ID_Cita = @id_cita;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_modificar_estado_solicitud_compra]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_modificar_estado_solicitud_compra]
(@id int,
@estado int)
as
begin
update SOLICITUD_COMPRA set Estado = @estado where ID_Solicitud_Compra = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_EXPRESS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_EXPRESS]
(
@ID_Factura int,
@Estado int
)
AS
BEGIN
UPDATE [dbo].[SERVICIOS_EXPRESS]
   SET [Estado] = @Estado
 WHERE [ID_Factura]=@ID_Factura
 END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_FACTURAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_MODIFICAR_FACTURAS]
(
@Numero_Factura int,
@Estado int
)
AS
BEGIN
UPDATE [dbo].[FACTURAS]
   SET [Estado] = @Estado
 WHERE [Numero_Factura]=@Numero_Factura
 END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_INVENTARIO]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_INVENTARIO]
(
@ID_Articulos int,
@Cantidad decimal
)
AS
BEGIN
UPDATE [dbo].[INVENTARIO]
   SET [Cantidad] = @Cantidad   
   
 WHERE ID_Articulos= @ID_Articulos
 END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_MASCOTAS_PRECONSULTA]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_MASCOTAS_PRECONSULTA]
@id int,
@Tama decimal(10,2),
@Est int,
@Edad int,
@Peso decimal(10,2)

AS
BEGIN
	UPDATE MASCOTAS
	SET 
	Tamaño=@Tama,
    Estado=@Est,
	
	Edad=@Edad,
	Peso=@Peso
  --  Estado=@Estado
	WHERE ID_MASCOTA = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_PARTICIPANTES]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------------------------------------------------------------------------17

CREATE PROCEDURE [dbo].[SP_MODIFICAR_PARTICIPANTES]
@Reclutamiento int,
@Ced varchar(20),
@Nomb varchar(30),
@Apell1 varchar(30),
@Apell2 varchar (30),
@Corre varchar (100),
@Tel varchar (8),
@Provincia int,
@Canton int,
@Distrito int,
@Direc varchar (150),
@Est int
AS
BEGIN
	SET NOCOUNT ON;
	Update PARTICIPANTES 
	Set ID_Reclutamiento = @Reclutamiento, Cedula_ =  @Ced, Nombre = @Nomb, Apellido_1 = @Apell1,
    Apellido_2 = @Apell2, Correo = @Corre, Telefono = @Tel, ID_Provincia = @Provincia,
    ID_Canton = @Canton, ID_Distrito = @Distrito, Direccion = @Direc, Estado = @Est
	where ID_Reclutamiento = @Reclutamiento
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_PERSONAL]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
-----------------------------------------------------------------------6

CREATE PROCEDURE [dbo].[SP_MODIFICAR_PERSONAL]
@ID_Personal int,
@ID_Puesto int,
@Cedula varchar(20),
@Nombre varchar(30),
@Apellido_1 varchar(30),
@Apellido_2 varchar(30),
@Salario_Hora decimal(10,2),
@Salario_Mensual decimal(10,2),
@Fecha_Contratacion date,
@Estado int,
@Direccion varchar(150),
@Correo_Electronico varchar(50),
@Telefono varchar(50)
AS
BEGIN
	Update PERSONAL
	Set ID_Puesto = @ID_Puesto, Cedula = @Cedula, Nombre = @Nombre, Apellido_1 = @Apellido_1, Apellido_2 
	= @Apellido_2, Salario_Hora = @Salario_Hora, Salario_Mensual = @Salario_Mensual, Fecha_Contratacion 
	= @Fecha_Contratacion, Estado = @Estado, Direccion = @Direccion, Correo_Electronico = @Correo_Electronico,
	Telefono = @Telefono
	where ID_Personal = @ID_Personal
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_PRUEBAS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------------------25

CREATE PROCEDURE [dbo].[SP_MODIFICAR_PRUEBAS]
@ID_Pruebas int,
@Nombre varchar (30),
@Descripcion varchar(100)
AS
BEGIN
	Update PRUEBAS
	Set Nombre = @Nombre, Descripcion = @Descripcion
	where ID_Pruebas = @ID_Pruebas
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_RECLUTAMIENTO]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MODIFICAR_RECLUTAMIENTO]
@ID_Puestos int,
@Nombre varchar (30),
@Descripcion varchar(100),
@Estado int
AS
BEGIN
	Update RECLUTAMIENTO
	Set Nombre = @Nombre, Descripcion = @Descripcion, Estado = @Estado
	where ID_Puestos = @ID_Puestos
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_USUARIOS]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------------------------------16

CREATE PROCEDURE [dbo].[SP_MODIFICAR_USUARIOS]
@ID_Usuario int,
@ID_Personal int,
@UserName varchar(20),
@Pass varchar(20),
@Estado int
AS
BEGIN
	Update USUARIOS
	Set ID_Personal = @ID_Personal, UserName = @UserName, Pass = @Pass,  Estado = @Estado
	where ID_Usuario = @ID_Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PA_NotasIdParticipantes]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------19

CREATE PROCEDURE [dbo].[SP_PA_NotasIdParticipantes]
AS
BEGIN
SELECT [ID_Participantes],
       [Cedula_]      
      
  FROM [dbo].[PARTICIPANTES]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PA_NotasIdPruebas]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------------------------18

CREATE PROCEDURE [dbo].[SP_PA_NotasIdPruebas]
AS
BEGIN
SELECT [ID_Pruebas],
       [Nombre]      
      
  FROM [dbo].[PRUEBAS]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PA_Tipo_Cargo]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------26

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Cargo]
AS
BEGIN
SELECT [ID_Puestos]
      ,[Nombre]      
      
  FROM [dbo].[PUESTOS]
   WHERE [ID_Puestos]= 1 OR [ID_Puestos]= 2 OR [ID_Puestos]= 3 OR [ID_Puestos]= 4
   OR [ID_Puestos]= 5 OR [ID_Puestos]= 6 OR [ID_Puestos]= 7 OR [ID_Puestos]= 8
    OR [ID_Puestos]= 9 OR [ID_Puestos]= 10 OR [ID_Puestos]= 11 OR [ID_Puestos]= 12
	 OR [ID_Puestos]= 13 OR [ID_Puestos]= 14 OR [ID_Puestos]= 15 OR [ID_Puestos]= 16
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PA_Tipo_Estado]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------------------------27

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Estado]

AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 11 OR [ID_Estados]= 15 OR [ID_Estados]= 16 OR [ID_Estados]= 17
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PA_Tipo_Estado_Personal]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------------------7

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Estado_Personal]
AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 5 OR [ID_Estados]= 6 OR [ID_Estados]= 7
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PA_Tipo_Estado_Postulantes]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------15

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Estado_Postulantes]
AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 18 OR [ID_Estados]= 19
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PA_Tipo_Estado_Usuario]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------------------------9

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Estado_Usuario]
AS
BEGIN
SELECT [ID_Estados]
      ,[Nombre]      
      
  FROM [dbo].[ESTADOS]
   WHERE [ID_Estados]= 8 OR [ID_Estados]= 9 OR [ID_Estados]= 10
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PA_Tipo_Puesto]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------------------------------------------------28

CREATE PROCEDURE [dbo].[SP_PA_Tipo_Puesto]

AS
BEGIN
SELECT [ID_Departamento]
      ,[Nombre]      
      
  FROM [dbo].[DEPARTAMENTOS]
   WHERE [ID_Departamento]= 1 OR [ID_Departamento]= 2 OR [ID_Departamento]= 3 OR [ID_Departamento]= 4
   OR [ID_Departamento]= 5 OR [ID_Departamento]= 6 OR [ID_Departamento]= 7 OR [ID_Departamento]= 8
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PA_USUARIOIDPERSONAL]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------8

CREATE PROCEDURE [dbo].[SP_PA_USUARIOIDPERSONAL]
AS
BEGIN
SELECT [ID_Personal],
       [Cedula]      
      
  FROM [dbo].[PERSONAL]
END
GO
/****** Object:  StoredProcedure [dbo].[sp_solicitudes_aprovadas]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_solicitudes_aprovadas]
as
begin
select sc.ID_Solicitud_Compra,sc.Encabezado,sc.Descripcion,p.Nombre from SOLICITUD_COMPRA sc, SOLICITUD_ARTICULOS sa, PROVEEDOR p, ARTICULOS_PROVEEDOR ap
	where (sc.ID_Solicitud_Compra = sa.ID_Solicitud_Compra and ap.ID_Articulos_Proveedor = sa.ID_Articulo_Proveedor and ap.ID_Proveedor = p.ID_Proveedor)
		and sc.Estado = 20;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Vista_Factura]    Script Date: 9/4/2020 6:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_Vista_Factura]
(@Factura INT)
AS
BEGIN
	SELECT 
		cl.Nombre, 
		cl.Apellido_1, 
		cl.Apellido_2, 
		fa.Fecha, 
		fa.Numero_Factura, 
		ar.Nombre, 
		ar.Precio, 
		da.Cantidad, 
		fa.Total 

FROM FACTURAS AS fa inner join DETALLE_ARTICULOS AS da on fa.Numero_Factura = da.ID_Factura 
					inner join ARTICULOS AS ar on ar.ID_Articulos = da.ID_Articulos
					inner join CLIENTES AS cl on fa.ID_Cliente = cl.ID_Cliente
where fa.Numero_Factura = @Factura
END
GO
