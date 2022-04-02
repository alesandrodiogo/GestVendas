using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestVendas
{
   public static class Conexaodb
    {
        public static SqlConnection abrir()
        {
            string conn = @"Data Source=DESKTOP-BI9CT1E\SQLEXPRESS;Initial Catalog=Venda;Integrated Security=True";
            SqlConnection cn =new  SqlConnection(conn);
            cn.Open();
            return cn;
        }
    }
}
