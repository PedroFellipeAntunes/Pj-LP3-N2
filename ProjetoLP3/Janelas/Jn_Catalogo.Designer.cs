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
            Flp_Catalogo = new FlowLayoutPanel();
            label1 = new Label();
            Bt_Carrinho = new Button();
            panel1 = new Panel();
            btnVerdetalhes = new Button();
            btnAdicionarCarrinho = new Button();
            lbdescricao = new Label();
            lbSelecaoFilme = new Label();
            pboxFilme = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxFilme).BeginInit();
            SuspendLayout();
            // 
            // Flp_Catalogo
            // 
            Flp_Catalogo.Location = new Point(10, 41);
            Flp_Catalogo.Name = "Flp_Catalogo";
            Flp_Catalogo.Size = new Size(747, 191);
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
            panel1.Controls.Add(btnVerdetalhes);
            panel1.Controls.Add(btnAdicionarCarrinho);
            panel1.Controls.Add(lbdescricao);
            panel1.Controls.Add(lbSelecaoFilme);
            panel1.Controls.Add(pboxFilme);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 252);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 120);
            panel1.TabIndex = 3;
            // 
            // btnVerdetalhes
            // 
            btnVerdetalhes.Location = new Point(487, 16);
            btnVerdetalhes.Margin = new Padding(3, 2, 3, 2);
            btnVerdetalhes.Name = "btnVerdetalhes";
            btnVerdetalhes.Size = new Size(181, 22);
            btnVerdetalhes.TabIndex = 4;
            btnVerdetalhes.Text = "Ver detalhes";
            btnVerdetalhes.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCarrinho
            // 
            btnAdicionarCarrinho.Location = new Point(487, 46);
            btnAdicionarCarrinho.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarCarrinho.Name = "btnAdicionarCarrinho";
            btnAdicionarCarrinho.Size = new Size(181, 22);
            btnAdicionarCarrinho.TabIndex = 3;
            btnAdicionarCarrinho.Text = "Adicionar no carrinho";
            btnAdicionarCarrinho.UseVisualStyleBackColor = true;
            // 
            // lbdescricao
            // 
            lbdescricao.AutoSize = true;
            lbdescricao.Location = new Point(145, 46);
            lbdescricao.Name = "lbdescricao";
            lbdescricao.Size = new Size(207, 15);
            lbdescricao.TabIndex = 2;
            lbdescricao.Text = "Aqui vai uma descricao curta do filme";
            // 
            // lbSelecaoFilme
            // 
            lbSelecaoFilme.AutoSize = true;
            lbSelecaoFilme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSelecaoFilme.Location = new Point(145, 14);
            lbSelecaoFilme.Name = "lbSelecaoFilme";
            lbSelecaoFilme.Size = new Size(242, 21);
            lbSelecaoFilme.TabIndex = 1;
            lbSelecaoFilme.Text = "Selecione o filme para aluguel";
            // 
            // pboxFilme
            // 
            pboxFilme.Image = Properties.Resources.iconFilme;
            pboxFilme.Location = new Point(10, 13);
            pboxFilme.Margin = new Padding(3, 2, 3, 2);
            pboxFilme.Name = "pboxFilme";
            pboxFilme.Size = new Size(116, 62);
            pboxFilme.SizeMode = PictureBoxSizeMode.Zoom;
            pboxFilme.TabIndex = 0;
            pboxFilme.TabStop = false;
            // 
            // Jn_Catalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 372);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel Flp_Catalogo;
        private Label label1;
        private Button Bt_Carrinho;
        private Panel panel1;
        private Label lbdescricao;
        private Label lbSelecaoFilme;
        private PictureBox pboxFilme;
        private Button btnAdicionarCarrinho;
        private Button btnVerdetalhes;
    }
}