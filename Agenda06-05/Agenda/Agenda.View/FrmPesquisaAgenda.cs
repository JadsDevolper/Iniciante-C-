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
    public partial class FrmPesquisaAgenda : Form
    {
        public FrmPesquisaAgenda()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            dgvContato.Rows.Clear();

            string[] filtrosPesquisa = { txtNome.Text, txtTelefone.Text };

            List<Contato> Contatos = ContatoBLL.BuscarContatoBLL(filtrosPesquisa);

            foreach (var objContato in Contatos)
            {
                string[] linhaContato = { objContato.Id.ToString(), objContato.Nome, objContato.Telefone };
                dgvContato.Rows.Add(linhaContato);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmCadastroAgenda FormCadastro = new FrmCadastroAgenda(0);
            var result = FormCadastro.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] linhaContato = { FormCadastro.objContato.Id.ToString(), FormCadastro.objContato.Nome, FormCadastro.objContato.Telefone };
                dgvContato.Rows.Add(linhaContato);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int CodigoContatoLinhaSelecionada = int.Parse(dgvContato.CurrentRow.Cells["ColumnID_CONTATO"].Value.ToString());

            FrmCadastroAgenda FormCadastro = new FrmCadastroAgenda(CodigoContatoLinhaSelecionada);
            var result = FormCadastro.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] linhaContato = { FormCadastro.objContato.Id.ToString(), FormCadastro.objContato.Nome, FormCadastro.objContato.Telefone };
                dgvContato.Rows[dgvContato.CurrentRow.Index].SetValues(linhaContato);
            }
        }

        private void dgvContato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do contato selecionado?", "Excluir Contato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int CodigoContatoLinhaSelecionada = int.Parse(dgvContato.CurrentRow.Cells["ColumnID_CONTATO"].Value.ToString());

                ContatoBLL.ExcluirContatoBLL(CodigoContatoLinhaSelecionada);

                dgvContato.Rows.RemoveAt(dgvContato.CurrentRow.Index);
            }
        }
    }
}
