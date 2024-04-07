using Crud.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mensajeDeBienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por visitar nuestra página, queremos consentir tus pies y los de toda tu familia");
        }

        private void quienesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Somos una empres familiar que nace en Michoacán en 1993 y que busca hacer los mejores zapatos del mundo");
        }

        private void misiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuestra misión es que todos los pies de México puedan sentirse comodos en cualquier actividad que hagan");
        }

        private void propositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuestro propósito es acercarte a un mundo de opciones para que tus pies esten cómodos cada día");
        }

        private void damasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tallas = new Tallas();
            tallas.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form contra = new ContrasenaClientes();
            contra.Show();
        }

        private void caballerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tallash = new TallasHom();
            tallash.Show();
        }

        private void provedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form contrasena = new ContraseñaPro();
            contrasena.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form producto = new Productos();
            producto.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form compras = new Compras();
            compras.Show();
        }
    }
}
