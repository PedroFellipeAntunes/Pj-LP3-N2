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
            label2 = new Label();
            Gb_InfoFilme = new GroupBox();
            label4 = new Label();
            Vsb_Catalogo = new VScrollBar();
            Gb_InfoFilme.SuspendLayout();
            SuspendLayout();
            // 
            // Flp_Catalogo
            // 
            Flp_Catalogo.Location = new Point(115, 93);
            Flp_Catalogo.Margin = new Padding(3, 4, 3, 4);
            Flp_Catalogo.Name = "Flp_Catalogo";
            Flp_Catalogo.Size = new Size(313, 180);
            Flp_Catalogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 55);
            label1.Name = "label1";
            label1.Size = new Size(547, 20);
            label1.TabIndex = 1;
            label1.Text = "Use isto aqui, é um flowlayout, tu vai adicionar atravez de codigo os botoes aqui!";
            // 
            // Bt_Carrinho
            // 
            Bt_Carrinho.Location = new Point(81, 16);
            Bt_Carrinho.Margin = new Padding(3, 4, 3, 4);
            Bt_Carrinho.Name = "Bt_Carrinho";
            Bt_Carrinho.Size = new Size(86, 31);
            Bt_Carrinho.TabIndex = 2;
            Bt_Carrinho.Text = "Carrinho";
            Bt_Carrinho.UseVisualStyleBackColor = true;
            Bt_Carrinho.Click += Bt_Carrinho_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 317);
            label2.Name = "label2";
            label2.Size = new Size(621, 20);
            label2.TabIndex = 3;
            label2.Text = "Em baixo tu vai ter a barra com as informações do filme e a opção de adicionar ao carrinho!\r\n";
            // 
            // Gb_InfoFilme
            // 
            Gb_InfoFilme.AutoSize = true;
            Gb_InfoFilme.Controls.Add(label4);
            Gb_InfoFilme.Dock = DockStyle.Bottom;
            Gb_InfoFilme.Location = new Point(0, 427);
            Gb_InfoFilme.Margin = new Padding(3, 4, 3, 4);
            Gb_InfoFilme.Name = "Gb_InfoFilme";
            Gb_InfoFilme.Padding = new Padding(3, 4, 3, 4);
            Gb_InfoFilme.Size = new Size(878, 69);
            Gb_InfoFilme.TabIndex = 5;
            Gb_InfoFilme.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 25);
            label4.Name = "label4";
            label4.Size = new Size(272, 20);
            label4.TabIndex = 0;
            label4.Text = "Aqui dentro vai ter os detalhes do filme";
            // 
            // Vsb_Catalogo
            // 
            Vsb_Catalogo.Location = new Point(794, 127);
            Vsb_Catalogo.Name = "Vsb_Catalogo";
            Vsb_Catalogo.Size = new Size(17, 107);
            Vsb_Catalogo.TabIndex = 6;
            // 
            // Jn_Catalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 496);
            Controls.Add(Vsb_Catalogo);
            Controls.Add(Gb_InfoFilme);
            Controls.Add(label2);
            Controls.Add(Bt_Carrinho);
            Controls.Add(label1);
            Controls.Add(Flp_Catalogo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Jn_Catalogo";
            Text = "Catálogo de Filmes";
            Load += Jn_Catalogo_Load;
            Gb_InfoFilme.ResumeLayout(false);
            Gb_InfoFilme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel Flp_Catalogo;
        private Label label1;
        private Button Bt_Carrinho;
        private Label label2;
        private GroupBox Gb_InfoFilme;
        private Label label4;
        private VScrollBar Vsb_Catalogo;
    }
}