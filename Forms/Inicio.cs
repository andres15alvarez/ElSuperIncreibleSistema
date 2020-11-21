using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElSuperIncreibleSistema
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnpreciosdolar_Click(object sender, EventArgs e)
        {
            ActualizacionPreciosDolar preciosDolar = new ActualizacionPreciosDolar();
            this.Hide();
            preciosDolar.Show();
        }

        private void btnprecioindividual_Click(object sender, EventArgs e)
        {
            ActualizacionPrecioIndividual precioIndividual = new ActualizacionPrecioIndividual();
            this.Hide();
            precioIndividual.Show();
        }

        private void btninclusion_Click(object sender, EventArgs e)
        {
            InclusionProductos inclusionProductos = new InclusionProductos();
            this.Hide();
            inclusionProductos.Show();
        }
    }
}
