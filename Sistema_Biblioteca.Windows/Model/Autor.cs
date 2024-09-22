using Microsoft.Data.SqlClient;
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
            //return (from p in DataHelper.ListaAutor select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<Autor> Retorno = new List<Autor>();
                string SQL = $"select id, Nome from Autor";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Autor oAutor = new Autor();
                    oAutor.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oAutor.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oAutor);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static Autor? Seleciona(int Codigo)
        {
            //return (from p in DataHelper.ListaAutor where p.id == Codigo select p).FirstOrDefault();
            using (var oCn = DataHelper.Conexao())
            {
                Autor? Retorno = null;
                string SQL = $"select id, Nome from Autor where id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Autor();
                    Retorno.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static void IncluirAutorStatico(Autor oAutor)
        {
            //Autor? oAutorSelecionado = Autor.Seleciona(oAutor.id);
            //if (oAutorSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no autor {oAutorSelecionado.Nome}.");
            //}
            //else
            //{
            //    DataHelper.ListaAutor.Add(oAutor);
            //}
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into Autor values('{this.Nome.Replace("'","")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
                //Autor? oAutorSelecionado = Autor.Seleciona(this.id);
                //if (oAutorSelecionado != null)
                //{
                //    throw new Exception($"O código informado está sendo utilizado no autor {oAutorSelecionado.Nome}.");
                //}
                //else
                //{
                //    DataHelper.ListaAutor.Add(this);
                //}
            }
        public static void Alterar(Autor oAutor)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Autor set Nome='{oAutor.Nome.Replace("'", "")}' where id={oAutor.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Autor? AutorColecao = Seleciona(oAutor.id);
            //if (AutorColecao == null)
            //{
            //    throw new Exception($"O objeto informado não existe mais no contexto.");
            //}
            //else
            //{
            //    AutorColecao.Nome = oAutor.Nome;
            //}
        }

        public void Excluir()
        {
            DataHelper.ListaAutor.Remove(this);
        }
    }
}
