using Sistema_Biblioteca.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca.Windows.Model
{
    public class Autor
    {
        private int _id;

        private string _Nome;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'", ""); }

        public static List<Autor> ListarTodos()
        {
            return (from p in DataHelper.ListaAutor select p).ToList();
        }

        public static Autor? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaAutor where p.id == Codigo select p).FirstOrDefault();
        }

        public static void IncluirAutorStatico(Autor oAutor)
        {
            Autor? oAutorSelecionado = Autor.Seleciona(oAutor.id);
            if (oAutorSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no autor {oAutorSelecionado.Nome}.");
            }
            else
            {
                DataHelper.ListaAutor.Add(oAutor);
            }
        }

        public void Incluir()
        {
            Autor? oAutorSelecionado = Autor.Seleciona(this.id);
            if (oAutorSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no autor {oAutorSelecionado.Nome}.");
            }
            else
            {
                DataHelper.ListaAutor.Add(this);
            }
        }
        public static void Alterar(Autor oAutor)
        {
            Autor? AutorColecao = Seleciona(oAutor.id);
            if (AutorColecao == null)
            {
                throw new Exception($"O objeto informado não existe mais no contexto.");
            }
            else
            {
                AutorColecao.Nome = oAutor.Nome;
            }
        }

        public void Excluir()
        {
            DataHelper.ListaAutor.Remove(this);
        }
    }
}
