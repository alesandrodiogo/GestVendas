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
    public partial class ClienteCustomControl : UserControl
    {
        public ClienteCustomControl()
        {
            InitializeComponent();
        }

        private void ClienteCustomControl_Load(object sender, EventArgs e)
        {

        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexaodb.abrir();
                comando.CommandText = "insert into cliente(nome_cliente,telefone_cliente,email_cliente)values('" + txtNomeCliente.Text + "','"+txtTelefoneCliente.Text+"','"+txtEmailCliente.Text+"')";
                comando.ExecuteNonQuery();
                comando.Connection.Close();

                MessageBox.Show("Dados inserido com sucesso!", "Aviso");
                txtNomeCliente.Clear();
                txtTelefoneCliente.Clear();
                txtEmailCliente.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro", "Aviso" + erro);

            }
        }
    }
}
