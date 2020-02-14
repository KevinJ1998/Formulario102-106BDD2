USE [FORM102A]
GO
/****** Object:  Table [dbo].[Auditoria]    Script Date: 13/2/2020 21:58:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auditoria](
	[id_auditoria] [int] IDENTITY(1,1) NOT NULL,
	[usuario_au] [varchar](20) NULL,
	[tabla] [varchar](20) NULL,
	[accion] [varchar](20) NOT NULL,
	[fecha_hora] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_auditoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contribuyente]    Script Date: 13/2/2020 21:58:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contribuyente](
	[id_contr] [int] IDENTITY(1,1) NOT NULL,
	[ruc_contr] [varchar](20) NOT NULL,
	[razonSocial_contr] [varchar](20) NOT NULL,
	[saldo_contr] [numeric](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_contr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[F106]    Script Date: 13/2/2020 21:58:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F106](
	[id_pago_imp] [int] IDENTITY(1,1) NOT NULL,
	[cod_doc] [varchar](15) NOT NULL,
	[ciudad] [varchar](20) NULL,
	[anio] [varchar](10) NULL,
	[mes] [varchar](10) NULL,
	[descripcion_pago] [varchar](100) NULL,
	[total_pago] [numeric](5, 2) NULL,
	[id_contrFK] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pago_imp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gastos]    Script Date: 13/2/2020 21:58:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gastos](
	[id_gast] [int] IDENTITY(1,1) NOT NULL,
	[id_contrFK] [int] NOT NULL,
	[valor_gast] [numeric](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_gast] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingresos]    Script Date: 13/2/2020 21:58:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingresos](
	[id_ingre] [int] IDENTITY(1,1) NOT NULL,
	[id_contrFK] [int] NOT NULL,
	[valor_ingre] [numeric](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ingre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DatosAlmacenados]    Script Date: 13/2/2020 21:58:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DatosAlmacenados]
as
select C.id_contr, C.razonSocial_contr, C.ruc_contr, C.saldo_contr, cod_doc, ciudad, anio, mes, descripcion_pago,total_pago 
from contribuyente C, F106 where id_contr= id_contrFK
GO
ALTER TABLE [dbo].[F106]  WITH CHECK ADD FOREIGN KEY([id_contrFK])
REFERENCES [dbo].[contribuyente] ([id_contr])
GO
ALTER TABLE [dbo].[gastos]  WITH CHECK ADD FOREIGN KEY([id_contrFK])
REFERENCES [dbo].[contribuyente] ([id_contr])
GO
ALTER TABLE [dbo].[ingresos]  WITH CHECK ADD FOREIGN KEY([id_contrFK])
REFERENCES [dbo].[contribuyente] ([id_contr])
GO
