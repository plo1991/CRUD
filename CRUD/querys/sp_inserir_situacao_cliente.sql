Create PROCEDURE [dbo].[sp_inserir_situacao_cliente]
@situacao_cliente varchar(50)
AS
BEGIN
INSERT INTO tb_situacao_cliente(situacao_cliente) VALUES(@situacao_cliente)
END