using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Crud.Formularios
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void lblnif_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-36RMT0U\\SQLEXPRESS;Initial Catalog=\"Actividad 3 Zapateria\";Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("insert into Compras (fecha_de_compra, Id_clientes, Código_producto) \r\nvalues ('" + txtfecha.Text + "', '" + txtIdCliente.Text + "', '" + txtcodigop.Text + "')", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Se agregó de manera correcta a " + txtfecha.Text + ".");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-36RMT0U\\SQLEXPRESS;Initial Catalog=\"Actividad 3 Zapateria\";Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("Update Compras set Código_producto = '" + txtcodigop.Text + "', Id_clientes = '" + txtIdCliente.Text + "' where fecha_de_compra = '" + txtfecha.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Se modificó exitosamente a " + txtfecha.Text + ".");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-36RMT0U\\SQLEXPRESS;Initial Catalog=\"Actividad 3 Zapateria\";Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("delete from Compras where fecha_de_compra = '" + txtfecha.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Se eliminó exitosamente a " + txtfecha.Text + ".");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-36RMT0U\\SQLEXPRESS;Initial Catalog=\"Actividad 3 Zapateria\";Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Compras", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dataGridViewCompras.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtfecha.Clear();
            txtIdCliente.Clear();   
            txtcodigop.Clear();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
