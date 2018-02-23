using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Practicas
{
    public partial class Resumen : Form
    {
        Tienda tienda;

        public Resumen()
        {
            tienda = new Tienda();
            InitializeComponent();
        }

        private void VentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            datos.ShowDialog();

            ArrayList lista = datos.Campos;

            string mensaje = "No datos para agregar";
            string titulo = "Error en datos";

            MessageBoxButtons opciones = MessageBoxButtons.OK;
            DialogResult result;

            if (lista.Count > 0)
                tienda.Anotar(lista);
            else
                result = MessageBox.Show(mensaje, titulo, opciones, MessageBoxIcon.Information);
        }

        private void OrdenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList lista = tienda.Mostrar("Ordenador");
            Mostrar(lista);

            foreach (Producto or in lista)
                dgv_extras.Rows.Add(or.Id, "", "", "", "", or.Velocidad, or.Puertos);

            dgv_extras.Visible = true;
            dgv_extras.Columns["velocidad"].Visible = true;
            dgv_extras.Columns["puertos"].Visible = true;
        }

        private void MovilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList lista = tienda.Mostrar("Movil");
            Mostrar(lista);

            foreach (Producto mov in lista)
                dgv_extras.Rows.Add(mov.Id, mov.So, mov.Almacenamiento, mov.DuracionBateria, "", "", "");

            dgv_extras.Visible = true;
            dgv_extras.Columns["duracionBateria"].Visible = true;
            dgv_extras.Columns["almacenamiento"].Visible = true;
            dgv_extras.Columns["so"].Visible = true;
        }

        private void TabletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList lista = tienda.Mostrar("Tablet");
            Mostrar(lista);

            foreach (Producto tab in lista)
                dgv_extras.Rows.Add(tab.Id, "", "", tab.DuracionBateria, tab.Resolucion, "", "");

            dgv_extras.Visible = true;
            dgv_extras.Columns["duracionBateria"].Visible = true;
            dgv_extras.Columns["resolucion"].Visible = true;
        }

        private void TodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar(tienda.Productos);
        }

        // Introduce en el DataGrilview en el El id, tipo, nombre, marca, precio y ram de todos los productos que se le manden
        private void Mostrar(ArrayList prod)
        {
            EliminarColumnas(false);

            dgv_extras.Visible = false;

            foreach (Producto o in prod)
            {
                int id = o.Id;
                id++;

                dgv_resumen.Rows.Add(id, o.GetType().Name, o.Nombre, o.Marca, o.Precio, o.Ram);
            }
        }

        // Vuelve invisibles las columnas especificas de cada producto
        private void EliminarColumnas(bool e)
        {
            dgv_resumen.Rows.Clear();
            dgv_extras.Rows.Clear();
            
            for (int i = 0; i < dgv_extras.Columns.Count; i++)
                dgv_extras.Columns[i].Visible = e;
        }

        private void Bt_eliminar_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgv_resumen.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if ((selectedRowCount > 0) && dgv_resumen.Rows.Count > 1)
            {
                int indice = dgv_resumen.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int id = Int32.Parse(dgv_resumen.Rows[indice].Cells[0].Value.ToString());
                tienda.Eliminar(--id);

                Mostrar(tienda.Productos);
            }
        }
    }
}
