using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Crud.Formularios
{
    public partial class Provedores : Form
    {
        public Provedores()
        {
            InitializeComponent();
        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-36RMT0U\\SQLEXPRESS;Initial Catalog=\"Actividad 3 Zapateria\";Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("insert into Provedores (nif, Nombre, Dirección) \r\nvalues ('" + txtNif.Text + "', '" + txtNombre.Text + "', '" + txtDirección.Text + "')", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Se agregó de manera correcta a " + txtNombre.Text + ".");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-36RMT0U\\SQLEXPRESS;Initial Catalog=\"Actividad 3 Zapateria\";Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("Update Provedores set Nombre = '" + txtNombre.Text + "', Dirección = '" + txtDirección.Text + "' where nif = '" + txtNif.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Se modificó exitosamente a " + txtNombre.Text + ".");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-36RMT0U\\SQLEXPRESS;Initial Catalog=\"Actividad 3 Zapateria\";Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("delete from Provedores where nif = '" + txtNif.Text + "'", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Se eliminó exitosamente a " + txtNombre.Text + ".");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-36RMT0U\\SQLEXPRESS;Initial Catalog=\"Actividad 3 Zapateria\";Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Provedores", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dataGridViewCliente.DataSource = dt;

            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNif.Clear();
            txtNombre.Clear();
            txtDirección.Clear();
        }
    }
}
