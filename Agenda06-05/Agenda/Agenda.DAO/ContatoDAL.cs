using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.DAL;
using System.Data.SqlClient;
using System.Data;
using Agenda.DTO;

namespace Agenda.DAL
{
    public static class ContatoDAL
    {
        public static int InserirContatoDAL(Contato objContato)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Agenda.DAO.Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT TB_CONTATO (NM_CONTATO, NR_TEL_CONTATO) VALUES (@Nome, @Telefone)";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objContato.Nome;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objContato.Telefone;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(ID_CONTATO) FROM TB_CONTATO";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }

        public static List<Contato> BuscarContatoDAL(string[] filtrosPesquisa)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Agenda.DAO.Properties.Settings.Default.ConexaoBD;

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

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            List<Contato> Contatos = new List<Contato>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Contato objContato = new Contato();
                    objContato.Id       = Convert.ToInt32(Dr["ID_CONTATO"]);
                    objContato.Nome     = Convert.ToString(Dr["NM_CONTATO"]);
                    objContato.Telefone = Convert.ToString(Dr["NR_TEL_CONTATO"]);
                    Contatos.Add(objContato);
                }
            }

            return Contatos;
        }

        public static Contato BuscarContatoDAL(int CodigoContato)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Agenda.DAO.Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CONTATO, NM_CONTATO, NR_TEL_CONTATO FROM TB_CONTATO WHERE ID_CONTATO = @IdContato";
            Comando.Parameters.Add("IdContato", SqlDbType.Int).Value = CodigoContato;

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            Contato objContato = new Contato();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    objContato.Id = Convert.ToInt32(Dr["ID_CONTATO"]);
                    objContato.Nome = Convert.ToString(Dr["NM_CONTATO"]);
                    objContato.Telefone = Convert.ToString(Dr["NR_TEL_CONTATO"]);
                }
            }

            return objContato;
        }

        public static void AtualizarContatoDAL(Contato objContato)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Agenda.DAO.Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE TB_CONTATO SET NM_CONTATO = @Nome, NR_TEL_CONTATO = @Telefone WHERE ID_CONTATO = @IdContato";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objContato.Nome;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objContato.Telefone;
            Comando.Parameters.Add("IdContato", SqlDbType.Int).Value = objContato.Id;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }

        public static void ExcluirContato(int IdContato)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Agenda.DAO.Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE TB_CONTATO WHERE ID_CONTATO = @IdContato";
            Comando.Parameters.Add("IdContato", SqlDbType.Int).Value = IdContato;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
    }
}
