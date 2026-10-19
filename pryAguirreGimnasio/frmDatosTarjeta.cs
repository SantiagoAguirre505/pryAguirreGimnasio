using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAguirreGimnasio
{
    public partial class frmDatosTarjeta : Form
    {
        // Variable pública estática para pasar la tarjeta censurada al formulario principal y al TXT
        public static string TarjetaEnmascaradaGlobal = "";

        public frmDatosTarjeta()
        {
            InitializeComponent();

            // Bloqueamos letras en los campos de Número y CVV desde el arranque
            txtNumeroTarjeta.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            txtCVV.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
        }

        // Evento genérico para permitir solo el ingreso de números
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Anula la tecla si se presiona una letra
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            // Validamos que el usuario no deje campos vacíos
            if (txtNumeroTarjeta.Text == "" || txtNombreApellido.Text == "" || txtCVV.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los datos de la tarjeta.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Capturamos los datos de los TextBox
            string tipo = cboTipoTarjeta.SelectedItem != null ? cboTipoTarjeta.SelectedItem.ToString() : "No especificado";
            string numero = txtNumeroTarjeta.Text;
            string titular = txtNombreApellido.Text.ToUpper();
            string vencimiento = txtFechaExpiracion.Text;
            string cvv = txtCVV.Text;

            // 2. CARGAMOS LOS DATOS EN LA MATRIZ GLOBAL DE 'BaseDeDatos'
            bool guardado = BaseDeDatos.AgregarTarjeta(tipo, numero, titular, vencimiento, cvv);

            if (guardado)
            {
                // 3. --- LÓGICA PARA CREAR LA TARJETA ENMASCARADA Y SEGURA ---
                if (numero.Length >= 4)
                {
                    string ultimos4 = numero.Substring(numero.Length - 4);
                    TarjetaEnmascaradaGlobal = "****-****-****-" + ultimos4;
                }
                else
                {
                    TarjetaEnmascaradaGlobal = "****-****-****-****";
                }

                MessageBox.Show("El método de pago ha sido guardado exitosamente.", "Pago Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra esta ventana y vuelve a la de inscripción
            }
            else
            {
                MessageBox.Show("Límite de tarjetas almacenadas en la matriz superado.", "Límite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}