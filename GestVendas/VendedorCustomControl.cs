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
    public partial class VendedorCustomControl : UserControl
    {
        public VendedorCustomControl()
        {
            InitializeComponent();
        }

        private void btnCadVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexaodb.abrir();
                comando.CommandText = "insert into vendedor(nome_vendedor)values('" + txtVendedor.Text + "')";
                comando.ExecuteNonQuery();
                comando.Connection.Close();

                MessageBox.Show("Dados inserido com sucesso!", "Aviso");
                txtVendedor.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro", "Aviso" + erro);

            }
        }
    }
}
