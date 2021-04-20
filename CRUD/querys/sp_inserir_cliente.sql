CREATE PROCEDURE [dbo].[sp_inserir_cliente]
@nome varchar(50),
@cpf varchar(50),
@tipo_cliente int,
@sexo varchar(50),
@situacao_cliente int
AS
BEGIN
INSERT INTO tb_cliente(nome,cpf,tipo_cliente,sexo,situacao_cliente) VALUES(@nome,@cpf,@tipo_cliente,@sexo,@situacao_cliente)
END