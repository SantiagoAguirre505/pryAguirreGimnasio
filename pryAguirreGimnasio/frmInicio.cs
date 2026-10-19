using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAguirreGimnasio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmbuscar buscar = new frmbuscar();//crea una instancia del formulario de búsqueda
            buscar.Show();//muestra el formulario de búsqueda
            buscar.FormClosed += (s, args) => this.Show(); //cuando se cierra el formulario de búsqueda, se vuelve a mostrar el formulario de inicio
            this.Hide(); //oculta el formulario de inicio mientras se muestra el formulario de búsqueda
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmInscripcion cargarNuevos = new frmInscripcion();
            cargarNuevos.Show();
            cargarNuevos.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
