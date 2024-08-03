namespace ProjetoLP3.Janelas
{
    partial class Jn_Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jn_Catalogo));
            Flp_Catalogo = new FlowLayoutPanel();
            label1 = new Label();
            Bt_Carrinho = new Button();
            panel1 = new Panel();
            lbLinha = new Label();
            lbdescricao = new Label();
            btnVerdetalhes = new Button();
            btnAdicionarCarrinho = new Button();
            lbSelecaoFilme = new Label();
            pboxFilme = new PictureBox();
            lbFilmesDestaque = new Label();
            pBoxCarrinho = new PictureBox();
            lbContadorCarrinho = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxFilme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCarrinho).BeginInit();
            SuspendLayout();
            // 
            // Flp_Catalogo
            // 
            Flp_Catalogo.AutoScroll = true;
            Flp_Catalogo.FlowDirection = FlowDirection.TopDown;
            Flp_Catalogo.Location = new Point(10, 50);
            Flp_Catalogo.Name = "Flp_Catalogo";
            Flp_Catalogo.Size = new Size(747, 200);
            Flp_Catalogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // Bt_Carrinho
            // 
            Bt_Carrinho.Location = new Point(19, 10);
            Bt_Carrinho.Name = "Bt_Carrinho";
            Bt_Carrinho.Size = new Size(75, 23);
            Bt_Carrinho.TabIndex = 2;
            Bt_Carrinho.Text = "Carrinho";
            Bt_Carrinho.UseVisualStyleBackColor = true;
            Bt_Carrinho.Click += Bt_Carrinho_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbLinha);
            panel1.Controls.Add(lbdescricao);
            panel1.Controls.Add(btnVerdetalhes);
            panel1.Controls.Add(btnAdicionarCarrinho);
            panel1.Controls.Add(lbSelecaoFilme);
            panel1.Controls.Add(pboxFilme);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 252);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 120);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // lbLinha
            // 
            lbLinha.AutoSize = true;
            lbLinha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLinha.Location = new Point(-11, 0);
            lbLinha.Name = "lbLinha";
            lbLinha.Size = new Size(1362, 15);
            lbLinha.TabIndex = 4;
            lbLinha.Text = resources.GetString("lbLinha.Text");
            // 
            // lbdescricao
            // 
            lbdescricao.AutoSize = true;
            lbdescricao.Location = new Point(71, 56);
            lbdescricao.Name = "lbdescricao";
            lbdescricao.Size = new Size(327, 15);
            lbdescricao.TabIndex = 5;
            lbdescricao.Text = "Parte exclusivamente dedicada uma descricao curta do filme";
            lbdescricao.Visible = false;
            // 
            // btnVerdetalhes
            // 
            btnVerdetalhes.Location = new Point(587, 44);
            btnVerdetalhes.Margin = new Padding(3, 2, 3, 2);
            btnVerdetalhes.Name = "btnVerdetalhes";
            btnVerdetalhes.Size = new Size(181, 22);
            btnVerdetalhes.TabIndex = 4;
            btnVerdetalhes.Text = "Ver detalhes";
            btnVerdetalhes.UseVisualStyleBackColor = true;
            btnVerdetalhes.Visible = false;
            btnVerdetalhes.Click += btnVerdetalhes_Click;
            // 
            // btnAdicionarCarrinho
            // 
            btnAdicionarCarrinho.Location = new Point(584, 70);
            btnAdicionarCarrinho.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarCarrinho.Name = "btnAdicionarCarrinho";
            btnAdicionarCarrinho.Size = new Size(181, 22);
            btnAdicionarCarrinho.TabIndex = 3;
            btnAdicionarCarrinho.Text = "Adicionar no carrinho";
            btnAdicionarCarrinho.UseVisualStyleBackColor = true;
            btnAdicionarCarrinho.Visible = false;
            btnAdicionarCarrinho.Click += btnAdicionarCarrinho_Click;
            // 
            // lbSelecaoFilme
            // 
            lbSelecaoFilme.AutoSize = true;
            lbSelecaoFilme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSelecaoFilme.Location = new Point(68, 27);
            lbSelecaoFilme.Name = "lbSelecaoFilme";
            lbSelecaoFilme.Size = new Size(257, 21);
            lbSelecaoFilme.TabIndex = 1;
            lbSelecaoFilme.Text = "Selecione um filme para aluguel";
            // 
            // pboxFilme
            // 
            pboxFilme.Image = Properties.Resources.iconFilme;
            pboxFilme.Location = new Point(19, 26);
            pboxFilme.Margin = new Padding(3, 2, 3, 2);
            pboxFilme.Name = "pboxFilme";
            pboxFilme.Size = new Size(44, 56);
            pboxFilme.SizeMode = PictureBoxSizeMode.Zoom;
            pboxFilme.TabIndex = 0;
            pboxFilme.TabStop = false;
            // 
            // lbFilmesDestaque
            // 
            lbFilmesDestaque.AutoSize = true;
            lbFilmesDestaque.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbFilmesDestaque.Location = new Point(10, 36);
            lbFilmesDestaque.Name = "lbFilmesDestaque";
            lbFilmesDestaque.Size = new Size(1372, 15);
            lbFilmesDestaque.TabIndex = 4;
            lbFilmesDestaque.Text = resources.GetString("lbFilmesDestaque.Text");
            // 
            // pBoxCarrinho
            // 
            pBoxCarrinho.Image = Properties.Resources.iconCarrinho;
            pBoxCarrinho.Location = new Point(100, 10);
            pBoxCarrinho.Margin = new Padding(3, 2, 3, 2);
            pBoxCarrinho.Name = "pBoxCarrinho";
            pBoxCarrinho.Size = new Size(34, 23);
            pBoxCarrinho.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxCarrinho.TabIndex = 5;
            pBoxCarrinho.TabStop = false;
            // 
            // lbContadorCarrinho
            // 
            lbContadorCarrinho.AutoSize = true;
            lbContadorCarrinho.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContadorCarrinho.Location = new Point(113, 7);
            lbContadorCarrinho.Name = "lbContadorCarrinho";
            lbContadorCarrinho.Size = new Size(13, 13);
            lbContadorCarrinho.TabIndex = 6;
            lbContadorCarrinho.Text = "0";
            // 
            // Jn_Catalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(768, 372);
            Controls.Add(lbContadorCarrinho);
            Controls.Add(pBoxCarrinho);
            Controls.Add(lbFilmesDestaque);
            Controls.Add(panel1);
            Controls.Add(Bt_Carrinho);
            Controls.Add(label1);
            Controls.Add(Flp_Catalogo);
            Name = "Jn_Catalogo";
            Text = "Catálogo de Filmes";
            Load += Jn_Catalogo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxFilme).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel Flp_Catalogo;
        private Label label1;
        private Button Bt_Carrinho;
        private Panel panel1;
        private Label lbSelecaoFilme;
        private PictureBox pboxFilme;
        private Button btnAdicionarCarrinho;
        private Button btnVerdetalhes;
        private Label lbdescricao;
        private Label lbLinha;
        private Label lbFilmesDestaque;
        private PictureBox pBoxCarrinho;
        private Label lbContadorCarrinho;
    }
}