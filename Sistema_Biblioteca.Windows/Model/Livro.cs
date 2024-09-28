using Microsoft.Data.SqlClient;
using Sistema_Biblioteca.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca.Windows.Model
{
    public class Livro
    {
        //public int Codigo {  get; set; }
        private int _id;

        private string _Nome;
        public int id
        { 
            get{ return _id; }
            set { _id = value; }
        }
        public string Nome { get => _Nome; set => _Nome = value.Replace("'",""); }

        public static List<Livro> ListarTodos()
        {
            //return (from p in DataHelper.ListaLivro select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<Livro> Retorno = new List<Livro>();
                string SQL = $"select id, Nome from Livro";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while(oDr.Read())
                {
                    Livro oLivro = new Livro();
                    oLivro.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oLivro.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oLivro);
                }
                oDr.Close();
                return Retorno;
            }
            //SqlConnection oCn = DataHelper.Conexao();

            //oCn.Close();
        }

        public static Livro? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Livro? Retorno = null;
                string SQL = $"select id, Nome from Livro where id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Livro();
                    Retorno.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                }
                oDr.Close();
                return Retorno;
            }
            //return (from p in DataHelper.ListaLivro where p.id == Codigo select p).FirstOrDefault();
        }

        public static void IncluirLivroStatico(Livro oLivro)
        {

            //Livro? oLivroSelecionado = Livro.Seleciona(oLivro.id);
            //if(oLivroSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no Livro {oLivroSelecionado.Nome}.");
            //}
            //else
            //{ 
            //    DataHelper.ListaLivro.Add(oLivro);
            //}
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into Livro values('{this.Nome.Replace("'","")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Livro? oLivroSelecionado = Livro.Seleciona(this.id);
            //if (oLivroSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no Livro {oLivroSelecionado.Nome}.");
            //}
            //else
            //{
            //    DataHelper.ListaLivro.Add(this);
            //}
        }
        public static void Alterar(Livro oLivro)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Livro set Nome='{oLivro.Nome.Replace("'", "")}' where id={oLivro.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Livro? LivroColecao = Seleciona(oLivro.id);
            //if (LivroColecao == null)
            //{
            //    throw new Exception($"O objeto informado não existe mais no contexto.");
            //}
            //else
            //{
            //    //LivroColecao.id = oLivro.id;
            //    LivroColecao.Nome = oLivro.Nome;
            //}
        }

        public void Excluir()
        {
            //DataHelper.ListaLivro.Remove(this);
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"delete from Livro where id={this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }
        
        //public string? Nome { get; set; }
        //public string Nome { get => _Nome; set => _Nome = value; }
    }
}
