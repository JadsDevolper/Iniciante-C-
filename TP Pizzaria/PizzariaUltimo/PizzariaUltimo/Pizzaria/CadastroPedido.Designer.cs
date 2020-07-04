namespace Pizzaria
{
    partial class CadastroPedido
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
            this.label3 = new System.Windows.Forms.Label();
            this.griditens = new System.Windows.Forms.DataGridView();
            this.btnprocurarcliente = new System.Windows.Forms.Button();
            this.btnprocurarproduto = new System.Windows.Forms.Button();
            this.btnincliritem = new System.Windows.Forms.Button();
            this.btneditaritem = new System.Windows.Forms.Button();
            this.btnexcluiritem = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Columncd_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnm_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnm_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnvlr_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.griditens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produto:";
            // 
            // griditens
            // 
            this.griditens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griditens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columncd_pedido,
            this.Columnnm_cliente,
            this.Columnnm_produto,
            this.Columnvlr_total});
            this.griditens.Location = new System.Drawing.Point(22, 107);
            this.griditens.Name = "griditens";
            this.griditens.RowTemplate.Height = 24;
            this.griditens.Size = new System.Drawing.Size(1158, 210);
            this.griditens.TabIndex = 3;
            // 
            // btnprocurarcliente
            // 
            this.btnprocurarcliente.Location = new System.Drawing.Point(455, 75);
            this.btnprocurarcliente.Name = "btnprocurarcliente";
            this.btnprocurarcliente.Size = new System.Drawing.Size(129, 31);
            this.btnprocurarcliente.TabIndex = 4;
            this.btnprocurarcliente.Text = "Procurar";
            this.btnprocurarcliente.UseVisualStyleBackColor = true;
            this.btnprocurarcliente.Click += new System.EventHandler(this.btnprocurarcliente_Click);
            // 
            // btnprocurarproduto
            // 
            this.btnprocurarproduto.Location = new System.Drawing.Point(455, 138);
            this.btnprocurarproduto.Name = "btnprocurarproduto";
            this.btnprocurarproduto.Size = new System.Drawing.Size(129, 31);
            this.btnprocurarproduto.TabIndex = 5;
            this.btnprocurarproduto.Text = "Procurar";
            this.btnprocurarproduto.UseVisualStyleBackColor = true;
            // 
            // btnincliritem
            // 
            this.btnincliritem.Location = new System.Drawing.Point(446, 34);
            this.btnincliritem.Name = "btnincliritem";
            this.btnincliritem.Size = new System.Drawing.Size(129, 31);
            this.btnincliritem.TabIndex = 6;
            this.btnincliritem.Text = "Incluir";
            this.btnincliritem.UseVisualStyleBackColor = true;
            // 
            // btneditaritem
            // 
            this.btneditaritem.Location = new System.Drawing.Point(614, 34);
            this.btneditaritem.Name = "btneditaritem";
            this.btneditaritem.Size = new System.Drawing.Size(129, 31);
            this.btneditaritem.TabIndex = 7;
            this.btneditaritem.Text = "Editar";
            this.btneditaritem.UseVisualStyleBackColor = true;
            // 
            // btnexcluiritem
            // 
            this.btnexcluiritem.Location = new System.Drawing.Point(791, 34);
            this.btnexcluiritem.Name = "btnexcluiritem";
            this.btnexcluiritem.Size = new System.Drawing.Size(129, 31);
            this.btnexcluiritem.TabIndex = 8;
            this.btnexcluiritem.Text = "Excluir";
            this.btnexcluiritem.UseVisualStyleBackColor = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(115, 29);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(90, 22);
            this.txtcodigo.TabIndex = 9;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(118, 58);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(90, 22);
            this.txtvalor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Total:";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(115, 79);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(311, 22);
            this.txtcliente.TabIndex = 12;
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(115, 142);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(311, 22);
            this.txtproduto.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtvalor);
            this.groupBox1.Controls.Add(this.btnexcluiritem);
            this.groupBox1.Controls.Add(this.btneditaritem);
            this.groupBox1.Controls.Add(this.btnincliritem);
            this.groupBox1.Controls.Add(this.griditens);
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1192, 323);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens do Pedido:";
            // 
            // Columncd_pedido
            // 
            this.Columncd_pedido.HeaderText = "CÓD";
            this.Columncd_pedido.Name = "Columncd_pedido";
            // 
            // Columnnm_cliente
            // 
            this.Columnnm_cliente.HeaderText = "CLIENTE";
            this.Columnnm_cliente.Name = "Columnnm_cliente";
            this.Columnnm_cliente.Width = 250;
            // 
            // Columnnm_produto
            // 
            this.Columnnm_produto.HeaderText = "PRODUTOS";
            this.Columnnm_produto.Name = "Columnnm_produto";
            this.Columnnm_produto.Width = 250;
            // 
            // Columnvlr_total
            // 
            this.Columnvlr_total.HeaderText = "TOTAL";
            this.Columnvlr_total.Name = "Columnvlr_total";
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btnprocurarproduto);
            this.Controls.Add(this.btnprocurarcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroPedido";
            this.Text = "Cadastro do Pedido";
            this.Load += new System.EventHandler(this.CadastroPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griditens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView griditens;
        private System.Windows.Forms.Button btnprocurarcliente;
        private System.Windows.Forms.Button btnprocurarproduto;
        private System.Windows.Forms.Button btnincliritem;
        private System.Windows.Forms.Button btneditaritem;
        private System.Windows.Forms.Button btnexcluiritem;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columncd_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnnm_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnnm_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnvlr_total;
    }
}