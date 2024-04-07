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
    public partial class ContraseñaPro : Form
    {
        public ContraseñaPro()
        {
            InitializeComponent();
        }

        private void btncontrasena_Click(object sender, EventArgs e)
        {
            if (txtContrasenaP.Text == "")
            {
                MessageBox.Show("Debe de ingreasar contraseña");

            }

            else if (txtContrasenaP.Text == "12345")
            {
                Form Provedores = new Provedores();
                Provedores.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Contraseña incorrecta");
                txtContrasenaP.Clear();
            }
        }
    }
}
