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
    public class MockIdioma
    {
        public static void CarregaIdioma()
        {
            List<Idioma> oLista = new List<Idioma>();

            for (int i = 1; i < 11; i++)
            {
                Idioma oIdioma = new Idioma
                {
                    id = i,
                    Nome = $"Idioma {i}"                    
                    
                };
                oLista.Add(oIdioma);
            }

            DataHelper.ListaIdioma = oLista;
        }
    }
}
