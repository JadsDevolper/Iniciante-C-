using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Pizzaria.DTO;
using Pizzaria.DAL;

namespace Pizzaria.DAL
{
    public class PizzaDAL
    {

        //INCLUINDO CLIENTES
        public static int IncluirClienteDAL(Pizza objPizza)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT TB_CONTATO (NM_CONTATO, NR_TEL_CONTATO, EMAIL, ENDERECO) VALUES (@Nome, @Telefone, @Email, @Endereco)";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objPizza.Nome;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objPizza.Telefone;
            Comando.Parameters.Add("Email", SqlDbType.VarChar).Value = objPizza.Email;
            Comando.Parameters.Add("Email", SqlDbType.VarChar).Value = objPizza.Endereco;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(ID_CONTATO) FROM TB_CONTATO";
            return int.Parse(Comando.ExecuteScalar().ToString());



           

        }
        //INCLUINDO PRODUTOS
        public static int IncluirProdutoDAL(Pizza objPizza)
        {
            return int.Parse(Comando.ExecuteScalar().ToString());
        }

        //PROCURAR CLIENTE LISTA
        public static List<Pizza> ProcurarClienteDAL(string[] filtrosPesquisa)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CONTATO, NM_CONTATO, NR_TEL_CONTATO FROM TB_CONTATO WHERE 1 = 1";

            if (filtrosPesquisa[0] != String.Empty)
            {
                Comando.CommandText += " AND NM_CONTATO LIKE '%' + @Nome + '%' ";
                Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = filtrosPesquisa[0];
            }

            if (filtrosPesquisa[1] != String.Empty)
            {
                Comando.CommandText += " AND NR_TEL_CONTATO LIKE '%' + @Telefone + '%' ";
                Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = filtrosPesquisa[1];
            }

            List<Pizza> Pizzas = new List<Pizza>();
            Conexao.Open();
            SqlDataReader Ler = Comando.ExecuteReader();

            if (Ler.HasRows)
            {
                while (Ler.Read())
                {
                    Pizza objPizza = new Pizza();
                    objPizza.Id = Convert.ToInt32(Ler["ID_CONTATO"]);
                    objPizza.Nome = Convert.ToString(Ler["NM_CONTATO"]);
                    objPizza.Telefone = Convert.ToString(Ler["NR_TEL_CONTATO"]);
                    
                    objPizza.Email = Convert.ToString(Ler["EMAIL"]);
                    objPizza.Endereco = Convert.ToString(Ler["ENDERECO"]);
                    Pizzas.Add(objPizza);
                }
            }

            return Pizzas;
        }
        public static Pizza ProcurarClienteDAL(int CodigoContato)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Telelista.DAL.Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CONTATO, NM_CONTATO, NR_TEL_CONTATO FROM TB_CONTATO WHERE ID_CONTATO = @IdContato";
            Comando.Parameters.Add("IdContato", SqlDbType.Int).Value = CodigoContato;

            Conexao.Open();
            SqlDataReader Ler = Comando.ExecuteReader();

            Pizza objPizza = new Pizza();

            if (Ler.HasRows)
            {
                while (Ler.Read())
                {
                    objPizza.Id = Convert.ToInt32(Ler["ID_CONTATO"]);
                    objPizza.Nome = Convert.ToString(Ler["NM_CONTATO"]);
                    objPizza.Telefone = Convert.ToString(Ler["NR_TEL_CONTATO"]);
                    //objPizza.Telefone2 = Convert.ToString(Ler["NR_TEL2_CONTATO"]);
                    objPizza.Email = Convert.ToString(Ler["EMAIL"]);
                    //objPizza.Operadora = Convert.ToString(Ler["OPERADORA"]);
                }
            }

            return objPizza;
        }
        public static void AtualizarDAL(Pizza objPizza)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Telelista.DAL.Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE TB_CONTATO SET NM_CONTATO = @Nome, NR_TEL_CONTATO = @Telefone, NR_TEL2_CONTATO = @Telefone2, EMAIL = @Email, OPERADORA = @Operadora WHERE ID_CONTATO = @IdContato";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objPizza.Nome;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objPizza.Telefone;
           // Comando.Parameters.Add("Telefone2", SqlDbType.VarChar).Value = objPizza.Telefone2;
            Comando.Parameters.Add("IdContato", SqlDbType.Int).Value = objPizza.Id;
            Comando.Parameters.Add("Email", SqlDbType.VarChar).Value = objPizza.Email;
            //Comando.Parameters.Add("Operadora", SqlDbType.VarChar).Value = objPizza.Operadora;


            Conexao.Open();
            Comando.ExecuteNonQuery();

        }
        public static void ApagarCliente(int IdContato)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Telelista.DAL.Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE TB_CONTATO WHERE ID_CONTATO = @IdContato";
            Comando.Parameters.Add("IdContato", SqlDbType.Int).Value = IdContato;

            Conexao.Open();
            Comando.ExecuteNonQuery();

        }

    }
}
