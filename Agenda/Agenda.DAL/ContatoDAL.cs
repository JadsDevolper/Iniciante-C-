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
        public static int InserirContato(Contato objContato)
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
            Comando.CommandText = "SELECT MAX(ID_CONTATO) FROM TB_CONTATO'";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }
        public static List<Contato> BuscarContatoDAL(string[] filtrosPesquisa)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Agenda.DAL.Properties.Settings.Default.ConexaoDB;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT  NM_CONTATO, NR_TEL_CONTATO, OPERADORA, FROM TB_CONTATO WHERE 1 = 1 ";

            if (filtrosPesquisa[0] != String.Empty)
            {
                Comando.CommandText += "AND CONTATO LIKE '%' + @Nome + '%' ";
                Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = filtrosPesquisa[0];
            }
            if (filtrosPesquisa[0] != String.Empty)
            {
                Comando.CommandText += "AND NR_TEL_CONTATO LIKE '%' + @Telefone + '%'";
                Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = filtrosPesquisa[1];
            }

            Conexao.Open();
            SqlDataReader leitura = Comando.ExecuteReader();

            List<Contato> Contatos = new List<Contato>();


            //DataTable tabela = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(Comando);
            //grid.DataSource = tabela;


            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    Contato objContato = new Contato();
                    objContato.Id = Convert.ToInt32(leitura["ID_CONTATO"]);
                    objContato.Nome = Convert.ToString(leitura["NM_CONTATO"]);
                    objContato.Telefone = Convert.ToString(leitura["NR_TEL_CONTATO"]);
                    Contatos.Add(objContato);
                }
            }
            return Contatos;

        }
        public static Contato BuscarContatoDAL(int CodigoContato)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Agenda.DAL.Properties.Settings.Default.ConexaoDB;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT  ID_CONTATO, NM_CONTATO, NR_TEL_CONTATO,  FROM TB_CONTATO WHERE ID_CONTATO = @IdContato"; ";
            Comando.Parameters.Add("IdContato", SqlDbType.VarChar).Value = CodigoContato;


            Contato objContato = new Contato();


            return objContato;
        }


    }
}
