using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Cadastro_SituacaoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnCadastroSituacaoCliente(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.situacao_cliente = txtSituacaoCliente.Text;

                ClienteDAL clienteDAL = new ClienteDAL();
                clienteDAL.GravarSituacaoCliente(cliente);

                lblMensagem.Text = "Cliente " + cliente.situacao_cliente + " cadastrado com sucesso!";

                txtSituacaoCliente.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}