using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAguirreGimnasio
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        private async void frmSplash_Load(object sender, EventArgs e)
        {
            prbCarga.Minimum = 0;
            prbCarga.Maximum = 100;
            prbCarga.Value = 0;

            for (int i = 0; i <= 100; i++)// Bucle para llenar la barra de progreso
            {
                prbCarga.Value = i; // Actualiza el valor de la barra de progreso
                await Task.Delay(30); // Simula un tiempo de carga para que la barra de progreso se llene gradualmente
            }
            await Task.Delay(500);// Espera adicional para que el usuario vea la barra llena
            this.Close(); // Cierra el formulario de splash después de completar la carga
            // Abre el formulario principal
        }


    }
}
