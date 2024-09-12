using Sistema_Biblioteca.Windows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Sistema_Biblioteca.Windows.Helper
{
    public static class DataHelper
    {
        public static List<Autor> ListaAutor { get; set; }
        public static List<Genero> ListaGenero { get; set; }
        public static SqlConnection Conexao()
        {
            string strconnection = "Data Source = DESKTOP-8TJAN6U; Initial Catalog=biblioteca - classes;Integrated Security = True; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = true;";
            SqlConnection oCn = new SqlConnection(strconnection);
            oCn.Open();
            return oCn;
        }

    }
}
