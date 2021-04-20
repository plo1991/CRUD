CREATE PROCEDURE [dbo].[sp_atualizar_cliente]
@codigo int,
@nome varchar(50),
@cpf varchar(50),
@tipo_cliente int,
@sexo varchar(50),
@situacao_cliente int
AS
BEGIN
update tb_cliente set nome=@nome,cpf=@cpf,tipo_cliente=@tipo_cliente,sexo=@sexo,situacao_cliente=@situacao_cliente where codigo=@codigo
END