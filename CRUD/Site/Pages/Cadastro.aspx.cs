using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregaTipoCliente();
                CarregaSituacaoCliente();
            }
        }
        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.nome = txtNome.Text;
                cliente.cpf = txtCPFCliente.Text;
                cliente.cod_tipo_cliente = Convert.ToInt32(ddlTipoCliente.SelectedValue);
                cliente.sexo = ddlSexo.SelectedValue;
                cliente.cod_situacao_cliente = Convert.ToInt32(ddlSituacaoCliente.SelectedValue);

                ClienteDAL clienteDAL = new ClienteDAL();

                clienteDAL.Gravar(cliente);

                lblMensagem.Text = "Cliente " + cliente.nome + " cadastrado com sucesso!";

                txtNome.Text = string.Empty;
                txtCPFCliente.Text = string.Empty;
                ddlSexo.SelectedValue = "1";
                ddlTipoCliente.SelectedValue = "0";
                ddlSituacaoCliente.SelectedValue = "0";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
        private void CarregaTipoCliente()
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            ddlTipoCliente.DataSource = clienteDAL.preencherTipoCliente();
            ddlTipoCliente.DataValueField = "codigo";
            ddlTipoCliente.DataTextField = "tipo_cliente";
            ddlTipoCliente.DataBind();
        }
        private void CarregaSituacaoCliente()
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            ddlSituacaoCliente.DataSource = clienteDAL.preencherSituacaoCliente();
            ddlSituacaoCliente.DataValueField = "codigo";
            ddlSituacaoCliente.DataTextField = "situacao_cliente";
            ddlSituacaoCliente.DataBind();
        }
    }
}