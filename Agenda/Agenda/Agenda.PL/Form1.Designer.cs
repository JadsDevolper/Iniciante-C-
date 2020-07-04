namespace Agenda.PL
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gridagenda = new System.Windows.Forms.DataGridView();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboperadora = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridagenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 22);
            this.txtNome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(115, 73);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(187, 22);
            this.txtTelefone.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(438, 17);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(188, 28);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gridagenda
            // 
            this.gridagenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridagenda.Location = new System.Drawing.Point(15, 201);
            this.gridagenda.Name = "gridagenda";
            this.gridagenda.RowTemplate.Height = 24;
            this.gridagenda.Size = new System.Drawing.Size(613, 217);
            this.gridagenda.TabIndex = 5;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(438, 140);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(188, 28);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Operadora";
            // 
            // cboperadora
            // 
            this.cboperadora.FormattingEnabled = true;
            this.cboperadora.Items.AddRange(new object[] {
            "Vivo",
            "Tim",
            "Claro",
            "Oi",
            "Nextel"});
            this.cboperadora.Location = new System.Drawing.Point(115, 115);
            this.cboperadora.Name = "cboperadora";
            this.cboperadora.Size = new System.Drawing.Size(164, 24);
            this.cboperadora.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 428);
            this.Controls.Add(this.cboperadora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.gridagenda);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridagenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gridagenda;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboperadora;
    }
}

