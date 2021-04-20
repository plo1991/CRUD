using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;
using System.Data;

namespace DAL.Persistence
{
    public class ClienteDAL : Conexao
    {
        public void GravarTipoCliente(Cliente cliente)
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("sp_inserir_tipo_cliente", conn);
                cdm.Parameters.AddWithValue("@tipo_cliente", cliente.tipo_cliente);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar tipo cliente: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }
        public void GravarSituacaoCliente(Cliente cliente)
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("sp_inserir_situacao_cliente", conn);
                cdm.Parameters.AddWithValue("@situacao_cliente", cliente.situacao_cliente);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar situacao cliente: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }
        public List<Cliente> ListarTipoCliente()
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("Select * from tb_tipo_cliente", conn);
                dr = cdm.ExecuteReader();

                List<Cliente> lista = new List<Cliente>();

                while (dr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.codigo = Convert.ToInt32(dr["codigo"]);
                    cliente.tipo_cliente = Convert.ToString(dr["tipo_cliente"]);

                    lista.Add(cliente);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar tipos de clientes: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }
        public List<Cliente> ListarSituacaoCliente()
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("Select * from tb_situacao_cliente", conn);
                dr = cdm.ExecuteReader();

                List<Cliente> lista = new List<Cliente>();

                while (dr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.codigo = Convert.ToInt32(dr["codigo"]);
                    cliente.situacao_cliente = Convert.ToString(dr["situacao_cliente"]);

                    lista.Add(cliente);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar situação dos clientes: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }
        public void Gravar(Cliente cliente)
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("sp_inserir_cliente", conn);
                cdm.Parameters.AddWithValue("@nome", cliente.nome);
                cdm.Parameters.AddWithValue("@cpf", cliente.cpf);
                cdm.Parameters.AddWithValue("@tipo_cliente", cliente.cod_tipo_cliente);
                cdm.Parameters.AddWithValue("@sexo", cliente.sexo);
                cdm.Parameters.AddWithValue("@situacao_cliente", cliente.cod_situacao_cliente);
                cdm.CommandType = CommandType.StoredProcedure;
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
        public List<Cliente> preencherTipoCliente()
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("Select * from tb_tipo_cliente", conn);
                dr = cdm.ExecuteReader();

                List<Cliente> lista = new List<Cliente>();

                while (dr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.cod_tipo_cliente = Convert.ToInt32(dr["codigo"]);
                    cliente.tipo_cliente = Convert.ToString(dr["tipo_cliente"]);

                    lista.Add(cliente);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao dropdown tipos dos clientes: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }
        public List<Cliente> preencherSituacaoCliente()
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("Select * from tb_situacao_cliente", conn);
                dr = cdm.ExecuteReader();

                List<Cliente> lista = new List<Cliente>();

                while (dr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.cod_situacao_cliente = Convert.ToInt32(dr["codigo"]);
                    cliente.situacao_cliente = Convert.ToString(dr["situacao_cliente"]);

                    lista.Add(cliente);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao dropdown situação dos clientes: " + ex.Message);
            }
            finally
            {
                FecharConecao();
            }
        }
        public List<Cliente> Listar()
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("select c.codigo, c.nome, c.cpf, c.sexo, tp.tipo_cliente, sc.situacao_cliente from tb_cliente c inner join tb_tipo_cliente tp on tp.codigo = c.tipo_cliente inner join tb_situacao_cliente sc on sc.codigo = c.situacao_cliente", conn);
                dr = cdm.ExecuteReader();

                List<Cliente> lista = new List<Cliente>();

                while (dr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.codigo = Convert.ToInt32(dr["codigo"]);
                    cliente.nome = Convert.ToString(dr["nome"]);
                    cliente.cpf = Convert.ToString(dr["cpf"]);
                    cliente.sexo = Convert.ToString(dr["sexo"]);
                    cliente.tipo_cliente = Convert.ToString(dr["tipo_cliente"]);
                    cliente.situacao_cliente = Convert.ToString(dr["situacao_cliente"]);

                    lista.Add(cliente);
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
        public Cliente PesquisarPorCodigo(int cod)
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("select c.codigo, c.nome, c.cpf, c.sexo, tp.codigo as cod_tipo_cliente, tp.tipo_cliente, sc.codigo as cod_situacao_cliente, sc.situacao_cliente from tb_cliente c inner join tb_tipo_cliente tp on tp.codigo = c.tipo_cliente inner join tb_situacao_cliente sc on sc.codigo = c.situacao_cliente where c.codigo = @codigo", conn);
                cdm.Parameters.AddWithValue("@codigo", cod);
                dr = cdm.ExecuteReader();

                Cliente c = null;

                if (dr.Read())
                {
                    c = new Cliente();
                    c.codigo = Convert.ToInt32(dr["codigo"]);
                    c.nome = Convert.ToString(dr["nome"]);
                    c.cpf = Convert.ToString(dr["cpf"]);
                    c.cod_tipo_cliente = Convert.ToInt32(dr["cod_tipo_cliente"]);
                    c.tipo_cliente = Convert.ToString(dr["tipo_cliente"]);
                    c.cod_situacao_cliente = Convert.ToInt32(dr["cod_situacao_cliente"]);
                    c.situacao_cliente = Convert.ToString(dr["situacao_cliente"]);
                }
                return c;
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
        public void Atualizar(Cliente cliente)
        {
            try
            {
                AbrirConecao();
                cdm = new SqlCommand("sp_atualizar_cliente", conn);
                cdm.Parameters.AddWithValue("@codigo", cliente.codigo);
                cdm.Parameters.AddWithValue("@nome", cliente.nome);
                cdm.Parameters.AddWithValue("@cpf", cliente.cpf);
                cdm.Parameters.AddWithValue("@tipo_cliente", cliente.cod_tipo_cliente);
                cdm.Parameters.AddWithValue("@sexo", cliente.sexo);
                cdm.Parameters.AddWithValue("@situacao_cliente", cliente.cod_situacao_cliente);
                cdm.CommandType = CommandType.StoredProcedure;
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
                cdm = new SqlCommand("sp_excluir_cliente", conn);
                cdm.Parameters.AddWithValue("@codigo", cod);
                cdm.CommandType = CommandType.StoredProcedure;
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
    }
}
