CREATE TABLE [dbo].[tb_tipo_cliente](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[tipo_cliente] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tb_tipo_cliente] PRIMARY KEY CLUSTERED([codigo])) 
