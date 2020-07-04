namespace Agenda.View
{
    partial class FrmPesquisaAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnID_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNM_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNR_TEL_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncluir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIncluir,
            this.btnEditar,
            this.btnExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(440, 34);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvContato);
            this.panel1.Location = new System.Drawing.Point(12, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 209);
            this.panel1.TabIndex = 2;
            // 
            // dgvContato
            // 
            this.dgvContato.AllowUserToAddRows = false;
            this.dgvContato.AllowUserToDeleteRows = false;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID_CONTATO,
            this.ColumnNM_CONTATO,
            this.ColumnNR_TEL_CONTATO});
            this.dgvContato.Location = new System.Drawing.Point(3, 3);
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.ReadOnly = true;
            this.dgvContato.Size = new System.Drawing.Size(528, 203);
            this.dgvContato.TabIndex = 0;
            this.dgvContato.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContato_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contato";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(99, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(309, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(99, 63);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(139, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // ColumnID_CONTATO
            // 
            this.ColumnID_CONTATO.HeaderText = "Código";
            this.ColumnID_CONTATO.Name = "ColumnID_CONTATO";
            this.ColumnID_CONTATO.ReadOnly = true;
            this.ColumnID_CONTATO.Width = 50;
            // 
            // ColumnNM_CONTATO
            // 
            this.ColumnNM_CONTATO.HeaderText = "Contato";
            this.ColumnNM_CONTATO.Name = "ColumnNM_CONTATO";
            this.ColumnNM_CONTATO.ReadOnly = true;
            this.ColumnNM_CONTATO.Width = 250;
            // 
            // ColumnNR_TEL_CONTATO
            // 
            this.ColumnNR_TEL_CONTATO.HeaderText = "Telefone";
            this.ColumnNR_TEL_CONTATO.Name = "ColumnNR_TEL_CONTATO";
            this.ColumnNR_TEL_CONTATO.ReadOnly = true;
            this.ColumnNR_TEL_CONTATO.Width = 150;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::Agenda.View.Properties.Resources._077_AddFile;
            this.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(60, 22);
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Agenda.View.Properties.Resources._042b_AddCategory;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::Agenda.View.Properties.Resources.delete;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmPesquisaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPesquisaAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda - Pesquisa";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnIncluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_CONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNM_CONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNR_TEL_CONTATO;
    }
}