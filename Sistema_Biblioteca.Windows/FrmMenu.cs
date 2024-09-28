namespace Sistema_Biblioteca.Windows
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnuGenero_Click(object sender, EventArgs e)
        {
            FrmGenero oFrm = new FrmGenero(MnuGenero, MnSGenero);
            oFrm.MdiParent = this;
            MnuGenero.Enabled = false;
            MnSGenero.Enabled = false;
            oFrm.Show();
        }

        private void MnuAutor_Click(object sender, EventArgs e)
        {
            FrmAutor oFrm = new FrmAutor(MnuAutor, MnSAutor);
            oFrm.MdiParent = this;
            MnuAutor.Enabled = false;
            MnSAutor.Enabled = false;
            oFrm.Show();
        }

        private void MnuIdioma_Click(object sender, EventArgs e)
        {
            FrmIdioma oFrm = new FrmIdioma(MnuIdioma, MnSIdioma);
            oFrm.MdiParent = this;
            MnuIdioma.Enabled = false;
            MnSIdioma.Enabled = false;
            oFrm.Show();
        }

        private void MnuEditora_Click(object sender, EventArgs e)
        {
            FrmEditora oFrm = new FrmEditora(MnuEditora, MnSEditora);
            oFrm.MdiParent = this;
            MnuEditora.Enabled = false;
            MnSEditora.Enabled = false;
            oFrm.Show();
        }

        private void MnuLivro_Click(object sender, EventArgs e)
        {
            FrmLivro oFrm = new FrmLivro(MnuLivro, MnSLivro);
            oFrm.MdiParent = this;
            MnuLivro.Enabled = false;
            MnSLivro.Enabled = false;
            oFrm.Show();
        }


        private void MnSGenero_Click(object sender, EventArgs e)
        {
            MnuGenero_Click(sender, e);
        }

        private void MnSAutor_Click(object sender, EventArgs e)
        {
            MnuAutor_Click(sender, e);
        }

        private void MnSIdioma_Click(object sender, EventArgs e)
        {
            MnuIdioma_Click(sender, e);
        }

        private void MnSEditora_Click(object sender, EventArgs e)
        {
            MnuEditora_Click(sender, e);
        }

        private void MnSLivro_Click(object sender, EventArgs e)
        {
            MnuLivro_Click(sender, e);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

    }
}
