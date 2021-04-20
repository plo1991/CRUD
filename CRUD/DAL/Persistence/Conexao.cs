using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class Conexao
    {
        protected SqlConnection conn;
        protected SqlCommand cdm;
        protected SqlDataReader dr;

        //metodo - Abri conexao
        protected void AbrirConecao()
        {
            try
            {
                conn = new SqlConnection("Data Source=PAULO-PC;Initial Catalog=model;Integrated Security=True");
                conn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //metodo - Fecha conecao
        protected void FecharConecao()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
