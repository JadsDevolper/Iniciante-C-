using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.BLL;
using Pizzaria.DTO;

namespace Telelista
{
    public partial class CadastroClientes : Form
    {
        public Pizza objPizza;

        public CadastroClientes()
        {
            InitializeComponent();
        }
        public CadastroClientes(int CodigoContato)
        {
            InitializeComponent();

            if (CodigoContato != 0)
            {
                objPizza = PizzaBLL.ProcurarClienteBLL(CodigoContato);
                txtcodigo.Text = objPizza.Id.ToString();
                txtnome.Text = objPizza.Nome;
                txttelefone.Text = objPizza.Telefone;
            }
        }

        private void btnsalvar_Click_1(object sender, EventArgs e)
        {
            if (objPizza == null)
                objPizza = new Pizza();


            objPizza.Nome = txtnome.Text;
            objPizza.Telefone = txttelefone.Text;

            if (objPizza.Id == 0)
                objPizza.Id = PizzaBLL.IncluirClienteBLL(objPizza);
            else
                PizzaBLL.AtualizarBLL(objPizza);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}

