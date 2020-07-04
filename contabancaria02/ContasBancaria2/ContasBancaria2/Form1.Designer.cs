namespace ContasBancaria2
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
            this.label6 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.chkautomovel = new System.Windows.Forms.CheckBox();
            this.chkresidencial = new System.Windows.Forms.CheckBox();
            this.rdsim = new System.Windows.Forms.RadioButton();
            this.rdnao = new System.Windows.Forms.RadioButton();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.txtagencia = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridcorrente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridpoupanca = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcorrente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpoupanca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cheque Especial";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Agência:";
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(456, 59);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(62, 17);
            this.Numero.TabIndex = 6;
            this.Numero.Text = "Número:";
            // 
            // chkautomovel
            // 
            this.chkautomovel.AutoSize = true;
            this.chkautomovel.Location = new System.Drawing.Point(491, 122);
            this.chkautomovel.Name = "chkautomovel";
            this.chkautomovel.Size = new System.Drawing.Size(146, 21);
            this.chkautomovel.TabIndex = 7;
            this.chkautomovel.Text = "Seguro Automóvel";
            this.chkautomovel.UseVisualStyleBackColor = true;
            // 
            // chkresidencial
            // 
            this.chkresidencial.AutoSize = true;
            this.chkresidencial.Location = new System.Drawing.Point(491, 162);
            this.chkresidencial.Name = "chkresidencial";
            this.chkresidencial.Size = new System.Drawing.Size(153, 21);
            this.chkresidencial.TabIndex = 8;
            this.chkresidencial.Text = "Seguro Residencial";
            this.chkresidencial.UseVisualStyleBackColor = true;
            // 
            // rdsim
            // 
            this.rdsim.AutoSize = true;
            this.rdsim.Location = new System.Drawing.Point(153, 166);
            this.rdsim.Name = "rdsim";
            this.rdsim.Size = new System.Drawing.Size(52, 21);
            this.rdsim.TabIndex = 9;
            this.rdsim.TabStop = true;
            this.rdsim.Text = "Sim";
            this.rdsim.UseVisualStyleBackColor = true;
            // 
            // rdnao
            // 
            this.rdnao.AutoSize = true;
            this.rdnao.Location = new System.Drawing.Point(246, 166);
            this.rdnao.Name = "rdnao";
            this.rdnao.Size = new System.Drawing.Size(55, 21);
            this.rdnao.TabIndex = 10;
            this.rdnao.TabStop = true;
            this.rdnao.Text = "Não";
            this.rdnao.UseVisualStyleBackColor = true;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(126, 63);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(238, 22);
            this.txtcliente.TabIndex = 11;
            // 
            // txtsaldo
            // 
            this.txtsaldo.Location = new System.Drawing.Point(126, 122);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(79, 22);
            this.txtsaldo.TabIndex = 12;
            // 
            // txtagencia
            // 
            this.txtagencia.Location = new System.Drawing.Point(524, 26);
            this.txtagencia.Name = "txtagencia";
            this.txtagencia.Size = new System.Drawing.Size(120, 22);
            this.txtagencia.TabIndex = 13;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(524, 54);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(120, 22);
            this.txtnumero.TabIndex = 14;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(126, 94);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(143, 22);
            this.txttelefone.TabIndex = 15;
            // 
            // combotipo
            // 
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Location = new System.Drawing.Point(126, 33);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(139, 24);
            this.combotipo.TabIndex = 16;
            this.combotipo.SelectedIndexChanged += new System.EventHandler(this.boxtipo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridcorrente);
            this.groupBox1.Location = new System.Drawing.Point(15, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 211);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta Corrente";
            // 
            // gridcorrente
            // 
            this.gridcorrente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcorrente.Location = new System.Drawing.Point(18, 21);
            this.gridcorrente.Name = "gridcorrente";
            this.gridcorrente.RowTemplate.Height = 24;
            this.gridcorrente.Size = new System.Drawing.Size(1006, 178);
            this.gridcorrente.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridpoupanca);
            this.groupBox2.Location = new System.Drawing.Point(15, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 226);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conta Poupança";
            // 
            // gridpoupanca
            // 
            this.gridpoupanca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpoupanca.Location = new System.Drawing.Point(18, 21);
            this.gridpoupanca.Name = "gridpoupanca";
            this.gridpoupanca.RowTemplate.Height = 24;
            this.gridpoupanca.Size = new System.Drawing.Size(1006, 178);
            this.gridpoupanca.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(815, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 684);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combotipo);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtagencia);
            this.Controls.Add(this.txtsaldo);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.rdnao);
            this.Controls.Add(this.rdsim);
            this.Controls.Add(this.chkresidencial);
            this.Controls.Add(this.chkautomovel);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de Contas Bancarias";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcorrente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridpoupanca)).EndInit();
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
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.CheckBox chkautomovel;
        private System.Windows.Forms.CheckBox chkresidencial;
        private System.Windows.Forms.RadioButton rdsim;
        private System.Windows.Forms.RadioButton rdnao;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.TextBox txtagencia;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.ComboBox combotipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridcorrente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridpoupanca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

