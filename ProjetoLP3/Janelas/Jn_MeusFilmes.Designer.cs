namespace ProjetoLP3.Janelas
{
    partial class Jn_MeusFilmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jn_MeusFilmes));
            flp_meusFilmes = new FlowLayoutPanel();
            label1 = new Label();
            panelDetalhes = new Panel();
            label2 = new Label();
            Lb_duracao = new Label();
            Lb_etaria = new Label();
            btnAssistir = new Button();
            lbdescricao = new Label();
            lbSelecaoFilme = new Label();
            pboxFilme = new PictureBox();
            panelDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxFilme).BeginInit();
            SuspendLayout();
            // 
            // flp_meusFilmes
            // 
            flp_meusFilmes.Location = new Point(12, 40);
            flp_meusFilmes.Name = "flp_meusFilmes";
            flp_meusFilmes.Size = new Size(854, 322);
            flp_meusFilmes.TabIndex = 0;
            flp_meusFilmes.Paint += flp_meusFilmes_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1722, 28);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // panelDetalhes
            // 
            panelDetalhes.Controls.Add(label2);
            panelDetalhes.Controls.Add(Lb_duracao);
            panelDetalhes.Controls.Add(Lb_etaria);
            panelDetalhes.Controls.Add(btnAssistir);
            panelDetalhes.Controls.Add(lbdescricao);
            panelDetalhes.Controls.Add(lbSelecaoFilme);
            panelDetalhes.Controls.Add(pboxFilme);
            panelDetalhes.Dock = DockStyle.Bottom;
            panelDetalhes.Location = new Point(0, 374);
            panelDetalhes.Name = "panelDetalhes";
            panelDetalhes.Size = new Size(878, 122);
            panelDetalhes.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-12, -9);
            label2.Name = "label2";
            label2.Size = new Size(1725, 20);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Lb_duracao
            // 
            Lb_duracao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_duracao.Location = new Point(539, 74);
            Lb_duracao.Name = "Lb_duracao";
            Lb_duracao.Size = new Size(114, 27);
            Lb_duracao.TabIndex = 9;
            Lb_duracao.Text = "duração";
            Lb_duracao.TextAlign = ContentAlignment.MiddleCenter;
            Lb_duracao.Visible = false;
            // 
            // Lb_etaria
            // 
            Lb_etaria.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_etaria.Location = new Point(539, 35);
            Lb_etaria.Name = "Lb_etaria";
            Lb_etaria.Size = new Size(114, 27);
            Lb_etaria.TabIndex = 8;
            Lb_etaria.Text = "faixa etaria";
            Lb_etaria.TextAlign = ContentAlignment.MiddleCenter;
            Lb_etaria.Visible = false;
            // 
            // btnAssistir
            // 
            btnAssistir.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssistir.Location = new Point(670, 24);
            btnAssistir.Name = "btnAssistir";
            btnAssistir.Size = new Size(171, 67);
            btnAssistir.TabIndex = 7;
            btnAssistir.Text = "Assista ao Filme";
            btnAssistir.UseVisualStyleBackColor = true;
            btnAssistir.Visible = false;
            btnAssistir.Click += btnAssistir_Click;
            // 
            // lbdescricao
            // 
            lbdescricao.Location = new Point(102, 39);
            lbdescricao.Name = "lbdescricao";
            lbdescricao.Size = new Size(446, 77);
            lbdescricao.TabIndex = 6;
            lbdescricao.Text = "Parte exclusivamente dedicada uma descricao curta do filme";
            lbdescricao.Visible = false;
            // 
            // lbSelecaoFilme
            // 
            lbSelecaoFilme.AutoSize = true;
            lbSelecaoFilme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSelecaoFilme.Location = new Point(102, 11);
            lbSelecaoFilme.Name = "lbSelecaoFilme";
            lbSelecaoFilme.Size = new Size(373, 28);
            lbSelecaoFilme.TabIndex = 2;
            lbSelecaoFilme.Text = "Selecione um filme para assistir agora";
            // 
            // pboxFilme
            // 
            pboxFilme.Image = Properties.Resources.iconFilme;
            pboxFilme.Location = new Point(12, 3);
            pboxFilme.Name = "pboxFilme";
            pboxFilme.Size = new Size(75, 111);
            pboxFilme.SizeMode = PictureBoxSizeMode.Zoom;
            pboxFilme.TabIndex = 1;
            pboxFilme.TabStop = false;
            // 
            // Jn_MeusFilmes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 496);
            Controls.Add(panelDetalhes);
            Controls.Add(label1);
            Controls.Add(flp_meusFilmes);
            Name = "Jn_MeusFilmes";
            Text = "Filmes Alugados";
            Load += Jn_MeusFilmes_Load;
            panelDetalhes.ResumeLayout(false);
            panelDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxFilme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_meusFilmes;
        private Label label1;
        private Panel panelDetalhes;
        private PictureBox pboxFilme;
        private Label lbSelecaoFilme;
        private Label lbdescricao;
        private Button btnAssistir;
        private Label Lb_etaria;
        private Label Lb_duracao;
        private Label label2;
    }
}