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

namespace Agenda.PL
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato objContato = new Contato();
            objContato.Nome = txtNome.Text;
            objContato.Telefone = txtTelefone.Text;

            ContatoBLL.InserirContato(objContato);
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
