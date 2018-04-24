using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papeleria
{
    public partial class PrincipalPapeleria : Form
    {
        private Papeleria p;

        public PrincipalPapeleria()
        {
            InitializeComponent();
            p = new Papeleria();
        }

        private void actualizarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.IniciarProductos("productos.txt");
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.GuardarProductos(@"C:\Productos","Productos.txt");
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.IniciarProductos("Z:\\Productos.txt");
        }
    }
}
