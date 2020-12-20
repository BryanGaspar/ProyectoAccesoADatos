USE [Materias]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 20/12/2020 13:36:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[codMat] [varchar](10) NOT NULL,
	[nombreMateria] [varchar](50) NULL,
	[nivel] [int] NULL,
	[carrera] [varchar](50) NULL,
	[fechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_Materias] PRIMARY KEY CLUSTERED 
(
	[codMat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Materias] ([codMat], [nombreMateria], [nivel], [carrera], [fechaCreacion]) VALUES (N'0000000001', N'Calculo Diferencial', 2, N'TIC', CAST(N'2020-12-18T19:28:11.743' AS DateTime))
GO
INSERT [dbo].[Materias] ([codMat], [nombreMateria], [nivel], [carrera], [fechaCreacion]) VALUES (N'0202020202', N'Estructuras', 2, N'TIC', CAST(N'2020-12-18T19:40:27.733' AS DateTime))
GO
INSERT [dbo].[Materias] ([codMat], [nombreMateria], [nivel], [carrera], [fechaCreacion]) VALUES (N'1234567812', N'Física', 1, N'TIC', CAST(N'2020-12-20T13:11:37.513' AS DateTime))
GO
INSERT [dbo].[Materias] ([codMat], [nombreMateria], [nivel], [carrera], [fechaCreacion]) VALUES (N'1234567891', N'asdas', 10, N'asda', CAST(N'2020-12-20T13:08:14.080' AS DateTime))
GO
ALTER TABLE [dbo].[Materias] ADD  CONSTRAINT [DF_Materias_fechaCreacion]  DEFAULT (getdate()) FOR [fechaCreacion]
GO
