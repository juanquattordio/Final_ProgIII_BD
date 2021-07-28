USE [prg3]
GO
/****** Object:  Table [dbo].[direcciones]    Script Date: 28/07/2021 0:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[direcciones](
	[id_dir] [int] IDENTITY(1,1) NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[ciudad] [nvarchar](50) NOT NULL,
	[provincia] [nvarchar](50) NOT NULL,
	[codigo_postal] [int] NOT NULL,
	[pais] [nvarchar](50) NOT NULL,
	[calle] [nvarchar](50) NOT NULL,
	[numero] [int] NOT NULL,
	[baja] [bit] NULL,
 CONSTRAINT [PK_direcciones] PRIMARY KEY CLUSTERED 
(
	[id_dir] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marcas]    Script Date: 28/07/2021 0:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marcas](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
	[baja] [bit] NULL,
 CONSTRAINT [PK_marcas] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[precios]    Script Date: 28/07/2021 0:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[precios](
	[id_precio] [int] IDENTITY(1,1) NOT NULL,
	[id_prod] [int] NOT NULL,
	[id_prov] [int] NOT NULL,
	[nombre_prov] [nvarchar](50) NULL,
	[id_marca] [int] NOT NULL,
	[nombre_marca] [nvarchar](50) NULL,
	[moneda] [nchar](10) NULL,
	[moneda_desc] [nvarchar](50) NOT NULL,
	[precio_valor] [float] NOT NULL,
	[precio_fecha] [nvarchar](50) NOT NULL,
	[baja] [bit] NULL,
 CONSTRAINT [PK_precios] PRIMARY KEY CLUSTERED 
(
	[id_precio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 28/07/2021 0:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[id_prod] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[precio_venta] [float] NULL,
	[marca] [varchar](100) NULL,
	[proveedores] [varchar](50) NULL,
	[baja] [bit] NOT NULL,
 CONSTRAINT [PK_productos] PRIMARY KEY CLUSTERED 
(
	[id_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 28/07/2021 0:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](50) NULL,
	[telefono] [nchar](10) NULL,
	[tipo_prov] [nvarchar](50) NOT NULL,
	[cuit] [nvarchar](50) NULL,
	[ibb] [nvarchar](50) NULL,
	[DNI] [nvarchar](50) NULL,
	[baja] [bit] NULL,
 CONSTRAINT [PK_proveedores] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sucursales]    Script Date: 28/07/2021 0:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sucursales](
	[id_suc] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[baja] [char](1) NULL,
 CONSTRAINT [PK_sucursales] PRIMARY KEY CLUSTERED 
(
	[id_suc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[telefonos]    Script Date: 28/07/2021 0:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[telefonos](
	[id_tel] [int] IDENTITY(1,1) NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[codigo_area] [int] NOT NULL,
	[telefono] [int] NOT NULL,
	[baja] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 28/07/2021 0:51:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](25) NOT NULL,
	[password] [nvarchar](150) NOT NULL,
	[last_login] [date] NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[direcciones] ON 

INSERT [dbo].[direcciones] ([id_dir], [id_proveedor], [ciudad], [provincia], [codigo_postal], [pais], [calle], [numero], [baja]) VALUES (1, 2, N'Rafaela', N'Santa Fe', 2300, N'Argetina', N'Los Cedros', 21, 1)
INSERT [dbo].[direcciones] ([id_dir], [id_proveedor], [ciudad], [provincia], [codigo_postal], [pais], [calle], [numero], [baja]) VALUES (2, 2, N'Rafaela', N'Santa Fe', 2300, N'Argentina', N'Madrid', 1067, 0)
INSERT [dbo].[direcciones] ([id_dir], [id_proveedor], [ciudad], [provincia], [codigo_postal], [pais], [calle], [numero], [baja]) VALUES (3, 2, N'Sunchales', N'Santa Fe', 2300, N'Argentina', N'Sarmiento', 22, 1)
INSERT [dbo].[direcciones] ([id_dir], [id_proveedor], [ciudad], [provincia], [codigo_postal], [pais], [calle], [numero], [baja]) VALUES (4, 2, N'dsad', N'dasd', 230, N'asdad', N'dasd', 12, 0)
INSERT [dbo].[direcciones] ([id_dir], [id_proveedor], [ciudad], [provincia], [codigo_postal], [pais], [calle], [numero], [baja]) VALUES (5, 3, N'Rafa', N'sadsad', 456, N'asdsad', N'asdsa', 45, 0)
INSERT [dbo].[direcciones] ([id_dir], [id_proveedor], [ciudad], [provincia], [codigo_postal], [pais], [calle], [numero], [baja]) VALUES (6, 2, N'sadasd', N'asd', 123, N'asd', N'asd', 12, 0)
INSERT [dbo].[direcciones] ([id_dir], [id_proveedor], [ciudad], [provincia], [codigo_postal], [pais], [calle], [numero], [baja]) VALUES (7, 3, N's', N's', 3, N'd', N'1', 2, 1)
INSERT [dbo].[direcciones] ([id_dir], [id_proveedor], [ciudad], [provincia], [codigo_postal], [pais], [calle], [numero], [baja]) VALUES (8, 2, N'321', N'321', 312, N'132', N'132', 132, 0)
INSERT [dbo].[direcciones] ([id_dir], [id_proveedor], [ciudad], [provincia], [codigo_postal], [pais], [calle], [numero], [baja]) VALUES (9, 2, N'2', N'2', 123, N'321', N'wqe', 123, 0)
INSERT [dbo].[direcciones] ([id_dir], [id_proveedor], [ciudad], [provincia], [codigo_postal], [pais], [calle], [numero], [baja]) VALUES (1003, 10, N'Hong Kong', N'KN', 234, N'Japon', N'Ji-pin', 21, 1)
SET IDENTITY_INSERT [dbo].[direcciones] OFF
GO
SET IDENTITY_INSERT [dbo].[marcas] ON 

INSERT [dbo].[marcas] ([id_marca], [nombre], [descripcion], [baja]) VALUES (1, N'SKF', N'Rodamientos', 1)
INSERT [dbo].[marcas] ([id_marca], [nombre], [descripcion], [baja]) VALUES (2, N'IKO', N'Rodamientos', 0)
INSERT [dbo].[marcas] ([id_marca], [nombre], [descripcion], [baja]) VALUES (3, N'Lubrind', N'Lubricante aerosol', 1)
INSERT [dbo].[marcas] ([id_marca], [nombre], [descripcion], [baja]) VALUES (4, N'Legget & Platt', N'Costura', 1)
INSERT [dbo].[marcas] ([id_marca], [nombre], [descripcion], [baja]) VALUES (5, N'Fecken', N'Cuchillas corte', 0)
INSERT [dbo].[marcas] ([id_marca], [nombre], [descripcion], [baja]) VALUES (6, N'Atlanta', N'Costura', 0)
INSERT [dbo].[marcas] ([id_marca], [nombre], [descripcion], [baja]) VALUES (1004, N'Lian Rou', N'Maquinarias', 1)
INSERT [dbo].[marcas] ([id_marca], [nombre], [descripcion], [baja]) VALUES (1005, N'Bea', N'Engrampadoras', 1)
SET IDENTITY_INSERT [dbo].[marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[precios] ON 

INSERT [dbo].[precios] ([id_precio], [id_prod], [id_prov], [nombre_prov], [id_marca], [nombre_marca], [moneda], [moneda_desc], [precio_valor], [precio_fecha], [baja]) VALUES (7, 1, 1, NULL, 1, NULL, NULL, N'Peso', 12, N'21072021', 1)
INSERT [dbo].[precios] ([id_precio], [id_prod], [id_prov], [nombre_prov], [id_marca], [nombre_marca], [moneda], [moneda_desc], [precio_valor], [precio_fecha], [baja]) VALUES (8, 1, 3, NULL, 3, NULL, NULL, N'Dolar', 15, N'15172021', 1)
INSERT [dbo].[precios] ([id_precio], [id_prod], [id_prov], [nombre_prov], [id_marca], [nombre_marca], [moneda], [moneda_desc], [precio_valor], [precio_fecha], [baja]) VALUES (9, 1, 2, N'Vitulich', 1, N'SKF', NULL, N'Peso', 28, N'15072021', 1)
INSERT [dbo].[precios] ([id_precio], [id_prod], [id_prov], [nombre_prov], [id_marca], [nombre_marca], [moneda], [moneda_desc], [precio_valor], [precio_fecha], [baja]) VALUES (10, 1, 3, N'Limansky', 4, N'Legget & Platt', NULL, N'Dolar', 50, N'12072021', 0)
INSERT [dbo].[precios] ([id_precio], [id_prod], [id_prov], [nombre_prov], [id_marca], [nombre_marca], [moneda], [moneda_desc], [precio_valor], [precio_fecha], [baja]) VALUES (11, 9, 10, N'Lian Rou', 1004, N'Lian Rou', NULL, N'Euro', 8, N'12072021', 1)
INSERT [dbo].[precios] ([id_precio], [id_prod], [id_prov], [nombre_prov], [id_marca], [nombre_marca], [moneda], [moneda_desc], [precio_valor], [precio_fecha], [baja]) VALUES (12, 10, 11, N'Bea', 1005, N'Bea', NULL, N'Franco Suizo', 12, N'12072019', 1)
SET IDENTITY_INSERT [dbo].[precios] OFF
GO
SET IDENTITY_INSERT [dbo].[productos] ON 

INSERT [dbo].[productos] ([id_prod], [nombre], [descripcion], [precio_venta], [marca], [proveedores], [baja]) VALUES (1, N'Aguja 90/40', N'Utilizada en máquinas cerradoras Atlanta', 1, N'GrozBecker', N'D', 1)
INSERT [dbo].[productos] ([id_prod], [nombre], [descripcion], [precio_venta], [marca], [proveedores], [baja]) VALUES (5, N'Rodamiento 3202 ZZ', N'Rodamiento de bolas número 3202 con sello', 2, N'SKF', N'V', 1)
INSERT [dbo].[productos] ([id_prod], [nombre], [descripcion], [precio_venta], [marca], [proveedores], [baja]) VALUES (6, N'Aceite 15W40', N'Aceite multiuso', 2, N'3M', N'E', 0)
INSERT [dbo].[productos] ([id_prod], [nombre], [descripcion], [precio_venta], [marca], [proveedores], [baja]) VALUES (7, N'Rueda 8"', N'Rueda para carro', NULL, NULL, NULL, 1)
INSERT [dbo].[productos] ([id_prod], [nombre], [descripcion], [precio_venta], [marca], [proveedores], [baja]) VALUES (8, N'Vaina teflonada', N'Vaina de cuchilla calesita', NULL, NULL, NULL, 1)
INSERT [dbo].[productos] ([id_prod], [nombre], [descripcion], [precio_venta], [marca], [proveedores], [baja]) VALUES (9, N'Cuchilla 8450', N'Cuchilla calesita', NULL, NULL, NULL, 1)
INSERT [dbo].[productos] ([id_prod], [nombre], [descripcion], [precio_venta], [marca], [proveedores], [baja]) VALUES (10, N'Blade 90/40', N'Espada para engrampadora', NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[productos] OFF
GO
SET IDENTITY_INSERT [dbo].[proveedores] ON 

INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [telefono], [tipo_prov], [cuit], [ibb], [DNI], [baja]) VALUES (1, N'Lagger', N'1', N'1         ', N'mayorista', N'20354631378', N'0111111111', N'', 1)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [telefono], [tipo_prov], [cuit], [ibb], [DNI], [baja]) VALUES (2, N'Vitulich', N'2', N'2         ', N'Minorista', N'', N'', N'35463139', 1)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [telefono], [tipo_prov], [cuit], [ibb], [DNI], [baja]) VALUES (3, N'Limansky', N'sdsda', N'451       ', N'Mayorista', N'35431256', N'6548491321', N'', 1)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [telefono], [tipo_prov], [cuit], [ibb], [DNI], [baja]) VALUES (4, N'Ferretería barrio', N'Madrid 79', N'45132     ', N'Mayorista', N'2035463137', N'156', N'', 0)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [telefono], [tipo_prov], [cuit], [ibb], [DNI], [baja]) VALUES (5, N'Andretich', N'Lomas 152', N'231313    ', N'Minorista', N'', N'', N'54546', 0)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [telefono], [tipo_prov], [cuit], [ibb], [DNI], [baja]) VALUES (9, N'Gomplastica', N'', N'          ', N'', N'', N'', N'', 0)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [telefono], [tipo_prov], [cuit], [ibb], [DNI], [baja]) VALUES (10, N'Lian Rou', NULL, NULL, N'Mayorista', N'15151515', N'12121212', N'', 1)
INSERT [dbo].[proveedores] ([id_proveedor], [nombre], [direccion], [telefono], [tipo_prov], [cuit], [ibb], [DNI], [baja]) VALUES (11, N'Bea', NULL, NULL, N'Mayorista', N'1232', N'213123', N'', 1)
SET IDENTITY_INSERT [dbo].[proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[sucursales] ON 

INSERT [dbo].[sucursales] ([id_suc], [nombre], [baja]) VALUES (1, N'Susana', N'N')
INSERT [dbo].[sucursales] ([id_suc], [nombre], [baja]) VALUES (2, N'Sunchales2', N'S')
INSERT [dbo].[sucursales] ([id_suc], [nombre], [baja]) VALUES (3, N'Maria Susana', N'S')
INSERT [dbo].[sucursales] ([id_suc], [nombre], [baja]) VALUES (4, N'Lehmann', N'N')
INSERT [dbo].[sucursales] ([id_suc], [nombre], [baja]) VALUES (5, N'San Carlos', N'N')
INSERT [dbo].[sucursales] ([id_suc], [nombre], [baja]) VALUES (6, N'Pilar', N'N')
INSERT [dbo].[sucursales] ([id_suc], [nombre], [baja]) VALUES (7, N'Roca', N'N')
SET IDENTITY_INSERT [dbo].[sucursales] OFF
GO
SET IDENTITY_INSERT [dbo].[telefonos] ON 

INSERT [dbo].[telefonos] ([id_tel], [id_proveedor], [codigo_area], [telefono], [baja]) VALUES (1, 2, 3492, 451736, 1)
INSERT [dbo].[telefonos] ([id_tel], [id_proveedor], [codigo_area], [telefono], [baja]) VALUES (2, 2, 3492, 451737, 0)
INSERT [dbo].[telefonos] ([id_tel], [id_proveedor], [codigo_area], [telefono], [baja]) VALUES (3, 2, 341, 501234, 1)
INSERT [dbo].[telefonos] ([id_tel], [id_proveedor], [codigo_area], [telefono], [baja]) VALUES (4, 3, 342, 456123, 1)
INSERT [dbo].[telefonos] ([id_tel], [id_proveedor], [codigo_area], [telefono], [baja]) VALUES (5, 3, 341, 4567894, 0)
INSERT [dbo].[telefonos] ([id_tel], [id_proveedor], [codigo_area], [telefono], [baja]) VALUES (6, 2, 342, 151513, 0)
INSERT [dbo].[telefonos] ([id_tel], [id_proveedor], [codigo_area], [telefono], [baja]) VALUES (7, 3, 342, 451455, 0)
INSERT [dbo].[telefonos] ([id_tel], [id_proveedor], [codigo_area], [telefono], [baja]) VALUES (8, 3, 412, 412, 1)
INSERT [dbo].[telefonos] ([id_tel], [id_proveedor], [codigo_area], [telefono], [baja]) VALUES (9, 2, 123, 12321312, 0)
INSERT [dbo].[telefonos] ([id_tel], [id_proveedor], [codigo_area], [telefono], [baja]) VALUES (10, 2, 123, 123, 0)
SET IDENTITY_INSERT [dbo].[telefonos] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_user], [usuario], [password], [last_login]) VALUES (3, N'admin2', N'䋈郃ꡙ랚葽�হ', CAST(N'2021-06-29' AS Date))
INSERT [dbo].[usuarios] ([id_user], [usuario], [password], [last_login]) VALUES (4, N'admin', N'⌡⤯坺ꞥ襃๊聊쌟', CAST(N'2021-06-29' AS Date))
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
