namespace pryAguirreGimnasio
{
    partial class frmbuscar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbuscar));
            bindingSource1 = new BindingSource(components);
            datagBuscar = new DataGridView();
            lblBuscador = new Label();
            txtBuscador = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagBuscar).BeginInit();
            SuspendLayout();
            // 
            // datagBuscar
            // 
            datagBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagBuscar.Location = new Point(12, 48);
            datagBuscar.Name = "datagBuscar";
            datagBuscar.Size = new Size(632, 182);
            datagBuscar.TabIndex = 0;
            datagBuscar.CellContentClick += datagBuscar_CellContentClick;
            // 
            // lblBuscador
            // 
            lblBuscador.AutoSize = true;
            lblBuscador.Location = new Point(12, 22);
            lblBuscador.Name = "lblBuscador";
            lblBuscador.Size = new Size(59, 15);
            lblBuscador.TabIndex = 1;
            lblBuscador.Text = "Buscador:";
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(74, 19);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(450, 23);
            txtBuscador.TabIndex = 2;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(530, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 25);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmbuscar
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 247);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(lblBuscador);
            Controls.Add(datagBuscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "frmbuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscador";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private DataGridView datagBuscar;
        private Label lblBuscador;
        private TextBox txtBuscador;
        private Button btnBuscar;
    }
}