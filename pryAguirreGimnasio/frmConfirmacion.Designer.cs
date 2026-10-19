namespace pryAguirreGimnasio
{
    partial class frmConfirmacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmacion));
            btnVolver = new Button();
            btnSuscribir = new Button();
            datagTodoslosdatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datagTodoslosdatos).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 492);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 32);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.UseWaitCursor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSuscribir
            // 
            btnSuscribir.Location = new Point(714, 490);
            btnSuscribir.Name = "btnSuscribir";
            btnSuscribir.Size = new Size(83, 36);
            btnSuscribir.TabIndex = 24;
            btnSuscribir.Text = "Suscribir";
            btnSuscribir.UseVisualStyleBackColor = true;
            btnSuscribir.UseWaitCursor = true;
            btnSuscribir.Click += btnSuscribir_Click;
            // 
            // datagTodoslosdatos
            // 
            datagTodoslosdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagTodoslosdatos.Location = new Point(12, 19);
            datagTodoslosdatos.Name = "datagTodoslosdatos";
            datagTodoslosdatos.Size = new Size(788, 465);
            datagTodoslosdatos.TabIndex = 26;
            datagTodoslosdatos.UseWaitCursor = true;
            datagTodoslosdatos.CellContentClick += datagTodoslosdatos_CellContentClick;
            // 
            // frmConfirmacion
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 538);
            ControlBox = false;
            Controls.Add(datagTodoslosdatos);
            Controls.Add(btnVolver);
            Controls.Add(btnSuscribir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmConfirmacion";
            StartPosition = FormStartPosition.CenterScreen;
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)datagTodoslosdatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private Button btnSuscribir;
        private DataGridView datagTodoslosdatos;
    }
}