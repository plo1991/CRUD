using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class PessoaDAL : Conexao
    {
        public void Gravar(Pessoa pessoa)
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("insert into Pessoa(nome, endereco, email) values(@nome, @endereco, @email)", conn);
                cdm.Parameters.AddWithValue("@nome", pessoa.nome);
                cdm.Parameters.AddWithValue("@endereco", pessoa.endereco);
                cdm.Parameters.AddWithValue("@email", pessoa.email);
                cdm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar cliente: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }
        public void Atualizar(Pessoa pessoa)
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("update Pessoa set nome = @nome, endereco = @endereco, email = @email where codigo = @codigo", conn);
                cdm.Parameters.AddWithValue("@nome", pessoa.nome);
                cdm.Parameters.AddWithValue("@endereco", pessoa.endereco);
                cdm.Parameters.AddWithValue("@email", pessoa.email);
                cdm.Parameters.AddWithValue("@codigo", pessoa.codigo);
                cdm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o cliente: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }
        public void Deletar(int cod)
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("delete from Pessoa where codigo = @codigo", conn);
                cdm.Parameters.AddWithValue("@codigo", cod);
                cdm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir o cliente: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }
        public Pessoa PesquisarPorCodigo(int cod)
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("Select * from Pessoa where codigo = @codigo", conn);
                cdm.Parameters.AddWithValue("@codigo", cod);
                dr = cdm.ExecuteReader();

                Pessoa p = null;

                if (dr.Read())
                {
                    p = new Pessoa();
                    p.codigo = Convert.ToInt32(dr["codigo"]);
                    p.nome = Convert.ToString(dr["nome"]);
                    p.endereco = Convert.ToString(dr["endereco"]);
                    p.email = Convert.ToString(dr["email"]);
                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar cliente: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }
        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("Select * from Pessoa", conn);
                dr = cdm.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (dr.Read())
                {
                    Pessoa pessoa = new Pessoa();

                    pessoa.codigo = Convert.ToInt32(dr["codigo"]);
                    pessoa.nome = Convert.ToString(dr["nome"]);
                    pessoa.endereco = Convert.ToString(dr["endereco"]);
                    pessoa.email = Convert.ToString(dr["email"]);

                    lista.Add(pessoa);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar clientes: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }

    }
}
