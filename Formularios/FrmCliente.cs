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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-36RMT0U\\SQLEXPRESS;Initial Catalog=\"Actividad 3 Zapateria\";Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("insert into Clientes (dni, Nombre, Apellidos, Fecha_de_nacimiento, Teléfono) \r\nvalues ('" + txtDni.Text + "', '" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtFecha.Text + "', '" + txtTelefono.Text + "')", cn);
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
                SqlCommand cmd = new SqlCommand("Update Clientes set Nombre = '" + txtNombre.Text + "', Apellidos = '" + txtApellido.Text + "', Fecha_de_nacimiento = '" + txtFecha.Text + "',  Teléfono = '" + txtTelefono.Text + "' where dni = '" + txtDni.Text + "'", cn);
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
                SqlCommand cmd = new SqlCommand("delete from Clientes where dni = '" +txtDni.Text + "'", cn);
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
            { SqlDataAdapter da = new SqlDataAdapter("select * from Clientes", cn);
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

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtFecha.Clear();
            txtTelefono.Clear();

        }
    }
}
