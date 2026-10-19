namespace pryAguirreGimnasio
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            picboxFotoInicio = new PictureBox();
            prbCarga = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)picboxFotoInicio).BeginInit();
            SuspendLayout();
            // 
            // picboxFotoInicio
            // 
            picboxFotoInicio.Image = (Image)resources.GetObject("picboxFotoInicio.Image");
            picboxFotoInicio.Location = new Point(-10, 0);
            picboxFotoInicio.Name = "picboxFotoInicio";
            picboxFotoInicio.Size = new Size(665, 388);
            picboxFotoInicio.TabIndex = 0;
            picboxFotoInicio.TabStop = false;
            // 
            // prbCarga
            // 
            prbCarga.BackColor = Color.BurlyWood;
            prbCarga.ForeColor = Color.Gold;
            prbCarga.Location = new Point(2, 365);
            prbCarga.Name = "prbCarga";
            prbCarga.Size = new Size(653, 23);
            prbCarga.Style = ProgressBarStyle.Continuous;
            prbCarga.TabIndex = 1;
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 387);
            Controls.Add(prbCarga);
            Controls.Add(picboxFotoInicio);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Siglo Gym";
            Load += frmSplash_Load;
            ((System.ComponentModel.ISupportInitialize)picboxFotoInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picboxFotoInicio;
        private ProgressBar prbCarga;
    }
}