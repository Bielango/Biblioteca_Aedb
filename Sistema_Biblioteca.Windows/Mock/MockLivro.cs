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
    public class MockLivro
    {
        public static void CarregaLivro()
        {
            List<Livro> oLista = new List<Livro>();

            for (int i = 1; i < 11; i++)
            {
                Livro oLivro = new Livro
                {
                    id = i,
                    Nome = $"Livro {i}",
                    Edicao = $"Livro {i}",
                    ISBN = $"Livro {i}",
                    QtdPaginas = $"Livro {i}",
                    Descricao = $"Livro {i}"
                };
                oLista.Add(oLivro);
            }

            DataHelper.ListaLivro = oLista;
        }
    }
}
