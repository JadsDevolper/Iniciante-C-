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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaAgenda));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnIncluir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.ColumnID_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNM_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNR_TEL_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIncluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(60, 22);
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 139);
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
            this.panel1.Location = new System.Drawing.Point(12, 173);
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
            this.ColumnNM_CONTATO.Width = 200;
            // 
            // ColumnNR_TEL_CONTATO
            // 
            this.ColumnNR_TEL_CONTATO.HeaderText = "Telefone";
            this.ColumnNR_TEL_CONTATO.Name = "ColumnNR_TEL_CONTATO";
            this.ColumnNR_TEL_CONTATO.ReadOnly = true;
            this.ColumnNR_TEL_CONTATO.Width = 150;
            // 
            // FrmPesquisaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPesquisaAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda - Pesquisa";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_CONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNM_CONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNR_TEL_CONTATO;
    }
}