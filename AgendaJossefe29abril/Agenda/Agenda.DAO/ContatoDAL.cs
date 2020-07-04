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
            return Comando.ExecuteNonQuery();
        }

        public static List<Contato> BuscarContatoDAL()
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Agenda.DAO.Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CONTATO, NM_CONTATO, NR_TEL_CONTATO FROM TB_CONTATO";

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
    }
}
