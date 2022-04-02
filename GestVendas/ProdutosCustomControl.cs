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
    public partial class ProdutosCustomControl : UserControl
    {
        public ProdutosCustomControl()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexaodb.abrir();
                comando.CommandText = "insert into produtos(nome_produto,descricao_produto,preco_produto,estoque_produto,id_categoria,id_fornecedor)values('" + txtNomeProduto.Text + "','"+txtDescricaoProduto.Text+"','"+numPrecoProduto.Value+"','"+numEstoqueProduto.Value+"','"+numIdCategoria.Value+"','"+numIdFornecedor.Value+"')";
                comando.ExecuteNonQuery();
                comando.Connection.Close();

                MessageBox.Show("Dados inserido com sucesso!", "Aviso");
                txtNomeProduto.Clear();
                txtDescricaoProduto.Clear();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro", "Aviso" + erro);

            }
        }
    }
}
