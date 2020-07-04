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
        public static int InserirContatoBLL(Contato objContato)
        {
            return ContatoDAL.InserirContatoDAL(objContato);
        }

        public static List<Contato> BuscarContatoBLL(string[] filtrosPesquisa)
        {
            return ContatoDAL.BuscarContatoDAL(filtrosPesquisa);
        }

        public static Contato BuscarContatoBLL(int CodigoContato)
        {
            return ContatoDAL.BuscarContatoDAL(CodigoContato);
        }

        public static void AtualizarContatoBLL(Contato objContato)
        {
            ContatoDAL.AtualizarContatoDAL(objContato);
        }

        public static void ExcluirContatoBLL(int CodigoContato)
        {
            ContatoDAL.ExcluirContato(CodigoContato);
        }
    }
}
