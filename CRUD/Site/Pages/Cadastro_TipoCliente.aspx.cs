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
    public partial class Cadastro_TipoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnCadastroTipoCliente(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.tipo_cliente = txtTipoCliente.Text;

                ClienteDAL clienteDAL = new ClienteDAL();
                clienteDAL.GravarTipoCliente(cliente);

                lblMensagem.Text = "Cliente " + cliente.tipo_cliente + " cadastrado com sucesso!";

                txtTipoCliente.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}