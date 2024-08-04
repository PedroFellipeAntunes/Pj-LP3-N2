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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jn_Catalogo));
            Flp_Catalogo = new FlowLayoutPanel();
            label1 = new Label();
            Bt_Carrinho = new Button();
            panel1 = new Panel();
            Lb_etaria = new Label();
            Lb_duracao = new Label();
            lbdescricao = new Label();
            lbLinha = new Label();
            btnAdicionarCarrinho = new Button();
            lbSelecaoFilme = new Label();
            pboxFilme = new PictureBox();
            lbFilmesDestaque = new Label();
            pBoxCarrinho = new PictureBox();
            lbContadorCarrinho = new Label();
            Tb_pesquisar = new TextBox();
            Bt_Editar = new Button();
            Tt_Ajuda = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxFilme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxCarrinho).BeginInit();
            SuspendLayout();
            // 
            // Flp_Catalogo
            // 
            Flp_Catalogo.AutoScroll = true;
            Flp_Catalogo.FlowDirection = FlowDirection.TopDown;
            Flp_Catalogo.Location = new Point(11, 67);
            Flp_Catalogo.Margin = new Padding(3, 4, 3, 4);
            Flp_Catalogo.Name = "Flp_Catalogo";
            Flp_Catalogo.Size = new Size(854, 267);
            Flp_Catalogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 55);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // Bt_Carrinho
            // 
            Bt_Carrinho.Location = new Point(11, 13);
            Bt_Carrinho.Margin = new Padding(3, 4, 3, 4);
            Bt_Carrinho.Name = "Bt_Carrinho";
            Bt_Carrinho.Size = new Size(122, 31);
            Bt_Carrinho.TabIndex = 2;
            Bt_Carrinho.Text = "Carrinho";
            Tt_Ajuda.SetToolTip(Bt_Carrinho, "Mover para a janela de efetuar aluguel de filmes");
            Bt_Carrinho.UseVisualStyleBackColor = true;
            Bt_Carrinho.Click += Bt_Carrinho_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Lb_etaria);
            panel1.Controls.Add(Lb_duracao);
            panel1.Controls.Add(lbdescricao);
            panel1.Controls.Add(lbLinha);
            panel1.Controls.Add(btnAdicionarCarrinho);
            panel1.Controls.Add(lbSelecaoFilme);
            panel1.Controls.Add(pboxFilme);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 336);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 160);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // Lb_etaria
            // 
            Lb_etaria.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_etaria.Location = new Point(557, 68);
            Lb_etaria.Name = "Lb_etaria";
            Lb_etaria.Size = new Size(114, 27);
            Lb_etaria.TabIndex = 7;
            Lb_etaria.Text = "faixa etaria";
            Lb_etaria.TextAlign = ContentAlignment.MiddleCenter;
            Lb_etaria.Visible = false;
            // 
            // Lb_duracao
            // 
            Lb_duracao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_duracao.Location = new Point(557, 119);
            Lb_duracao.Name = "Lb_duracao";
            Lb_duracao.Size = new Size(114, 27);
            Lb_duracao.TabIndex = 6;
            Lb_duracao.Text = "duração";
            Lb_duracao.TextAlign = ContentAlignment.MiddleCenter;
            Lb_duracao.Visible = false;
            // 
            // lbdescricao
            // 
            lbdescricao.Location = new Point(104, 68);
            lbdescricao.Name = "lbdescricao";
            lbdescricao.Size = new Size(446, 77);
            lbdescricao.TabIndex = 5;
            lbdescricao.Text = "Parte exclusivamente dedicada uma descricao curta do filme";
            lbdescricao.Visible = false;
            // 
            // lbLinha
            // 
            lbLinha.AutoSize = true;
            lbLinha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLinha.Location = new Point(-13, 0);
            lbLinha.Name = "lbLinha";
            lbLinha.Size = new Size(1635, 20);
            lbLinha.TabIndex = 4;
            lbLinha.Text = resources.GetString("lbLinha.Text");
            // 
            // btnAdicionarCarrinho
            // 
            btnAdicionarCarrinho.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarCarrinho.Location = new Point(693, 68);
            btnAdicionarCarrinho.Name = "btnAdicionarCarrinho";
            btnAdicionarCarrinho.Size = new Size(171, 67);
            btnAdicionarCarrinho.TabIndex = 3;
            btnAdicionarCarrinho.Text = "Adicionar ao Carrinho";
            btnAdicionarCarrinho.UseVisualStyleBackColor = true;
            btnAdicionarCarrinho.Visible = false;
            btnAdicionarCarrinho.Click += btnAdicionarCarrinho_Click;
            // 
            // lbSelecaoFilme
            // 
            lbSelecaoFilme.AutoSize = true;
            lbSelecaoFilme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSelecaoFilme.Location = new Point(104, 35);
            lbSelecaoFilme.Name = "lbSelecaoFilme";
            lbSelecaoFilme.Size = new Size(317, 28);
            lbSelecaoFilme.TabIndex = 1;
            lbSelecaoFilme.Text = "Selecione um filme para aluguel";
            // 
            // pboxFilme
            // 
            pboxFilme.Image = Properties.Resources.iconFilme;
            pboxFilme.Location = new Point(14, 35);
            pboxFilme.Name = "pboxFilme";
            pboxFilme.Size = new Size(75, 111);
            pboxFilme.SizeMode = PictureBoxSizeMode.Zoom;
            pboxFilme.TabIndex = 0;
            pboxFilme.TabStop = false;
            // 
            // lbFilmesDestaque
            // 
            lbFilmesDestaque.AutoSize = true;
            lbFilmesDestaque.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbFilmesDestaque.Location = new Point(11, 48);
            lbFilmesDestaque.Name = "lbFilmesDestaque";
            lbFilmesDestaque.Size = new Size(1568, 28);
            lbFilmesDestaque.TabIndex = 4;
            lbFilmesDestaque.Text = "---- Filmes em destaque ----------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // pBoxCarrinho
            // 
            pBoxCarrinho.Image = Properties.Resources.iconCarrinho;
            pBoxCarrinho.Location = new Point(141, 13);
            pBoxCarrinho.Name = "pBoxCarrinho";
            pBoxCarrinho.Size = new Size(39, 31);
            pBoxCarrinho.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxCarrinho.TabIndex = 5;
            pBoxCarrinho.TabStop = false;
            Tt_Ajuda.SetToolTip(pBoxCarrinho, "Quantidade de filmes selecionados");
            // 
            // lbContadorCarrinho
            // 
            lbContadorCarrinho.AutoSize = true;
            lbContadorCarrinho.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContadorCarrinho.Location = new Point(155, 9);
            lbContadorCarrinho.Name = "lbContadorCarrinho";
            lbContadorCarrinho.Size = new Size(15, 17);
            lbContadorCarrinho.TabIndex = 6;
            lbContadorCarrinho.Text = "0";
            Tt_Ajuda.SetToolTip(lbContadorCarrinho, "Quantidade de filmes selecionados");
            // 
            // Tb_pesquisar
            // 
            Tb_pesquisar.Location = new Point(186, 16);
            Tb_pesquisar.Margin = new Padding(3, 4, 3, 4);
            Tb_pesquisar.Name = "Tb_pesquisar";
            Tb_pesquisar.PlaceholderText = "Pesquisar";
            Tb_pesquisar.Size = new Size(211, 27);
            Tb_pesquisar.TabIndex = 7;
            Tt_Ajuda.SetToolTip(Tb_pesquisar, "Filtrar filmes por nome");
            Tb_pesquisar.TextChanged += Tb_pesquisar_TextChanged;
            // 
            // Bt_Editar
            // 
            Bt_Editar.Location = new Point(744, 16);
            Bt_Editar.Margin = new Padding(3, 4, 3, 4);
            Bt_Editar.Name = "Bt_Editar";
            Bt_Editar.Size = new Size(121, 31);
            Bt_Editar.TabIndex = 8;
            Bt_Editar.Text = "Editar Filme";
            Tt_Ajuda.SetToolTip(Bt_Editar, "Editar dados do filme selecionado");
            Bt_Editar.UseVisualStyleBackColor = true;
            Bt_Editar.Visible = false;
            Bt_Editar.Click += Bt_Editar_Click;
            // 
            // Jn_Catalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(878, 496);
            Controls.Add(Bt_Editar);
            Controls.Add(Tb_pesquisar);
            Controls.Add(lbContadorCarrinho);
            Controls.Add(pBoxCarrinho);
            Controls.Add(lbFilmesDestaque);
            Controls.Add(panel1);
            Controls.Add(Bt_Carrinho);
            Controls.Add(label1);
            Controls.Add(Flp_Catalogo);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lbdescricao;
        private Label lbLinha;
        private Label lbFilmesDestaque;
        private PictureBox pBoxCarrinho;
        private Label lbContadorCarrinho;
        private Label Lb_etaria;
        private Label Lb_duracao;
        private TextBox Tb_pesquisar;
        private Button Bt_Editar;
        private ToolTip Tt_Ajuda;
    }
}