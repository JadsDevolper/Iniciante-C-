using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.DTO;
using System.Data.SqlClient;
using System.Data;

namespace Agenda.DAL
{
    public class ContatoDAL
    {
        public static void InserirContato(Contato objContato)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Agenda.DAL.Properties.Settings.Default.ConexaoDB;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT TB_CONTATO (NM_CONTATO, NR_TEL_CONTATO) VALUES (@Nome, @Telefone)";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objContato.Nome;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objContato.Telefone;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
    }
}
