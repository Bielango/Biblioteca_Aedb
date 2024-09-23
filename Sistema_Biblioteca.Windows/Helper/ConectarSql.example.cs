using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca.Windows.Helper
{
    internal class ConectarSqlExemplo
    {
        static string nomeDesktop = "Cole_aqui_nome_do_pc";
        static string nomeBancoDados = "Cole_aqui_nome_do_banco_de_dados";

        public static string conectar = $"Data Source = {nomeDesktop}; " +
        $"Initial Catalog={nomeBancoDados};" +
        "Integrated Security = True; " +
        "Connect Timeout = 30; Encrypt = True; " +
        "TrustServerCertificate = true;";
    }
}
