namespace Criarconta
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtagencia = new System.Windows.Forms.TextBox();
            this.txtconta = new System.Windows.Forms.TextBox();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.gridpessoas = new System.Windows.Forms.DataGridView();
            this.btncriar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btndepositar = new System.Windows.Forms.Button();
            this.btnsacar = new System.Windows.Forms.Button();
            this.txttitular = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridpessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agência:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conta:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titular:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor:";
            // 
            // txtagencia
            // 
            this.txtagencia.Location = new System.Drawing.Point(114, 20);
            this.txtagencia.Name = "txtagencia";
            this.txtagencia.Size = new System.Drawing.Size(73, 22);
            this.txtagencia.TabIndex = 5;
            // 
            // txtconta
            // 
            this.txtconta.Location = new System.Drawing.Point(114, 76);
            this.txtconta.Name = "txtconta";
            this.txtconta.Size = new System.Drawing.Size(103, 22);
            this.txtconta.TabIndex = 6;
            // 
            // txtsaldo
            // 
            this.txtsaldo.Location = new System.Drawing.Point(114, 197);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(73, 22);
            this.txtsaldo.TabIndex = 8;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(114, 267);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(73, 22);
            this.txtvalor.TabIndex = 9;
            // 
            // gridpessoas
            // 
            this.gridpessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpessoas.Location = new System.Drawing.Point(13, 299);
            this.gridpessoas.Name = "gridpessoas";
            this.gridpessoas.RowTemplate.Height = 24;
            this.gridpessoas.Size = new System.Drawing.Size(780, 252);
            this.gridpessoas.TabIndex = 10;
            // 
            // btncriar
            // 
            this.btncriar.Location = new System.Drawing.Point(416, 16);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(196, 33);
            this.btncriar.TabIndex = 11;
            this.btncriar.Text = "Criar";
            this.btncriar.UseVisualStyleBackColor = true;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(416, 76);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(196, 33);
            this.btnconsultar.TabIndex = 12;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click_1);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(416, 143);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(196, 33);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btndepositar
            // 
            this.btndepositar.Location = new System.Drawing.Point(284, 220);
            this.btndepositar.Name = "btndepositar";
            this.btndepositar.Size = new System.Drawing.Size(196, 33);
            this.btndepositar.TabIndex = 14;
            this.btndepositar.Text = "Depositar";
            this.btndepositar.UseVisualStyleBackColor = true;
            this.btndepositar.Click += new System.EventHandler(this.btndepositar_Click_1);
            // 
            // btnsacar
            // 
            this.btnsacar.Location = new System.Drawing.Point(550, 220);
            this.btnsacar.Name = "btnsacar";
            this.btnsacar.Size = new System.Drawing.Size(196, 33);
            this.btnsacar.TabIndex = 15;
            this.btnsacar.Text = "Sacar";
            this.btnsacar.UseVisualStyleBackColor = true;
            this.btnsacar.Click += new System.EventHandler(this.btnsacar_Click);
            // 
            // txttitular
            // 
            this.txttitular.Location = new System.Drawing.Point(117, 134);
            this.txttitular.Name = "txttitular";
            this.txttitular.Size = new System.Drawing.Size(167, 22);
            this.txttitular.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.txttitular);
            this.Controls.Add(this.btnsacar);
            this.Controls.Add(this.btndepositar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.gridpessoas);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtsaldo);
            this.Controls.Add(this.txtconta);
            this.Controls.Add(this.txtagencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridpessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtagencia;
        private System.Windows.Forms.TextBox txtconta;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.DataGridView gridpessoas;
        private System.Windows.Forms.Button btncriar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btndepositar;
        private System.Windows.Forms.Button btnsacar;
        private System.Windows.Forms.TextBox txttitular;
    }
}

