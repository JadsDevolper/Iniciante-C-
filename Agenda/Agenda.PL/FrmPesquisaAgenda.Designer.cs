namespace Agenda.PL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaAgenda));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.stripeditar = new System.Windows.Forms.ToolStripButton();
            this.gridcontato = new System.Windows.Forms.DataGridView();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnprocurar = new System.Windows.Forms.Button();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontato)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.stripeditar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 24);
            this.toolStripButton1.Text = "Incluir";
            // 
            // stripeditar
            // 
            this.stripeditar.Image = ((System.Drawing.Image)(resources.GetObject("stripeditar.Image")));
            this.stripeditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripeditar.Name = "stripeditar";
            this.stripeditar.Size = new System.Drawing.Size(76, 24);
            this.stripeditar.Text = "Excluir";
            this.stripeditar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gridcontato
            // 
            this.gridcontato.AllowUserToAddRows = false;
            this.gridcontato.AllowUserToDeleteRows = false;
            this.gridcontato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcontato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTelefone,
            this.ColumnContato});
            this.gridcontato.Location = new System.Drawing.Point(51, 256);
            this.gridcontato.Name = "gridcontato";
            this.gridcontato.ReadOnly = true;
            this.gridcontato.RowTemplate.Height = 24;
            this.gridcontato.Size = new System.Drawing.Size(673, 237);
            this.gridcontato.TabIndex = 1;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Contato";
            this.ColumnTelefone.MinimumWidth = 200;
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            this.ColumnTelefone.Width = 200;
            // 
            // ColumnContato
            // 
            this.ColumnContato.HeaderText = "Telefone";
            this.ColumnContato.MinimumWidth = 50;
            this.ColumnContato.Name = "ColumnContato";
            this.ColumnContato.ReadOnly = true;
            this.ColumnContato.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.btnprocurar);
            this.groupBox1.Location = new System.Drawing.Point(33, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnprocurar
            // 
            this.btnprocurar.Location = new System.Drawing.Point(609, 50);
            this.btnprocurar.Name = "btnprocurar";
            this.btnprocurar.Size = new System.Drawing.Size(108, 31);
            this.btnprocurar.TabIndex = 0;
            this.btnprocurar.Text = "Procurar";
            this.btnprocurar.UseVisualStyleBackColor = true;
            this.btnprocurar.Click += new System.EventHandler(this.btnprocurar_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(72, 24);
            this.toolStripButton2.Text = "Editar";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(121, 31);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(274, 22);
            this.txtnom.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone:";
            // 
            // FrmPesquisaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridcontato);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPesquisaAgenda";
            this.Text = "FrmPesquisaAgenda";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontato)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stripeditar;
        private System.Windows.Forms.DataGridView gridcontato;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnprocurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContato;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtnom;
    }
}