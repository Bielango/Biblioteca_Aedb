using Sistema_Biblioteca.Windows.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Biblioteca.Windows
{
    public partial class FrmLivro : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;

        public FrmLivro(ToolStripMenuItem Mnu1, ToolStripMenuItem Mnu2)
        {
            InitializeComponent();
            _mnu = Mnu1;
            _mnu2 = Mnu2;
        }
        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Livro.ListarTodos();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mnu.Enabled = true;
            _mnu2.Enabled = true;
        }

        private void FrmLivro_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Livros";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaControles()
        {
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }
            //
            if (TxtEdicao.Text.Trim() == "")
            {
                MessageBox.Show("O campo Edicao é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEdicao.Focus();
                return false;
            }
            //
            if (TxtISBN.Text.Trim() == "")
            {
                MessageBox.Show("O campo ISBN é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtISBN.Focus();
                return false;
            }
            //
            if (TxtQtdPaginas.Text.Trim() == "")
            {
                MessageBox.Show("O campo Quantidade de Paginas é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtQtdPaginas.Focus();
                return false;
            }
            //
            if (TxtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("O campo Descrição é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDescricao.Focus();
                return false;
            }
            //

            return true;
        }

        private void LimpaControles()
        {
            TxtNome.Text = "";
            TxtEdicao.Text = "";
            TxtISBN.Text = "";
            TxtQtdPaginas.Text = "";
            TxtDescricao.Text = "";

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Incluir)
                {

                    Livro oLivro = new Livro
                    {
                        //id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text,
                        Edicao = TxtEdicao.Text,
                        ISBN = TxtISBN.Text,
                        QtdPaginas = TxtQtdPaginas.Text,
                        Descricao = TxtDescricao.Text,
                    };

                    try
                    {
                        oLivro.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o Livro: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }
                else
                {

                    Livro oLivro = new Livro
                    {
                        id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };
                    try
                    {

                        Livro.Alterar(oLivro);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = true;
                        TxtCodigo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o Livro: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }

            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {

                Livro objSelecionado = (Livro)GrdItens.Rows[e.RowIndex].DataBoundItem;

                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtCodigo.Text = objSelecionado.id.ToString();
                    TxtNome.Text = objSelecionado.Nome;
                    TxtEdicao.Text = objSelecionado.Edicao;
                    TxtISBN.Text = objSelecionado.ISBN;
                    TxtQtdPaginas.Text = objSelecionado.QtdPaginas;
                    TxtDescricao.Text = objSelecionado.Descricao;
                    TxtNome.Focus();
                    TxtEdicao.Focus();
                    TxtISBN.Focus();
                    TxtQtdPaginas.Focus();
                    TxtDescricao.Focus();
                    TxtCodigo.Enabled = false;
                    Incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Confirme a exclusão.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.Excluir();
                        CarregaGrid();
                    }
                }
            }
        }

        private void GrdItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            //
        }


        private void TxtEdicao_TextChanged_1(object sender, EventArgs e)
        {
            //
        }

        private void TxtDescricao_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void TxtISBN_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void TxtQtdPaginas_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
