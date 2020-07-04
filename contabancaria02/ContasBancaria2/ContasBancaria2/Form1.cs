using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasBancaria2
{
    public partial class Form1 : Form
    {
        List<Conta> listapessoas = new List<Conta>();

        ContaPoupanca cpou = new ContaPoupanca();
        Conta cc = new Conta();
       
        Conta [] modelos;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void boxtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.modelos = new Conta[2];

            combotipo.Items.Add("CORRENTE");
            combotipo.Items.Add("POUPANÇA");

        }
    }
}
