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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<Contato> listapessoas = new List<Contato>();

            Contato objContato = new Contato();
            objContato.Nome = txtNome.Text;
            objContato.Telefone = txtTelefone.Text;

            ContatoBLL.InserirContato(objContato);

            //SALVANDO NO GRID


            listapessoas.Add(NovaConta);
            gridagenda.DataSource = null;
            gridagenda.DataSource = listapessoas;
        }

    }
    }
}
