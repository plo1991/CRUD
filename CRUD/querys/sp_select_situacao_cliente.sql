CREATE PROCEDURE [dbo].[sp_select_situacao_cliente]
@situacao_cliente varchar(50)
AS
BEGIN
select * from tb_situacao_cliente where situacao_cliente = @situacao_cliente 
END