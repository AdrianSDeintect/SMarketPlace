/****** Object:  Table [dbo].[tblproductosDidi]    Script Date: 5/22/2023 10:37:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LogProductosMP](
	[intArticuloid] [int] NOT NULL,
	[tipoMP] [varchar](10) NOT NULL,
	[dtRegistro] [datetime] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[intArticuloid] ASC,
	[dtRegistro] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LogProductosMP] ADD DEFAULT GETDATE() FOR dtRegistro


