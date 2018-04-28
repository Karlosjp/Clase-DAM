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
        private int sele;
        private string mostrar;

        public PrincipalPapeleria()
        {
            InitializeComponent();
            p = new Papeleria();
            sele = 0;
            mostrar = "Productos";
        }

        // Muestra los atributos propios de cada producto en el grid secundario
        private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sele = e.RowIndex;

            if (sele > -1)
            {
                dgvSecunadario.Rows.Clear();
                VisibleNo(dgvSecunadario.Columns);

                foreach (Producto p in Datos.Productos)
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
        }

        // Registra una compra con sus correspondientes datos
        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mostrar.Equals("Productos"))
            {
                double importe = Datos.Productos[sele].precio;

                Seleccion sc = new Seleccion();

                if (dgvPrincipal.SelectedRows.Count == 1)
                {
                    sc.ShowDialog();

                    if (!(sc.Cliente == -1))
                    {
                        p.HacerCompra(Datos.ProductoElegido(sele), sc.Cliente, importe);
                        MessageBox.Show("Compra registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("No se ha escogido cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Solo 1 producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Para realizar compra muestre los productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Carga la lista de productos al grid principal
        private void PrincipalPapeleria_Load(object sender, EventArgs e)
        {
            foreach (Producto p in Datos.Productos)
                dgvPrincipal.Rows.Add(p.nombre, p.tipo, p.codigo, p.precio);
        }

        // Elimina una compra seleccionada del grid principal
        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (mostrar.Equals("Ventas"))
            {
                dgvPrincipal.Rows.RemoveAt(sele);
                p.EliminarCompra(Int32.Parse(dgvPrincipal.Rows[sele].Cells[2].Value.ToString()));
            }
            else
                MessageBox.Show("Para realizar compra muestre los productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Pone en visible falce las columnas del grid secundario
        private void VisibleNo(DataGridViewColumnCollection columnas)
        {
            foreach (DataGridViewColumn dgvc in columnas)
                dgvc.Visible = false;
        }

        // Muestra los productos en el grid
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPrincipal.Rows.Clear();

            foreach (Producto p in Datos.Productos)
                dgvPrincipal.Rows.Add(p.nombre, p.tipo, p.codigo, p.precio);
        }

        // Muestra ista de ventas total en el grid
        private void totalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvPrincipal.Rows.Clear();

            foreach (Compra compra in Datos.Compras)
                dgvPrincipal.Rows.Add(compra.fecha.ToShortDateString(),compra.codigoCompra,compra.compraCliente.dni,
                    compra.compraCliente.nombre, compra.pComprado.codigo, compra.pComprado.tipo, compra.pComprado.nombre );
                //dgvPrincipal.Rows.Add(p.nombre, p.tipo, p.codigo, p.precio);
        }

        // Muestra ista de ventas tipo en el grid
        private void porTipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        // Muestra ista de ventas por mes en el grid
        private void porMesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        // Muestra ista de ventas por cliente en el grid
        private void clienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        // Muestra ista de ventas por producto en el grid
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
