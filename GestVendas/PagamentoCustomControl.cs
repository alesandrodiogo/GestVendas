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
    public partial class PagamentoCustomControl : UserControl
    {
        public PagamentoCustomControl()
        {
            InitializeComponent();
        }

        private void btnCadFormasPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexaodb.abrir();
                comando.CommandText = "insert into pagamento(formas_pagamento)values('" + txtPagamento.Text+ "')";
                comando.ExecuteNonQuery();
                comando.Connection.Close();

                MessageBox.Show("Dados inserido com sucesso!", "Aviso");
                txtPagamento.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro", "Aviso" + erro);

            }
        }
    }
}
