<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="jumbotron">
                    <h1>Gestão de Clientes Fácil Assist</h1>

                    Selecione a operação desejada:
                    <asp:DropDownList ID="ddlMenu" runat="server">
                        <asp:ListItem Value="0" Text="Selecione..."/>
                        <asp:ListItem Value="1" Text="Cadastrar Cliente"/>
                        <asp:ListItem Value="2" Text="Cadastrar Tipo Cliente"/>
                        <asp:ListItem Value="3" Text="Cadastrar Situação Cliente"/>
                        <asp:ListItem Value="4" Text="Consultar Cliente"/>
                        <asp:ListItem Value="5" Text="Consultar Tipo Cliente"/>
                        <asp:ListItem Value="6" Text="Consultar Situação Cliente"/>
                        <asp:ListItem Value="7" Text="Obter Dados do Cliente"/>
                    </asp:DropDownList>
                    <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary btn-lg" OnClick="btnAcessar"/>
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" ></asp:Label>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
