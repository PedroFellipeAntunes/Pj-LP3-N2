namespace ProjetoLP3.Janelas
{
    partial class Jn_CalendarioPopUp
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
            Mc_Calendario = new MonthCalendar();
            SuspendLayout();
            // 
            // Mc_Calendario
            // 
            Mc_Calendario.Location = new Point(1, 1);
            Mc_Calendario.Name = "Mc_Calendario";
            Mc_Calendario.TabIndex = 0;
            Mc_Calendario.DateChanged += Mc_Calendario_DateChanged;
            // 
            // Jn_CalendarioPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 164);
            Controls.Add(Mc_Calendario);
            Name = "Jn_CalendarioPopUp";
            Text = "Jn_CalendarioPopUp";
            Load += Jn_CalendarioPopUp_Load;
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar Mc_Calendario;
    }
}