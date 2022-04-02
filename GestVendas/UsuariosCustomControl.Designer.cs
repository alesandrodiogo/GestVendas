namespace GestVendas
{
    partial class UsuariosCustomControl
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
            this.txtNomerUser = new System.Windows.Forms.TextBox();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.txtTelefoneUser = new System.Windows.Forms.TextBox();
            this.txtEnderecoUser = new System.Windows.Forms.TextBox();
            this.btnCadUsuarios = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDicaRecoverUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR USUÁRIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome_Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone_Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha_Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço_Usuário";
            // 
            // txtNomerUser
            // 
            this.txtNomerUser.Location = new System.Drawing.Point(153, 81);
            this.txtNomerUser.Name = "txtNomerUser";
            this.txtNomerUser.Size = new System.Drawing.Size(280, 26);
            this.txtNomerUser.TabIndex = 5;
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Location = new System.Drawing.Point(609, 81);
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.Size = new System.Drawing.Size(314, 26);
            this.txtSenhaUser.TabIndex = 6;
            // 
            // txtTelefoneUser
            // 
            this.txtTelefoneUser.Location = new System.Drawing.Point(173, 149);
            this.txtTelefoneUser.Name = "txtTelefoneUser";
            this.txtTelefoneUser.Size = new System.Drawing.Size(260, 26);
            this.txtTelefoneUser.TabIndex = 7;
            // 
            // txtEnderecoUser
            // 
            this.txtEnderecoUser.Location = new System.Drawing.Point(640, 149);
            this.txtEnderecoUser.Name = "txtEnderecoUser";
            this.txtEnderecoUser.Size = new System.Drawing.Size(283, 26);
            this.txtEnderecoUser.TabIndex = 8;
            // 
            // btnCadUsuarios
            // 
            this.btnCadUsuarios.Location = new System.Drawing.Point(652, 210);
            this.btnCadUsuarios.Name = "btnCadUsuarios";
            this.btnCadUsuarios.Size = new System.Drawing.Size(203, 35);
            this.btnCadUsuarios.TabIndex = 9;
            this.btnCadUsuarios.Text = "Cadastrar";
            this.btnCadUsuarios.UseVisualStyleBackColor = true;
            this.btnCadUsuarios.Click += new System.EventHandler(this.btnCadUsuarios_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dica para recuperar a Senha";
            // 
            // txtDicaRecoverUser
            // 
            this.txtDicaRecoverUser.Location = new System.Drawing.Point(252, 219);
            this.txtDicaRecoverUser.Name = "txtDicaRecoverUser";
            this.txtDicaRecoverUser.Size = new System.Drawing.Size(282, 26);
            this.txtDicaRecoverUser.TabIndex = 11;
            // 
            // UsuariosCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDicaRecoverUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadUsuarios);
            this.Controls.Add(this.txtEnderecoUser);
            this.Controls.Add(this.txtTelefoneUser);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.txtNomerUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsuariosCustomControl";
            this.Size = new System.Drawing.Size(1012, 705);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomerUser;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.TextBox txtTelefoneUser;
        private System.Windows.Forms.TextBox txtEnderecoUser;
        private System.Windows.Forms.Button btnCadUsuarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDicaRecoverUser;
    }
}
