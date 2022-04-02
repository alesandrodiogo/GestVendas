namespace GestVendas
{
    partial class PagamentoCustomControl
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
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.btnCadFormasPagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR FORMAS DE PAGAMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formas de Pagamento";
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(195, 103);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(239, 26);
            this.txtPagamento.TabIndex = 2;
            // 
            // btnCadFormasPagamento
            // 
            this.btnCadFormasPagamento.Location = new System.Drawing.Point(488, 98);
            this.btnCadFormasPagamento.Name = "btnCadFormasPagamento";
            this.btnCadFormasPagamento.Size = new System.Drawing.Size(200, 37);
            this.btnCadFormasPagamento.TabIndex = 3;
            this.btnCadFormasPagamento.Text = "Cadastrar";
            this.btnCadFormasPagamento.UseVisualStyleBackColor = true;
            this.btnCadFormasPagamento.Click += new System.EventHandler(this.btnCadFormasPagamento_Click);
            // 
            // PagamentoCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCadFormasPagamento);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PagamentoCustomControl";
            this.Size = new System.Drawing.Size(1012, 705);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Button btnCadFormasPagamento;
    }
}
