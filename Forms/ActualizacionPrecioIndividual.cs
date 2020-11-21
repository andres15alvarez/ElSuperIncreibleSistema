using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ElSuperIncreibleSistema
{
    public partial class ActualizacionPrecioIndividual : Validaciones
    {
        public ActualizacionPrecioIndividual()
        {
            InitializeComponent();
            btnbuscar.Enabled = false;
            btnactualizar.Enabled = false;
        }

        private void ActualizacionPrecioIndividual_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNroEspacio(txtnombre);
            if(txtnombre.Text.Length > 0)
            {
                btnbuscar.Enabled = true;
            }
        }

        private void txtcostodolar_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(txtcostodolar);
            ValidarLimiteEntrada(txtcostodolar, 8);
        }

        private void txtcostobolivar_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(txtcostobolivar);
            ValidarLimiteEntrada(txtcostobolivar, 17);
        }

        private void txtpreciodolar_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(txtpreciodolar);
            ValidarLimiteEntrada(txtpreciodolar, 8);
        }

        private void txtpreciobolivar_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(txtpreciobolivar);
            ValidarLimiteEntrada(txtpreciobolivar, 17);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(bd.BuscarProducto(txtnombre.Text, txtcostodolar, txtcostobolivar, txtpreciodolar, txtpreciobolivar))
            {
                btnactualizar.Enabled = true;
            }

            else
            {
                Error("No se entraron resultados. \nVerifique el codigo", "Error al buscar el producto");
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text == "" || txtcostodolar.Text == "" || txtcostobolivar.Text == "" || txtpreciodolar.Text == "" || txtpreciobolivar.Text == "" ) 
            {
                Advertencia("Debe llenar todos los campos", "Advertencia");
            }

            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(bd.ActualizarPrecioIndividual(txtnombre.Text, txtcostodolar, txtcostobolivar, txtpreciodolar, txtpreciobolivar))
            {
                txtnombre.Text = "";
                txtcostodolar.Text = "";
                txtcostobolivar.Text = "";
                txtpreciodolar.Text = "";
                txtpreciobolivar.Text = "";
                btnactualizar.Enabled = false;
                Informacion("El producto fue actualizado exitosamente", "Actualizacion de producto");
            }

            else
            {
                Error("No se pudo actualizar el producto. \nPor favor verifique los campos", "Error al actualizar el producto");
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();
        }
    }
}
