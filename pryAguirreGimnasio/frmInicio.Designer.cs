namespace pryAguirreGimnasio
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            btnBuscar = new Button();
            btnNuevo = new Button();
            btnCerrarApp = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(370, 339);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(165, 34);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Black;
            btnNuevo.BackgroundImageLayout = ImageLayout.None;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(155, 339);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(165, 34);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCerrarApp
            // 
            btnCerrarApp.BackColor = Color.Black;
            btnCerrarApp.BackgroundImageLayout = ImageLayout.None;
            btnCerrarApp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarApp.ForeColor = Color.White;
            btnCerrarApp.Location = new Point(622, 12);
            btnCerrarApp.Name = "btnCerrarApp";
            btnCerrarApp.Size = new Size(33, 32);
            btnCerrarApp.TabIndex = 2;
            btnCerrarApp.Text = "X";
            btnCerrarApp.UseVisualStyleBackColor = false;
            btnCerrarApp.Click += btnCerrarApp_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(663, 387);
            ControlBox = false;
            Controls.Add(btnCerrarApp);
            Controls.Add(btnNuevo);
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicio";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private Button btnNuevo;
        private Button btnCerrarApp;
    }
}