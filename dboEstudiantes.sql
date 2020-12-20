USE [Estudiantes]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 20/12/2020 13:33:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[cedula] [varchar](10) NOT NULL,
	[apellidos] [varchar](30) NULL,
	[nombres] [varchar](30) NULL,
	[sexo] [varchar](1) NULL,
	[fechaNacimiento] [date] NULL,
	[correo] [varchar](80) NULL,
	[estatura] [int] NULL,
	[peso] [numeric](6, 2) NULL,
	[fechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Personas] ([cedula], [apellidos], [nombres], [sexo], [fechaNacimiento], [correo], [estatura], [peso], [fechaCreacion]) VALUES (N'0520369050', N'Gonzales Lopez', N'Maria Jose', N'M', CAST(N'2001-12-17' AS Date), N'asdasda@hotmail.com', 180, CAST(80.00 AS Numeric(6, 2)), CAST(N'2020-12-17T19:08:56.470' AS DateTime))
GO
INSERT [dbo].[Personas] ([cedula], [apellidos], [nombres], [sexo], [fechaNacimiento], [correo], [estatura], [peso], [fechaCreacion]) VALUES (N'0800000009', N'De la Cruz', N'Marta', N'F', CAST(N'2000-10-10' AS Date), N'maria@hotmail.com', 170, CAST(65.55 AS Numeric(6, 2)), CAST(N'2020-12-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Personas] ([cedula], [apellidos], [nombres], [sexo], [fechaNacimiento], [correo], [estatura], [peso], [fechaCreacion]) VALUES (N'0800000021', N'Gaspar Vera', N'Bryan Jr', N'M', CAST(N'2002-04-02' AS Date), N'byran@hotmail.com', 175, CAST(907.00 AS Numeric(6, 2)), CAST(N'2020-12-17T12:45:18.720' AS DateTime))
GO
INSERT [dbo].[Personas] ([cedula], [apellidos], [nombres], [sexo], [fechaNacimiento], [correo], [estatura], [peso], [fechaCreacion]) VALUES (N'0820369010', N'Pele pele', N'jose jose', N'M', CAST(N'1999-12-18' AS Date), N'asdasda@asdas.com', 180, CAST(80.00 AS Numeric(6, 2)), CAST(N'2020-12-18T19:41:46.080' AS DateTime))
GO
INSERT [dbo].[Personas] ([cedula], [apellidos], [nombres], [sexo], [fechaNacimiento], [correo], [estatura], [peso], [fechaCreacion]) VALUES (N'0850594573', N'Gonzales Perez', N'Jose Jose', N'M', CAST(N'2002-12-17' AS Date), N'asdad@hotmail.com', 185, CAST(80.00 AS Numeric(6, 2)), CAST(N'2020-12-17T16:50:06.977' AS DateTime))
GO
ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [DF_Personas_fechaCreacion]  DEFAULT (getdate()) FOR [fechaCreacion]
GO
