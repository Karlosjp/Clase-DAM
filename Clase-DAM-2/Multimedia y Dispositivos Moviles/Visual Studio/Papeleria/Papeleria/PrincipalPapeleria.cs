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
        private string face;
        private string[] consumible, accesorio, reprografia, resumenSecundario, producto, resumenPrincipal;

        public PrincipalPapeleria()
        {
            InitializeComponent();
            p = new Papeleria();
            sele = 0;
            face = "Productos";
            producto = new string[] { "Nombre", "Tipo", "Código", "Precio" };
            consumible = new string[] { "Fecha Fabricación", "Peso"};
            accesorio = new string[] { "Peso", "Material" };
            reprografia = new string[] { "Material", "Color", "Fabricante" };
            resumenSecundario = new string[] { "Tipo", "Cantidad", "Importe total" };
            resumenPrincipal = new string[] { "Fecha compra", "Codigo compra", "Codigo comprador", "Nombre comprador", "Codigo producto", "Tipo producto", "Nombre producto" };
        }

        // Muestra los atributos propios de cada producto en el grid secundario
        private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sele = e.RowIndex;
            gridSecundario();
        }

        // Muestra datos en el grid secunadrio
        private void gridSecundario()
        {
            if (sele > -1 && face.Equals("Productos"))
            {
                mostrar(dgvSecunadario, false, dgvSecunadario.Columns.Count);

                foreach (Producto p in Datos.Productos)
                    if (p.codigo == Int32.Parse(dgvPrincipal.Rows[sele].Cells[2].Value.ToString()))
                    {
                        if (p is Consumible)
                        {
                            Consumible c = (Consumible)p;
                            mostrar(dgvSecunadario, true, consumible.Length);
                            mostrar(dgvSecunadario, consumible);
                            dgvSecunadario.Rows.Add(c.fechaFabricacion.Day.ToString(), c.peso);

                        }
                        else if (p is Reprografia)
                        {
                            Reprografia r = (Reprografia)p;
                            mostrar(dgvSecunadario, true, reprografia.Length);
                            mostrar(dgvSecunadario, reprografia);
                            dgvSecunadario.Rows.Add(r.material, r.color, r.fabricante);
                        }
                        else if (p is Accesorio)
                        {
                            Accesorio a = (Accesorio)p;
                            mostrar(dgvSecunadario, true, accesorio.Length);
                            mostrar(dgvSecunadario, accesorio);
                            dgvSecunadario.Rows.Add(a.peso, a.material);
                        }
                        break;
                    }
            }
        }

        // Muestra tipo, cantidad de productos e importe total de un tipo de producto en el grid secundario
        private void gridSecundario(string tipo)
        {
            dgvSecunadario.Rows.Add(tipo, Datos.CantidadTipoProducto(tipo), Datos.ImporteTotal(tipo));
        }

        // Registra una compra con sus correspondientes datos
        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (face.Equals("Productos"))
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
            face = "Productos";
            mostrar(dgvPrincipal, false, dgvPrincipal.Columns.Count);
            mostrar(dgvPrincipal, true, producto.Length);
            mostrar(dgvPrincipal, producto);

            foreach (Producto p in Datos.Productos)
                dgvPrincipal.Rows.Add(p.nombre, p.tipo, p.codigo, p.precio);

            gridSecundario();            
        }

        // Elimina una compra seleccionada del grid principal
        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (face.Equals("Ventas"))
            {
                mostrar(dgvPrincipal, false, dgvSecunadario.Columns.Count);

                dgvPrincipal.Rows.RemoveAt(sele);
                p.EliminarCompra(Int32.Parse(dgvPrincipal.Rows[sele].Cells[2].Value.ToString()));
            }
            else
                MessageBox.Show("Para realizar compra muestre los productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Prepara las columnas para mostrar productos o ventas
        private void mostrar(DataGridView dgv, string[] nombreColumnas)
        {
            for (int i = 0; i < nombreColumnas.Length; i++)
            {
                dgv.Columns[i].HeaderText = nombreColumnas[i];
            }
        }

        // Pone en visible falce/true las columnas del grid seleccionado
        private void mostrar(DataGridView dgv, bool estado, int numeroColumnas)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < numeroColumnas; i++)
                dgv.Columns[i].Visible = estado;
        }

        // Muestra los productos en el grid
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            face = "Productos";
            mostrar(dgvPrincipal, true, resumenPrincipal.Length);
            mostrar(dgvPrincipal, resumenPrincipal);

            foreach (Producto p in Datos.Productos)
                dgvPrincipal.Rows.Add(p.nombre, p.tipo, p.codigo, p.precio);
        }

        // Muestra ista de ventas total en el grid
        private void totalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            face = "Ventas";
            mostrar(dgvPrincipal, false, dgvPrincipal.Columns.Count);
            mostrar(dgvPrincipal, true, producto.Length);
            mostrar(dgvPrincipal, producto);

            mostrar(dgvSecunadario, false, dgvSecunadario.Columns.Count);
            mostrar(dgvSecunadario, true, resumenSecundario.Length);
            mostrar(dgvSecunadario, resumenSecundario);

            foreach (Compra compra in Datos.Compras)
                dgvPrincipal.Rows.Add(compra.fecha.ToShortDateString(), compra.codigoCompra, compra.compraCliente.dni,
                    compra.compraCliente.nombre, compra.pComprado.codigo, compra.pComprado.tipo, compra.pComprado.nombre);

            gridSecundario(Datos.consumible);
            gridSecundario(Datos.reprografia);
            gridSecundario(Datos.accesorio);            
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
