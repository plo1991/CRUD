CREATE TABLE [dbo].[tb_cliente](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](14) NOT NULL,
	[tipo_cliente] [int] NOT NULL,
	[sexo] [varchar](15) NOT NULL,
	[situacao_cliente] [int] NOT NULL,
 CONSTRAINT [PK_tb_cliente] PRIMARY KEY CLUSTERED([codigo]))

ALTER TABLE [dbo].[tb_cliente]  WITH CHECK ADD  CONSTRAINT [FK_tb_situacao_cliente] FOREIGN KEY([situacao_cliente])
REFERENCES [dbo].[tb_situacao_cliente] ([codigo])

ALTER TABLE [dbo].[tb_cliente] CHECK CONSTRAINT [FK_tb_situacao_cliente]

ALTER TABLE [dbo].[tb_cliente]  WITH CHECK ADD  CONSTRAINT [FK_tb_tipo_cliente] FOREIGN KEY([tipo_cliente])
REFERENCES [dbo].[tb_tipo_cliente] ([codigo])

ALTER TABLE [dbo].[tb_cliente] CHECK CONSTRAINT [FK_tb_tipo_cliente]