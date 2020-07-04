using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaFisicaJuridica
{
    public partial class FrmCadastro : Form
    {
        List<PessoaFisica> pessoasFisica = new List<PessoaFisica>(); // cria lista como nome p.fisica

        List<PessoaJuridica> pessoasJuridica = new List<PessoaJuridica>(); // cria lista com nome p.juridica


        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (cmbTipoPessoa.SelectedIndex == 0)
            {
                // adiciona os atributos do parametro pessoa.juridica

                PessoaFisica PF = new PessoaFisica(txtNome.Text, txtTelefone.Text, (float.Parse(txtSaldo.Text)), (rdbBrasileira.Checked ? "BR" : "ES"), chkLinkedIn.Checked, chkSite.Checked, txtCpf.Text, txtRg.Text);
                pessoasFisica.Add(PF);

                dgvPessoaFisica.DataSource = null;
                dgvPessoaFisica.DataSource = pessoasFisica; // pega pessoas da lista e ostra o grid
            }
            else
            {
                // adiciona os atributos do parametro pessoa.juridica

                PessoaJuridica PJ = new PessoaJuridica(txtNome.Text, txtTelefone.Text, float.Parse(txtSaldo.Text), (rdbBrasileira.Checked ? "BR" : "ES"), chkLinkedIn.Checked, chkSite.Checked, txtCnpj.Text, txtIe.Text);
                pessoasJuridica.Add(PJ);

                dgvPessoaJuridica.DataSource = null;
                dgvPessoaJuridica.DataSource = pessoasJuridica;  // pega pessoas da lista e ostra o grid
            }
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            int i = -1;

            if (cmbTipoPessoa.SelectedIndex == 0)
            {
                foreach (PessoaFisica PF in pessoasFisica) //procura va classe contendo na lista 
                {
                    if (PF.Nome == txtNome.Text)
                        i = pessoasFisica.IndexOf(PF); //grava em i o numero indice do nome encontrado
                }

                if (i != -1)
                {
                    pessoasFisica.RemoveAt(i);
                    MessageBox.Show("Pessoa Física removida com sucesso!");

                    dgvPessoaFisica.DataSource = null;
                    dgvPessoaFisica.DataSource = pessoasFisica;
                }
                else
                {
                    MessageBox.Show("Pessoa Física não encontrada!");
                }
            }
            else
            if (cmbTipoPessoa.SelectedIndex == 1)
            {
                foreach (PessoaJuridica PJ in pessoasJuridica)
                {
                    if (PJ.Nome == txtNome.Text)
                        i = pessoasJuridica.IndexOf(PJ);
                }

                if (i != -1)
                {
                    pessoasJuridica.RemoveAt(i);
                    MessageBox.Show("Pessoa Jurídica removida com sucesso!");

                    dgvPessoaJuridica.DataSource = null;
                    dgvPessoaJuridica.DataSource = pessoasJuridica;
                }
                else
                {
                    MessageBox.Show("Pessoa Jurídica não encontrada!");
                }
            }
        }

        private void cmbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPessoa.SelectedIndex == 0)
            {
                txtCnpj.Text = String.Empty;
                txtIe.Text = String.Empty;
            }
            else
            {
                txtCpf.Text = String.Empty;
                txtRg.Text = String.Empty;
            }

            txtCpf.Enabled = (cmbTipoPessoa.SelectedIndex == 0);
            txtRg.Enabled = (cmbTipoPessoa.SelectedIndex == 0);

            txtCnpj.Enabled = (cmbTipoPessoa.SelectedIndex == 1);
            txtIe.Enabled = (cmbTipoPessoa.SelectedIndex == 1);
        }
    }
}
