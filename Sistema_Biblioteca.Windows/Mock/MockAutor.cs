using Sistema_Biblioteca.Windows.Helper;
using Sistema_Biblioteca.Windows.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca.Windows.Mock
{
    public class MockAutor
    {
        public static void CarregaAutor()
        {
            List<Autor> oLista = new List<Autor>();

            for (int i = 1; i < 11; i++)
            {
                Autor oAutor = new Autor
                {
                    id = i,
                    Nome = $"Autor {i}"

                };
                oLista.Add(oAutor);
            }

            DataHelper.ListaAutor = oLista;
        }
    }
}
