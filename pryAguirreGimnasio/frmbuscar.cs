using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; // <-- Necesario para manejar la lectura del archivo TXT

namespace pryAguirreGimnasio
{
    public partial class frmbuscar : Form
    {
        public frmbuscar()
        {
            InitializeComponent();

            // 1. Configuramos que la grilla se vea limpia al abrir el formulario
            datagBuscar.AllowUserToAddRows = false;
            datagBuscar.RowHeadersVisible = false;
            datagBuscar.ReadOnly = true;
            datagBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagBuscar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            // busqueda automáticamente mientras el usuario escribe,
            // sin necesidad de presionar el botón, descomenta la línea de abajo:
            // btnBuscar.PerformClick();
        }

        private void datagBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Espacio para programar clics dentro de las celdas (ej: un botón para eliminar)
        }

        // --- BOTÓN PRINCIPAL DE BÚSQUEDA ---
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = txtBuscador.Text.Trim();
            string rutaArchivo = @"C:\Inscripciones_SigloGym\Inscripciones_Totales.txt";

            //estructura de las columnas para el DataGridView
            DataTable tablaResultados = new DataTable();
            tablaResultados.Columns.Add("Nombre");
            tablaResultados.Columns.Add("DNI");
            tablaResultados.Columns.Add("Edad");
            tablaResultados.Columns.Add("Plan");
            tablaResultados.Columns.Add("Estudiante");
            tablaResultados.Columns.Add("Casillero");


            //despues sumar todas las filas de casilleros,prof,etc


            // Si el archivo de texto no existe
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("Aún no hay inscripciones registradas en el sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datagBuscar.DataSource = tablaResultados;
                return;
            }

            try
            {
                // leer documento completo
                string todoElTexto = File.ReadAllText(rutaArchivo);

                // Cortamos el archivo por cada bloque de inscripción usando el título como "tijera"
                string separador = "--- SOCIO N°";
                string[] bloques = todoElTexto.Split(new string[] { separador }, StringSplitOptions.RemoveEmptyEntries);

                // Analizamos alumno por alumno
                foreach (string bloque in bloques)
                   
                {
                    // Si el TextBox está vacío (queremos ver a todos) o si este bloque tiene la palabra que buscamos
                    if (string.IsNullOrEmpty(textoBuscado) || bloque.Contains(textoBuscado))
                    {
                        // Extraemos los datos exactos usando la función que está abajo
                        string nombre = ExtraerDato(bloque, "Nombre: ");
                        string dni = ExtraerDato(bloque, "DNI: ");
                        string edad = ExtraerDato(bloque, "Edad: ");
                        string plan = ExtraerDato(bloque, "Plan Elegido: ");
                        string estudiante = ExtraerDato(bloque, "Estudiante: ");
                        string casillero = ExtraerDato(bloque, "Casillero Nº: ");

                        // Los agregamos como una fila a nuestra tabla
                        tablaResultados.Rows.Add(nombre, dni, edad, plan, estudiante, casillero);
                    }
                }

                // Pasamos la tabla terminada a tu DataGridView
                datagBuscar.DataSource = tablaResultados;

                // Si buscó algo específico y no lo encontró, le avisamos
                if (tablaResultados.Rows.Count == 0 && !string.IsNullOrEmpty(textoBuscado))
                {
                    MessageBox.Show("No se encontró ningún registro coincidente con: " + textoBuscado, "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- FUNCIÓN AUXILIAR PARA EXTRAER DATOS DEL TXT ---
        // Busca una palabra clave (ej: "DNI: ") y recorta solo el valor que está adelante
        private string ExtraerDato(string bloqueTexto, string clave)
        {
            int indiceInicio = bloqueTexto.IndexOf(clave);
            if (indiceInicio == -1) return "---"; // Si no encuentra el dato, pone guiones

            // Avanzamos el índice para saltar la palabra clave y leer solo el valor
            indiceInicio += clave.Length;

            // Buscamos dónde termina ese renglón
            int indiceFin = bloqueTexto.IndexOf(Environment.NewLine, indiceInicio);
            if (indiceFin == -1) indiceFin = bloqueTexto.Length;

            // Recortamos el fragmento exacto y lo devolvemos limpio
            return bloqueTexto.Substring(indiceInicio, indiceFin - indiceInicio).Trim();
        }
    }
}

//sumar configuracion dinamica de estado
//sumar datos de estado de cuenta
//sumar datos de pagos