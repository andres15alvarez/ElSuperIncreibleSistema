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
    public partial class ActualizacionPreciosDolar : Validaciones
    {
        public ActualizacionPreciosDolar()
        {
            InitializeComponent();
            btnpreciosdolar.Enabled = false;
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.CargarLista(dgvproductos);
        }

        private void ActualizacionPreciosDolar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txttasadolar_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(txttasadolar);
            if(txttasadolar.Text.Length > 0)
            {
                btnpreciosdolar.Enabled = true;
            }
            else
            {
                btnpreciosdolar.Enabled = false;
            }
        }

        private void btnpreciosdolar_Click(object sender, EventArgs e)
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.ActualizarPreciosDolar(double.Parse(txttasadolar.Text));
            txttasadolar.Clear();
            Informacion("Los prodcutos fueron actualizados satisfactoriamente", "Actualizacion exitosa");
            bd.CargarLista(dgvproductos);
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application exportar = new Microsoft.Office.Interop.Excel.Application();
            exportar.Application.Workbooks.Add(true);

            int indicecolumna = 0;

            foreach(DataGridViewColumn columna in dgvproductos.Columns)
            {
                indicecolumna++;

                exportar.Cells[1, indicecolumna] = columna.Name;
            }

            int indicefila = 1;

            foreach(DataGridViewRow fila in dgvproductos.Rows)
            {
                indicefila++;
                indicecolumna = 0;

                foreach(DataGridViewColumn columna in dgvproductos.Columns)
                {
                    indicecolumna++;
                    exportar.Cells[indicefila, indicecolumna] = fila.Cells[columna.Name].Value;
                }
            }

            exportar.Visible = true;
        }

        private void btnvoler_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();
        }
    }
}
