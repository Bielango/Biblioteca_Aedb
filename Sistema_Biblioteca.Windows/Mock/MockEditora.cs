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
    public class MockEditora
    {
        public static void CarregaEditora()
        {
            List<Editora> oLista = new List<Editora>();

            for (int i = 1; i < 11; i++)
            {
                Editora oEditora = new Editora
                {
                    id = i,
                    Nome = $"Editora {i}"                    
                    
                };
                oLista.Add(oEditora);
            }

            DataHelper.ListaEditora = oLista;
        }
    }
}
