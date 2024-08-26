namespace ProjetoLP3.Janelas
{
    partial class Jn_Login
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
            Bt_Login = new Button();
            Lb_Email = new Label();
            Tb_Email = new TextBox();
            Bt_Cadastrar = new Button();
            label1 = new Label();
            Tb_Senha = new TextBox();
            SuspendLayout();
            // 
            // Bt_Login
            // 
            Bt_Login.Location = new Point(269, 95);
            Bt_Login.Name = "Bt_Login";
            Bt_Login.Size = new Size(75, 23);
            Bt_Login.TabIndex = 0;
            Bt_Login.Text = "Login";
            Bt_Login.UseVisualStyleBackColor = true;
            Bt_Login.Click += Bt_Login_Click;
            // 
            // Lb_Email
            // 
            Lb_Email.AutoSize = true;
            Lb_Email.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Lb_Email.Location = new Point(12, 13);
            Lb_Email.Name = "Lb_Email";
            Lb_Email.Size = new Size(47, 17);
            Lb_Email.TabIndex = 1;
            Lb_Email.Text = "E-Mail";
            Lb_Email.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tb_Email
            // 
            Tb_Email.Location = new Point(65, 12);
            Tb_Email.Name = "Tb_Email";
            Tb_Email.Size = new Size(279, 23);
            Tb_Email.TabIndex = 2;
            // 
            // Bt_Cadastrar
            // 
            Bt_Cadastrar.Location = new Point(12, 95);
            Bt_Cadastrar.Name = "Bt_Cadastrar";
            Bt_Cadastrar.Size = new Size(75, 23);
            Bt_Cadastrar.TabIndex = 3;
            Bt_Cadastrar.Text = "Cadastrar";
            Bt_Cadastrar.UseVisualStyleBackColor = true;
            Bt_Cadastrar.Click += Bt_Cadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 4;
            label1.Text = "Senha";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tb_Senha
            // 
            Tb_Senha.Location = new Point(65, 54);
            Tb_Senha.Name = "Tb_Senha";
            Tb_Senha.Size = new Size(279, 23);
            Tb_Senha.TabIndex = 5;
            // 
            // Jn_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 130);
            Controls.Add(Tb_Senha);
            Controls.Add(label1);
            Controls.Add(Bt_Cadastrar);
            Controls.Add(Tb_Email);
            Controls.Add(Lb_Email);
            Controls.Add(Bt_Login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Jn_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_Login;
        private Label Lb_Email;
        private TextBox Tb_Email;
        private Button Bt_Cadastrar;
        private Label label1;
        private TextBox Tb_Senha;
    }
}