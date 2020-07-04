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
        public Contato objContato;

        public FrmCadastroAgenda()
        {
            InitializeComponent();
        }

        public FrmCadastroAgenda(int CodigoContato)
        {
            InitializeComponent();

            if (CodigoContato != 0)
            {
                objContato = ContatoBLL.BuscarContatoBLL(CodigoContato);

                txtCodigo.Text = objContato.Id.ToString();
                txtNome.Text = objContato.Nome;
                txtTelefone.Text = objContato.Telefone;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (objContato == null)
                objContato = new Contato();

            objContato.Nome = txtNome.Text;
            objContato.Telefone = txtTelefone.Text;

            if (objContato.Id == 0)
                objContato.Id = ContatoBLL.InserirContatoBLL(objContato);
            else
                ContatoBLL.AtualizarContatoBLL(objContato);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
