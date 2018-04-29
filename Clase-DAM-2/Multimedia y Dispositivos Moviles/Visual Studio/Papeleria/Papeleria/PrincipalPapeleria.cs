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
        Seleccion sc;

        public PrincipalPapeleria()
        {
            InitializeComponent();
            p = new Papeleria();
            p.CargarVentas();
            sele = 0;
            face = Datos.PRODUCTO;
            sc = new Seleccion();
        }

        // Muestra datos en el grid principal
        private void gridPrincipal(List<Compra> lista, string[] nombreCabecera, string modo)
        {
            face = modo;

            mostrar(dgvPrincipal, false, dgvPrincipal.ColumnCount);
            mostrar(dgvPrincipal, true, nombreCabecera.Length);
            mostrar(dgvPrincipal, nombreCabecera);

            mostrar(dgvSecunadario, false, dgvSecunadario.ColumnCount);
            mostrar(dgvSecunadario, true, Datos.resumenSecundario.Length);
            mostrar(dgvSecunadario, Datos.resumenSecundario);

            foreach (Compra compra in lista)
                dgvPrincipal.Rows.Add(compra.fecha.ToShortDateString(), compra.codigoCompra, compra.compraCliente.dni,
                    compra.compraCliente.nombre, compra.pComprado.codigo, compra.pComprado.tipo, compra.pComprado.nombre, compra.pComprado.precio);
        }

        private void gridPrincipal(List<Producto> lista, string[] nombreCabecera, string modo)
        {
            face = modo;

            mostrar(dgvPrincipal, false, dgvPrincipal.ColumnCount);
            mostrar(dgvPrincipal, true, Datos.producto.Length);
            mostrar(dgvPrincipal, Datos.producto);

            foreach (Producto p in lista)
                dgvPrincipal.Rows.Add(p.nombre, p.tipo, p.codigo, p.precio);

            gridSecundario();
        }

        // Muestra datos en el grid secunadrio
        private void gridSecundario()
        {
            if (sele > -1 && face.Equals(Datos.PRODUCTO))
            {
                mostrar(dgvSecunadario, false, dgvSecunadario.ColumnCount);

                foreach (Producto p in Datos.Productos)
                    if (p.codigo == Int32.Parse(dgvPrincipal.Rows[sele].Cells[2].Value.ToString()))
                    {
                        if (p is Consumible)
                        {
                            Consumible c = (Consumible)p;
                            mostrar(dgvSecunadario, true, Datos.consumible.Length);
                            mostrar(dgvSecunadario, Datos.consumible);
                            dgvSecunadario.Rows.Add(c.fechaFabricacion.Day.ToString(), c.peso);

                        }
                        else if (p is Reprografia)
                        {
                            Reprografia r = (Reprografia)p;
                            mostrar(dgvSecunadario, true, Datos.reprografia.Length);
                            mostrar(dgvSecunadario, Datos.reprografia);
                            dgvSecunadario.Rows.Add(r.material, r.color, r.fabricante);
                        }
                        else if (p is Accesorio)
                        {
                            Accesorio a = (Accesorio)p;
                            mostrar(dgvSecunadario, true, Datos.accesorio.Length);
                            mostrar(dgvSecunadario, Datos.accesorio);
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
            dgvSecunadario.Rows.Add(tipo, p.CantidadTipoProducto(tipo), p.ImporteTotal(tipo));
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
            sele = 0;

            dgv.Rows.Clear();
            for (int i = 0; i < numeroColumnas; i++)
                dgv.Columns[i].Visible = estado;
        }

        private void mostrar()
        {
            gridPrincipal(Datos.Compras, Datos.resumenPrincipal, Datos.VENTAS);
            gridSecundario(Datos.CONSUMIBLE);
            gridSecundario(Datos.REPROGRAFIA);
            gridSecundario(Datos.ACCESORIO);

            if (dgvPrincipal.Rows.Count == 1)
                MessageBox.Show("No se encontraron compras para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Carga la lista de productos al grid principal
        private void PrincipalPapeleria_Load(object sender, EventArgs e)
        {
            gridPrincipal(Datos.Productos, Datos.producto, Datos.PRODUCTO);
        }

        // Muestra los atributos propios de cada producto en el grid secundario
        private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sele = e.RowIndex;
            gridSecundario();
        }

        // Registra una compra con sus correspondientes datos
        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (face.Equals(face = Datos.PRODUCTO))
            {
                double importe = Datos.Productos[sele].precio;
                MessageBox.Show("Selecciona un cliente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                sc.datos = Datos.CLIENTE;

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

        // Elimina una compra seleccionada del grid principal
        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (face.Equals(Datos.VENTAS))
                if (dgvPrincipal.Rows.Count > 1)
                    if (sele > -1)
                    {
                        p.EliminarCompra(Int32.Parse(dgvPrincipal.Rows[sele].Cells[1].Value.ToString()));
                        mostrar();
                    }
                    else
                        MessageBox.Show("Para eliminar selecione una compra ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("No hay productos para borrar ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Para eliminar primero muestre las compras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Muestra los productos en el grid
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridPrincipal(Datos.Productos, Datos.producto, Datos.PRODUCTO);
            if (dgvPrincipal.Rows.Count == 1)
                MessageBox.Show("No se encontraron productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Muestra lista de ventas tipo reprografia en el grid
        private void reprografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridPrincipal(p.Listado(Datos.REPROGRAFIA), Datos.resumenPrincipal, Datos.VENTAS);
            gridSecundario(Datos.REPROGRAFIA);

            if (dgvPrincipal.Rows.Count == 1)
                MessageBox.Show("No se encontraron compras de tipo: " + Datos.REPROGRAFIA, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Muestra lista de ventas tipo accesorio en el grid
        private void accesorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            gridPrincipal(p.Listado(Datos.ACCESORIO), Datos.resumenPrincipal, Datos.VENTAS);
            gridSecundario(Datos.ACCESORIO);

            if (dgvPrincipal.Rows.Count == 1)
                MessageBox.Show("No se encontraron compras de tipo: " + Datos.REPROGRAFIA, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Muestra lista de ventas tipo consumible en el grid
        private void consumibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridPrincipal(p.Listado(Datos.CONSUMIBLE), Datos.resumenPrincipal, Datos.VENTAS);
            gridSecundario(Datos.CONSUMIBLE);

            if (dgvPrincipal.Rows.Count == 1)
                MessageBox.Show("No se encontraron compras de tipo: " + Datos.CONSUMIBLE, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Muestra lista de ventas total en el grid
        private void totalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        // Muestra lista de ventas por mes en el grid
        private void porMesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            face = Datos.VENTAS;
            int mes;

            sc.datos = Datos.MES;
            MessageBox.Show("Selecciona un mes ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            sc.ShowDialog();

            mes = sc.Eleccion + 1;

            if (!(sc.Eleccion == -1))
            {
                gridPrincipal(p.Listado(mes), Datos.resumenPrincipal, Datos.VENTAS);
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
            MessageBox.Show("Selecciona un cliente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            sc.datos = Datos.CLIENTE;
            sc.ShowDialog();

            if (!(sc.Eleccion == -1))
            {
                gridPrincipal(p.Listado(Datos.ClienteElegido(sc.Eleccion)), Datos.resumenPrincipal, Datos.VENTAS);
                dgvSecunadario.Visible = false;

                if (dgvPrincipal.Rows.Count == 1)
                    MessageBox.Show("No se encontraron compras para el cliente: " + Datos.ClienteElegido(sc.Eleccion), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("No se ha escogido cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Muestra ista de ventas por producto en el grid
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            face = "Ventas";
            MessageBox.Show("Selecciona un producto ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            sc.datos = Datos.PRODUCTO;
            sc.ShowDialog();

            if (!(sc.Eleccion == -1))
            {
                gridPrincipal(p.Listado(Datos.ProductoElegido(sc.Eleccion)), Datos.resumenPrincipal, Datos.VENTAS);
                dgvSecunadario.Visible = false;

                if (dgvPrincipal.Rows.Count == 1)
                    MessageBox.Show("No se han encontrado ventas para el producto: " + Datos.ProductoElegido(sc.Eleccion).nombre, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
                MessageBox.Show("No se ha escogido producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Elimina un cliente de la lista
        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecciona un cliente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            sc.datos = Datos.CLIENTE;
            sc.ShowDialog();

            if (!(sc.Eleccion == -1))
            {
                p.EliminarCliente(Datos.Clientes[sc.Eleccion].dni);
                dgvPrincipal.Rows.Clear();
                dgvSecunadario.Rows.Clear();
            }
            else
                MessageBox.Show("No se ha escogido cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Modifica fecha y/o importe de una compra seleccionada
        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (face == Datos.VENTAS)
            {
                string importe = dgvPrincipal.Rows[sele].Cells[7].Value.ToString();
                DateTime fecha = Datos.OrdenarFecha(dgvPrincipal.Rows[sele].Cells[0].Value.ToString());
                MessageBox.Show("Indique nueva fecha y/o importe para la compra ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                sc.datos = Datos.MODIFICACION;
                sc.Modificacion(importe, fecha);

                sc.ShowDialog();

                if (sc.Modificacion(ref importe, ref fecha))
                {
                    p.ModificarCompra(Convert.ToInt32(dgvPrincipal.Rows[sele].Cells[1].Value.ToString()), fecha, Convert.ToDouble(importe));
                    MessageBox.Show("Operacion realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    mostrar();
                }
                else
                    MessageBox.Show("No hay cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
