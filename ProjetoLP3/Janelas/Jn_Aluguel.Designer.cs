namespace ProjetoLP3.Janelas
{
    partial class Jn_Aluguel
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
            Vw_Filmes = new ListView();
            Lb_1 = new Label();
            Bt_Reset = new Button();
            Bt_Remover = new Button();
            Lb_2 = new Label();
            Tb_DataAtual = new TextBox();
            Mc_DataFinal = new MonthCalendar();
            Lb_3 = new Label();
            Tb_DataFinal = new TextBox();
            Tb_HoraFinal = new TextBox();
            Tb_HoraAtual = new TextBox();
            Temporizador = new System.Windows.Forms.Timer(components);
            Tb_Preço = new TextBox();
            Cb_Pagamento = new ComboBox();
            Lb_Pg = new Label();
            Lb_Preço = new Label();
            Bt_Alugar = new Button();
            Tp_HelpReset = new ToolTip(components);
            Tp_HelpRemover = new ToolTip(components);
            Tp_Preço = new ToolTip(components);
            Tp_DataFinal = new ToolTip(components);
            SuspendLayout();
            // 
            // Vw_Filmes
            // 
            Vw_Filmes.Location = new Point(12, 29);
            Vw_Filmes.Name = "Vw_Filmes";
            Vw_Filmes.Size = new Size(322, 91);
            Vw_Filmes.TabIndex = 0;
            Vw_Filmes.UseCompatibleStateImageBehavior = false;
            Vw_Filmes.SelectedIndexChanged += Vw_Filmes_SelectedIndexChanged;
            // 
            // Lb_1
            // 
            Lb_1.AutoSize = true;
            Lb_1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_1.Location = new Point(12, 9);
            Lb_1.Name = "Lb_1";
            Lb_1.Size = new Size(132, 17);
            Lb_1.TabIndex = 1;
            Lb_1.Text = "Filmes Selecionados";
            // 
            // Bt_Reset
            // 
            Bt_Reset.Location = new Point(12, 126);
            Bt_Reset.Name = "Bt_Reset";
            Bt_Reset.Size = new Size(75, 23);
            Bt_Reset.TabIndex = 2;
            Bt_Reset.Text = "Reset";
            Tp_HelpReset.SetToolTip(Bt_Reset, "Desfaz alterações a lista de filmes.");
            Bt_Reset.UseVisualStyleBackColor = true;
            Bt_Reset.Click += Bt_Reset_Click;
            // 
            // Bt_Remover
            // 
            Bt_Remover.Location = new Point(93, 126);
            Bt_Remover.Name = "Bt_Remover";
            Bt_Remover.Size = new Size(75, 23);
            Bt_Remover.TabIndex = 3;
            Bt_Remover.Text = "Remover";
            Tp_HelpRemover.SetToolTip(Bt_Remover, "Remove filmes selecionados da lista.");
            Bt_Remover.UseVisualStyleBackColor = true;
            Bt_Remover.Click += Bt_Remover_Click;
            // 
            // Lb_2
            // 
            Lb_2.AutoSize = true;
            Lb_2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_2.Location = new Point(340, 9);
            Lb_2.Name = "Lb_2";
            Lb_2.Size = new Size(74, 17);
            Lb_2.TabIndex = 5;
            Lb_2.Text = "Data Atual";
            // 
            // Tb_DataAtual
            // 
            Tb_DataAtual.Location = new Point(340, 29);
            Tb_DataAtual.Name = "Tb_DataAtual";
            Tb_DataAtual.ReadOnly = true;
            Tb_DataAtual.Size = new Size(74, 23);
            Tb_DataAtual.TabIndex = 6;
            Tb_DataAtual.TextAlign = HorizontalAlignment.Center;
            // 
            // Mc_DataFinal
            // 
            Mc_DataFinal.Location = new Point(340, 126);
            Mc_DataFinal.Name = "Mc_DataFinal";
            Mc_DataFinal.ShowToday = false;
            Mc_DataFinal.TabIndex = 7;
            // 
            // Lb_3
            // 
            Lb_3.AutoSize = true;
            Lb_3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_3.Location = new Point(340, 74);
            Lb_3.Name = "Lb_3";
            Lb_3.Size = new Size(71, 17);
            Lb_3.TabIndex = 8;
            Lb_3.Text = "Data Final";
            Tp_DataFinal.SetToolTip(Lb_3, "Data final é exatamente 7 dias após a geração do aluguel.");
            // 
            // Tb_DataFinal
            // 
            Tb_DataFinal.Location = new Point(340, 97);
            Tb_DataFinal.Name = "Tb_DataFinal";
            Tb_DataFinal.ReadOnly = true;
            Tb_DataFinal.Size = new Size(74, 23);
            Tb_DataFinal.TabIndex = 9;
            Tb_DataFinal.TextAlign = HorizontalAlignment.Center;
            Tp_Preço.SetToolTip(Tb_DataFinal, "Data final é exatamente 7 dias após a geração do aluguel.");
            // 
            // Tb_HoraFinal
            // 
            Tb_HoraFinal.Location = new Point(420, 97);
            Tb_HoraFinal.Name = "Tb_HoraFinal";
            Tb_HoraFinal.ReadOnly = true;
            Tb_HoraFinal.Size = new Size(74, 23);
            Tb_HoraFinal.TabIndex = 10;
            Tb_HoraFinal.TextAlign = HorizontalAlignment.Center;
            Tp_Preço.SetToolTip(Tb_HoraFinal, "Data final é exatamente 7 dias após a geração do aluguel.");
            // 
            // Tb_HoraAtual
            // 
            Tb_HoraAtual.Location = new Point(420, 29);
            Tb_HoraAtual.Name = "Tb_HoraAtual";
            Tb_HoraAtual.ReadOnly = true;
            Tb_HoraAtual.Size = new Size(74, 23);
            Tb_HoraAtual.TabIndex = 11;
            Tb_HoraAtual.TextAlign = HorizontalAlignment.Center;
            // 
            // Temporizador
            // 
            Temporizador.Interval = 1000;
            Temporizador.Tick += Temporizador_Tick;
            // 
            // Tb_Preço
            // 
            Tb_Preço.Location = new Point(12, 219);
            Tb_Preço.Name = "Tb_Preço";
            Tb_Preço.ReadOnly = true;
            Tb_Preço.Size = new Size(78, 23);
            Tb_Preço.TabIndex = 12;
            Tb_Preço.TextAlign = HorizontalAlignment.Center;
            Tp_Preço.SetToolTip(Tb_Preço, "Taxa de R$ 5,30 por filme.");
            // 
            // Cb_Pagamento
            // 
            Cb_Pagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Pagamento.FormattingEnabled = true;
            Cb_Pagamento.Location = new Point(12, 265);
            Cb_Pagamento.Name = "Cb_Pagamento";
            Cb_Pagamento.Size = new Size(156, 23);
            Cb_Pagamento.TabIndex = 13;
            // 
            // Lb_Pg
            // 
            Lb_Pg.AutoSize = true;
            Lb_Pg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Pg.Location = new Point(12, 245);
            Lb_Pg.Name = "Lb_Pg";
            Lb_Pg.Size = new Size(78, 17);
            Lb_Pg.TabIndex = 14;
            Lb_Pg.Text = "Pagamento";
            // 
            // Lb_Preço
            // 
            Lb_Preço.AutoSize = true;
            Lb_Preço.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Preço.Location = new Point(12, 199);
            Lb_Preço.Name = "Lb_Preço";
            Lb_Preço.Size = new Size(42, 17);
            Lb_Preço.TabIndex = 15;
            Lb_Preço.Text = "Preço";
            Tp_Preço.SetToolTip(Lb_Preço, "Taxa de R$ 5,30 por filme.");
            // 
            // Bt_Alugar
            // 
            Bt_Alugar.Location = new Point(216, 300);
            Bt_Alugar.Name = "Bt_Alugar";
            Bt_Alugar.Size = new Size(148, 28);
            Bt_Alugar.TabIndex = 16;
            Bt_Alugar.Text = "Alugar Filmes";
            Bt_Alugar.UseVisualStyleBackColor = true;
            Bt_Alugar.Click += Bt_Alugar_Click;
            // 
            // Jn_Aluguel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 339);
            Controls.Add(Bt_Alugar);
            Controls.Add(Lb_Preço);
            Controls.Add(Lb_Pg);
            Controls.Add(Cb_Pagamento);
            Controls.Add(Tb_Preço);
            Controls.Add(Tb_HoraAtual);
            Controls.Add(Tb_HoraFinal);
            Controls.Add(Tb_DataFinal);
            Controls.Add(Lb_3);
            Controls.Add(Mc_DataFinal);
            Controls.Add(Tb_DataAtual);
            Controls.Add(Lb_2);
            Controls.Add(Bt_Remover);
            Controls.Add(Bt_Reset);
            Controls.Add(Lb_1);
            Controls.Add(Vw_Filmes);
            Name = "Jn_Aluguel";
            Text = "Aluguel";
            Load += Jn_Aluguel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView Vw_Filmes;
        private Label Lb_1;
        private Button Bt_Reset;
        private Button Bt_Remover;
        private Label Lb_2;
        private TextBox Tb_DataAtual;
        private MonthCalendar Mc_DataFinal;
        private Label Lb_3;
        private TextBox Tb_DataFinal;
        private TextBox Tb_HoraFinal;
        private TextBox Tb_HoraAtual;
        private System.Windows.Forms.Timer Temporizador;
        private TextBox Tb_Preço;
        private ComboBox Cb_Pagamento;
        private Label Lb_Pg;
        private Label Lb_Preço;
        private Button Bt_Alugar;
        private ToolTip Tp_HelpReset;
        private ToolTip Tp_HelpRemover;
        private ToolTip Tp_Preço;
        private ToolTip Tp_DataFinal;
    }
}