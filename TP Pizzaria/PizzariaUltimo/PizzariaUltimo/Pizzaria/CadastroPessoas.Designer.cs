namespace Pizzaria
{
    partial class CadastroPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPessoas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridpessoas = new System.Windows.Forms.DataGridView();
            this.Columncd_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnm_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnr_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnendereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 27);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(73, 24);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(74, 70);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(71, 22);
            this.txtcodigo.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Código:";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(450, 123);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(162, 22);
            this.txtendereco.TabIndex = 24;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(74, 173);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(186, 22);
            this.txtemail.TabIndex = 23;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(455, 175);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(99, 22);
            this.txtcep.TabIndex = 22;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(450, 72);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(162, 22);
            this.txttelefone.TabIndex = 21;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(74, 121);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(226, 22);
            this.txtnome.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome:";
            // 
            // gridpessoas
            // 
            this.gridpessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columncd_cliente,
            this.Columnnm_cliente,
            this.Columnnr_telefone,
            this.Columnendereco});
            this.gridpessoas.Location = new System.Drawing.Point(26, 248);
            this.gridpessoas.Name = "gridpessoas";
            this.gridpessoas.RowTemplate.Height = 24;
            this.gridpessoas.Size = new System.Drawing.Size(779, 199);
            this.gridpessoas.TabIndex = 27;
            // 
            // Columncd_cliente
            // 
            this.Columncd_cliente.HeaderText = "CÓD";
            this.Columncd_cliente.Name = "Columncd_cliente";
            // 
            // Columnnm_cliente
            // 
            this.Columnnm_cliente.HeaderText = "NOME";
            this.Columnnm_cliente.Name = "Columnnm_cliente";
            this.Columnnm_cliente.Width = 230;
            // 
            // Columnnr_telefone
            // 
            this.Columnnr_telefone.HeaderText = "TELEFONE";
            this.Columnnr_telefone.Name = "Columnnr_telefone";
            // 
            // Columnendereco
            // 
            this.Columnendereco.HeaderText = "ENDEREÇO";
            this.Columnendereco.Name = "Columnendereco";
            this.Columnendereco.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 28;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 24);
            this.button2.TabIndex = 29;
            this.button2.Text = "Procurar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridpessoas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroPessoas";
            this.Text = "Cadastro de Clientes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridpessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columncd_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnnm_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnnr_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnendereco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

