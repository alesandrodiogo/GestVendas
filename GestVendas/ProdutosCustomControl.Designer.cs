namespace GestVendas
{
    partial class ProdutosCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.numEstoqueProduto = new System.Windows.Forms.NumericUpDown();
            this.numPrecoProduto = new System.Windows.Forms.NumericUpDown();
            this.numIdCategoria = new System.Windows.Forms.NumericUpDown();
            this.numIdFornecedor = new System.Windows.Forms.NumericUpDown();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome_Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço_Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição_Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estoque_Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID_Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID_Fornecedor";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(148, 75);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(301, 26);
            this.txtNomeProduto.TabIndex = 7;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(637, 75);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(338, 26);
            this.txtDescricaoProduto.TabIndex = 8;
            // 
            // numEstoqueProduto
            // 
            this.numEstoqueProduto.Location = new System.Drawing.Point(637, 150);
            this.numEstoqueProduto.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.numEstoqueProduto.Name = "numEstoqueProduto";
            this.numEstoqueProduto.Size = new System.Drawing.Size(338, 26);
            this.numEstoqueProduto.TabIndex = 11;
            // 
            // numPrecoProduto
            // 
            this.numPrecoProduto.Location = new System.Drawing.Point(148, 150);
            this.numPrecoProduto.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.numPrecoProduto.Name = "numPrecoProduto";
            this.numPrecoProduto.Size = new System.Drawing.Size(301, 26);
            this.numPrecoProduto.TabIndex = 12;
            // 
            // numIdCategoria
            // 
            this.numIdCategoria.Location = new System.Drawing.Point(148, 226);
            this.numIdCategoria.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.numIdCategoria.Name = "numIdCategoria";
            this.numIdCategoria.Size = new System.Drawing.Size(301, 26);
            this.numIdCategoria.TabIndex = 13;
            // 
            // numIdFornecedor
            // 
            this.numIdFornecedor.Location = new System.Drawing.Point(637, 226);
            this.numIdFornecedor.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.numIdFornecedor.Name = "numIdFornecedor";
            this.numIdFornecedor.Size = new System.Drawing.Size(338, 26);
            this.numIdFornecedor.TabIndex = 14;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(437, 280);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(220, 49);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // ProdutosCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.numIdFornecedor);
            this.Controls.Add(this.numIdCategoria);
            this.Controls.Add(this.numPrecoProduto);
            this.Controls.Add(this.numEstoqueProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProdutosCustomControl";
            this.Size = new System.Drawing.Size(1012, 705);
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdFornecedor)).EndInit();
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
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.NumericUpDown numEstoqueProduto;
        private System.Windows.Forms.NumericUpDown numPrecoProduto;
        private System.Windows.Forms.NumericUpDown numIdCategoria;
        private System.Windows.Forms.NumericUpDown numIdFornecedor;
        private System.Windows.Forms.Button btnCadastrar;
    }
}
