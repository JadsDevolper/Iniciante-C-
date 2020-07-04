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
    public partial class FrmCadastroAgenda : Form
    {
        public FrmCadastroAgenda()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int r;

            Contato objContato = new Contato();
            objContato.Nome = txtNome.Text;
            objContato.Telefone = txtTelefone.Text;

            r = ContatoBLL.InserirContatoBLL(objContato);

            if (r != 0)
                MessageBox.Show("Contato cadastrado com sucesso!");
            else
                MessageBox.Show("Houve erros ao salvar um contato!");
        }
    }
}
