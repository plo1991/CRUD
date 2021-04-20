<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/mascara.js"></script>

<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Cadastro de Cliente</h3>
                    <br />
                    Nome do Cliente:
                    <br />
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Por favor digite o nome!" ForeColor="Red" />
                    <br />
                    <br />
                    CPF Cliente:<br />
                    <asp:TextBox ID="txtCPFCliente" onkeyup="formataCPF(this,event);" runat="server" placeholder="CPF do Cliente" MaxLength="14" Width="45%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requiredCPFCliente" runat="server" ControlToValidate="txtCPFCliente" ErrorMessage="Por favor digite CPF do Cliente!" ForeColor="Red" />
                    <br />
                    <br />
                    Tipo do Cliente:<br />
                    <asp:DropDownList ID="ddlTipoCliente" DataValueField="codigo" Width="45%" CssClass="form-control" runat="server"></asp:DropDownList>
                    <br />
                    <br />
                    Sexo do Cliente:<br />
                    <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control" Width="45%">
                        <asp:ListItem Value="Masculino" Text="Masculino"/>
                        <asp:ListItem Value="Feminino" Text="Feminino"/>
                    </asp:DropDownList>
                    <br />
                    <br />
                    Situação do Cliente:<br />
                    <asp:DropDownList ID="ddlSituacaoCliente" DataValueField="codigo" Width="45%" CssClass="form-control" runat="server"></asp:DropDownList>
                    <br />
                    <br />
                    <p>
                        <b><asp:Label ID="lblMensagem" runat="server" ></asp:Label></b>
                    </p>
                    <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" data-dismiss="alert" OnClick="btnCadastro_Click"/>
                    <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
