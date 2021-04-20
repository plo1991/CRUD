<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Detalhes</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    
    <script type="text/javascript">
        
        function excluir() {
            if (confirm("Deseja excluir esse cliente?")) {
                return true;
            } else {
                return false;
            }
        }

        function atualizar() {
            if (confirm("Deseja atualizar esse cliente?")) {
                return true;
            } else {
                return false;
            }
        }
    </script>
    
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Detalhes do Clientes</h3>
                    <br />
                    <br />
                    Informe o Código do Cliente:
                    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="5%"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info btn-lg" OnClick="btnPesquisar"></asp:Button>
                    <a href="/Pages/Consulta.aspx" class="btn btn-warning btn-lg">Código dos Clientes</a>
                    <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                    <br />
                    <br />
                    <br />
                    <p>
                        <b><asp:Label ID="lblMensagem" runat="server" ></asp:Label></b>
                    </p>
                    <asp:Panel ID="pnDados" runat="server">
                    Nome do Cliente:
                    <br />
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" Width="45%"></asp:TextBox>
                    <br />
                    <br />
                    CPF Cliente:<br />
                    <asp:TextBox ID="txtCPFCliente" runat="server" MaxLength="14" Width="45%" CssClass="form-control"></asp:TextBox>
                    <br />
                    <br />
                    Tipo do Cliente:<br />
                    <asp:DropDownList ID="ddlTipoCliente" AutoPostBack="true" Width="45%" CssClass="form-control" runat="server"></asp:DropDownList>
                    <br />
                    <br />
                    Sexo do Cliente:<br />
                    <asp:DropDownList ID="ddlSexo" runat="server" AutoPostBack="true" CssClass="form-control" Width="45%">
                        <asp:ListItem Value="Masculino" Text="Masculino"/>
                        <asp:ListItem Value="Feminino" Text="Feminino"/>
                    </asp:DropDownList>
                    <br />
                    <br />
                    Situação do Cliente:<br />
                    <asp:DropDownList ID="ddlSituacaoCliente" AutoPostBack="true" Width="45%" CssClass="form-control" runat="server"></asp:DropDownList>
                    <br />
                    <br />
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger btn-lg" OnClick="BtnExcluir" OnClientClick="javascript:return excluir();" />
                    <asp:Button ID="Atualizar" runat="server" Text="Atualizar" CssClass="btn btn-warning btn-lg" OnClick="btnAtualizar" OnClientClick="javascript:return atualizar();"></asp:Button>
                    <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                    </asp:Panel>
                    <br />
                    <br />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
