using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace MySql
{
    public class ConectorBD
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataReader dr;

        public ConectorBD()
        {
            con = new MySqlConnection("server=localhost; database=zonafrancalite; uid=root; password=068856187030");
        }

        public void Conectar()
        {
            con.Open();
        }

        public void Desconectar()
        {
            con.Close();
        }

        public bool VerificarExistencia(string tabla, string columna, string id)
        {
            bool existencia = false;
            Conectar();
            string query = String.Format("SELECT {0} FROM {1} WHERE {0} = ?id;", columna, tabla);
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("?id", MySqlDbType.VarChar).Value = id;
            var resultado = cmd.ExecuteScalar();
            if ((resultado != null) && (id == Convert.ToString(resultado)))
            {
                existencia = true;
                Desconectar();
                return existencia;
            }
            else
            {
                Desconectar();
                return existencia;
            }
        }

        public bool BuscarProducto(string nombre, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            Conectar();
            string query = String.Format("SELECT costo_dolar, costo_bolivar, precio_dolar, precio_bolivar FROM producto  WHERE nombre = '{0}';", nombre);
            cmd = new MySqlCommand(query, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt1.Text = dr[0].ToString();
                txt2.Text = dr[1].ToString();
                txt3.Text = dr[2].ToString();
                txt4.Text = dr[3].ToString();
                dr.Close();
                Desconectar();
                return true;
            }

            else
            {
                dr.Close();
                Desconectar();
                return false;
            }
        }

        public void ActualizarPreciosDolar(double tasa)
        {
            Conectar();
            string query = String.Format("UPDATE producto SET costo_bolivar = costo_dolar * {0}, precio_bolivar = precio_dolar * {0};", tasa);
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            Desconectar();
        }

        public bool ActualizarPrecioIndividual(string nombre, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            Conectar();
            double costodolar = double.Parse(txt1.Text);
            double costobolivar = double.Parse(txt2.Text);
            double preciodolar = double.Parse(txt3.Text);
            double preciobolivar = double.Parse(txt4.Text);
            string query = String.Format("UPDATE producto SET costo_dolar = ?costodolar, costo_bolivar = ?costobolivar, precio_dolar = ?preciodolar, precio_bolivar = ?preciobolivar WHERE nombre = '{0}';", nombre);
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("?costodolar", MySqlDbType.Double).Value = costodolar;
            cmd.Parameters.Add("?costobolivar", MySqlDbType.Double).Value = costobolivar;
            cmd.Parameters.Add("?preciodolar", MySqlDbType.Double).Value = preciodolar;
            cmd.Parameters.Add("?preciobolivar", MySqlDbType.Double).Value = preciobolivar;
            if (cmd.ExecuteNonQuery() > 0)
            {
                Desconectar();
                return true;
            }

            else
            {
                Desconectar();
                return false;
            }
        }

        public bool IncluirProducto(string nombre, TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            Conectar();
            double costodolar = double.Parse(txt1.Text);
            double costobolivar = double.Parse(txt2.Text);
            double preciodolar = double.Parse(txt3.Text);
            double preciobolivar = double.Parse(txt4.Text);
            string query = "INSERT INTO producto(nombre, costo_dolar, costo_bolivar, precio_dolar, precio_bolivar) VALUES(?nombre, ?costodolar, ?costobolivar, ?preciodolar, ?preciobolivar);";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = nombre;
            cmd.Parameters.Add("?costodolar", MySqlDbType.Double).Value = costodolar;
            cmd.Parameters.Add("?costobolivar", MySqlDbType.Double).Value = costobolivar;
            cmd.Parameters.Add("?preciodolar", MySqlDbType.Double).Value = preciodolar;
            cmd.Parameters.Add("?preciobolivar", MySqlDbType.Double).Value = preciobolivar;
            if (cmd.ExecuteNonQuery() > 0)
            {
                Desconectar();
                return true;
            }

            else
            {
                Desconectar();
                return false;
            }
        }

        public void CargarLista(DataGridView dgv)
        {
            Conectar();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT nombre as 'Nombre', costo_dolar as 'Costo en dolares', costo_bolivar as 'Costo en bolivares', precio_dolar as 'Precio en dolares', precio_bolivar as 'Precio en bolivares' FROM producto;", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "producto");
            dgv.DataSource = ds.Tables["producto"];
            Desconectar();
        }
    }
}
