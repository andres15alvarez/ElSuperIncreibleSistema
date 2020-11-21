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
    public partial class InclusionProductos : Validaciones
    {
        public InclusionProductos()
        {
            InitializeComponent();
            btnincluir.Enabled = false;
        }

        private void InclusionProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNroEspacio(txtnombre);
            ValidarLimiteEntrada(txtnombre, 50);
            if (txtnombre.Text.Length > 0)
            {
                MySql.ConectorBD bd = new MySql.ConectorBD();
                if (bd.VerificarExistencia("producto", "nombre", txtnombre.Text))
                {
                    lbladvertencia.Text = "El nombre ya se encuentra registrado, por favor escoga otro";
                }

                else
                {
                    lbladvertencia.Text = "";
                    btnincluir.Enabled = true;
                }
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

        private void btnincluir_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text == "" || txtcostodolar.Text == "" || txtcostobolivar.Text == "" || txtpreciodolar.Text =="" || txtpreciobolivar.Text == "")
            {
                Advertencia("Debe llenar todos los campos", "Advertencia");
            }

            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(bd.IncluirProducto(txtnombre.Text, txtcostodolar, txtcostobolivar, txtpreciodolar, txtpreciobolivar))
            {
                txtnombre.Text = "";
                txtcostodolar.Text = "";
                txtcostobolivar.Text = "";
                txtpreciodolar.Text = "";
                txtpreciobolivar.Text = "";
                btnincluir.Enabled = false;
                Informacion("El producto fue incluido exitosamente", "Inclusion de producto");
            }

            else
            {
                Error("No se pudo incluir el producto. \nPor favor verifique los campos", "Error al incluir el producto");
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
