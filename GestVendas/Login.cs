using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestVendas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ckbMostarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMostarSenha.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexaodb.abrir();
                comando.CommandText = "select *from cad_user where nome_usuario='" + txtUser.Text + "'and senha_usuario='" + txtPass.Text + "'";
                comando.Connection.Close();

                SqlDataAdapter sda = new SqlDataAdapter(comando);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);
                if (tbl.Rows.Count==1)
                {
                    TelaPrincipal chamar = new TelaPrincipal();
                    chamar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dados incorrectos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Clear();
                    txtPass.Clear();
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro", "Aviso"+erro);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
        
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RecoverSenha chamar = new RecoverSenha();
            chamar.Show();
            this.Hide();
        }
    }
}
