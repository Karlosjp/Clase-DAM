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
            face = Datos.PRODUCTO;
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
            if (sele > -1 && face.Equals(Datos.PRODUCTO))
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
            dgvSecunadario.Visible = true;
            dgvSecunadario.Rows.Add(tipo, Datos.CantidadTipoProducto(tipo), Datos.ImporteTotal(tipo));
        }

        // Registra una compra con sus correspondientes datos
        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (face.Equals(face = Datos.PRODUCTO))
            {
                double importe = Datos.Productos[sele].precio;
                MessageBox.Show("Selecciona un cliente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Seleccion sc = new Seleccion(Datos.CLIENTE);

                if (dgvPrincipal.SelectedRows.Count == 1)
                {
                    sc.ShowDialog();

                    if (!(sc.Eleccion == -1))
                    {
                        p.HacerCompra(Datos.ProductoElegido(sele), sc.Eleccion, importe);
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
            face = Datos.PRODUCTO;

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
            if (face.Equals(Datos.VENTAS))
            {
                if (sele > -1)
                {                  
                    p.EliminarCompra(Int32.Parse(dgvPrincipal.Rows[sele].Cells[2].Value.ToString()));
                    dgvPrincipal.Rows.RemoveAt(sele);
                }

                else
                    MessageBox.Show("Para eliminar selecione una compra ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Para eliminar primero muestre las compras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Prepara las columnas para mostrar productos o ventas
        private void mostrar(DataGridView dgv, string[] nombreColumnas)
        {
            for (int i = 0; i < nombreColumnas.Length; i++)
            {
                dgv.Columns[i].HeaderText = nombreColumnas[i];
            }
        }

        // Muestra datos en el grid principal
        private void gridPrincipal(List<Compra> lista)
        {
            face = Datos.VENTAS;

            mostrar(dgvPrincipal, false, dgvPrincipal.Columns.Count);
            mostrar(dgvPrincipal, true, producto.Length);
            mostrar(dgvPrincipal, producto);

            mostrar(dgvSecunadario, false, dgvSecunadario.Columns.Count);
            mostrar(dgvSecunadario, true, resumenSecundario.Length);
            mostrar(dgvSecunadario, resumenSecundario);

            foreach (Compra compra in lista)
                dgvPrincipal.Rows.Add(compra.fecha.ToShortDateString(), compra.codigoCompra, compra.compraCliente.dni,
                    compra.compraCliente.nombre, compra.pComprado.codigo, compra.pComprado.tipo, compra.pComprado.nombre);
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
            face = Datos.PRODUCTO;

            mostrar(dgvPrincipal, true, resumenPrincipal.Length);
            mostrar(dgvPrincipal, resumenPrincipal);

            foreach (Producto p in Datos.Productos)
                dgvPrincipal.Rows.Add(p.nombre, p.tipo, p.codigo, p.precio);
        }

        // Muestra lista de ventas tipo reprografia en el grid
        private void reprografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridPrincipal(Datos.Listado(Datos.REPROGRAFIA));
            gridSecundario(Datos.REPROGRAFIA);
        }

        // Muestra lista de ventas tipo accesorio en el grid
        private void accesorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridPrincipal(Datos.Listado(Datos.ACCESORIO));
            gridSecundario(Datos.ACCESORIO);
        }

        private void porTipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        // Muestra lista de ventas tipo consumible en el grid
        private void consumibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridPrincipal(Datos.Listado(Datos.CONSUMIBLE));
            gridSecundario(Datos.CONSUMIBLE);
        }

        // Muestra lista de ventas total en el grid
        private void totalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridPrincipal(Datos.Compras);
            gridSecundario(Datos.CONSUMIBLE);
            gridSecundario(Datos.REPROGRAFIA);
            gridSecundario(Datos.ACCESORIO);
        }

        // Muestra lista de ventas por mes en el grid
        private void porMesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            face = Datos.VENTAS;
            int mes;

            Seleccion sc = new Seleccion(Datos.MES);
            MessageBox.Show("Selecciona un mes ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            sc.ShowDialog();

            mes = sc.Eleccion + 1;

            if (!(sc.Eleccion == -1))
            {
                gridPrincipal(Datos.Listado(mes));
                if (dgvPrincipal.Rows.Count > 1)
                {
                    gridSecundario(Datos.CONSUMIBLE);
                    gridSecundario(Datos.REPROGRAFIA);
                    gridSecundario(Datos.ACCESORIO);
                }
                else
                {
                    dgvSecunadario.Visible = false;
                    MessageBox.Show("No se encontraron compras para el mes: " + Datos.meses[--mes], "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("No se ha escogido cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Muestra lista de ventas por cliente en el grid
        private void clienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            face = Datos.VENTAS;

            Seleccion sc = new Seleccion(Datos.CLIENTE);
            MessageBox.Show("Selecciona un cliente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            sc.ShowDialog();

            if (!(sc.Eleccion == -1))
            {
                mostrar(dgvPrincipal, false, dgvPrincipal.Columns.Count);
                mostrar(dgvPrincipal, true, producto.Length);
                mostrar(dgvPrincipal, producto);

                dgvSecunadario.Visible = false;

                foreach (Compra compra in Datos.Listado(Datos.ClienteElegido(sc.Eleccion)))
                    dgvPrincipal.Rows.Add(compra.fecha.ToShortDateString(), compra.codigoCompra, compra.compraCliente.dni,
                        compra.compraCliente.nombre, compra.pComprado.codigo, compra.pComprado.tipo, compra.pComprado.nombre);

            }
            else
                MessageBox.Show("No se ha escogido cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Muestra ista de ventas por producto en el grid
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            face = "Ventas";
            MessageBox.Show("Selecciona un cliente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

/*sc.ShowDialog();

            if (!(sc.Cliente == -1))
            {
                mostrar(dgvPrincipal, false, dgvPrincipal.Columns.Count);
                mostrar(dgvPrincipal, true, producto.Length);
                mostrar(dgvPrincipal, producto);

                dgvSecunadario.Visible = false;

                foreach (Compra compra in Datos.Listado(Datos.ClienteElegido(sc.Cliente)))
                    dgvPrincipal.Rows.Add(compra.fecha.ToShortDateString(), compra.codigoCompra, compra.compraCliente.dni,
                        compra.compraCliente.nombre, compra.pComprado.codigo, compra.pComprado.tipo, compra.pComprado.nombre);

            }
            else
                MessageBox.Show("No se ha escogido cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
        }
    }
}
