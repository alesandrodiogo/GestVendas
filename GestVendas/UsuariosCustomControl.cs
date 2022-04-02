using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestVendas
{
    public partial class UsuariosCustomControl : UserControl
    {
        public UsuariosCustomControl()
        {
            InitializeComponent();
        }

        private void btnCadUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexaodb.abrir();
                comando.CommandText = "insert into cad_user(nome_usuario,senha_usuario,telefone_usuario,endereco,dica_senha)values('" + txtNomerUser.Text + "','" + txtSenhaUser.Text + "','" + txtTelefoneUser.Text + "','" + txtEnderecoUser.Text + "','" + txtDicaRecoverUser.Text + "')";
                comando.ExecuteNonQuery();
                comando.Connection.Close();
             
                    MessageBox.Show("Dados inseridos com sucesso!","Aviso");
                    txtNomerUser.Clear();
                    txtSenhaUser.Clear();
                    txtTelefoneUser.Clear();
                    txtEnderecoUser.Clear();
                    txtDicaRecoverUser.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro", "Aviso" + erro);

            }
        }
    }
}
