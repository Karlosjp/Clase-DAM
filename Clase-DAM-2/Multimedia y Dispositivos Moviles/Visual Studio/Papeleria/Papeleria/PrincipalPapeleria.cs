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
            List<Producto> productos = p.productos;

            dgvSecunadario.Rows.Clear();
            VisibleNo();

            foreach (Producto p in productos)
                if (p.codigo == Int32.Parse(dgvPrincipal.Rows[sele].Cells[2].Value.ToString()))
                {
                    if (p is Consumible)
                    {
                        Consumible c = (Consumible)p;
                        dgvSecunadario.Rows.Add(c.fechaFabricacion.Day.ToString(), c.peso);
                        dgvSecunadario.Columns[0].Visible = true;
                        dgvSecunadario.Columns[0].HeaderText = "Fecha Fabricación";
                        dgvSecunadario.Columns[1].Visible = true;
                        dgvSecunadario.Columns[1].HeaderText = "Peso";
                    }
                    else if (p is Reprografia)
                    {
                        Reprografia r = (Reprografia)p;
                        dgvSecunadario.Rows.Add(r.material, r.color, r.fabricante);
                        dgvSecunadario.Columns[0].Visible = true;
                        dgvSecunadario.Columns[0].HeaderText = "Material";
                        dgvSecunadario.Columns[1].Visible = true;
                        dgvSecunadario.Columns[1].HeaderText = "Color";
                        dgvSecunadario.Columns[2].Visible = true;
                        dgvSecunadario.Columns[2].HeaderText = "Fabricante";                        
                    }
                    else if (p is Accesorio)
                    {
                        Accesorio a = (Accesorio)p;
                        dgvSecunadario.Rows.Add(a.peso, a.material);
                        dgvSecunadario.Columns[0].Visible = true;
                        dgvSecunadario.Columns[0].HeaderText = "Peso";
                        dgvSecunadario.Columns[1].Visible = true;
                        dgvSecunadario.Columns[1].HeaderText = "Material";
                    }
                    break;
                }
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto pc = p.ProductoElegido(sele);
            Cliente cc = new Cliente();
            double importe = 0;
            List<string> lNombre = p.NombreClientes();
            List<string> lDni = p.DniClientes();

            SeleccionClientes sc = new SeleccionClientes(lNombre,lDni);

            sc.ShowDialog();
            

            p.HacerCompra(pc, cc, importe);
        }

        private void PrincipalPapeleria_Load(object sender, EventArgs e)
        {
            p.IniciarProductos(Path.Combine(ruta, @"Archivos\Productos.txt"));
            List<Producto> productos = p.productos;
            foreach (Producto p in productos)
                dgvPrincipal.Rows.Add(p.nombre, p.tipo, p.codigo, p.precio);
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPrincipal.Rows.RemoveAt(sele);
            p.EliminarCompra(Int32.Parse(dgvPrincipal.Rows[sele].Cells[2].Value.ToString()));
        }

        private void VisibleNo()
        {
            foreach (DataGridViewColumn dgvc in dgvSecunadario.Columns)
                dgvc.Visible = false;
        }
    }
}
