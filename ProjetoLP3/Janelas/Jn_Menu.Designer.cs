namespace ProjetoLP3
{
    partial class Jn_Menu
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
            Ms_Menu = new MenuStrip();
            catálogoDeFilmesToolStripMenuItem = new ToolStripMenuItem();
            meusFilmesToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFilmeToolStripMenuItem = new ToolStripMenuItem();
            contaToolStripMenuItem = new ToolStripMenuItem();
            tstAluguelToolStripMenuItem = new ToolStripMenuItem();
            Ms_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Ms_Menu
            // 
            Ms_Menu.Dock = DockStyle.Left;
            Ms_Menu.Items.AddRange(new ToolStripItem[] { catálogoDeFilmesToolStripMenuItem, meusFilmesToolStripMenuItem, cadastrarFilmeToolStripMenuItem, contaToolStripMenuItem, tstAluguelToolStripMenuItem });
            Ms_Menu.Location = new Point(0, 0);
            Ms_Menu.Name = "Ms_Menu";
            Ms_Menu.Size = new Size(126, 360);
            Ms_Menu.TabIndex = 1;
            Ms_Menu.Text = "Ms_Menu";
            // 
            // catálogoDeFilmesToolStripMenuItem
            // 
            catálogoDeFilmesToolStripMenuItem.Name = "catálogoDeFilmesToolStripMenuItem";
            catálogoDeFilmesToolStripMenuItem.Size = new Size(113, 19);
            catálogoDeFilmesToolStripMenuItem.Text = "Catálogo de Filmes";
            catálogoDeFilmesToolStripMenuItem.Click += abrirJanelaCatalogoFilmes;
            // 
            // meusFilmesToolStripMenuItem
            // 
            meusFilmesToolStripMenuItem.Name = "meusFilmesToolStripMenuItem";
            meusFilmesToolStripMenuItem.Size = new Size(113, 19);
            meusFilmesToolStripMenuItem.Text = "Meus Filmes";
            meusFilmesToolStripMenuItem.Click += abrirJanelaFilmesUsuario;
            // 
            // cadastrarFilmeToolStripMenuItem
            // 
            cadastrarFilmeToolStripMenuItem.Name = "cadastrarFilmeToolStripMenuItem";
            cadastrarFilmeToolStripMenuItem.Size = new Size(113, 19);
            cadastrarFilmeToolStripMenuItem.Text = "Cadastrar Filme";
            cadastrarFilmeToolStripMenuItem.Click += abrirJanelaCadastrarFilme;
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(113, 19);
            contaToolStripMenuItem.Text = "Conta";
            contaToolStripMenuItem.Click += abrirJanelaConta;
            // 
            // tstAluguelToolStripMenuItem
            // 
            tstAluguelToolStripMenuItem.Name = "tstAluguelToolStripMenuItem";
            tstAluguelToolStripMenuItem.Size = new Size(113, 19);
            tstAluguelToolStripMenuItem.Text = "tst aluguel";
            tstAluguelToolStripMenuItem.Click += tstAluguelToolStripMenuItem_Click;
            // 
            // Jn_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 360);
            Controls.Add(Ms_Menu);
            IsMdiContainer = true;
            MainMenuStrip = Ms_Menu;
            Name = "Jn_Menu";
            Text = "Menu";
            Load += Form1_Load;
            Ms_Menu.ResumeLayout(false);
            Ms_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Ms_Menu;
        private ToolStripMenuItem contaToolStripMenuItem;
        private ToolStripMenuItem catálogoDeFilmesToolStripMenuItem;
        private ToolStripMenuItem meusFilmesToolStripMenuItem;
        private ToolStripMenuItem cadastrarFilmeToolStripMenuItem;
        private ToolStripMenuItem tstAluguelToolStripMenuItem;
    }
}
