using System.Data;

namespace pryAguirreGimnasio
{
    public partial class frmConfirmacion : Form
    {
        // Variable global para almacenar los datos que llegan al formulario
        private DatosResumen datosGlobales;

        public frmConfirmacion(DatosResumen datosDelUsuario)
        {
            InitializeComponent();

            // Guardamos los datos recibidos en nuestra variable global
            datosGlobales = datosDelUsuario;

            // 1. Configuramos el DataGridView para que se vea limpio
            datagTodoslosdatos.AllowUserToAddRows = false;
            datagTodoslosdatos.RowHeadersVisible = false;
            datagTodoslosdatos.ReadOnly = true;
            datagTodoslosdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. Creamos una nueva tabla estructurada para mostrar absolutamente todo
            DataTable tablaCompleta = new DataTable();
            tablaCompleta.Columns.Add("Concepto");
            tablaCompleta.Columns.Add("Detalle");

            // 3. Agregamos los datos personales a la tabla
            tablaCompleta.Rows.Add("--- DATOS DEL NUEVO MIEMBRO ---", "");
            tablaCompleta.Rows.Add("Nombre y Apellido", datosDelUsuario.Nombre);
            tablaCompleta.Rows.Add("DNI", datosDelUsuario.DNI);
            tablaCompleta.Rows.Add("Edad", datosDelUsuario.Edad + " años");
            tablaCompleta.Rows.Add("Correo Electrónico", datosDelUsuario.Correo);

            // Evaluamos si es estudiante para mostrar SÍ o NO
            string esEstudiante = datosDelUsuario.EsEstudiante ? "SÍ" : "NO";
            tablaCompleta.Rows.Add("Es Estudiante", esEstudiante);
            string institucion = string.IsNullOrWhiteSpace(datosDelUsuario.NombreInstitucion) ? "No aplica / Ninguna" : datosDelUsuario.NombreInstitucion;
            tablaCompleta.Rows.Add("Institución", institucion);
            tablaCompleta.Rows.Add("Plan Elegido", datosDelUsuario.PlanElegido);
            tablaCompleta.Rows.Add("Método de Pago", datosDelUsuario.TarjetaEnmascarada);
            tablaCompleta.Rows.Add("Casillero Nº", datosDelUsuario.NumeroCasillero);
            tablaCompleta.Rows.Add("", ""); // Fila en blanco como separador
            tablaCompleta.Rows.Add("--- DETALLE DE FACTURACIÓN ---", "");

            // 4. Extraemos las filas de la tabla de facturación y las sumamos a esta tabla completa
            if (datosDelUsuario.TablaFacturacion != null)
            {
                foreach (DataRow filaFacturacion in datosDelUsuario.TablaFacturacion.Rows)
                {
                    string concepto = filaFacturacion["Concepto"].ToString();
                    string detalle = $"{filaFacturacion["Detalle / Meses"]} | {filaFacturacion["Subtotal"]}";

                    tablaCompleta.Rows.Add(concepto, detalle);
                }
            }

            // 5. Finalmente, pasamos esta mega-tabla al DataGridView
            datagTodoslosdatos.DataSource = tablaCompleta;
        }

        private void datagTodoslosdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Espacio para programar clics dentro de las celdas si lo requieres a futuro
        }

        // 3. GUARDADO ACUMULATIVO DEL ARRAY GLOBAL EN RUTA FIJA
        private void btnSuscribir_Click(object sender, EventArgs e)
        {
            // 1. Definimos la ruta fija de la carpeta
            string rutaCarpeta = @"C:\Inscripciones_SigloGym\";

            // 2. Verificamos si la carpeta existe. Si no, se crea.
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            // 3. Usamos un nombre de archivo TOTAL para guardar a todos juntos
            string nombreArchivo = "Inscripciones_Totales.txt";

            // 4. Unimos la carpeta con el nombre del archivo
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

            try
            {
                // 5. Usamos true para agregar al socio nuevo sin borrar los anteriores
                using (StreamWriter escritor = new StreamWriter(rutaCompleta, true))
                {
                    escritor.WriteLine("========================================");
                    escritor.WriteLine($"--- NUEVO SOCIO REGISTRADO ---");
                    escritor.WriteLine("Fecha de emisión: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                    escritor.WriteLine("========================================");
                    escritor.WriteLine("Nombre: " + datosGlobales.Nombre);
                    escritor.WriteLine("DNI: " + datosGlobales.DNI);
                    escritor.WriteLine("Edad: " + datosGlobales.Edad + " años");
                    escritor.WriteLine("Correo: " + datosGlobales.Correo);
                    escritor.WriteLine("Estudiante: " + (datosGlobales.EsEstudiante ? "SÍ" : "NO"));

                    string institucionTxt = string.IsNullOrWhiteSpace(datosGlobales.NombreInstitucion) ? "No aplica / Ninguna" : datosGlobales.NombreInstitucion;
                    escritor.WriteLine("Institución: " + institucionTxt);

                    escritor.WriteLine("Plan Elegido: " + datosGlobales.PlanElegido);
                    escritor.WriteLine("Casillero: " + datosGlobales.NumeroCasillero);
                    escritor.WriteLine("Método de Pago: " + datosGlobales.TarjetaEnmascarada);
                    escritor.WriteLine("----------------------------------------");
                }

                // Avisamos que todo salió bien
                MessageBox.Show("¡Suscripciones guardadas correctamente desde el arreglo global en:\n" + rutaCompleta,
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cierra este formulario al terminar
                this.Close();
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostramos el mensaje
                MessageBox.Show("Hubo un error al guardar el archivo: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}