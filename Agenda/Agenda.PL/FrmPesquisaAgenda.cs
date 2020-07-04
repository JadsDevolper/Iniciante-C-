using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.DTO;
using Agenda.BLL;

namespace Agenda.PL
{
    public partial class FrmPesquisaAgenda : Form
    {
        public FrmPesquisaAgenda()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmAgenda pesquisaagenda = new FrmAgenda();
            pesquisaagenda.Show();

        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            List<Contato> Contatos = ContatoBLL.ListarContatoBLL();
            gridcontato.Rows.Clear();

            foreach (var objContato in Contatos)
            {
                string[] linhaContato = { objContato.Nome, objContato.Telefone };
                gridcontato.Rows.Add(linhaContato);
            }
        }
    }
}
