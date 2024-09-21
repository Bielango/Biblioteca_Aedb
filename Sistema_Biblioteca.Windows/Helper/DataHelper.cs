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
        //pronto
        public static List<Genero> ListaGenero { get; set; }
        //a fazer
        public static List<Autor> ListaAutor { get; set; }

        //conexao com banco de dados
        public static SqlConnection Conexao()
        {
            string strconnection = ConectarSql.conectar;
            SqlConnection oCn = new SqlConnection(strconnection);
            oCn.Open();
            return oCn;
        }

    }
}
