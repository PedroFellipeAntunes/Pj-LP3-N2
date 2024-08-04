namespace ProjetoLP3.Janelas
{
    partial class Conta
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
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pbIdade = new PictureBox();
            pbEmail = new PictureBox();
            btnEditar = new Button();
            txtEmail = new TextBox();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            pbNome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIdade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNome).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.userIcons;
            pictureBox2.Location = new Point(32, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 214);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F);
            label2.Location = new Point(436, 250);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 10;
            label2.Text = "Idade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F);
            label1.Location = new Point(432, 174);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 11;
            label1.Text = "Email:";
            // 
            // pbIdade
            // 
            pbIdade.Image = Properties.Resources.IdadeIcon;
            pbIdade.Location = new Point(370, 250);
            pbIdade.Name = "pbIdade";
            pbIdade.Size = new Size(49, 49);
            pbIdade.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIdade.TabIndex = 13;
            pbIdade.TabStop = false;
            // 
            // pbEmail
            // 
            pbEmail.Image = Properties.Resources.EmailIcon;
            pbEmail.Location = new Point(370, 174);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(49, 49);
            pbEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmail.TabIndex = 12;
            pbEmail.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(281, 375);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(129, 49);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Salvar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(432, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(436, 272);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(230, 27);
            txtIdade.TabIndex = 16;
            txtIdade.KeyPress += txtIdade_KeyPress;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(432, 107);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(230, 27);
            txtNome.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F);
            label3.Location = new Point(436, 85);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 18;
            label3.Text = "Nome:";
            // 
            // pbNome
            // 
            pbNome.Image = Properties.Resources.usuario;
            pbNome.Location = new Point(370, 85);
            pbNome.Name = "pbNome";
            pbNome.Size = new Size(49, 49);
            pbNome.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNome.TabIndex = 19;
            pbNome.TabStop = false;
            // 
            // Conta
            // 
            ClientSize = new Size(727, 465);
            Controls.Add(pbNome);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(txtIdade);
            Controls.Add(txtEmail);
            Controls.Add(btnEditar);
            Controls.Add(pbIdade);
            Controls.Add(pbEmail);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Conta";
            Text = "Conta do Usuário";
            Load += Conta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIdade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private PictureBox pbIdade;
        private PictureBox pbEmail;
        private Button btnEditar;
        private TextBox txtEmail;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Label label3;
        private PictureBox pbNome;
    }
}
