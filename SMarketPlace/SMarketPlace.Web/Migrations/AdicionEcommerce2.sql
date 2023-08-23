/****** Object:  Table [dbo].[PROMOCIONESC2SSMP]    Script Date: 6/1/2023 7:22:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROMOCIONESALERTA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ID_PROMOCION] [varchar](500) NULL,
	[MAP_COD] [varchar](500) NULL,
	[NRO_LOCAL] [varchar](500) NULL,
	[MECANICA] [varchar](500) NULL,
	[DESCRIPCION_PROMOCION] [varchar](500) NULL,
	[CANTIDAD_BENEFICIO] [varchar](500) NULL,
	[CANTIDAD_REQUISITO] [varchar](500) NULL,
	[BENEFICIO] [varchar](500) NULL,
	[INICIO_VIGENCIA] [varchar](500) NULL,
	[FIN_VIGENCIA] [varchar](500) NULL,
	[MOSTRAR_PRECIO_REBAJADO] [varchar](500) NULL,
	[ALCANCEAS] [varchar](500) NULL,
	[ZONA_VISUALIZACION] [varchar](500) NULL,
	[DESCRIPCION_CORTA] [varchar](500) NULL,
	[Lealtad_Codigo_Acumula] [varchar](500) NULL,
	[Lealtad_limite_piezas] [varchar](500) NULL,
	[Lealtad_limite_periodicidad] [varchar](500) NULL
) ON [PRIMARY]
GO
