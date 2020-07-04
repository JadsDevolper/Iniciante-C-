using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.BLL;
using Agenda.DTO;

namespace Agenda.View
{
    public partial class FrmPesquisaAgenda : Form
    {
        public FrmPesquisaAgenda()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            List<Contato> Contatos = ContatoBLL.BuscarContatoBLL();

            dgvContato.Rows.Clear();

            foreach (var objContato in Contatos)
            {
                string[] linhaContato = { objContato.Id.ToString(), objContato.Nome, objContato.Telefone };
                dgvContato.Rows.Add(linhaContato);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmCadastroAgenda FormCadastro = new FrmCadastroAgenda();
            FormCadastro.Show();
        }
    }
}
