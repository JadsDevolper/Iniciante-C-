using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.DAL;
using Agenda.DTO;

namespace Agenda.BLL
{
    public class ContatoBLL
    {
        public static int InserirContato(Contato objContato)
        {
            //if (objContato.Nome == "")

            return ContatoDAL.InserirContato(objContato);
        }
        public static List<Contato> BuscarContatoBLL(string [] filtrosPesquisa)
        {
            return ContatoDAL.BuscarContatoDAL(filtrosPesquisa);
        }

        public static BuscarContatoBLL(int CodigoContato)
        {
            return ContatoDAL.BuscarContatoDAL(CodigoContato);
        }
        public static void AtualizaContatoBLL(Contato objContato)
        {
            ContatoDAL.AtualizarContatoDAL(objContato);
        }

        public static void ExcluiContato(Contato objContato)
        {
            ContatoDAL.ExcluirContato(CodigoContato);
        }
    }
}
