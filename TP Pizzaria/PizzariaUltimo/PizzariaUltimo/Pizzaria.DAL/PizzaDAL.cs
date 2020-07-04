using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Pizzaria.DAL;
using Pizzaria.DTO;

namespace Pizzaria.DAL
{
    public class PizzaDAL
    {
        //INCLUINDO CIENTES 
        public static int IncluirClienteDAL(Pizza objPizza)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.CoexaoBD; 

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT tb_cliente (nm_cliente, nr_telefone, endereco, email, cep,) VALUES (@Nome, @Telefone, @Endereco, @Email, @Cep)";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objPizza.Nome;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objPizza.Telefone;
            Comando.Parameters.Add("Endereco", SqlDbType.VarChar).Value = objPizza.Endereco;
            Comando.Parameters.Add("Email", SqlDbType.VarChar).Value = objPizza.Email;
            Comando.Parameters.Add("Cep", SqlDbType.VarChar).Value = objPizza.Cep;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(cd_cliente) FROM tb_cliente";
            return int.Parse(Comando.ExecuteScalar().ToString());

        }

        public static int IncluirProdutoDAL(Pizza objPizza)
        {
            throw new NotImplementedException();
        }

        //INCLUINDO PRODUTOS
        public static int IncluirProdutoDAL(PizzaDAL objPizza)
        {


            return int.Parse(Comando.ExecuteScalar().ToString());
        }

        //PROCURAR CLIENTE LISTA
        public static List<Pizza> ProcurarClienteDAL(string[] filtrosPesquisa)
        {


            List<Pizza> Pizzas = new List<Pizza>();


            return Pizzas;
        }

        //PROCURAR PRODUTO LISTA
        public static List<Pizza> ProcurarProdutoDAL(string[] filtrosPesquisa)
        {


            List<Pizza> Produtos = new List<Pizza>();


            return Produtos;
        }
        //PROCURAR CLIENTE2
        public static Pizza ProcurarPessoaDAL(int CodigoContato)
        {



            Pizza objPizza = new Pizza();



            return objPizza;

        }
        //PROCURAR PRODUTO2
        public static Pizza ProcurarProdutoDAL(int CodigoProduto)
        {

            Pizza objPizza = new Pizza();



            return objPizza;

        }
        //ATUALIZAR CLIENTE
        public static void AtualizarDAL(Pizza objPizza)
        {


        }
        //ATUALIZAR PRODUTO
        public static void AtualizarProdutoDAL(Pizza objPizza)
        {


        }
        //APAGAR CLIENTE
        public static void ApagarCliente(int CodigoCliente)
        {


        }
        //APAGAR PRODUTO
        public static void ApagarProduto(int CodigoProduto)
        {


        }


    }
}
