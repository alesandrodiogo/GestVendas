namespace GestVendas
{
    partial class FornecedoresCustomControl
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
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txtEnderecoFornecedor = new System.Windows.Forms.TextBox();
            this.txtTelefoneFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome_Fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço_Fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone_Fornecedor";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(239, 100);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(284, 26);
            this.txtNomeFornecedor.TabIndex = 3;
            // 
            // txtEnderecoFornecedor
            // 
            this.txtEnderecoFornecedor.Location = new System.Drawing.Point(239, 174);
            this.txtEnderecoFornecedor.Name = "txtEnderecoFornecedor";
            this.txtEnderecoFornecedor.Size = new System.Drawing.Size(284, 26);
            this.txtEnderecoFornecedor.TabIndex = 4;
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(739, 100);
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(221, 26);
            this.txtTelefoneFornecedor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "CADASTRAR FORNECEDORES";
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.Location = new System.Drawing.Point(561, 159);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Size = new System.Drawing.Size(207, 41);
            this.btnCadFornecedor.TabIndex = 7;
            this.btnCadFornecedor.Text = "Cadastrar";
            this.btnCadFornecedor.UseVisualStyleBackColor = true;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            // 
            // FornecedoresCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCadFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefoneFornecedor);
            this.Controls.Add(this.txtEnderecoFornecedor);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FornecedoresCustomControl";
            this.Size = new System.Drawing.Size(1012, 705);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.TextBox txtEnderecoFornecedor;
        private System.Windows.Forms.TextBox txtTelefoneFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadFornecedor;
    }
}
