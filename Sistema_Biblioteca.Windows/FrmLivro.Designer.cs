namespace Sistema_Biblioteca.Windows
{
    partial class FrmLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            TxtNome = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            TxtISBN = new TextBox();
            TxtQtdPaginas = new TextBox();
            TxtDescricao = new TextBox();
            TxtEdicao = new TextBox();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            GrdItens = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Edicao = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            QtdPaginas = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            AutorLivro = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            LivroEmprestado = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            TxtCodigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.BackColor = Color.Black;
            TxtNome.ForeColor = SystemColors.Info;
            TxtNome.Location = new Point(71, 24);
            TxtNome.Margin = new Padding(3, 2, 3, 2);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(250, 23);
            TxtNome.TabIndex = 3;
            toolTip1.SetToolTip(TxtNome, "Nome do livro");
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 7);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // TxtISBN
            // 
            TxtISBN.BackColor = Color.Black;
            TxtISBN.ForeColor = SystemColors.Info;
            TxtISBN.Location = new Point(388, 24);
            TxtISBN.Margin = new Padding(3, 2, 3, 2);
            TxtISBN.MaxLength = 50;
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(183, 23);
            TxtISBN.TabIndex = 7;
            toolTip1.SetToolTip(TxtISBN, "Nome do livro");
            TxtISBN.TextChanged += TxtISBN_TextChanged;
            // 
            // TxtQtdPaginas
            // 
            TxtQtdPaginas.BackColor = Color.Black;
            TxtQtdPaginas.ForeColor = SystemColors.Info;
            TxtQtdPaginas.Location = new Point(577, 24);
            TxtQtdPaginas.Margin = new Padding(3, 2, 3, 2);
            TxtQtdPaginas.MaxLength = 50;
            TxtQtdPaginas.Name = "TxtQtdPaginas";
            TxtQtdPaginas.Size = new Size(183, 23);
            TxtQtdPaginas.TabIndex = 15;
            toolTip1.SetToolTip(TxtQtdPaginas, "Nome do livro");
            TxtQtdPaginas.TextChanged += TxtQtdPaginas_TextChanged;
            // 
            // TxtDescricao
            // 
            TxtDescricao.BackColor = Color.Black;
            TxtDescricao.ForeColor = SystemColors.Info;
            TxtDescricao.Location = new Point(23, 77);
            TxtDescricao.Margin = new Padding(3, 2, 3, 2);
            TxtDescricao.MaxLength = 50;
            TxtDescricao.Multiline = true;
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(339, 88);
            TxtDescricao.TabIndex = 18;
            toolTip1.SetToolTip(TxtDescricao, "Nome do livro");
            TxtDescricao.TextChanged += TxtDescricao_TextChanged;
            // 
            // TxtEdicao
            // 
            TxtEdicao.BackColor = Color.Black;
            TxtEdicao.ForeColor = SystemColors.Info;
            TxtEdicao.Location = new Point(327, 24);
            TxtEdicao.Margin = new Padding(3, 2, 3, 2);
            TxtEdicao.MaxLength = 50;
            TxtEdicao.Name = "TxtEdicao";
            TxtEdicao.Size = new Size(46, 23);
            TxtEdicao.TabIndex = 20;
            toolTip1.SetToolTip(TxtEdicao, "Nome do livro");
            TxtEdicao.TextChanged += TxtEdicao_TextChanged_1;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.Gray;
            BtnSalvar.Location = new Point(388, 147);
            BtnSalvar.Margin = new Padding(3, 2, 3, 2);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(155, 31);
            BtnSalvar.TabIndex = 4;
            BtnSalvar.Text = "Sa&lvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.Gray;
            BtnFechar.Location = new Point(613, 147);
            BtnFechar.Margin = new Padding(3, 2, 3, 2);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(155, 31);
            BtnFechar.TabIndex = 5;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += button2_Click;
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.BackgroundColor = Color.Gray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GrdItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Edicao, ISBN, QtdPaginas, Descricao, AutorLivro, Editora, Genero, LivroEmprestado, BtnAlterar, BtnExcluir });
            GrdItens.EnableHeadersVisualStyles = false;
            GrdItens.GridColor = Color.Silver;
            GrdItens.Location = new Point(4, 182);
            GrdItens.Margin = new Padding(3, 2, 3, 2);
            GrdItens.Name = "GrdItens";
            GrdItens.RowHeadersWidth = 51;
            GrdItens.Size = new Size(764, 239);
            GrdItens.TabIndex = 6;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "id";
            dataGridViewCellStyle2.BackColor = Color.Gray;
            Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle3.BackColor = Color.Gray;
            Nome.DefaultCellStyle = dataGridViewCellStyle3;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 200;
            // 
            // Edicao
            // 
            Edicao.HeaderText = "Edição";
            Edicao.Name = "Edicao";
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            // 
            // QtdPaginas
            // 
            QtdPaginas.HeaderText = "QtdPaginas";
            QtdPaginas.Name = "QtdPaginas";
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            // 
            // AutorLivro
            // 
            AutorLivro.DataPropertyName = "id";
            AutorLivro.HeaderText = "Autor";
            AutorLivro.Name = "AutorLivro";
            // 
            // Editora
            // 
            Editora.DataPropertyName = "id";
            Editora.HeaderText = "Editora";
            Editora.Name = "Editora";
            // 
            // Genero
            // 
            Genero.DataPropertyName = "id";
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            // 
            // LivroEmprestado
            // 
            LivroEmprestado.HeaderText = "LivroEmprestado";
            LivroEmprestado.Name = "LivroEmprestado";
            // 
            // BtnAlterar
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Gray;
            BtnAlterar.DefaultCellStyle = dataGridViewCellStyle4;
            BtnAlterar.HeaderText = "Alterar";
            BtnAlterar.MinimumWidth = 6;
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Width = 125;
            // 
            // BtnExcluir
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Gray;
            BtnExcluir.DefaultCellStyle = dataGridViewCellStyle5;
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.MinimumWidth = 6;
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 9);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "ISBN";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(520, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 59);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 10;
            label3.Text = "Autor";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(647, 77);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(388, 77);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 59);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 13;
            label4.Text = "Editora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(647, 59);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 14;
            label5.Text = "Genero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(577, 9);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 16;
            label6.Text = "Quantidade de Paginas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 60);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 17;
            label7.Text = "Descrição";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(327, 7);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 19;
            label8.Text = "Edição";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 7);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 21;
            label9.Text = "Codigo";
            // 
            // TxtCodigo
            // 
            TxtCodigo.BackColor = Color.Black;
            TxtCodigo.ForeColor = SystemColors.Info;
            TxtCodigo.Location = new Point(25, 24);
            TxtCodigo.Margin = new Padding(3, 2, 3, 2);
            TxtCodigo.MaxLength = 50;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(40, 23);
            TxtCodigo.TabIndex = 22;
            toolTip1.SetToolTip(TxtCodigo, "Nome do livro");
            TxtCodigo.TextChanged += TxtCodigo_TextChanged;
            // 
            // FrmLivro
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            CancelButton = BtnFechar;
            ClientSize = new Size(772, 430);
            Controls.Add(label9);
            Controls.Add(TxtCodigo);
            Controls.Add(label8);
            Controls.Add(TxtEdicao);
            Controls.Add(label7);
            Controls.Add(TxtDescricao);
            Controls.Add(label6);
            Controls.Add(TxtQtdPaginas);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(TxtISBN);
            Controls.Add(GrdItens);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(label1);
            Controls.Add(TxtNome);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLivro";
            Text = "Cadastro de livros da Biblioteca";
            Activated += FrmLivro_Activated;
            FormClosed += FrmLivro_FormClosed;
            Load += FrmLivro_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtNome;
        private Label label1;
        private ToolTip toolTip1;
        private Button BtnSalvar;
        private Button BtnFechar;
        private DataGridView GrdItens;
        private TextBox TxtISBN;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label4;
        private Label label5;
        private TextBox TxtQtdPaginas;
        private Label label6;
        private Label label7;
        private TextBox TxtDescricao;
        private Label label8;
        private TextBox TxtEdicao;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Edicao;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn QtdPaginas;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn AutorLivro;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn LivroEmprestado;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
        private Label label9;
        private TextBox TxtCodigo;
    }
}