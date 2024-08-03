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
            flp_meusFilmes = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flp_meusFilmes
            // 
            flp_meusFilmes.Dock = DockStyle.Fill;
            flp_meusFilmes.Location = new Point(0, 0);
            flp_meusFilmes.Name = "flp_meusFilmes";
            flp_meusFilmes.Size = new Size(878, 496);
            flp_meusFilmes.TabIndex = 0;
            // 
            // Jn_MeusFilmes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 496);
            Controls.Add(flp_meusFilmes);
            Name = "Jn_MeusFilmes";
            Text = "Filmes Alugados";
            Load += Jn_MeusFilmes_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_meusFilmes;
    }
}