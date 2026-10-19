namespace pryAguirreGimnasio
{
    partial class frmDatosTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosTarjeta));
            lblNombreTitular = new Label();
            lblNumeroTarjeta = new Label();
            lblFechaExpiracion = new Label();
            lblCVV = new Label();
            lblTipoTarjeta = new Label();
            gbDatosTarjeta = new GroupBox();
            txtFechaExpiracion = new TextBox();
            cboTipoTarjeta = new ComboBox();
            txtCVV = new TextBox();
            txtNumeroTarjeta = new TextBox();
            txtNombreApellido = new TextBox();
            btnAnadir = new Button();
            btnVolver = new Button();
            gbDatosTarjeta.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreTitular
            // 
            lblNombreTitular.AutoSize = true;
            lblNombreTitular.Location = new Point(6, 19);
            lblNombreTitular.Name = "lblNombreTitular";
            lblNombreTitular.Size = new Size(107, 15);
            lblNombreTitular.TabIndex = 0;
            lblNombreTitular.Text = "Nombre del Titular";
            // 
            // lblNumeroTarjeta
            // 
            lblNumeroTarjeta.AutoSize = true;
            lblNumeroTarjeta.Location = new Point(8, 43);
            lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            lblNumeroTarjeta.Size = new Size(105, 15);
            lblNumeroTarjeta.TabIndex = 1;
            lblNumeroTarjeta.Text = "Número de Tarjeta";
            // 
            // lblFechaExpiracion
            // 
            lblFechaExpiracion.AutoSize = true;
            lblFechaExpiracion.Location = new Point(6, 69);
            lblFechaExpiracion.Name = "lblFechaExpiracion";
            lblFechaExpiracion.Size = new Size(168, 15);
            lblFechaExpiracion.TabIndex = 2;
            lblFechaExpiracion.Text = "Fecha de Expiración (MM/AA):";
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Location = new Point(8, 98);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(182, 15);
            lblCVV.TabIndex = 3;
            lblCVV.Text = "Código de Seguridad (CVV/CVC):";
            // 
            // lblTipoTarjeta
            // 
            lblTipoTarjeta.AutoSize = true;
            lblTipoTarjeta.Location = new Point(8, 124);
            lblTipoTarjeta.Name = "lblTipoTarjeta";
            lblTipoTarjeta.Size = new Size(88, 15);
            lblTipoTarjeta.TabIndex = 4;
            lblTipoTarjeta.Text = "Tipo de Tarjeta:";
            // 
            // gbDatosTarjeta
            // 
            gbDatosTarjeta.Controls.Add(txtFechaExpiracion);
            gbDatosTarjeta.Controls.Add(cboTipoTarjeta);
            gbDatosTarjeta.Controls.Add(txtCVV);
            gbDatosTarjeta.Controls.Add(txtNumeroTarjeta);
            gbDatosTarjeta.Controls.Add(txtNombreApellido);
            gbDatosTarjeta.Controls.Add(lblNombreTitular);
            gbDatosTarjeta.Controls.Add(lblTipoTarjeta);
            gbDatosTarjeta.Controls.Add(lblNumeroTarjeta);
            gbDatosTarjeta.Controls.Add(lblCVV);
            gbDatosTarjeta.Controls.Add(lblFechaExpiracion);
            gbDatosTarjeta.Location = new Point(0, 0);
            gbDatosTarjeta.Name = "gbDatosTarjeta";
            gbDatosTarjeta.Size = new Size(386, 162);
            gbDatosTarjeta.TabIndex = 5;
            gbDatosTarjeta.TabStop = false;
            gbDatosTarjeta.Text = "Datos de Tarjeta";
            // 
            // txtFechaExpiracion
            // 
            txtFechaExpiracion.Location = new Point(180, 66);
            txtFechaExpiracion.MaxLength = 4;
            txtFechaExpiracion.Multiline = true;
            txtFechaExpiracion.Name = "txtFechaExpiracion";
            txtFechaExpiracion.Size = new Size(52, 20);
            txtFechaExpiracion.TabIndex = 11;
            // 
            // cboTipoTarjeta
            // 
            cboTipoTarjeta.FormattingEnabled = true;
            cboTipoTarjeta.Items.AddRange(new object[] { "Visa", "Mastercard" });
            cboTipoTarjeta.Location = new Point(102, 121);
            cboTipoTarjeta.Name = "cboTipoTarjeta";
            cboTipoTarjeta.Size = new Size(72, 23);
            cboTipoTarjeta.TabIndex = 10;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(196, 95);
            txtCVV.MaxLength = 3;
            txtCVV.Multiline = true;
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(52, 20);
            txtCVV.TabIndex = 8;
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Location = new Point(119, 40);
            txtNumeroTarjeta.MaxLength = 30;
            txtNumeroTarjeta.Multiline = true;
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(153, 20);
            txtNumeroTarjeta.TabIndex = 6;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(119, 16);
            txtNombreApellido.MaxLength = 30;
            txtNombreApellido.Multiline = true;
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(153, 20);
            txtNombreApellido.TabIndex = 5;
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(284, 168);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(102, 33);
            btnAnadir.TabIndex = 5;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(176, 168);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(102, 33);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmDatosTarjeta
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 200);
            ControlBox = false;
            Controls.Add(btnVolver);
            Controls.Add(btnAnadir);
            Controls.Add(gbDatosTarjeta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDatosTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            gbDatosTarjeta.ResumeLayout(false);
            gbDatosTarjeta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombreTitular;
        private Label lblNumeroTarjeta;
        private Label lblFechaExpiracion;
        private Label lblCVV;
        private Label lblTipoTarjeta;
        private GroupBox gbDatosTarjeta;
        private Button btnAnadir;
        private Button btnVolver;
        private ComboBox cboTipoTarjeta;
        private TextBox txtCVV;
        private TextBox txtNumeroTarjeta;
        private TextBox txtNombreApellido;
        private TextBox txtFechaExpiracion;
    }
}