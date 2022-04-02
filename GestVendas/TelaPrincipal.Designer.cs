namespace GestVendas
{
    partial class TelaPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.usuariosCustomControl1 = new GestVendas.UsuariosCustomControl();
            this.pagamentoCustomControl1 = new GestVendas.PagamentoCustomControl();
            this.vendedorCustomControl1 = new GestVendas.VendedorCustomControl();
            this.clienteCustomControl1 = new GestVendas.ClienteCustomControl();
            this.fornecedoresCustomControl1 = new GestVendas.FornecedoresCustomControl();
            this.categoriaCustomControl1 = new GestVendas.CategoriaCustomControl();
            this.produtosCustomControl1 = new GestVendas.ProdutosCustomControl();
            this.caixaCustomControl1 = new GestVendas.CaixaCustomControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnCalculadora);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnPagamento);
            this.panel1.Controls.Add(this.btnVendedor);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.btnFornecedores);
            this.panel1.Controls.Add(this.btnCategorias);
            this.panel1.Controls.Add(this.btnProdutos);
            this.panel1.Controls.Add(this.btnCaixa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 769);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(15, 83);
            this.SidePanel.TabIndex = 2;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(34, 598);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(266, 63);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "     Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.FlatAppearance.BorderSize = 0;
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.Color.White;
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagamento.Location = new System.Drawing.Point(34, 518);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(266, 63);
            this.btnPagamento.TabIndex = 8;
            this.btnPagamento.Text = "     Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnVendedor
            // 
            this.btnVendedor.FlatAppearance.BorderSize = 0;
            this.btnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedor.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendedor.ForeColor = System.Drawing.Color.White;
            this.btnVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnVendedor.Image")));
            this.btnVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendedor.Location = new System.Drawing.Point(34, 440);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(263, 63);
            this.btnVendedor.TabIndex = 7;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(34, 360);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(263, 63);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.FlatAppearance.BorderSize = 0;
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedores.ForeColor = System.Drawing.Color.White;
            this.btnFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedores.Image")));
            this.btnFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedores.Location = new System.Drawing.Point(34, 277);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(263, 63);
            this.btnFornecedores.TabIndex = 5;
            this.btnFornecedores.Text = "    Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(34, 198);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(266, 63);
            this.btnCategorias.TabIndex = 4;
            this.btnCategorias.Text = "Categoria";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(34, 104);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(263, 63);
            this.btnProdutos.TabIndex = 3;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnCaixa.Image")));
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(31, 4);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(266, 63);
            this.btnCaixa.TabIndex = 2;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 29);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(933, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "─";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(974, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.FlatAppearance.BorderSize = 0;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.ForeColor = System.Drawing.Color.White;
            this.btnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.Image")));
            this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.Location = new System.Drawing.Point(31, 667);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(266, 63);
            this.btnCalculadora.TabIndex = 9;
            this.btnCalculadora.Text = "     Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // usuariosCustomControl1
            // 
            this.usuariosCustomControl1.Location = new System.Drawing.Point(300, 45);
            this.usuariosCustomControl1.Name = "usuariosCustomControl1";
            this.usuariosCustomControl1.Size = new System.Drawing.Size(1012, 724);
            this.usuariosCustomControl1.TabIndex = 9;
            // 
            // pagamentoCustomControl1
            // 
            this.pagamentoCustomControl1.Location = new System.Drawing.Point(300, 45);
            this.pagamentoCustomControl1.Name = "pagamentoCustomControl1";
            this.pagamentoCustomControl1.Size = new System.Drawing.Size(1012, 724);
            this.pagamentoCustomControl1.TabIndex = 8;
            // 
            // vendedorCustomControl1
            // 
            this.vendedorCustomControl1.Location = new System.Drawing.Point(300, 45);
            this.vendedorCustomControl1.Name = "vendedorCustomControl1";
            this.vendedorCustomControl1.Size = new System.Drawing.Size(1012, 724);
            this.vendedorCustomControl1.TabIndex = 7;
            // 
            // clienteCustomControl1
            // 
            this.clienteCustomControl1.Location = new System.Drawing.Point(300, 45);
            this.clienteCustomControl1.Name = "clienteCustomControl1";
            this.clienteCustomControl1.Size = new System.Drawing.Size(1012, 724);
            this.clienteCustomControl1.TabIndex = 6;
            // 
            // fornecedoresCustomControl1
            // 
            this.fornecedoresCustomControl1.Location = new System.Drawing.Point(300, 45);
            this.fornecedoresCustomControl1.Name = "fornecedoresCustomControl1";
            this.fornecedoresCustomControl1.Size = new System.Drawing.Size(1012, 724);
            this.fornecedoresCustomControl1.TabIndex = 5;
            // 
            // categoriaCustomControl1
            // 
            this.categoriaCustomControl1.Location = new System.Drawing.Point(300, 45);
            this.categoriaCustomControl1.Name = "categoriaCustomControl1";
            this.categoriaCustomControl1.Size = new System.Drawing.Size(1012, 724);
            this.categoriaCustomControl1.TabIndex = 4;
            // 
            // produtosCustomControl1
            // 
            this.produtosCustomControl1.Location = new System.Drawing.Point(300, 35);
            this.produtosCustomControl1.Name = "produtosCustomControl1";
            this.produtosCustomControl1.Size = new System.Drawing.Size(1012, 731);
            this.produtosCustomControl1.TabIndex = 3;
            // 
            // caixaCustomControl1
            // 
            this.caixaCustomControl1.Location = new System.Drawing.Point(300, 35);
            this.caixaCustomControl1.Name = "caixaCustomControl1";
            this.caixaCustomControl1.Size = new System.Drawing.Size(1012, 731);
            this.caixaCustomControl1.TabIndex = 2;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 769);
            this.Controls.Add(this.usuariosCustomControl1);
            this.Controls.Add(this.pagamentoCustomControl1);
            this.Controls.Add(this.vendedorCustomControl1);
            this.Controls.Add(this.clienteCustomControl1);
            this.Controls.Add(this.fornecedoresCustomControl1);
            this.Controls.Add(this.categoriaCustomControl1);
            this.Controls.Add(this.produtosCustomControl1);
            this.Controls.Add(this.caixaCustomControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCaixa;
        private CaixaCustomControl caixaCustomControl1;
        private ProdutosCustomControl produtosCustomControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CategoriaCustomControl categoriaCustomControl1;
        private FornecedoresCustomControl fornecedoresCustomControl1;
        private ClienteCustomControl clienteCustomControl1;
        private VendedorCustomControl vendedorCustomControl1;
        private PagamentoCustomControl pagamentoCustomControl1;
        private UsuariosCustomControl usuariosCustomControl1;
        private System.Windows.Forms.Button btnCalculadora;
    }
}