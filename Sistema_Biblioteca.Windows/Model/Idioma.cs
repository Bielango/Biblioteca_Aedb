using Microsoft.Data.SqlClient;
using Sistema_Biblioteca.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca.Windows.Model
{
    public class Idioma
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

        public static List<Idioma> ListarTodos()
        {
            //return (from p in DataHelper.ListaIdioma select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<Idioma> Retorno = new List<Idioma>();
                string SQL = $"select id, Nome from Idioma";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while(oDr.Read())
                {
                    Idioma oIdioma = new Idioma();
                    oIdioma.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oIdioma.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oIdioma);
                }
                oDr.Close();
                return Retorno;
            }
            //SqlConnection oCn = DataHelper.Conexao();

            //oCn.Close();
        }

        public static Idioma? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Idioma? Retorno = null;
                string SQL = $"select id, Nome from Idioma where id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Idioma();
                    Retorno.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                }
                oDr.Close();
                return Retorno;
            }
            //return (from p in DataHelper.ListaIdioma where p.id == Codigo select p).FirstOrDefault();
        }

        public static void IncluirIdiomaStatico(Idioma oIdioma)
        {

            //Idioma? oIdiomaSelecionado = Idioma.Seleciona(oIdioma.id);
            //if(oIdiomaSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no Idioma {oIdiomaSelecionado.Nome}.");
            //}
            //else
            //{ 
            //    DataHelper.ListaIdioma.Add(oIdioma);
            //}
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into Idioma values('{this.Nome.Replace("'","")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Idioma? oIdiomaSelecionado = Idioma.Seleciona(this.id);
            //if (oIdiomaSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no Idioma {oIdiomaSelecionado.Nome}.");
            //}
            //else
            //{
            //    DataHelper.ListaIdioma.Add(this);
            //}
        }
        public static void Alterar(Idioma oIdioma)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Idioma set Nome='{oIdioma.Nome.Replace("'", "")}' where id={oIdioma.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Idioma? IdiomaColecao = Seleciona(oIdioma.id);
            //if (IdiomaColecao == null)
            //{
            //    throw new Exception($"O objeto informado não existe mais no contexto.");
            //}
            //else
            //{
            //    //IdiomaColecao.id = oIdioma.id;
            //    IdiomaColecao.Nome = oIdioma.Nome;
            //}
        }

        public void Excluir()
        {
            //DataHelper.ListaIdioma.Remove(this);
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"delete from Idioma where id={this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }
        
        //public string? Nome { get; set; }
        //public string Nome { get => _Nome; set => _Nome = value; }
    }
}
