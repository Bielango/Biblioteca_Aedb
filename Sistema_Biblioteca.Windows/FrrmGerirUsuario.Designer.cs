namespace Sistema_Biblioteca.Windows
{
    partial class FrmGerirUsuario
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
            TxtCodigo = new TextBox();
            TxtNome = new TextBox();
            LblCodigo = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            BtnSalvar = new Button();
            BtnFechar = new Button();
            GrdItens = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            CbxCargo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // TxtCodigo
            // 
            TxtCodigo.BackColor = SystemColors.InactiveCaptionText;
            TxtCodigo.Enabled = false;
            TxtCodigo.ForeColor = SystemColors.Info;
            TxtCodigo.Location = new Point(23, 24);
            TxtCodigo.Margin = new Padding(3, 2, 3, 2);
            TxtCodigo.MaxLength = 4;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(51, 23);
            TxtCodigo.TabIndex = 1;
            toolTip1.SetToolTip(TxtCodigo, "Código numérico do Gerir Usuário");
            TxtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // TxtNome
            // 
            TxtNome.BackColor = Color.Black;
            TxtNome.ForeColor = SystemColors.Info;
            TxtNome.Location = new Point(79, 24);
            TxtNome.Margin = new Padding(3, 2, 3, 2);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(496, 23);
            TxtNome.TabIndex = 3;
            toolTip1.SetToolTip(TxtNome, "Nome do Gerir Usuário do filme");
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(23, 7);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(46, 15);
            LblCodigo.TabIndex = 0;
            LblCodigo.Text = "Código";
            LblCodigo.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 7);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.Gray;
            BtnSalvar.Location = new Point(31, 68);
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
            BtnFechar.Location = new Point(191, 68);
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
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Cargo, BtnAlterar, BtnExcluir });
            GrdItens.EnableHeadersVisualStyles = false;
            GrdItens.GridColor = Color.Silver;
            GrdItens.Location = new Point(4, 103);
            GrdItens.Margin = new Padding(3, 2, 3, 2);
            GrdItens.Name = "GrdItens";
            GrdItens.RowHeadersWidth = 51;
            GrdItens.Size = new Size(764, 318);
            GrdItens.TabIndex = 6;
            GrdItens.CellClick += GrdItens_CellClick;
            GrdItens.CellContentClick += GrdItens_CellContentClick_1;
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
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
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
            // CbxCargo
            // 
            CbxCargo.BackColor = SystemColors.GrayText;
            CbxCargo.FormattingEnabled = true;
            CbxCargo.Items.AddRange(new object[] { "Bibliotecario", "Cliente", "Administrador" });
            CbxCargo.Location = new Point(603, 24);
            CbxCargo.Name = "CbxCargo";
            CbxCargo.Size = new Size(133, 23);
            CbxCargo.TabIndex = 7;
            CbxCargo.SelectedIndexChanged += CbxCargo_SelectedIndexChanged;
            // 
            // FrmGerirUsuario
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            CancelButton = BtnFechar;
            ClientSize = new Size(772, 430);
            Controls.Add(CbxCargo);
            Controls.Add(GrdItens);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(label1);
            Controls.Add(LblCodigo);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGerirUsuario";
            Text = "Cadastro de Gerir Usuários de Filme";
            Activated += FrmGerirUsuario_Activated;
            FormClosed += FrmGerirUsuario_FormClosed;
            Load += FrmGerirUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private Label LblCodigo;
        private Label label1;
        private ToolTip toolTip1;
        private Button BtnSalvar;
        private Button BtnFechar;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
        private ComboBox CbxCargo;
    }
}