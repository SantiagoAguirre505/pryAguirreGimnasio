using pryAguirreGimnasio;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace pryAguirreGimnasio
{

    public partial class frmInscripcion : Form
    {
        //precio planes
        private const decimal precioMusculacion = 15000;
        private const decimal precioFuncional = 18000;
        private const decimal precioNatacion = 22000;
        //edad minima para inscripcion
        private const int edadMinima = 14;
        //precio servicios
        private const decimal precioCasillero = 3000;
        private const decimal precioProfesorPersonalizado = 5000;
        //descuento estudiante
        private const decimal descuentoEstudiante = 0.15m;
        //descuento edad
        private const decimal descuentomenor = 0.25m;
        private const decimal descuentomayor = 0.30m;
        //descuento metodo de pago
        private const decimal descuentoEfectivo = 0.10m;
        //recargo por cuotas
        private const decimal recargo3Cuotas = 0.10m;
        private const decimal recargo6Cuotas = 0.20m;

        public frmInscripcion()
        {
            InitializeComponent();
            tabpMiembros.SelectedIndexChanged += new EventHandler(tabpMiembros_SelectedIndexChanged);
            datgridFacturacion.AllowUserToAddRows = false;
            datgridFacturacion.RowHeadersVisible = false;

            // Asignamos el evento a los campos numéricos para 
            // bloquear el ingreso de letras automáticamente al abrir.
            txtDNI.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtEdad.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtTelefono.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtMeses.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
        }

        // Método que bloquea las letras en el teclado.
        // Solo permite números y teclas de control (como Retroceso).
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Anula la tecla si no es un número
            }
        }

        // Metodo para limpiar todos los campos del formulario y dejarlo en estado inicial
        private void EstadoInicial()
        {
            //Datos personales
            txtNombreApellido.Clear();
            txtEdad.Clear();
            txtDNI.Clear();
            txtGmail.Clear();
            txtTelefono.Clear();
            rbtEstudianteNo.Checked = false;
            rbEstudianteSi.Checked = false;
            txtNombreInstitucion.Clear();

            //Planes y metodos de pago
            cboTurno.SelectedIndex = -1;
            cboPlan.SelectedIndex = -1;
            txtMeses.Clear();
            chkCasilleroSI.Checked = false;
            chkCasilleroNO.Checked = false;
            chekProfesorPersonalizadoSI.Checked = false;
            chekProfesorPersonalizadoNO.Checked = false;

            rbtEfectivo.Checked = false;
            rbtTarjeta.Checked = false;
            rbtPagoUnico.Checked = false;
            rbt3Cuotas.Checked = false;
            rbt6Cuotas.Checked = false;
        }

        // Método que valida que todos los campos obligatorios estén completos
        private bool ValidarCamposCompletos()
        {
            // --- DATOS PERSONALES ---
            if (string.IsNullOrWhiteSpace(txtNombreApellido.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre y apellido.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 0;
                txtNombreApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Por favor, ingrese el DNI.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 0;
                txtDNI.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("Por favor, ingrese la edad.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 0;
                txtEdad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGmail.Text))
            {
                MessageBox.Show("Por favor, ingrese el correo electrónico.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 0;
                txtGmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, ingrese el teléfono.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 0;
                txtTelefono.Focus();
                return false;
            }

            if (!rbEstudianteSi.Checked && !rbtEstudianteNo.Checked)
            {
                MessageBox.Show("Por favor, indique si es estudiante o no.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 0;
                return false;
            }

            if (rbEstudianteSi.Checked && string.IsNullOrWhiteSpace(txtNombreInstitucion.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la institución.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 0;
                txtNombreInstitucion.Focus();
                return false;
            }

            // --- PLANES Y SERVICIOS ---
            if (cboTurno.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un turno.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 1;
                cboTurno.Focus();
                return false;
            }

            if (cboPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un plan.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 1;
                cboPlan.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMeses.Text))
            {
                MessageBox.Show("Por favor, ingrese la cantidad de meses.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 1;
                txtMeses.Focus();
                return false;
            }

            if (!chkCasilleroSI.Checked && !chkCasilleroNO.Checked)
            {
                MessageBox.Show("Por favor, indique si desea el servicio de casillero.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 1;
                return false;
            }

            if (!chekProfesorPersonalizadoSI.Checked && !chekProfesorPersonalizadoNO.Checked)
            {
                MessageBox.Show("Por favor, indique si desea profesor personalizado.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 1;
                return false;
            }

            // --- MÉTODO DE PAGO ---
            if (!rbtEfectivo.Checked && !rbtTarjeta.Checked)
            {
                MessageBox.Show("Por favor, seleccione un método de pago.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 1;
                return false;
            }

            if (rbtTarjeta.Checked && !rbtPagoUnico.Checked && !rbt3Cuotas.Checked && !rbt6Cuotas.Checked)
            {
                MessageBox.Show("Por favor, seleccione la modalidad de pago con tarjeta (Cuotas).", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabpMiembros.SelectedIndex = 1;
                return false;
            }

            return true;
        }

        private void btnSeguiente_Click(object sender, EventArgs e)
        {
            if (tabpMiembros.SelectedIndex < tabpMiembros.TabCount - 1)
            {
                tabpMiembros.SelectedIndex++;
            }
            if (txtEdad.Text != "")
            {
                int edad = int.Parse(txtEdad.Text);
                if (edad < edadMinima)
                {
                    MessageBox.Show($"La edad mínima para inscribirse es de {edadMinima} años.", "Edad insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabpMiembros.SelectedIndex = 0;
                }
            }
        }

        // Boton para pasar a la siguiente pestaña de planes y metodos de pago
        private void btnSiguienteMtP_Click(object sender, EventArgs e)
        {
            if (tabpMiembros.SelectedIndex < tabpMiembros.TabCount - 1)
            {
                tabpMiembros.SelectedIndex++;
            }

            if (tabpMiembros.SelectedIndex < tabpMiembros.TabCount - 1)
            {
                tabpMiembros.SelectedIndex++;
            }
            if (txtEdad.Text != "")
            {
                int edad = int.Parse(txtEdad.Text);
                if (edad < edadMinima)
                {
                    MessageBox.Show($"La edad mínima para inscribirse es de {edadMinima} años.", "Edad insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabpMiembros.SelectedIndex = 0;
                }
            }
        }

        // Boton para pasar a la siguiente pestaña de facturacion
        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (tabpMiembros.SelectedIndex > 0)
            {
                tabpMiembros.SelectedIndex--;
            }
        }
        // Boton para pasar a la siguiente pestaña de facturacion
        private void btnVolverFac_Click(object sender, EventArgs e)
        {
            if (tabpMiembros.SelectedIndex > 0)
            {
                tabpMiembros.SelectedIndex--;
            }
        }
        // Boton para cerrar el formulario
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Boton para limpiar todos los campos del formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            tabpMiembros.SelectedIndex = 0;
        }
        // Cancela si se seleciona uno o otro checkbox de casillero 
        private void chkCasilleroSI_CheckedChanged(object sender, EventArgs e)
        {
            chkCasilleroNO.Checked = false;
        }
        // Cancela si se seleciona uno o otro checkbox de casillero 
        private void chkCasilleroNO_CheckedChanged(object sender, EventArgs e)
        {
            chkCasilleroSI.Checked = false;
        }
        // Cancela si se seleciona uno o otro checkbox de profesor personalizado
        private void chekProfesorPersonalizadoSI_CheckedChanged(object sender, EventArgs e)
        {
            chekProfesorPersonalizadoNO.Checked = false;
        }
        // Cancela si se seleciona uno o otro checkbox de profesor personalizado
        private void chekProfesorPersonalizadoNO_CheckedChanged(object sender, EventArgs e)
        {
            chekProfesorPersonalizadoSI.Checked = false;
        }
        // Muestra el formulario de datos de tarjeta si se selecciona el metodo de pago con tarjeta
        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            // Asumiendo que frmDatosTarjeta existe en tu proyecto
            if (rbtTarjeta.Checked)
            {
                frmDatosTarjeta tarjeta = new frmDatosTarjeta();
                tarjeta.Show();
                tarjeta.FormClosed += (s, args) => this.Show();
                this.Hide();
                gbCuotas.Enabled = true;
                gbCuotas.Visible = true;
            }
            else
            {
                // Eligió efectivo: se ocultan y limpian las cuotas
                gbCuotas.Enabled = false;
                gbCuotas.Visible = false;
                rbtPagoUnico.Checked = false;
                rbt3Cuotas.Checked = false;
                rbt6Cuotas.Checked = false;
            }
        }

        private void tabpMiembros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabpMiembros.SelectedIndex == tabpMiembros.TabCount - 1)
            {
                DataTable tablaFacturacion = new DataTable();
                tablaFacturacion.Columns.Add("Concepto");
                tablaFacturacion.Columns.Add("Detalle / Meses");
                tablaFacturacion.Columns.Add("Subtotal");

                decimal subtotalGeneral = 0;

                // 1. Calcular el Plan seleccionado
                decimal precioPlan = 0;
                string nombrePlan = "Ninguno";

                if (cboPlan.SelectedItem != null)
                {
                    nombrePlan = cboPlan.SelectedItem.ToString();
                    if (nombrePlan.Contains("Musculación")) precioPlan = precioMusculacion;
                    else if (nombrePlan.Contains("Funcional")) precioPlan = precioFuncional;
                    else if (nombrePlan.Contains("Natación")) precioPlan = precioNatacion;
                }

                int meses = 1;
                int.TryParse(txtMeses.Text, out meses);
                if (meses <= 0) meses = 1;

                decimal totalPlan = precioPlan * meses;
                subtotalGeneral += totalPlan;
                tablaFacturacion.Rows.Add($"Plan: {nombrePlan}", $"{meses} mes(es)", $"$ {totalPlan}");

                // 2. Calcular Servicios Adicionales (Casillero)
                if (chkCasilleroSI.Checked)
                {
                    decimal totalCasillero = precioCasillero * meses;
                    subtotalGeneral += totalCasillero;
                    tablaFacturacion.Rows.Add("Servicio de Casillero", $"{meses} mes(es)", $"$ {totalCasillero}");
                }

                // Profesor Personalizado
                if (chekProfesorPersonalizadoSI.Checked)
                {
                    decimal totalProfesor = precioProfesorPersonalizado * meses;
                    subtotalGeneral += totalProfesor;
                    tablaFacturacion.Rows.Add("Profesor Personalizado", $"{meses} mes(es)", $"$ {totalProfesor}");
                }

                // 3. Aplicar Descuentos (Estudiante / Edad)
                // 3. Aplicar Descuentos (Edad o Estudiante - No acumulables)
                decimal totalDescuentos = 0;
                int edadUsuario = 0;
                int.TryParse(txtEdad.Text, out edadUsuario);

                if (edadUsuario > 0 && edadUsuario < 18)
                {
                    // Menor de 18
                    decimal descMenor = totalPlan * descuentomenor;
                    totalDescuentos += descMenor;
                    tablaFacturacion.Rows.Add("Descuento Menor de 18 (25%)", "-", $"- $ {descMenor}");
                }
                else if (edadUsuario >= 65)
                {
                    // 65 años o más
                    decimal descMayor = totalPlan * descuentomayor;
                    totalDescuentos += descMayor;
                    tablaFacturacion.Rows.Add("Descuento Mayor de 65 (30%)", "-", $"- $ {descMayor}");
                }
                else if (rbEstudianteSi.Checked)
                {
                    // Estudiante (y no cumplió ninguna de las condiciones de edad)
                    decimal descEst = totalPlan * descuentoEstudiante;
                    totalDescuentos += descEst;
                    tablaFacturacion.Rows.Add("Descuento Estudiante (15%)", "-", $"- $ {descEst}");
                }


                // 4. Método de pago y recargos/descuentos por cuotas
                if (rbtEfectivo.Checked)
                {
                    decimal descEfectivo = totalPlan * descuentoEfectivo;
                    totalDescuentos += descEfectivo;
                    tablaFacturacion.Rows.Add("Descuento Pago Efectivo (10%)", "-", $"- $ {descEfectivo}");
                }
                else if (rbtTarjeta.Checked)
                {
                    if (rbt3Cuotas.Checked)
                    {
                        decimal recargo3 = totalPlan * recargo3Cuotas;
                        subtotalGeneral += recargo3;
                        tablaFacturacion.Rows.Add("Recargo 3 Cuotas (10%)", "-", $"+ $ {recargo3}");
                    }
                    else if (rbt6Cuotas.Checked)
                    {
                        decimal recargo6 = totalPlan * recargo6Cuotas;
                        subtotalGeneral += recargo6;
                        tablaFacturacion.Rows.Add("Recargo 6 Cuotas (20%)", "-", $"+ $ {recargo6}");
                    }
                }

                // Calcular Total Final
                decimal totalFinal = subtotalGeneral - totalDescuentos;

                tablaFacturacion.Rows.Add("--------------------", "------------", "----------");
                tablaFacturacion.Rows.Add("TOTAL A PAGAR", "", $"$ {totalFinal}");

                datgridFacturacion.DataSource = tablaFacturacion;
            }
        }

        // Inscripcion de datos y envio al formulario de confirmacion
        private void btnSiguienteFact_Click(object sender, EventArgs e)
        {

            // Validar que todos los campos estén completos antes de proceder
            if (!ValidarCamposCompletos())
            {
                return;
            }

            if (datgridFacturacion.DataSource != null)
            {
                // Instanciar una caja de datos
                DatosResumen misDatos = new DatosResumen();

                //.ToUpper() para forzar Mayúsculas
                misDatos.Nombre = txtNombreApellido.Text.ToUpper();
                misDatos.DNI = txtDNI.Text;
                misDatos.Edad = txtEdad.Text;
                misDatos.Correo = txtGmail.Text;
                misDatos.EsEstudiante = rbEstudianteSi.Checked;
                misDatos.NombreInstitucion = txtNombreInstitucion.Text;

                // Método de pago que se muestra en la confirmación y en el TXT
                if (rbtEfectivo.Checked)
                {
                    misDatos.TarjetaEnmascarada = "Efectivo";
                }
                else
                {
                    string tarjeta = frmDatosTarjeta.TarjetaEnmascaradaGlobal;
                    misDatos.TarjetaEnmascarada = string.IsNullOrEmpty(tarjeta)
                        ? "Tarjeta (sin datos cargados)"
                        : "Tarjeta " + tarjeta;
                }

                // Se limpia para que el próximo socio no herede esta tarjeta
                frmDatosTarjeta.TarjetaEnmascaradaGlobal = "";

                if (chkCasilleroSI.Checked)
                {
                    string nro = BaseDeDatos.AsignarCasillero(txtDNI.Text);
                    if (nro == "")
                    {
                        MessageBox.Show("No hay casilleros disponibles.", "Casilleros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    misDatos.NumeroCasillero = nro;
                }


                if (cboPlan.SelectedItem != null)
                {
                    misDatos.PlanElegido = cboPlan.SelectedItem.ToString();
                }

                // Guardamos el DataTable
                misDatos.TablaFacturacion = (DataTable)datgridFacturacion.DataSource;

                // SE CARGAN LOS DATOS AL ARRAY GLOBAL DE LA CLASE BaseDeDatos
                // Se manda el objeto 'misDatos' al vector en memoria.
                bool guardadoExitoso = BaseDeDatos.AgregarSocio(misDatos);

                if (!guardadoExitoso)
                {
                    MessageBox.Show("Se ha alcanzado el límite máximo de inscripciones en memoria.", "Límite Almacenamiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Instanciamos el segundo formulario 
                // y le pasamos la clase contenedora por el constructor.
                frmConfirmacion formResumen = new frmConfirmacion(misDatos);

                formResumen.Show();
                this.Hide();
                formResumen.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Asegúrese de generar la facturación primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
       
        {
            string rutaArchivo = @"C:\Inscripciones_SigloGym\Inscripciones_Totales.txt";

            // 1. Verificamos si la "libreta" existe
            if (File.Exists(rutaArchivo))
            {
                // 2. Abrimos la libreta para leerla
                using (StreamReader lector = new StreamReader(rutaArchivo))
                {
                    string linea;
                    string dniActual = "";

                    // 3. Leemos línea por línea hasta el final
                    while ((linea = lector.ReadLine()) != null)
                    {
                        // Cuando encontramos la línea del DNI, lo guardamos temporalmente
                        if (linea.StartsWith("DNI: "))
                        {
                            dniActual = linea.Replace("DNI: ", "").Trim();
                        }

                        // Cuando encontramos la línea del Casillero, recuperamos el dato
                        if (linea.StartsWith("Casillero: "))
                        {
                            string valorCasillero = linea.Replace("Casillero: ", "").Trim();

                            // Si la persona sí pidió casillero (y no dice "No solicitado")
                            if (valorCasillero != "No solicitado" && int.TryParse(valorCasillero, out int numeroCasillero))
                            {
                                // 4. ACTUALIZAMOS LA MEMORIA GLOBAL (BaseDeDatos)
                                // Restamos 1 porque el casillero 1 está en la fila 0 de tu matriz
                                int indice = numeroCasillero - 1;

                                // Nos aseguramos de no pasarnos del límite de la matriz (30 casilleros)
                                if (indice >= 0 && indice < BaseDeDatos.MatrizCasilleros.GetLength(0))
                                {
                                    // Le decimos a la BaseDeDatos: "Ey, este casillero ya es de este DNI"
                                    BaseDeDatos.MatrizCasilleros[indice, 1] = dniActual;
                                }
                            }

                            // Limpiamos el DNI para la siguiente persona que leamos
                            dniActual = "";
                        }
                    }
                }
            }
        }
    }
}

    // funciona como un modelo de datos estructurado para agrupar y almacenar la información de un usuario 
    // Basicamente guarda los datos ingresados antes de enviarlos al formulario de confirmacion, porque se definene como publicos
    public class DatosResumen
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Edad { get; set; }
        public string Correo { get; set; }
        public string PlanElegido { get; set; }
        public bool EsEstudiante { get; set; }
        public string NombreInstitucion { get; set; }
        public DataTable TablaFacturacion { get; set; }
        public string NumeroCasillero { get; set; } = "No solicitado"; //ver si despues lo sumo no puse la matriz
        public string TarjetaEnmascarada { get; set; } = "Efectivo / Tarjeta";



}

