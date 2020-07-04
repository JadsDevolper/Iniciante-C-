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

namespace Pizzaria
{
    public partial class CadastroPessoas : Form
    {
        public Pizza objPizza;

        public CadastroPessoas()
        {
            InitializeComponent();
        }
        public CadastroPessoas(int CodigoCliente)
        {
            InitializeComponent();

            if (CodigoCliente != 0)
            {
                objPizza = PizzaBLL.ProcurarClienteBLL(CodigoCliente);
                txtcodigo.Text = objPizza.Cdcliente.ToString();
                txtnome.Text = objPizza.Nome;
                txttelefone.Text = objPizza.Telefone;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (objPizza == null)
                objPizza = new Pizza();


            objPizza.Nome = txtnome.Text;
            objPizza.Telefone = txttelefone.Text;
            objPizza.Endereco = txtendereco.Text;
            objPizza.Cep = txtcep.Text;
            objPizza.Email = txtemail.Text;

            if (objPizza.Cdcliente == 0)
                objPizza.Cdcliente = PizzaBLL.IncluirClienteBLL(objPizza);
            else
                PizzaBLL.AtualizarBLL(objPizza);

            DialogResult = DialogResult.OK;

            Close();


        }
    }
}
