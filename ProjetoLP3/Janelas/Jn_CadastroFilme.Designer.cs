namespace ProjetoLP3.Janelas
{
    partial class Jn_CadastroFilme
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
            Lb_1 = new Label();
            Tb_Nome = new TextBox();
            Lb_2 = new Label();
            Tb_Descrição = new TextBox();
            Mtb_FaixaEtaria = new MaskedTextBox();
            Lb_3 = new Label();
            Lb_4 = new Label();
            Mtb_Duração = new MaskedTextBox();
            Pb_Foto = new PictureBox();
            Bt_Imagem = new Button();
            Clb_Genero = new CheckedListBox();
            Lb_5 = new Label();
            Lb_6 = new Label();
            Clb_Pais = new CheckedListBox();
            Tp_Genero = new ToolTip(components);
            Tp_Pais = new ToolTip(components);
            Tp_Duração = new ToolTip(components);
            Cb_Status = new CheckBox();
            Bt_Cadastrar = new Button();
            Bt_Video = new Button();
            Gb_InfoFilme = new GroupBox();
            Bt_Apagar = new Button();
            ((System.ComponentModel.ISupportInitialize)Pb_Foto).BeginInit();
            Gb_InfoFilme.SuspendLayout();
            SuspendLayout();
            // 
            // Lb_1
            // 
            Lb_1.AutoSize = true;
            Lb_1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_1.Location = new Point(12, 9);
            Lb_1.Name = "Lb_1";
            Lb_1.Size = new Size(103, 17);
            Lb_1.TabIndex = 2;
            Lb_1.Text = "Nome do Filme";
            // 
            // Tb_Nome
            // 
            Tb_Nome.Location = new Point(12, 29);
            Tb_Nome.Name = "Tb_Nome";
            Tb_Nome.Size = new Size(303, 23);
            Tb_Nome.TabIndex = 3;
            // 
            // Lb_2
            // 
            Lb_2.AutoSize = true;
            Lb_2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_2.Location = new Point(12, 64);
            Lb_2.Name = "Lb_2";
            Lb_2.Size = new Size(67, 17);
            Lb_2.TabIndex = 4;
            Lb_2.Text = "Descrição";
            // 
            // Tb_Descrição
            // 
            Tb_Descrição.Location = new Point(12, 84);
            Tb_Descrição.Multiline = true;
            Tb_Descrição.Name = "Tb_Descrição";
            Tb_Descrição.ScrollBars = ScrollBars.Vertical;
            Tb_Descrição.Size = new Size(303, 94);
            Tb_Descrição.TabIndex = 5;
            // 
            // Mtb_FaixaEtaria
            // 
            Mtb_FaixaEtaria.Location = new Point(12, 211);
            Mtb_FaixaEtaria.Mask = "00";
            Mtb_FaixaEtaria.Name = "Mtb_FaixaEtaria";
            Mtb_FaixaEtaria.PromptChar = ' ';
            Mtb_FaixaEtaria.Size = new Size(79, 23);
            Mtb_FaixaEtaria.TabIndex = 6;
            Mtb_FaixaEtaria.TextAlign = HorizontalAlignment.Right;
            Mtb_FaixaEtaria.ValidatingType = typeof(int);
            // 
            // Lb_3
            // 
            Lb_3.AutoSize = true;
            Lb_3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_3.Location = new Point(12, 191);
            Lb_3.Name = "Lb_3";
            Lb_3.Size = new Size(79, 17);
            Lb_3.TabIndex = 7;
            Lb_3.Text = "Faixa Etária";
            Lb_3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Lb_4
            // 
            Lb_4.AutoSize = true;
            Lb_4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_4.Location = new Point(219, 191);
            Lb_4.Name = "Lb_4";
            Lb_4.Size = new Size(59, 17);
            Lb_4.TabIndex = 8;
            Lb_4.Text = "Duração";
            Lb_4.TextAlign = ContentAlignment.MiddleLeft;
            Tp_Duração.SetToolTip(Lb_4, "Duração do filme em segundos.");
            // 
            // Mtb_Duração
            // 
            Mtb_Duração.Location = new Point(219, 211);
            Mtb_Duração.Mask = "000000";
            Mtb_Duração.Name = "Mtb_Duração";
            Mtb_Duração.PromptChar = ' ';
            Mtb_Duração.Size = new Size(96, 23);
            Mtb_Duração.TabIndex = 9;
            Mtb_Duração.TextAlign = HorizontalAlignment.Right;
            Tp_Duração.SetToolTip(Mtb_Duração, "Duração do filme em segundos.");
            Mtb_Duração.ValidatingType = typeof(int);
            // 
            // Pb_Foto
            // 
            Pb_Foto.BackColor = SystemColors.ControlLight;
            Pb_Foto.Location = new Point(336, 9);
            Pb_Foto.Name = "Pb_Foto";
            Pb_Foto.Size = new Size(126, 169);
            Pb_Foto.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Foto.TabIndex = 10;
            Pb_Foto.TabStop = false;
            // 
            // Bt_Imagem
            // 
            Bt_Imagem.Location = new Point(336, 188);
            Bt_Imagem.Name = "Bt_Imagem";
            Bt_Imagem.Size = new Size(126, 23);
            Bt_Imagem.TabIndex = 11;
            Bt_Imagem.Text = "Adicionar Imagem";
            Bt_Imagem.UseVisualStyleBackColor = true;
            Bt_Imagem.Click += Bt_Imagem_Click;
            // 
            // Clb_Genero
            // 
            Clb_Genero.FormattingEnabled = true;
            Clb_Genero.Location = new Point(481, 29);
            Clb_Genero.Name = "Clb_Genero";
            Clb_Genero.Size = new Size(143, 220);
            Clb_Genero.TabIndex = 12;
            Tp_Genero.SetToolTip(Clb_Genero, "Genero de filme");
            // 
            // Lb_5
            // 
            Lb_5.AutoSize = true;
            Lb_5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_5.Location = new Point(481, 9);
            Lb_5.Name = "Lb_5";
            Lb_5.Size = new Size(52, 17);
            Lb_5.TabIndex = 13;
            Lb_5.Text = "Genero";
            Tp_Genero.SetToolTip(Lb_5, "Genero de filme");
            // 
            // Lb_6
            // 
            Lb_6.AutoSize = true;
            Lb_6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_6.Location = new Point(630, 9);
            Lb_6.Name = "Lb_6";
            Lb_6.Size = new Size(33, 17);
            Lb_6.TabIndex = 14;
            Lb_6.Text = "País";
            Tp_Pais.SetToolTip(Lb_6, "País onde o filme é permitido");
            // 
            // Clb_Pais
            // 
            Clb_Pais.FormattingEnabled = true;
            Clb_Pais.Location = new Point(630, 29);
            Clb_Pais.Name = "Clb_Pais";
            Clb_Pais.Size = new Size(141, 220);
            Clb_Pais.TabIndex = 15;
            Tp_Pais.SetToolTip(Clb_Pais, "País onde o filme é permitido");
            // 
            // Cb_Status
            // 
            Cb_Status.AutoSize = true;
            Cb_Status.Location = new Point(336, 25);
            Cb_Status.Name = "Cb_Status";
            Cb_Status.Size = new Size(58, 19);
            Cb_Status.TabIndex = 19;
            Cb_Status.Text = "Status";
            Cb_Status.TextAlign = ContentAlignment.MiddleCenter;
            Tp_Duração.SetToolTip(Cb_Status, "Define se o filme está liberado para os clientes");
            Cb_Status.UseVisualStyleBackColor = true;
            // 
            // Bt_Cadastrar
            // 
            Bt_Cadastrar.Location = new Point(198, 22);
            Bt_Cadastrar.Name = "Bt_Cadastrar";
            Bt_Cadastrar.Size = new Size(117, 23);
            Bt_Cadastrar.TabIndex = 16;
            Bt_Cadastrar.Text = "Cadastrar Filme";
            Bt_Cadastrar.UseVisualStyleBackColor = true;
            Bt_Cadastrar.Click += Bt_Cadastrar_Click;
            // 
            // Bt_Video
            // 
            Bt_Video.Location = new Point(12, 22);
            Bt_Video.Name = "Bt_Video";
            Bt_Video.Size = new Size(172, 23);
            Bt_Video.TabIndex = 17;
            Bt_Video.Text = "Adicionar Arquivo de Video";
            Bt_Video.UseVisualStyleBackColor = true;
            Bt_Video.Click += Bt_Video_Click;
            // 
            // Gb_InfoFilme
            // 
            Gb_InfoFilme.AutoSize = true;
            Gb_InfoFilme.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Gb_InfoFilme.Controls.Add(Cb_Status);
            Gb_InfoFilme.Controls.Add(Bt_Apagar);
            Gb_InfoFilme.Controls.Add(Bt_Video);
            Gb_InfoFilme.Controls.Add(Bt_Cadastrar);
            Gb_InfoFilme.Dock = DockStyle.Bottom;
            Gb_InfoFilme.Location = new Point(0, 266);
            Gb_InfoFilme.Margin = new Padding(0);
            Gb_InfoFilme.Name = "Gb_InfoFilme";
            Gb_InfoFilme.Padding = new Padding(0);
            Gb_InfoFilme.Size = new Size(783, 64);
            Gb_InfoFilme.TabIndex = 18;
            Gb_InfoFilme.TabStop = false;
            // 
            // Bt_Apagar
            // 
            Bt_Apagar.Location = new Point(651, 22);
            Bt_Apagar.Name = "Bt_Apagar";
            Bt_Apagar.Size = new Size(120, 23);
            Bt_Apagar.TabIndex = 18;
            Bt_Apagar.Text = "Apagar Filme";
            Bt_Apagar.UseVisualStyleBackColor = true;
            Bt_Apagar.Visible = false;
            Bt_Apagar.Click += Bt_Apagar_Click;
            // 
            // Jn_CadastroFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 330);
            Controls.Add(Gb_InfoFilme);
            Controls.Add(Clb_Pais);
            Controls.Add(Lb_6);
            Controls.Add(Lb_5);
            Controls.Add(Clb_Genero);
            Controls.Add(Bt_Imagem);
            Controls.Add(Pb_Foto);
            Controls.Add(Mtb_Duração);
            Controls.Add(Lb_4);
            Controls.Add(Lb_3);
            Controls.Add(Mtb_FaixaEtaria);
            Controls.Add(Tb_Descrição);
            Controls.Add(Lb_2);
            Controls.Add(Tb_Nome);
            Controls.Add(Lb_1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Jn_CadastroFilme";
            Text = "Cadastrar Filme";
            Load += Jn_CadastroFilme_Load;
            ((System.ComponentModel.ISupportInitialize)Pb_Foto).EndInit();
            Gb_InfoFilme.ResumeLayout(false);
            Gb_InfoFilme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_1;
        private TextBox Tb_Nome;
        private Label Lb_2;
        private TextBox Tb_Descrição;
        private MaskedTextBox Mtb_FaixaEtaria;
        private Label Lb_3;
        private Label Lb_4;
        private MaskedTextBox Mtb_Duração;
        private PictureBox Pb_Foto;
        private Button Bt_Imagem;
        private CheckedListBox Clb_Genero;
        private ToolTip Tp_Duração;
        private ToolTip Tp_Genero;
        private Label Lb_5;
        private Label Lb_6;
        private ToolTip Tp_Pais;
        private CheckedListBox Clb_Pais;
        private Button Bt_Cadastrar;
        private Button Bt_Video;
        private GroupBox Gb_InfoFilme;
        private Button Bt_Apagar;
        private CheckBox Cb_Status;
    }
}