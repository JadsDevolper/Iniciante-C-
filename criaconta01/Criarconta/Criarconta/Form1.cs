using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criarconta
{
    public partial class Form1 : Form
    {
        List<Pessoa> listapessoas = new List<Pessoa>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            Pessoa NovaConta = new Pessoa();

            NovaConta.agencia = txtagencia.Text;
            NovaConta.conta = txtconta.Text;
            NovaConta.titular = txttitular.Text;
            NovaConta.saldo = double.Parse(txtsaldo.Text);


            //adiciona capos na lista

            listapessoas.Add(NovaConta);
            MessageBox.Show("Conta cadastrada com sucesso!");

            //adiciona alista no grid

            gridpessoas.DataSource = null;
            gridpessoas.DataSource = listapessoas;

            //limpa campos, cursor esperando

            txtagencia.Text = "";
            txtconta.Text = "";
            txttitular.Text = "";
            txtsaldo.Text = "";
            txtvalor.Text = "";
            txtagencia.Focus();

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //limpa campos, cursor esperando

            txtagencia.Text = "";
            txtconta.Text = "";
            txttitular.Text = "";
            txtsaldo.Text = "";
            txtvalor.Text = "";
            txtagencia.Focus();
        }
  
        private void btnsacar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listapessoas.Count - 1; i++)
            {
                if (listapessoas[i].titular == txttitular.Text)
                {
                    listapessoas[i].Sacar(Double.Parse(txtvalor.Text));
                }
            }
            foreach (Pessoa DaLista in listapessoas)
            {
                if (DaLista.titular == txttitular.Text)
                {
                    DaLista.Sacar(Double.Parse(txtvalor.Text));
                }
            }

            gridpessoas.DataSource = null;
            gridpessoas.DataSource = listapessoas;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            //limpa campos, cursor esperando

            txtagencia.Text = "";
            txtconta.Text = "";
            txttitular.Text = "";
            txtsaldo.Text = "";
            txtvalor.Text = "";
            txtagencia.Focus();
        }

        private void btnconsultar_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= listapessoas.Count - 1; i++)
            {
                if (listapessoas[i].titular == txttitular.Text)
                {
                    txtagencia.Text = listapessoas[i].agencia;
                    txtconta.Text = listapessoas[i].conta;
                    txtsaldo.Text = Convert.ToString(listapessoas[i].saldo);
                }

                if (txttitular.Text == "")
                {
                    MessageBox.Show("Digite um nome para culsulta");
                }
                else 
                {
                    MessageBox.Show("Pessoa não encontrada");
                }
            }
        }

        private void btndepositar_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= listapessoas.Count - 1; i++)
            {
                if (listapessoas[i].titular == txttitular.Text)
                {
                    listapessoas[i].Depositar(Double.Parse(txtvalor.Text));
                }
            }
            foreach (Pessoa DaLista in listapessoas)
            {
                if (DaLista.titular == txttitular.Text)
                {
                    DaLista.Depositar(Double.Parse(txtvalor.Text));
                }
            }

            gridpessoas.DataSource = null;
            gridpessoas.DataSource = listapessoas;
        }
    }
}
