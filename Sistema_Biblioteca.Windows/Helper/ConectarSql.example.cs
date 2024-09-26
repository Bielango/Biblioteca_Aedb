using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca.Windows.Helper
{
    internal class ConectarSql
    {
        static string nomeDesktop = "DESKTOP-8TJAN6U";
        static string nomeBancoDados = "biblioteca - classes";

        public static string conectar = $"Data Source = {nomeDesktop}; " +
        $"Initial Catalog={nomeBancoDados};" +
        "Integrated Security = True; " +
        "Connect Timeout = 30; Encrypt = True; " +
        "TrustServerCertificate = true;";
    }
}
