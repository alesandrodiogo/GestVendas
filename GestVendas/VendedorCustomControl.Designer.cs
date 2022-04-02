namespace GestVendas
{
    partial class VendedorCustomControl
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
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.btnCadVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR VENDEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome_Vendedor";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(192, 88);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(250, 26);
            this.txtVendedor.TabIndex = 2;
            // 
            // btnCadVendedor
            // 
            this.btnCadVendedor.Location = new System.Drawing.Point(512, 76);
            this.btnCadVendedor.Name = "btnCadVendedor";
            this.btnCadVendedor.Size = new System.Drawing.Size(167, 35);
            this.btnCadVendedor.TabIndex = 3;
            this.btnCadVendedor.Text = "Cadastrar";
            this.btnCadVendedor.UseVisualStyleBackColor = true;
            this.btnCadVendedor.Click += new System.EventHandler(this.btnCadVendedor_Click);
            // 
            // VendedorCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCadVendedor);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VendedorCustomControl";
            this.Size = new System.Drawing.Size(1012, 705);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Button btnCadVendedor;
    }
}
