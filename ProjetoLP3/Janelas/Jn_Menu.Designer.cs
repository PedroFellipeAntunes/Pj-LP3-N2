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
            Bt_Catalogo = new ToolStripMenuItem();
            Bt_MeusFilmes = new ToolStripMenuItem();
            Bt_CadastrarFilme = new ToolStripMenuItem();
            Bt_Conta = new ToolStripMenuItem();
            tstAluguelToolStripMenuItem = new ToolStripMenuItem();
            Bt_Fechar = new ToolStripMenuItem();
            Ms_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Ms_Menu
            // 
            Ms_Menu.Dock = DockStyle.Left;
            Ms_Menu.Items.AddRange(new ToolStripItem[] { Bt_Catalogo, Bt_MeusFilmes, Bt_CadastrarFilme, Bt_Conta, tstAluguelToolStripMenuItem, Bt_Fechar });
            Ms_Menu.Location = new Point(0, 0);
            Ms_Menu.Name = "Ms_Menu";
            Ms_Menu.Size = new Size(126, 360);
            Ms_Menu.TabIndex = 1;
            Ms_Menu.Text = "Ms_Menu";
            // 
            // Bt_Catalogo
            // 
            Bt_Catalogo.Name = "Bt_Catalogo";
            Bt_Catalogo.Size = new Size(113, 19);
            Bt_Catalogo.Text = "Catálogo de Filmes";
            Bt_Catalogo.Click += Bt_Catalogo_Click;
            // 
            // Bt_MeusFilmes
            // 
            Bt_MeusFilmes.Name = "Bt_MeusFilmes";
            Bt_MeusFilmes.Size = new Size(113, 19);
            Bt_MeusFilmes.Text = "Meus Filmes";
            Bt_MeusFilmes.Click += Bt_MeusFilmes_Click;
            // 
            // Bt_CadastrarFilme
            // 
            Bt_CadastrarFilme.Name = "Bt_CadastrarFilme";
            Bt_CadastrarFilme.Size = new Size(113, 19);
            Bt_CadastrarFilme.Text = "Cadastrar Filme";
            Bt_CadastrarFilme.Click += Bt_CadastrarFilmes_Click;
            // 
            // Bt_Conta
            // 
            Bt_Conta.Name = "Bt_Conta";
            Bt_Conta.Size = new Size(113, 19);
            Bt_Conta.Text = "Conta";
            Bt_Conta.Click += Bt_Conta_Click;
            // 
            // tstAluguelToolStripMenuItem
            // 
            tstAluguelToolStripMenuItem.Name = "tstAluguelToolStripMenuItem";
            tstAluguelToolStripMenuItem.Size = new Size(113, 19);
            tstAluguelToolStripMenuItem.Text = "tst aluguel";
            tstAluguelToolStripMenuItem.Click += tstAluguelToolStripMenuItem_Click;
            // 
            // Bt_Fechar
            // 
            Bt_Fechar.Name = "Bt_Fechar";
            Bt_Fechar.Size = new Size(113, 19);
            Bt_Fechar.Text = "FECHAR";
            Bt_Fechar.Click += Bt_Fechar_Click;
            // 
            // Jn_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 360);
            Controls.Add(Ms_Menu);
            IsMdiContainer = true;
            MainMenuStrip = Ms_Menu;
            Name = "Jn_Menu";
            Text = "Menu";
            Load += Jn_Menu_Load;
            Ms_Menu.ResumeLayout(false);
            Ms_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Ms_Menu;
        private ToolStripMenuItem Bt_Conta;
        private ToolStripMenuItem Bt_Catalogo;
        private ToolStripMenuItem Bt_MeusFilmes;
        private ToolStripMenuItem Bt_CadastrarFilme;
        private ToolStripMenuItem tstAluguelToolStripMenuItem;
        private ToolStripMenuItem Bt_Fechar;
    }
}
