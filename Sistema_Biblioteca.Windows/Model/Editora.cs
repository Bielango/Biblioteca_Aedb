using Microsoft.Data.SqlClient;
using Sistema_Biblioteca.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca.Windows.Model
{
    public class Editora
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

        public static List<Editora> ListarTodos()
        {
            //return (from p in DataHelper.ListaEditora select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<Editora> Retorno = new List<Editora>();
                string SQL = $"select id, Nome from Editora";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while(oDr.Read())
                {
                    Editora oEditora = new Editora();
                    oEditora.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oEditora.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oEditora);
                }
                oDr.Close();
                return Retorno;
            }
            //SqlConnection oCn = DataHelper.Conexao();

            //oCn.Close();
        }

        public static Editora? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                Editora? Retorno = null;
                string SQL = $"select id, Nome from Editora where id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new Editora();
                    Retorno.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                }
                oDr.Close();
                return Retorno;
            }
            //return (from p in DataHelper.ListaEditora where p.id == Codigo select p).FirstOrDefault();
        }

        public static void IncluirEditoraStatico(Editora oEditora)
        {

            //Editora? oEditoraSelecionado = Editora.Seleciona(oEditora.id);
            //if(oEditoraSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no editora {oEditoraSelecionado.Nome}.");
            //}
            //else
            //{ 
            //    DataHelper.ListaEditora.Add(oEditora);
            //}
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into Editora values('{this.Nome.Replace("'","")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Editora? oEditoraSelecionado = Editora.Seleciona(this.id);
            //if (oEditoraSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no editora {oEditoraSelecionado.Nome}.");
            //}
            //else
            //{
            //    DataHelper.ListaEditora.Add(this);
            //}
        }
        public static void Alterar(Editora oEditora)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update Editora set Nome='{oEditora.Nome.Replace("'", "")}' where id={oEditora.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //Editora? EditoraColecao = Seleciona(oEditora.id);
            //if (EditoraColecao == null)
            //{
            //    throw new Exception($"O objeto informado não existe mais no contexto.");
            //}
            //else
            //{
            //    //EditoraColecao.id = oEditora.id;
            //    EditoraColecao.Nome = oEditora.Nome;
            //}
        }

        public void Excluir()
        {
            //DataHelper.ListaEditora.Remove(this);
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"delete from Editora where id={this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }
        
        //public string? Nome { get; set; }
        //public string Nome { get => _Nome; set => _Nome = value; }
    }
}
