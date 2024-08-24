namespace ProjetoLP3.Janelas
{
    partial class Jn_CadastroUsuario
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
            Tb_Senha = new TextBox();
            Lb_Senha = new Label();
            Tb_Email = new TextBox();
            Lb_Email = new Label();
            Tb_Nome = new TextBox();
            Lb_Nome = new Label();
            Dtp_Data = new DateTimePicker();
            Lb_Idade = new Label();
            Bt_Cadastrar = new Button();
            SuspendLayout();
            // 
            // Tb_Senha
            // 
            Tb_Senha.Location = new Point(66, 41);
            Tb_Senha.Name = "Tb_Senha";
            Tb_Senha.Size = new Size(279, 23);
            Tb_Senha.TabIndex = 9;
            // 
            // Lb_Senha
            // 
            Lb_Senha.AutoSize = true;
            Lb_Senha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Lb_Senha.Location = new Point(12, 42);
            Lb_Senha.Name = "Lb_Senha";
            Lb_Senha.Size = new Size(45, 17);
            Lb_Senha.TabIndex = 8;
            Lb_Senha.Text = "Senha";
            Lb_Senha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tb_Email
            // 
            Tb_Email.Location = new Point(66, 12);
            Tb_Email.Name = "Tb_Email";
            Tb_Email.Size = new Size(279, 23);
            Tb_Email.TabIndex = 7;
            // 
            // Lb_Email
            // 
            Lb_Email.AutoSize = true;
            Lb_Email.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Lb_Email.Location = new Point(10, 13);
            Lb_Email.Name = "Lb_Email";
            Lb_Email.Size = new Size(47, 17);
            Lb_Email.TabIndex = 6;
            Lb_Email.Text = "E-Mail";
            Lb_Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tb_Nome
            // 
            Tb_Nome.Location = new Point(66, 70);
            Tb_Nome.Name = "Tb_Nome";
            Tb_Nome.Size = new Size(279, 23);
            Tb_Nome.TabIndex = 10;
            // 
            // Lb_Nome
            // 
            Lb_Nome.AutoSize = true;
            Lb_Nome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Lb_Nome.Location = new Point(12, 71);
            Lb_Nome.Name = "Lb_Nome";
            Lb_Nome.Size = new Size(45, 17);
            Lb_Nome.TabIndex = 11;
            Lb_Nome.Text = "Nome";
            Lb_Nome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dtp_Data
            // 
            Dtp_Data.Location = new Point(66, 99);
            Dtp_Data.Name = "Dtp_Data";
            Dtp_Data.Size = new Size(279, 23);
            Dtp_Data.TabIndex = 32;
            // 
            // Lb_Idade
            // 
            Lb_Idade.AutoSize = true;
            Lb_Idade.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Lb_Idade.Location = new Point(12, 103);
            Lb_Idade.Name = "Lb_Idade";
            Lb_Idade.Size = new Size(42, 17);
            Lb_Idade.TabIndex = 33;
            Lb_Idade.Text = "Idade";
            Lb_Idade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bt_Cadastrar
            // 
            Bt_Cadastrar.Location = new Point(140, 138);
            Bt_Cadastrar.Name = "Bt_Cadastrar";
            Bt_Cadastrar.Size = new Size(75, 23);
            Bt_Cadastrar.TabIndex = 34;
            Bt_Cadastrar.Text = "Cadastrar";
            Bt_Cadastrar.UseVisualStyleBackColor = true;
            Bt_Cadastrar.Click += Bt_Cadastrar_Click;
            // 
            // Jn_CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 173);
            Controls.Add(Bt_Cadastrar);
            Controls.Add(Lb_Idade);
            Controls.Add(Dtp_Data);
            Controls.Add(Lb_Nome);
            Controls.Add(Tb_Nome);
            Controls.Add(Tb_Senha);
            Controls.Add(Lb_Senha);
            Controls.Add(Tb_Email);
            Controls.Add(Lb_Email);
            MaximizeBox = false;
            Name = "Jn_CadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            Load += Jn_CadastroUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tb_Senha;
        private Label Lb_Senha;
        private TextBox Tb_Email;
        private Label Lb_Email;
        private TextBox Tb_Nome;
        private Label Lb_Nome;
        private DateTimePicker Dtp_Data;
        private Label Lb_Idade;
        private Button Bt_Cadastrar;
    }
}