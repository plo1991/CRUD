CREATE PROCEDURE [dbo].[sp_select_tipo_cliente]
@tipo_cliente varchar(50)
AS
BEGIN
select * from tb_tipo_cliente where tipo_cliente = @tipo_cliente 
END