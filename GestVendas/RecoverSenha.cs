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
    public partial class RecoverSenha : Form
    {
        public RecoverSenha()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login abrir = new Login();
            abrir.Show();
            this.Hide();
        }
    }
}
