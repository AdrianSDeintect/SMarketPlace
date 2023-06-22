USE [SMP]
GO

/****** Object:  Table [dbo].[LogProductosMP]    Script Date: 6/19/2023 4:48:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LogProductosEliminado](
	[intArticuloid] [int] NOT NULL,
	[tipoMP] [varchar](10) NOT NULL,
	[iEliminado] [int] NOT NULL,
	[dtRegistroUsr] [datetime] NOT NULL,
	[dtEliminacionInt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[intArticuloid] ASC,
	[tipoMP] ASC,
	[dtRegistroUsr] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LogProductosEliminado] ADD  DEFAULT (getdate()) FOR [dtRegistroUsr]
GO


