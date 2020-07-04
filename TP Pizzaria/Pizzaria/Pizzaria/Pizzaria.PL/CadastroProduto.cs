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

namespace Pizzaria.PL
{
    public partial class CadastroProduto : Form
    {
        public Pizza objPizza;
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (objPizza == null)
                objPizza = new Pizza();


            
            objPizza.Categoria = txtcategoria.Text;
            objPizza.Nomeproduto = txtnomeproduto.Text;
            objPizza.Valorproduto = float.Parse(txtvalor.Text);
            

            if (objPizza.Id == 0)
                objPizza.Id = PizzaBLL.IncluiProdutoBLL(objPizza);
            else
                PizzaBLL.AtualizarBLL(objPizza);

            DialogResult = DialogResult.OK;

            Close();
        }


    }
}
