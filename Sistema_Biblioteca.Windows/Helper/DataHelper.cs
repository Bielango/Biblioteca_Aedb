﻿using Sistema_Biblioteca.Windows.Model;
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
        public static List<Genero> ListaGenero { get; set; }

        public static List<Autor> ListaAutor { get; set; }

        public static List<Editora> ListaEditora { get; set; }

        public static List<Idioma> ListaIdioma { get; set; }

        public static List<GerirUsuario> ListaGerirUsuario { get; set; }

        public static List<Livro> ListaLivro { get; set; }

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
