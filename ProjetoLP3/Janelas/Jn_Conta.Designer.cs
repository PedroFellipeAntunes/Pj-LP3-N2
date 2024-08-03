namespace ProjetoLP3.Janelas
{
    partial class Jn_Conta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Pb_Usuario = new PictureBox();
            Pb_PqIdade = new PictureBox();
            Pb_PqEmail = new PictureBox();
            Pb_PqUsuario = new PictureBox();
            Bt_SalvarEditar = new Button();
            Tb_Nome = new TextBox();
            Mtb_Idade = new MaskedTextBox();
            Tb_Email = new TextBox();
            Lb_1 = new Label();
            label1 = new Label();
            label2 = new Label();
            Bt_Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)Pb_Usuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_PqIdade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_PqEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_PqUsuario).BeginInit();
            SuspendLayout();
            // 
            // Pb_Usuario
            // 
            Pb_Usuario.BackColor = SystemColors.ControlDark;
            Pb_Usuario.Image = Properties.Resources.userIcons;
            Pb_Usuario.InitialImage = Properties.Resources.userIcons;
            Pb_Usuario.Location = new Point(361, 30);
            Pb_Usuario.Name = "Pb_Usuario";
            Pb_Usuario.Size = new Size(165, 165);
            Pb_Usuario.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Usuario.TabIndex = 5;
            Pb_Usuario.TabStop = false;
            // 
            // Pb_PqIdade
            // 
            Pb_PqIdade.Image = Properties.Resources.IdadeIcon;
            Pb_PqIdade.InitialImage = Properties.Resources.IdadeIcon;
            Pb_PqIdade.Location = new Point(12, 170);
            Pb_PqIdade.Name = "Pb_PqIdade";
            Pb_PqIdade.Size = new Size(25, 25);
            Pb_PqIdade.TabIndex = 13;
            Pb_PqIdade.TabStop = false;
            // 
            // Pb_PqEmail
            // 
            Pb_PqEmail.Image = Properties.Resources.EmailIcon;
            Pb_PqEmail.InitialImage = Properties.Resources.EmailIcon;
            Pb_PqEmail.Location = new Point(12, 97);
            Pb_PqEmail.Name = "Pb_PqEmail";
            Pb_PqEmail.Size = new Size(25, 25);
            Pb_PqEmail.TabIndex = 12;
            Pb_PqEmail.TabStop = false;
            // 
            // Pb_PqUsuario
            // 
            Pb_PqUsuario.Image = Properties.Resources.editarIcon;
            Pb_PqUsuario.InitialImage = Properties.Resources.userIcons;
            Pb_PqUsuario.Location = new Point(12, 30);
            Pb_PqUsuario.Name = "Pb_PqUsuario";
            Pb_PqUsuario.Size = new Size(24, 24);
            Pb_PqUsuario.TabIndex = 17;
            Pb_PqUsuario.TabStop = false;
            // 
            // Bt_SalvarEditar
            // 
            Bt_SalvarEditar.Location = new Point(211, 170);
            Bt_SalvarEditar.Name = "Bt_SalvarEditar";
            Bt_SalvarEditar.Size = new Size(94, 25);
            Bt_SalvarEditar.TabIndex = 20;
            Bt_SalvarEditar.Text = "Editar";
            Bt_SalvarEditar.UseVisualStyleBackColor = true;
            Bt_SalvarEditar.Click += Bt_SalvarEditar_Click;
            // 
            // Tb_Nome
            // 
            Tb_Nome.Location = new Point(53, 30);
            Tb_Nome.Name = "Tb_Nome";
            Tb_Nome.Size = new Size(252, 23);
            Tb_Nome.TabIndex = 21;
            // 
            // Mtb_Idade
            // 
            Mtb_Idade.Location = new Point(53, 172);
            Mtb_Idade.Mask = "00";
            Mtb_Idade.Name = "Mtb_Idade";
            Mtb_Idade.PromptChar = ' ';
            Mtb_Idade.Size = new Size(47, 23);
            Mtb_Idade.TabIndex = 23;
            Mtb_Idade.TextAlign = HorizontalAlignment.Right;
            Mtb_Idade.ValidatingType = typeof(int);
            // 
            // Tb_Email
            // 
            Tb_Email.Location = new Point(53, 99);
            Tb_Email.Name = "Tb_Email";
            Tb_Email.Size = new Size(252, 23);
            Tb_Email.TabIndex = 24;
            // 
            // Lb_1
            // 
            Lb_1.AutoSize = true;
            Lb_1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_1.Location = new Point(53, 10);
            Lb_1.Name = "Lb_1";
            Lb_1.Size = new Size(45, 17);
            Lb_1.TabIndex = 25;
            Lb_1.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 79);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 26;
            label1.Text = "E-Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 152);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 27;
            label2.Text = "Idade";
            // 
            // Bt_Cancelar
            // 
            Bt_Cancelar.Location = new Point(111, 170);
            Bt_Cancelar.Name = "Bt_Cancelar";
            Bt_Cancelar.Size = new Size(94, 25);
            Bt_Cancelar.TabIndex = 28;
            Bt_Cancelar.Text = "Cancelar";
            Bt_Cancelar.UseVisualStyleBackColor = true;
            Bt_Cancelar.Visible = false;
            Bt_Cancelar.Click += this.Bt_Cancelar_Click;
            // 
            // Jn_Conta
            // 
            ClientSize = new Size(538, 217);
            Controls.Add(Bt_Cancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Lb_1);
            Controls.Add(Tb_Email);
            Controls.Add(Mtb_Idade);
            Controls.Add(Tb_Nome);
            Controls.Add(Bt_SalvarEditar);
            Controls.Add(Pb_PqUsuario);
            Controls.Add(Pb_PqIdade);
            Controls.Add(Pb_PqEmail);
            Controls.Add(Pb_Usuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Jn_Conta";
            Text = "Conta do Usuário";
            Load += Jn_Conta_Load;
            ((System.ComponentModel.ISupportInitialize)Pb_Usuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_PqIdade).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_PqEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_PqUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox Pb_Usuario;
        private PictureBox Pb_PqIdade;
        private PictureBox Pb_PqEmail;
        private PictureBox Pb_PqUsuario;
        private Button Bt_SalvarEditar;
        private TextBox Tb_Nome;
        private MaskedTextBox Mtb_Idade;
        private TextBox Tb_Email;
        private Label Lb_1;
        private Label label1;
        private Label label2;
        private Button Bt_Cancelar;
    }
}
