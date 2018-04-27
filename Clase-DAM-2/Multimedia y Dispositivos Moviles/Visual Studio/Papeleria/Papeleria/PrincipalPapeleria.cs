using System;
using System.IO;
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
        private string ruta;
        private int sele;
        //No se puede encontrar una parte de la ruta de acceso 'Z:\\Git\\Clase-DAM\\Clase-DAM-2\\Multimedia y Dispositivos Moviles\\Visual Studio\\Papeleria\\Papeleria\\bin\\Debug\\Productos\\Productos.txt'."}	System.Exception {System.IO.DirectoryNotFoundException

        public PrincipalPapeleria()
        {
            InitializeComponent();
            p = new Papeleria();
            ruta = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            sele = 0;
        }

        private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sele = e.RowIndex;
            dgvPrincipal.Rows[sele].Cells[2].Value.ToString();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalPapeleria_Load(object sender, EventArgs e)
        {
            p.IniciarProductos(Path.Combine(ruta, @"Archivos\Productos.txt"));
            List<Producto> productos = p.MostrarProductos();
            foreach (Producto p in productos)
                dgvPrincipal.Rows.Add(p.Nombre, p.Tipo, p.Codigo, p.Precio);
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPrincipal.Rows.RemoveAt(sele);
            p.EliminarCompra(Int32.Parse(dgvPrincipal.Rows[sele].Cells[2].Value.ToString()));
        }
    }
}
