namespace pryAguirreGimnasio
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            gbInicio = new GroupBox();
            btnSeguiente = new Button();
            gbEstudiante = new GroupBox();
            rbtEstudianteNo = new RadioButton();
            rbEstudianteSi = new RadioButton();
            lblDatosEstudiante = new Label();
            txtNombreInstitucion = new TextBox();
            gbContacto = new GroupBox();
            lblGmail = new Label();
            txtGmail = new TextBox();
            lbltelefono = new Label();
            txtTelefono = new TextBox();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtNombreApellido = new TextBox();
            lblNombreApellido = new Label();
            btnVolver = new Button();
            lblPlan = new Label();
            cboPlan = new ComboBox();
            lblMeses = new Label();
            txtMeses = new TextBox();
            lblServicioCasillero = new Label();
            chkCasilleroSI = new CheckBox();
            chkCasilleroNO = new CheckBox();
            tabpMiembros = new TabControl();
            tabPageDatosPersonales = new TabPage();
            tabPPlanesMetodoPago = new TabPage();
            btnAtras = new Button();
            btnSiguienteMtP = new Button();
            gbCuotas = new GroupBox();
            rbt6Cuotas = new RadioButton();
            rbt3Cuotas = new RadioButton();
            rbtPagoUnico = new RadioButton();
            gbServicios = new GroupBox();
            lblTurno = new Label();
            cboTurno = new ComboBox();
            chekProfesorPersonalizadoSI = new CheckBox();
            chekProfesorPersonalizadoNO = new CheckBox();
            lblProfesorPersonalizado = new Label();
            gbMetodoDePago = new GroupBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            tabPageConfirmacion = new TabPage();
            datgridFacturacion = new DataGridView();
            btnLimpiar = new Button();
            btnVolverFac = new Button();
            btnSiguienteFact = new Button();
            gbInicio.SuspendLayout();
            gbEstudiante.SuspendLayout();
            gbContacto.SuspendLayout();
            tabpMiembros.SuspendLayout();
            tabPageDatosPersonales.SuspendLayout();
            tabPPlanesMetodoPago.SuspendLayout();
            gbCuotas.SuspendLayout();
            gbServicios.SuspendLayout();
            gbMetodoDePago.SuspendLayout();
            tabPageConfirmacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datgridFacturacion).BeginInit();
            SuspendLayout();
            // 
            // gbInicio
            // 
            gbInicio.Controls.Add(btnSeguiente);
            gbInicio.Controls.Add(gbEstudiante);
            gbInicio.Controls.Add(gbContacto);
            gbInicio.Controls.Add(txtDNI);
            gbInicio.Controls.Add(lblDNI);
            gbInicio.Controls.Add(txtEdad);
            gbInicio.Controls.Add(lblEdad);
            gbInicio.Controls.Add(txtNombreApellido);
            gbInicio.Controls.Add(lblNombreApellido);
            gbInicio.Location = new Point(6, 6);
            gbInicio.Name = "gbInicio";
            gbInicio.Size = new Size(364, 295);
            gbInicio.TabIndex = 0;
            gbInicio.TabStop = false;
            gbInicio.Text = "Nuevo Miembro";
            // 
            // btnSeguiente
            // 
            btnSeguiente.Location = new Point(283, 258);
            btnSeguiente.Name = "btnSeguiente";
            btnSeguiente.Size = new Size(75, 31);
            btnSeguiente.TabIndex = 13;
            btnSeguiente.Text = "Siguiente";
            btnSeguiente.UseVisualStyleBackColor = true;
            btnSeguiente.Click += btnSeguiente_Click;
            // 
            // gbEstudiante
            // 
            gbEstudiante.Controls.Add(rbtEstudianteNo);
            gbEstudiante.Controls.Add(rbEstudianteSi);
            gbEstudiante.Controls.Add(lblDatosEstudiante);
            gbEstudiante.Controls.Add(txtNombreInstitucion);
            gbEstudiante.Location = new Point(6, 163);
            gbEstudiante.Name = "gbEstudiante";
            gbEstudiante.Size = new Size(357, 84);
            gbEstudiante.TabIndex = 17;
            gbEstudiante.TabStop = false;
            gbEstudiante.Text = "Estudiante";
            // 
            // rbtEstudianteNo
            // 
            rbtEstudianteNo.AutoSize = true;
            rbtEstudianteNo.Location = new Point(44, 15);
            rbtEstudianteNo.Name = "rbtEstudianteNo";
            rbtEstudianteNo.Size = new Size(41, 19);
            rbtEstudianteNo.TabIndex = 17;
            rbtEstudianteNo.TabStop = true;
            rbtEstudianteNo.Text = "No";
            rbtEstudianteNo.UseVisualStyleBackColor = true;
            // 
            // rbEstudianteSi
            // 
            rbEstudianteSi.AutoSize = true;
            rbEstudianteSi.Location = new Point(6, 15);
            rbEstudianteSi.Name = "rbEstudianteSi";
            rbEstudianteSi.Size = new Size(34, 19);
            rbEstudianteSi.TabIndex = 16;
            rbEstudianteSi.TabStop = true;
            rbEstudianteSi.Text = "Si";
            rbEstudianteSi.UseVisualStyleBackColor = true;
            // 
            // lblDatosEstudiante
            // 
            lblDatosEstudiante.AutoSize = true;
            lblDatosEstudiante.Location = new Point(0, 37);
            lblDatosEstudiante.Name = "lblDatosEstudiante";
            lblDatosEstudiante.Size = new Size(191, 15);
            lblDatosEstudiante.TabIndex = 14;
            lblDatosEstudiante.Text = "Ingrese el Nombre de la institucion";
            // 
            // txtNombreInstitucion
            // 
            txtNombreInstitucion.Location = new Point(6, 55);
            txtNombreInstitucion.MaxLength = 80;
            txtNombreInstitucion.Multiline = true;
            txtNombreInstitucion.Name = "txtNombreInstitucion";
            txtNombreInstitucion.Size = new Size(191, 20);
            txtNombreInstitucion.TabIndex = 15;
            // 
            // gbContacto
            // 
            gbContacto.Controls.Add(lblGmail);
            gbContacto.Controls.Add(txtGmail);
            gbContacto.Controls.Add(lbltelefono);
            gbContacto.Controls.Add(txtTelefono);
            gbContacto.Location = new Point(8, 88);
            gbContacto.Name = "gbContacto";
            gbContacto.Size = new Size(355, 74);
            gbContacto.TabIndex = 16;
            gbContacto.TabStop = false;
            gbContacto.Text = "Informacion de Contacto";
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.Location = new Point(6, 19);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(41, 15);
            lblGmail.TabIndex = 9;
            lblGmail.Text = "Gmail:";
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(53, 16);
            txtGmail.MaxLength = 50;
            txtGmail.Multiline = true;
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(131, 20);
            txtGmail.TabIndex = 10;
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(0, 45);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(56, 15);
            lbltelefono.TabIndex = 11;
            lbltelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(53, 42);
            txtTelefono.MaxLength = 50;
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(131, 20);
            txtTelefono.TabIndex = 12;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(50, 62);
            txtDNI.MaxLength = 8;
            txtDNI.Multiline = true;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(78, 20);
            txtDNI.TabIndex = 8;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(8, 67);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 7;
            lblDNI.Text = "DNI:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(50, 39);
            txtEdad.MaxLength = 3;
            txtEdad.Multiline = true;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(45, 20);
            txtEdad.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(8, 44);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad:";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(124, 18);
            txtNombreApellido.MaxLength = 30;
            txtNombreApellido.Multiline = true;
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(153, 20);
            txtNombreApellido.TabIndex = 1;
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Location = new Point(8, 21);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(110, 15);
            lblNombreApellido.TabIndex = 0;
            lblNombreApellido.Text = "Nombre y Apellido:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(6, 265);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 31);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(14, 24);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(101, 15);
            lblPlan.TabIndex = 7;
            lblPlan.Text = "Selecciona el Plan";
            // 
            // cboPlan
            // 
            cboPlan.AllowDrop = true;
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.IntegralHeight = false;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(14, 42);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(108, 23);
            cboPlan.TabIndex = 8;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(14, 112);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(97, 15);
            lblMeses.TabIndex = 9;
            lblMeses.Text = "Meses a Suscribir";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(115, 112);
            txtMeses.MaxLength = 2;
            txtMeses.Multiline = true;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(52, 20);
            txtMeses.TabIndex = 10;
            // 
            // lblServicioCasillero
            // 
            lblServicioCasillero.AutoSize = true;
            lblServicioCasillero.Location = new Point(14, 132);
            lblServicioCasillero.Name = "lblServicioCasillero";
            lblServicioCasillero.Size = new Size(112, 15);
            lblServicioCasillero.TabIndex = 11;
            lblServicioCasillero.Text = "Servicio de Casillero";
            // 
            // chkCasilleroSI
            // 
            chkCasilleroSI.AutoSize = true;
            chkCasilleroSI.Location = new Point(14, 150);
            chkCasilleroSI.Name = "chkCasilleroSI";
            chkCasilleroSI.Size = new Size(35, 19);
            chkCasilleroSI.TabIndex = 12;
            chkCasilleroSI.Text = "Si";
            chkCasilleroSI.UseVisualStyleBackColor = true;
            chkCasilleroSI.CheckedChanged += chkCasilleroSI_CheckedChanged;
            // 
            // chkCasilleroNO
            // 
            chkCasilleroNO.AutoSize = true;
            chkCasilleroNO.Location = new Point(55, 150);
            chkCasilleroNO.Name = "chkCasilleroNO";
            chkCasilleroNO.Size = new Size(42, 19);
            chkCasilleroNO.TabIndex = 13;
            chkCasilleroNO.Text = "No";
            chkCasilleroNO.UseVisualStyleBackColor = true;
            chkCasilleroNO.CheckedChanged += chkCasilleroNO_CheckedChanged;
            // 
            // tabpMiembros
            // 
            tabpMiembros.Controls.Add(tabPageDatosPersonales);
            tabpMiembros.Controls.Add(tabPPlanesMetodoPago);
            tabpMiembros.Controls.Add(tabPageConfirmacion);
            tabpMiembros.Location = new Point(12, 2);
            tabpMiembros.Name = "tabpMiembros";
            tabpMiembros.SelectedIndex = 0;
            tabpMiembros.Size = new Size(383, 332);
            tabpMiembros.TabIndex = 15;
            // 
            // tabPageDatosPersonales
            // 
            tabPageDatosPersonales.Controls.Add(btnVolver);
            tabPageDatosPersonales.Controls.Add(gbInicio);
            tabPageDatosPersonales.Location = new Point(4, 24);
            tabPageDatosPersonales.Name = "tabPageDatosPersonales";
            tabPageDatosPersonales.Padding = new Padding(3);
            tabPageDatosPersonales.Size = new Size(375, 304);
            tabPageDatosPersonales.TabIndex = 0;
            tabPageDatosPersonales.Text = "Datos Personales";
            tabPageDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // tabPPlanesMetodoPago
            // 
            tabPPlanesMetodoPago.Controls.Add(btnAtras);
            tabPPlanesMetodoPago.Controls.Add(btnSiguienteMtP);
            tabPPlanesMetodoPago.Controls.Add(gbCuotas);
            tabPPlanesMetodoPago.Controls.Add(gbServicios);
            tabPPlanesMetodoPago.Controls.Add(gbMetodoDePago);
            tabPPlanesMetodoPago.Location = new Point(4, 24);
            tabPPlanesMetodoPago.Name = "tabPPlanesMetodoPago";
            tabPPlanesMetodoPago.Padding = new Padding(3);
            tabPPlanesMetodoPago.Size = new Size(375, 304);
            tabPPlanesMetodoPago.TabIndex = 1;
            tabPPlanesMetodoPago.Text = "Planes y Metodos de Pago";
            tabPPlanesMetodoPago.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(7, 265);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(80, 33);
            btnAtras.TabIndex = 20;
            btnAtras.Text = "Volver";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSiguienteMtP
            // 
            btnSiguienteMtP.Location = new Point(281, 265);
            btnSiguienteMtP.Name = "btnSiguienteMtP";
            btnSiguienteMtP.Size = new Size(80, 33);
            btnSiguienteMtP.TabIndex = 19;
            btnSiguienteMtP.Text = "Siguiente";
            btnSiguienteMtP.UseVisualStyleBackColor = true;
            btnSiguienteMtP.Click += btnSiguienteMtP_Click;
            // 
            // gbCuotas
            // 
            gbCuotas.Controls.Add(rbt6Cuotas);
            gbCuotas.Controls.Add(rbt3Cuotas);
            gbCuotas.Controls.Add(rbtPagoUnico);
            gbCuotas.Enabled = false;
            gbCuotas.Location = new Point(194, 91);
            gbCuotas.Name = "gbCuotas";
            gbCuotas.Size = new Size(167, 131);
            gbCuotas.TabIndex = 17;
            gbCuotas.TabStop = false;
            gbCuotas.Text = "Cuotas";
            gbCuotas.Visible = false;
            // 
            // rbt6Cuotas
            // 
            rbt6Cuotas.AutoSize = true;
            rbt6Cuotas.Location = new Point(6, 71);
            rbt6Cuotas.Name = "rbt6Cuotas";
            rbt6Cuotas.Size = new Size(69, 19);
            rbt6Cuotas.TabIndex = 2;
            rbt6Cuotas.TabStop = true;
            rbt6Cuotas.Text = "6 cuotas";
            rbt6Cuotas.UseVisualStyleBackColor = true;
            // 
            // rbt3Cuotas
            // 
            rbt3Cuotas.AutoSize = true;
            rbt3Cuotas.Location = new Point(6, 46);
            rbt3Cuotas.Name = "rbt3Cuotas";
            rbt3Cuotas.Size = new Size(69, 19);
            rbt3Cuotas.TabIndex = 1;
            rbt3Cuotas.TabStop = true;
            rbt3Cuotas.Text = "3 cuotas";
            rbt3Cuotas.UseVisualStyleBackColor = true;
            // 
            // rbtPagoUnico
            // 
            rbtPagoUnico.AutoSize = true;
            rbtPagoUnico.Location = new Point(6, 22);
            rbtPagoUnico.Name = "rbtPagoUnico";
            rbtPagoUnico.Size = new Size(85, 19);
            rbtPagoUnico.TabIndex = 0;
            rbtPagoUnico.TabStop = true;
            rbtPagoUnico.Text = "Pago unico";
            rbtPagoUnico.UseVisualStyleBackColor = true;
            // 
            // gbServicios
            // 
            gbServicios.Controls.Add(lblTurno);
            gbServicios.Controls.Add(cboTurno);
            gbServicios.Controls.Add(chekProfesorPersonalizadoSI);
            gbServicios.Controls.Add(chekProfesorPersonalizadoNO);
            gbServicios.Controls.Add(lblProfesorPersonalizado);
            gbServicios.Controls.Add(lblPlan);
            gbServicios.Controls.Add(lblMeses);
            gbServicios.Controls.Add(chkCasilleroSI);
            gbServicios.Controls.Add(cboPlan);
            gbServicios.Controls.Add(lblServicioCasillero);
            gbServicios.Controls.Add(txtMeses);
            gbServicios.Controls.Add(chkCasilleroNO);
            gbServicios.Location = new Point(7, 10);
            gbServicios.Name = "gbServicios";
            gbServicios.Size = new Size(176, 237);
            gbServicios.TabIndex = 16;
            gbServicios.TabStop = false;
            gbServicios.Text = "Servicios";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(14, 68);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 17;
            lblTurno.Text = "Turno";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana (7 a 12 h) ", "Tarde (14 a 18 h) ", "Noche (18 a 23 h)" });
            cboTurno.Location = new Point(14, 86);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(108, 23);
            cboTurno.TabIndex = 18;
            // 
            // chekProfesorPersonalizadoSI
            // 
            chekProfesorPersonalizadoSI.AutoSize = true;
            chekProfesorPersonalizadoSI.Location = new Point(14, 190);
            chekProfesorPersonalizadoSI.Name = "chekProfesorPersonalizadoSI";
            chekProfesorPersonalizadoSI.Size = new Size(35, 19);
            chekProfesorPersonalizadoSI.TabIndex = 15;
            chekProfesorPersonalizadoSI.Text = "Si";
            chekProfesorPersonalizadoSI.UseVisualStyleBackColor = true;
            chekProfesorPersonalizadoSI.CheckedChanged += chekProfesorPersonalizadoSI_CheckedChanged;
            // 
            // chekProfesorPersonalizadoNO
            // 
            chekProfesorPersonalizadoNO.AutoSize = true;
            chekProfesorPersonalizadoNO.Location = new Point(55, 190);
            chekProfesorPersonalizadoNO.Name = "chekProfesorPersonalizadoNO";
            chekProfesorPersonalizadoNO.Size = new Size(42, 19);
            chekProfesorPersonalizadoNO.TabIndex = 16;
            chekProfesorPersonalizadoNO.Text = "No";
            chekProfesorPersonalizadoNO.UseVisualStyleBackColor = true;
            chekProfesorPersonalizadoNO.CheckedChanged += chekProfesorPersonalizadoNO_CheckedChanged;
            // 
            // lblProfesorPersonalizado
            // 
            lblProfesorPersonalizado.AutoSize = true;
            lblProfesorPersonalizado.Location = new Point(14, 172);
            lblProfesorPersonalizado.Name = "lblProfesorPersonalizado";
            lblProfesorPersonalizado.Size = new Size(135, 15);
            lblProfesorPersonalizado.TabIndex = 14;
            lblProfesorPersonalizado.Text = "Profesor / Personalizado";
            // 
            // gbMetodoDePago
            // 
            gbMetodoDePago.Controls.Add(rbtTarjeta);
            gbMetodoDePago.Controls.Add(rbtEfectivo);
            gbMetodoDePago.Location = new Point(189, 11);
            gbMetodoDePago.Name = "gbMetodoDePago";
            gbMetodoDePago.Size = new Size(169, 73);
            gbMetodoDePago.TabIndex = 15;
            gbMetodoDePago.TabStop = false;
            gbMetodoDePago.Text = "Metodo de Pago";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(10, 49);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(10, 24);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // tabPageConfirmacion
            // 
            tabPageConfirmacion.Controls.Add(datgridFacturacion);
            tabPageConfirmacion.Controls.Add(btnLimpiar);
            tabPageConfirmacion.Controls.Add(btnVolverFac);
            tabPageConfirmacion.Controls.Add(btnSiguienteFact);
            tabPageConfirmacion.Location = new Point(4, 24);
            tabPageConfirmacion.Name = "tabPageConfirmacion";
            tabPageConfirmacion.Padding = new Padding(3);
            tabPageConfirmacion.Size = new Size(375, 304);
            tabPageConfirmacion.TabIndex = 2;
            tabPageConfirmacion.Text = "Facturación";
            tabPageConfirmacion.UseVisualStyleBackColor = true;
            // 
            // datgridFacturacion
            // 
            datgridFacturacion.AllowDrop = true;
            datgridFacturacion.AllowUserToAddRows = false;
            datgridFacturacion.AllowUserToDeleteRows = false;
            datgridFacturacion.AllowUserToOrderColumns = true;
            datgridFacturacion.AllowUserToResizeColumns = false;
            datgridFacturacion.AllowUserToResizeRows = false;
            datgridFacturacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datgridFacturacion.Location = new Point(19, 6);
            datgridFacturacion.Name = "datgridFacturacion";
            datgridFacturacion.ReadOnly = true;
            datgridFacturacion.Size = new Size(340, 244);
            datgridFacturacion.TabIndex = 23;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(187, 264);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(83, 36);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolverFac
            // 
            btnVolverFac.Location = new Point(6, 266);
            btnVolverFac.Name = "btnVolverFac";
            btnVolverFac.Size = new Size(81, 32);
            btnVolverFac.TabIndex = 20;
            btnVolverFac.Text = "Volver";
            btnVolverFac.UseVisualStyleBackColor = true;
            btnVolverFac.Click += btnVolverFac_Click;
            // 
            // btnSiguienteFact
            // 
            btnSiguienteFact.Location = new Point(276, 264);
            btnSiguienteFact.Name = "btnSiguienteFact";
            btnSiguienteFact.Size = new Size(83, 36);
            btnSiguienteFact.TabIndex = 19;
            btnSiguienteFact.Text = "Siguiente";
            btnSiguienteFact.UseVisualStyleBackColor = true;
            btnSiguienteFact.Click += btnSiguienteFact_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 336);
            Controls.Add(tabpMiembros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            Load += frmInscripcion_Load;
            gbInicio.ResumeLayout(false);
            gbInicio.PerformLayout();
            gbEstudiante.ResumeLayout(false);
            gbEstudiante.PerformLayout();
            gbContacto.ResumeLayout(false);
            gbContacto.PerformLayout();
            tabpMiembros.ResumeLayout(false);
            tabPageDatosPersonales.ResumeLayout(false);
            tabPPlanesMetodoPago.ResumeLayout(false);
            gbCuotas.ResumeLayout(false);
            gbCuotas.PerformLayout();
            gbServicios.ResumeLayout(false);
            gbServicios.PerformLayout();
            gbMetodoDePago.ResumeLayout(false);
            gbMetodoDePago.PerformLayout();
            tabPageConfirmacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datgridFacturacion).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblEdad;
        private TextBox txtNombreApellido;
        private Label lblNombreApellido;
        private TextBox txtEdad;
        private Label lblPlan;
        public GroupBox gbInicio;
        private ComboBox cboPlan;
        private Label lblServicioCasillero;
        private TextBox txtMeses;
        private Label lblMeses;
        private CheckBox chkCasilleroNO;
        private CheckBox chkCasilleroSI;
        private TextBox txtDNI;
        private Label lblDNI;
        private TabControl tabpMiembros;
        private TabPage tabPageDatosPersonales;
        private TabPage tabPPlanesMetodoPago;
        private Button btnSeguiente;
        private TextBox txtNombreInstitucion;
        private Label lblDatosEstudiante;
        private GroupBox gbMetodoDePago;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private GroupBox gbServicios;
        private CheckBox chekProfesorPersonalizadoSI;
        private CheckBox chekProfesorPersonalizadoNO;
        private Label lblProfesorPersonalizado;
        private GroupBox gbCuotas;
        private RadioButton rbt6Cuotas;
        private RadioButton rbt3Cuotas;
        private RadioButton rbtPagoUnico;
        private Button btnSiguienteMtP;
        private Button btnAtras;
        private TabPage tabPageConfirmacion;
        private Button btnVolverFac;
        private Button btnSiguienteFact;
        private Button btnVolver;
        private Button btnLimpiar;
        private GroupBox gbEstudiante;
        private GroupBox gbContacto;
        private Label lblGmail;
        private TextBox txtGmail;
        private Label lbltelefono;
        private TextBox txtTelefono;
        private RadioButton rbtEstudianteNo;
        private RadioButton rbEstudianteSi;
        private DataGridView datgridFacturacion;
        private Label lblTurno;
        private ComboBox cboTurno;
        //private Button btnSiguiente;
    }
}
