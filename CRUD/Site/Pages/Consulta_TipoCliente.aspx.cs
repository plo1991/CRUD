using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Site.Pages
{
    public partial class Consulta_TipoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ClienteDAL clienteDAL = new ClienteDAL();

                GridTiposClientes.DataSource = clienteDAL.ListarTipoCliente();
                GridTiposClientes.DataBind();
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}