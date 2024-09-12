using Microsoft.Data.SqlClient;
using Sistema_Biblioteca.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca.Windows.Model
{
    public class Genero
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

        public static List<Genero> ListarTodos()
        {
            //return (from p in DataHelper.ListaGenero select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<Genero> Retorno = new List<Genero>();
                string SQL = $"select id, Nome from Genero";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while(oDr.Read())
                {
                    Genero oGenero = new Genero();
                    oGenero.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oGenero.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oGenero);
                }
                oDr.Close();
                return Retorno;
            }
            //SqlConnection oCn = DataHelper.Conexao();

            //oCn.Close();
        }

        public static Genero? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Genero? Retorno = null;
                string SQL = $"select id, Nome from Genero where id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Genero();
                    Retorno.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                }
                oDr.Close();
                return Retorno;
            }
            //return (from p in DataHelper.ListaGenero where p.id == Codigo select p).FirstOrDefault();
        }

        public static void IncluirGeneroStatico(Genero oGenero)
        {

            //Genero? oGeneroSelecionado = Genero.Seleciona(oGenero.id);
            //if(oGeneroSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no gênero {oGeneroSelecionado.Nome}.");
            //}
            //else
            //{ 
            //    DataHelper.ListaGenero.Add(oGenero);
            //}
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into Genero values('{this.Nome.Replace("'","")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Genero? oGeneroSelecionado = Genero.Seleciona(this.id);
            //if (oGeneroSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no gênero {oGeneroSelecionado.Nome}.");
            //}
            //else
            //{
            //    DataHelper.ListaGenero.Add(this);
            //}
        }
        public static void Alterar(Genero oGenero)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Genero set Nome='{oGenero.Nome.Replace("'", "")}' where id={oGenero.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Genero? GeneroColecao = Seleciona(oGenero.id);
            //if (GeneroColecao == null)
            //{
            //    throw new Exception($"O objeto informado não existe mais no contexto.");
            //}
            //else
            //{
            //    //GeneroColecao.id = oGenero.id;
            //    GeneroColecao.Nome = oGenero.Nome;
            //}
        }

        public void Excluir()
        {
            //DataHelper.ListaGenero.Remove(this);
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"delete from Genero where id={this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }
        
        //public string? Nome { get; set; }
        //public string Nome { get => _Nome; set => _Nome = value; }
    }
}
