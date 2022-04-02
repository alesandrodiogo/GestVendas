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
    public partial class FornecedoresCustomControl : UserControl
    {
        public FornecedoresCustomControl()
        {
            InitializeComponent();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexaodb.abrir();
                comando.CommandText = "insert into fornecedores(nome_fornecedor,endereco_fornecedor,telefone_fornecedor)values('" + txtNomeFornecedor.Text + "','"+txtEnderecoFornecedor.Text+"','"+txtTelefoneFornecedor.Text+"')";
                comando.ExecuteNonQuery();
                comando.Connection.Close();

                MessageBox.Show("Dados inserido com sucesso!", "Aviso");
                txtNomeFornecedor.Clear();
                txtEnderecoFornecedor.Clear();
                txtTelefoneFornecedor.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro", "Aviso" + erro);

            }
        }
    }
}
