namespace Sistema_Biblioteca.Windows
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            MnuGenero = new ToolStripMenuItem();
            MnuEditora = new ToolStripMenuItem();
            MnuAutor = new ToolStripMenuItem();
            MnuIdioma = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            MnuSair = new ToolStripMenuItem();
            MnuSuspenso = new ContextMenuStrip(components);
            MnSGenero = new ToolStripMenuItem();
            MnSEditora = new ToolStripMenuItem();
            MnSAutor = new ToolStripMenuItem();
            MnSIdioma = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LblDisplay = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            MnuSuspenso.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(879, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { MnuGenero, MnuEditora, MnuAutor, MnuIdioma, toolStripMenuItem2, MnuSair });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(71, 20);
            toolStripMenuItem1.Text = "&Cadastros";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // MnuGenero
            // 
            MnuGenero.Name = "MnuGenero";
            MnuGenero.Size = new Size(180, 22);
            MnuGenero.Text = "&Gênero";
            MnuGenero.Click += MnuGenero_Click;
            // 
            // MnuEditora
            // 
            MnuEditora.Name = "MnuEditora";
            MnuEditora.Size = new Size(180, 22);
            MnuEditora.Text = "&Editora";
            MnuEditora.Click += MnuEditora_Click;
            // 
            // MnuAutor
            // 
            MnuAutor.Name = "MnuAutor";
            MnuAutor.Size = new Size(180, 22);
            MnuAutor.Text = "&Autor";
            MnuAutor.Click += MnuAutor_Click;
            // 
            // MnuIdioma
            // 
            MnuIdioma.Name = "MnuIdioma";
            MnuIdioma.Size = new Size(180, 22);
            MnuIdioma.Text = "&Idioma";
            MnuIdioma.Click += MnuIdioma_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // MnuSair
            // 
            MnuSair.Name = "MnuSair";
            MnuSair.Size = new Size(180, 22);
            MnuSair.Text = "Sai&r";
            MnuSair.Click += sairToolStripMenuItem_Click;
            // 
            // MnuSuspenso
            // 
            MnuSuspenso.ImageScalingSize = new Size(20, 20);
            MnuSuspenso.Items.AddRange(new ToolStripItem[] { MnSGenero, MnSEditora, MnSAutor, MnSIdioma });
            MnuSuspenso.Name = "MnuSuspenso";
            MnuSuspenso.Size = new Size(113, 92);
            // 
            // MnSGenero
            // 
            MnSGenero.Name = "MnSGenero";
            MnSGenero.Size = new Size(112, 22);
            MnSGenero.Text = "&Genêro";
            MnSGenero.Click += MnSGenero_Click;
            // 
            // MnSEditora
            // 
            MnSEditora.Name = "MnSEditora";
            MnSEditora.Size = new Size(112, 22);
            MnSEditora.Text = "&Editora";
            MnSEditora.Click += MnSEditora_Click;
            // 
            // MnSAutor
            // 
            MnSAutor.Name = "MnSAutor";
            MnSAutor.Size = new Size(112, 22);
            MnSAutor.Text = "&Autor";
            MnSAutor.Click += MnSAutor_Click;
            // 
            // MnSIdioma
            // 
            MnSIdioma.Name = "MnSIdioma";
            MnSIdioma.Size = new Size(112, 22);
            MnSIdioma.Text = "&Idioma";
            MnSIdioma.Click += MnSIdioma_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblDisplay });
            statusStrip1.Location = new Point(0, 382);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(879, 24);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblDisplay
            // 
            LblDisplay.AutoSize = false;
            LblDisplay.BackColor = Color.White;
            LblDisplay.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            LblDisplay.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(300, 19);
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(879, 406);
            ContextMenuStrip = MnuSuspenso;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenu";
            Text = "Sistema de Biblioteca";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MnuSuspenso.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem MnuSair;
        public MenuStrip menuStrip1;
        public ContextMenuStrip MnuSuspenso;
        public ToolStripMenuItem MnuGenero;
        public ToolStripMenuItem MnSGenero;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel LblDisplay;
        private ToolStripMenuItem autorToolStripMenuItem;
        public ToolStripMenuItem MnuAutor;
        public ToolStripMenuItem MnSAutor;
        private ToolStripMenuItem MnuIdioma;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem MnSIdioma;
        private ToolStripMenuItem MnuEditora;
        private ToolStripMenuItem MnSEditora;
    }
}
