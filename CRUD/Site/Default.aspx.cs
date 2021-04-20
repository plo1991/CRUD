using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessar(object sender, EventArgs e)
        {
            string opcao = ddlMenu.SelectedValue;

            switch (opcao)
            {
                case "0":
                    lblMensagem.Text = "Por favor selecione uma opção!";
                    break;
                case "1":
                    Response.Redirect("/Pages/Cadastro.aspx");
                    break;
                case "2":
                    Response.Redirect("/Pages/Cadastro_TipoCliente.aspx");
                    break;
                case "3":
                    Response.Redirect("/Pages/Cadastro_SituacaoCliente.aspx");
                    break;
                case "4":
                    Response.Redirect("/Pages/Consulta.aspx");
                    break;
                case "5":
                    Response.Redirect("/Pages/Consulta_TipoCliente.aspx");
                    break;
                case "6":
                    Response.Redirect("/Pages/Consulta_SituacaoCliente.aspx");
                    break;
                case "7":
                    Response.Redirect("/Pages/Detalhes.aspx");
                    break;

            }
        }
    }
}