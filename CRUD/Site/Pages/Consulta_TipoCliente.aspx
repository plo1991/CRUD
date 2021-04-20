<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta_TipoCliente.aspx.cs" Inherits="Site.Pages.Consulta_TipoCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consulta</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Consulta Tipos Clientes</h3>
                    <asp:GridView ID="GridTiposClientes" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#ccffcc" PageSize="1">
                        <Columns>
                            <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="tipo_cliente" HeaderText="Tipo Cliente" />
                        </Columns>
                        <RowStyle CssClass="cursor-pointer" />
                    </asp:GridView>
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" ></asp:Label>
                    </p>
                    <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                    <%--<a href="/Pages/Detalhes.aspx" class="btn btn-primary btn-lg">Dados do Cliente</a>--%>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
