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
    public partial class CaixaCustomControl : UserControl
    {
        public CaixaCustomControl()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexaodb.abrir();
                comando.CommandText = "insert into venda(quantidade_venda,valor_total,troco_venda,id_produto,id_cliente,id_vendedor,id_pagamento,data_venda)values('" + numQuantidade.Value + "','"+numValorTotal.Value+"','"+numTroco.Value+"','"+numIdProduto.Value+"','"+numIdCliente.Value+"','"+numIdVendedor.Value+"','"+numIdPagamento.Value+"','"+txtData.Text+"')";
                comando.ExecuteNonQuery();
                comando.Connection.Close();

                MessageBox.Show("Dados inserido com sucesso!", "Aviso");
                txtData.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro", "Aviso" + erro);

            }
        }
    }
}
