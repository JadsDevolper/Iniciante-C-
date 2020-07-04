namespace PessoaFisicaJuridica
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.rdbBrasileira = new System.Windows.Forms.RadioButton();
            this.rdbEstrangeira = new System.Windows.Forms.RadioButton();
            this.chkLinkedIn = new System.Windows.Forms.CheckBox();
            this.chkSite = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.grbPF = new System.Windows.Forms.GroupBox();
            this.dgvPessoaFisica = new System.Windows.Forms.DataGridView();
            this.grbPJ = new System.Windows.Forms.GroupBox();
            this.dgvPessoaJuridica = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.grbPF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaFisica)).BeginInit();
            this.grbPJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaJuridica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Pessoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cnpj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saldo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nacionalidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cpf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Rg";
            // 
            // cmbTipoPessoa
            // 
            this.cmbTipoPessoa.DisplayMember = "F, J";
            this.cmbTipoPessoa.FormattingEnabled = true;
            this.cmbTipoPessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cmbTipoPessoa.Location = new System.Drawing.Point(117, 43);
            this.cmbTipoPessoa.Name = "cmbTipoPessoa";
            this.cmbTipoPessoa.Size = new System.Drawing.Size(151, 21);
            this.cmbTipoPessoa.TabIndex = 8;
            this.cmbTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPessoa_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(117, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(253, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(117, 96);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(151, 20);
            this.txtTelefone.TabIndex = 10;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(118, 122);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "I.E.";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(456, 37);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 14;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(456, 63);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 20);
            this.txtRg.TabIndex = 15;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(456, 91);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 20);
            this.txtCnpj.TabIndex = 16;
            // 
            // txtIe
            // 
            this.txtIe.Location = new System.Drawing.Point(456, 118);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(100, 20);
            this.txtIe.TabIndex = 17;
            // 
            // rdbBrasileira
            // 
            this.rdbBrasileira.AutoSize = true;
            this.rdbBrasileira.Location = new System.Drawing.Point(117, 148);
            this.rdbBrasileira.Name = "rdbBrasileira";
            this.rdbBrasileira.Size = new System.Drawing.Size(67, 17);
            this.rdbBrasileira.TabIndex = 18;
            this.rdbBrasileira.TabStop = true;
            this.rdbBrasileira.Text = "Brasileira";
            this.rdbBrasileira.UseVisualStyleBackColor = true;
            // 
            // rdbEstrangeira
            // 
            this.rdbEstrangeira.AutoSize = true;
            this.rdbEstrangeira.Location = new System.Drawing.Point(190, 148);
            this.rdbEstrangeira.Name = "rdbEstrangeira";
            this.rdbEstrangeira.Size = new System.Drawing.Size(78, 17);
            this.rdbEstrangeira.TabIndex = 19;
            this.rdbEstrangeira.TabStop = true;
            this.rdbEstrangeira.Text = "Estrangeira";
            this.rdbEstrangeira.UseVisualStyleBackColor = true;
            // 
            // chkLinkedIn
            // 
            this.chkLinkedIn.AutoSize = true;
            this.chkLinkedIn.Location = new System.Drawing.Point(117, 171);
            this.chkLinkedIn.Name = "chkLinkedIn";
            this.chkLinkedIn.Size = new System.Drawing.Size(67, 17);
            this.chkLinkedIn.TabIndex = 20;
            this.chkLinkedIn.Text = "LinkedIn";
            this.chkLinkedIn.UseVisualStyleBackColor = true;
            // 
            // chkSite
            // 
            this.chkSite.AutoSize = true;
            this.chkSite.Location = new System.Drawing.Point(117, 194);
            this.chkSite.Name = "chkSite";
            this.chkSite.Size = new System.Drawing.Size(44, 17);
            this.chkSite.TabIndex = 21;
            this.chkSite.Text = "Site";
            this.chkSite.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvar,
            this.tsbExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(58, 22);
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(61, 22);
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // grbPF
            // 
            this.grbPF.Controls.Add(this.dgvPessoaFisica);
            this.grbPF.Location = new System.Drawing.Point(18, 237);
            this.grbPF.Name = "grbPF";
            this.grbPF.Size = new System.Drawing.Size(776, 147);
            this.grbPF.TabIndex = 25;
            this.grbPF.TabStop = false;
            this.grbPF.Text = "Pessoa Física";
            // 
            // dgvPessoaFisica
            // 
            this.dgvPessoaFisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoaFisica.Location = new System.Drawing.Point(15, 19);
            this.dgvPessoaFisica.Name = "dgvPessoaFisica";
            this.dgvPessoaFisica.Size = new System.Drawing.Size(744, 112);
            this.dgvPessoaFisica.TabIndex = 23;
            // 
            // grbPJ
            // 
            this.grbPJ.Controls.Add(this.dgvPessoaJuridica);
            this.grbPJ.Location = new System.Drawing.Point(18, 403);
            this.grbPJ.Name = "grbPJ";
            this.grbPJ.Size = new System.Drawing.Size(770, 156);
            this.grbPJ.TabIndex = 26;
            this.grbPJ.TabStop = false;
            this.grbPJ.Text = "Pessoa Jurídica";
            // 
            // dgvPessoaJuridica
            // 
            this.dgvPessoaJuridica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoaJuridica.Location = new System.Drawing.Point(15, 19);
            this.dgvPessoaJuridica.Name = "dgvPessoaJuridica";
            this.dgvPessoaJuridica.Size = new System.Drawing.Size(744, 119);
            this.dgvPessoaJuridica.TabIndex = 0;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.grbPJ);
            this.Controls.Add(this.grbPF);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chkSite);
            this.Controls.Add(this.chkLinkedIn);
            this.Controls.Add(this.rdbEstrangeira);
            this.Controls.Add(this.rdbBrasileira);
            this.Controls.Add(this.txtIe);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbTipoPessoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastro";
            this.Text = "Cadastro de Pessoas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbPF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaFisica)).EndInit();
            this.grbPJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaJuridica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoPessoa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.RadioButton rdbBrasileira;
        private System.Windows.Forms.RadioButton rdbEstrangeira;
        private System.Windows.Forms.CheckBox chkLinkedIn;
        private System.Windows.Forms.CheckBox chkSite;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.GroupBox grbPF;
        private System.Windows.Forms.DataGridView dgvPessoaFisica;
        private System.Windows.Forms.GroupBox grbPJ;
        private System.Windows.Forms.DataGridView dgvPessoaJuridica;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
    }
}

