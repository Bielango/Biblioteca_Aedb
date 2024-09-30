using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Biblioteca.Windows.Mock;
using Sistema_Biblioteca.Windows.Helper;
using Sistema_Biblioteca.Windows.Model;
using System.Security.Cryptography;

namespace Sistema_Biblioteca.Windows.Mock
{
    public class MockLivro
    {
        public static void CarregaLivro()
        {
            Random novoRandom = new Random(); 

            List<Livro> oLista = new List<Livro>();

            for (int i = 1; i < 11; i++)
            {
                Livro oLivro = new Livro
                {
                    id = i,
                    Nome = $"Livro {i}",
                    Edicao = novoRandom.Next(100),
                    ISBN = $"Livro {i}",
                    QtdPaginas = novoRandom.Next(100),
                    Descricao = $"Livro {i}"
                };
                oLista.Add(oLivro);
            }

            DataHelper.ListaLivro = oLista;
        }
    }
}
