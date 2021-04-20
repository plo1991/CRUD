CREATE PROCEDURE [dbo].[sp_selecionar_cliente]
@codigo int
AS
BEGIN
select * from tb_cliente where codigo=@codigo
END