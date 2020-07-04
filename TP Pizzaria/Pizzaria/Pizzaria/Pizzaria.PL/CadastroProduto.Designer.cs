namespace Pizzaria.PL
{
    partial class CadastroProduto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnomeproduto = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.bntbuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 161);
            this.dataGridView1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(103, 20);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 22);
            this.txtcodigo.TabIndex = 5;
            // 
            // txtnomeproduto
            // 
            this.txtnomeproduto.Location = new System.Drawing.Point(103, 126);
            this.txtnomeproduto.Name = "txtnomeproduto";
            this.txtnomeproduto.Size = new System.Drawing.Size(260, 22);
            this.txtnomeproduto.TabIndex = 6;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(103, 74);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(260, 22);
            this.txtcategoria.TabIndex = 7;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(444, 74);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(146, 42);
            this.btnsalvar.TabIndex = 8;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(104, 177);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(98, 22);
            this.txtvalor.TabIndex = 10;
            // 
            // bntbuscar
            // 
            this.bntbuscar.Location = new System.Drawing.Point(444, 196);
            this.bntbuscar.Name = "bntbuscar";
            this.bntbuscar.Size = new System.Drawing.Size(146, 42);
            this.bntbuscar.TabIndex = 11;
            this.bntbuscar.Text = "Buscar";
            this.bntbuscar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntbuscar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtnomeproduto);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroProduto";
            this.Text = "Cadastro Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnomeproduto;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button bntbuscar;
        private System.Windows.Forms.Button button1;
    }
}