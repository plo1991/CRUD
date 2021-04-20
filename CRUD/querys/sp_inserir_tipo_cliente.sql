CREATE PROCEDURE [dbo].[sp_inserir_tipo_cliente]
@tipo_cliente varchar(50)
AS
BEGIN
INSERT INTO tb_tipo_cliente(tipo_cliente) VALUES(@tipo_cliente)
END