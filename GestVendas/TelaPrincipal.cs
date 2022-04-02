using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestVendas
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            SidePanel.Height = btnCaixa.Height;
            SidePanel.Top = btnCaixa.Top;
            caixaCustomControl1.BringToFront();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCaixa.Height;
            SidePanel.Top = btnCaixa.Top;
            caixaCustomControl1.BringToFront();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProdutos.Height;
            SidePanel.Top = btnProdutos.Top;
            produtosCustomControl1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCategorias.Height;
            SidePanel.Top = btnCategorias.Top;
            categoriaCustomControl1.BringToFront();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnFornecedores.Height;
            SidePanel.Top = btnFornecedores.Top;
            fornecedoresCustomControl1.BringToFront();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCliente.Height;
            SidePanel.Top = btnCliente.Top;
            clienteCustomControl1.BringToFront();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnVendedor.Height;
            SidePanel.Top = btnVendedor.Top;
            vendedorCustomControl1.BringToFront();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPagamento.Height;
            SidePanel.Top = btnPagamento.Top;
            pagamentoCustomControl1.BringToFront();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnUsuarios.Height;
            SidePanel.Top = btnUsuarios.Top;
            usuariosCustomControl1.BringToFront();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
    }
}
