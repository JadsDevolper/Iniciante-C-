using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class CadastroPedido : Form
    {
        public CadastroPedido()
        {
            InitializeComponent();
        }

        private void CadastroPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnprocurarcliente_Click(object sender, EventArgs e)
        {
            CadastroPessoas FormCadPessoas = new CadastroPessoas();

        }
    }
}
