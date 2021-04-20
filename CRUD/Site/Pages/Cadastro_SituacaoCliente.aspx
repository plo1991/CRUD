<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro_SituacaoCliente.aspx.cs" Inherits="Site.Pages.Cadastro_SituacaoCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro Tipo Cliente</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Cadastro Situação Cliente</h3>
                    <br />
                    Tipo Cliente:
                    <br />
                    <asp:TextBox ID="txtSituacaoCliente" runat="server" placeholder="Tipo Cliente" Width="45%" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="requiredSituacaoCliente" runat="server" ControlToValidate="txtSituacaoCliente" ErrorMessage="Por favor digite a situação do cliente!" ForeColor="Red" />
                    <br />
                    <br />
                    <p>
                        <b><asp:Label ID="lblMensagem" runat="server" ></asp:Label></b>
                    </p>
                    <asp:Button ID="btnCadastroSituacaoCliente" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" data-dismiss="alert" OnClick="BtnCadastroSituacaoCliente"/>
                    <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
