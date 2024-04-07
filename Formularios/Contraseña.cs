using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud.Formularios
{
    public partial class ContrasenaClientes : Form
    {
        public ContrasenaClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContrasenaC.Text == "")
            {
                MessageBox.Show("Debe de ingreasar contraseña");

            }

            else if (txtContrasenaC.Text == "12345")
            {
                Form clientes = new FrmCliente();
                clientes.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Contraseña incorrecta");
                txtContrasenaC.Clear();

            }
        }
    }
}
