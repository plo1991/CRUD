CREATE PROCEDURE [dbo].[sp_excluir_cliente]
@codigo int
AS
BEGIN
delete from tb_cliente where codigo=@codigo
END