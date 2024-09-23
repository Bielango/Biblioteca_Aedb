using Microsoft.Data.SqlClient;
using Sistema_Biblioteca.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca.Windows.Model
{
    public class GerirUsuario
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

        public static List<GerirUsuario> ListarTodos()
        {
            //return (from p in DataHelper.ListaGerirUsuario select p).ToList();
            using (var oCn = DataHelper.Conexao())
            {
                List<GerirUsuario> Retorno = new List<GerirUsuario>();
                string SQL = $"select id, Nome from GerirUsuario";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while(oDr.Read())
                {
                    GerirUsuario oGerirUsuario = new GerirUsuario();
                    oGerirUsuario.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oGerirUsuario.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    Retorno.Add(oGerirUsuario);
                }
                oDr.Close();
                return Retorno;
            }
            //SqlConnection oCn = DataHelper.Conexao();

            //oCn.Close();
        }

        public static GerirUsuario? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                GerirUsuario? Retorno = null;
                string SQL = $"select id, Nome from GerirUsuario where id={Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Retorno = new GerirUsuario();
                    Retorno.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    Retorno.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                }
                oDr.Close();
                return Retorno;
            }
            //return (from p in DataHelper.ListaGerirUsuario where p.id == Codigo select p).FirstOrDefault();
        }

        public static void IncluirGerirUsuarioStatico(GerirUsuario oGerirUsuario)
        {

            //GerirUsuario? oGerirUsuarioSelecionado = GerirUsuario.Seleciona(oGerirUsuario.id);
            //if(oGerirUsuarioSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no GerirUsuario {oGerirUsuarioSelecionado.Nome}.");
            //}
            //else
            //{ 
            //    DataHelper.ListaGerirUsuario.Add(oGerirUsuario);
            //}
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"insert into GerirUsuario values('{this.Nome.Replace("'","")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //GerirUsuario? oGerirUsuarioSelecionado = GerirUsuario.Seleciona(this.id);
            //if (oGerirUsuarioSelecionado != null)
            //{
            //    throw new Exception($"O código informado está sendo utilizado no GerirUsuario {oGerirUsuarioSelecionado.Nome}.");
            //}
            //else
            //{
            //    DataHelper.ListaGerirUsuario.Add(this);
            //}
        }
        public static void Alterar(GerirUsuario oGerirUsuario)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"update GerirUsuario set Nome='{oGerirUsuario.Nome.Replace("'", "")}' where id={oGerirUsuario.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
            //GerirUsuario? GerirUsuarioColecao = Seleciona(oGerirUsuario.id);
            //if (GerirUsuarioColecao == null)
            //{
            //    throw new Exception($"O objeto informado não existe mais no contexto.");
            //}
            //else
            //{
            //    //GerirUsuarioColecao.id = oGerirUsuario.id;
            //    GerirUsuarioColecao.Nome = oGerirUsuario.Nome;
            //}
        }

        public void Excluir()
        {
            //DataHelper.ListaGerirUsuario.Remove(this);
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"delete from GerirUsuario where id={this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }

        }
        
        //public string? Nome { get; set; }
        //public string Nome { get => _Nome; set => _Nome = value; }
    }
}
