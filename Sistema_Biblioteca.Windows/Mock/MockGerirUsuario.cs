using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Biblioteca.Windows.Mock;
using Sistema_Biblioteca.Windows.Helper;
using Sistema_Biblioteca.Windows.Model;

namespace Sistema_Biblioteca.Windows.Mock
{
    public class MockGerirUsuario
    {
        public static void CarregaGerirUsuario()
        {
            List<GerirUsuario> oLista = new List<GerirUsuario>();

            for (int i = 1; i < 11; i++)
            {
                GerirUsuario oGerirUsuario = new GerirUsuario
                {
                    id = i,
                    Nome = $"GerirUsuario {i}"                    
                    
                };
                oLista.Add(oGerirUsuario);
            }

            DataHelper.ListaGerirUsuario = oLista;
        }
    }
}
