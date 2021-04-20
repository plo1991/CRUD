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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnDados.Visible = false;

            //if (!IsPostBack)
            //{
            //    CarregaTipoCliente();
            //    CarregaSituacaoCliente();
            //}
        }
        protected void btnPesquisar(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                 
                ClienteDAL clienteDAL = new ClienteDAL();
                Cliente cliente = clienteDAL.PesquisarPorCodigo(codigo);

                if(cliente != null)
                {
                    
                    pnDados.Visible = true;
                    txtNome.Text = cliente.nome;
                    txtCPFCliente.Text = cliente.cpf;
                    ddlTipoCliente.SelectedValue = cliente.tipo_cliente;
                    ddlSexo.SelectedValue = cliente.sexo;
                    ddlSituacaoCliente.SelectedValue = cliente.situacao_cliente;
                }
                else
                {
                    lblMensagem.Text = "Cliente não encontrado!";
                    txtCodigo.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
        protected void BtnExcluir(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(txtCodigo.Text);

                Cliente cliente = new Cliente();
                ClienteDAL clienteDAL = new ClienteDAL();

                clienteDAL.Deletar(cod);

                lblMensagem.Text = "Cliente " + cliente.nome + " Excluido com Sucesso!";

                txtNome.Text = string.Empty;
                txtCPFCliente.Text = string.Empty;
                ddlSexo.SelectedValue = "1";
                ddlSituacaoCliente.SelectedValue = "0";
                ddlTipoCliente.SelectedValue = "0";
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
        protected void btnAtualizar(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                ClienteDAL clienteDAL = new ClienteDAL();

                cliente.codigo = Convert.ToInt32(txtCodigo.Text);
                cliente.nome = Convert.ToString(txtNome.Text);
                cliente.cpf = Convert.ToString(txtCPFCliente.Text);
                cliente.sexo = Convert.ToString(ddlSexo.SelectedValue);
                cliente.cod_tipo_cliente = Convert.ToInt32(ddlTipoCliente.SelectedValue);
                cliente.cod_situacao_cliente = Convert.ToInt32(ddlSituacaoCliente.SelectedValue);

                clienteDAL.Atualizar(cliente);

                lblMensagem.Text = "Cliente " + cliente.nome + "  Atualizado com Sucesso!";

                txtNome.Text = string.Empty;
                txtCPFCliente.Text = string.Empty;
                ddlSexo.SelectedValue = "1";
                ddlSituacaoCliente.SelectedValue = "0";
                ddlTipoCliente.SelectedValue = "0";
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