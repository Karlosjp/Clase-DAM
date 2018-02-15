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
        ArrayList lista;

        public Resumen()
        {
            tienda = new Tienda();
            lista = null;
            InitializeComponent();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            datos.ShowDialog();

            lista = datos.Campos;

            string mensaje = "No datos para agregar";
            string titulo = "Error en datos";

            MessageBoxButtons opciones = MessageBoxButtons.OK;
            DialogResult result;

            if (lista.Count > 0)
                tienda.Anotar(lista);
            else
                result = MessageBox.Show(mensaje, titulo, opciones, MessageBoxIcon.Information);
        }

        private void ordenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarColumnas(false);
            dgv_extras.Columns["velocidad"].Visible = true;
            dgv_extras.Columns["puertos"].Visible = true;

            lista = tienda.Mostrar("Ordenadores");

            foreach (Ordenador or in lista)
            {
                dgv_resumen.Rows.Add(or.Id, "Ordenador", or.Nombre, or.Marca, or.Precio, or.Ram);
                dgv_extras.Rows.Add(or.Id, or.Velocidad, or.Puertos);
            }
        }

        private void movilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarColumnas(false);
            dgv_extras.Columns["duracionBateria"].Visible = true;
            dgv_extras.Columns["almacenamiento"].Visible = true;
            dgv_extras.Columns["so"].Visible = true;

            lista = tienda.Mostrar("Movil");

            foreach (Movil mov in lista)
            {
                dgv_resumen.Rows.Add(mov.Id, "Movil", mov.Nombre, mov.Marca, mov.Precio, mov.Ram);
                dgv_extras.Rows.Add(mov.Id, mov.So, mov.Almacenamiento, mov.DuracionBateria);
            }
        }

        private void tabletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarColumnas(false);
            dgv_extras.Columns["duracionBateria"].Visible = true;
            dgv_extras.Columns["resolucion"].Visible = true;

            lista = tienda.Mostrar("Tablet");

            foreach (Tablet tab in lista)
            {
                dgv_resumen.Rows.Add(tab.Id, "Tablet", tab.Nombre, tab.Marca, tab.Precio, tab.Ram);
                dgv_extras.Rows.Add(tab.Id, tab.DuracionBateria, tab.Resolucion);
            }
        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //eliminarColumnas(true);
            dgv_resumen.Rows.Clear();

            int id = 0;

            lista = tienda.Productos;

            foreach (Object o in lista)
            {
                string t = o.GetType().Name;

                switch (t)
                {
                    case "Ordenador":
                        id = ((Ordenador)o).Id;
                        id++;
                        dgv_resumen.Rows.Add(id, t, ((Ordenador)o).Nombre, ((Ordenador)o).Marca, ((Ordenador)o).Precio, ((Ordenador)o).Ram);
                        //dgv_extras.Rows.Add(((Ordenador)o).Id, "--", "--", "--", "--", ((Ordenador)o).Velocidad, ((Ordenador)o).Puertos);
                        break;
                    case "Movil":
                        id = ((Ordenador)o).Id;
                        id++;
                        dgv_resumen.Rows.Add(id, t, ((Movil)o).Nombre, ((Movil)o).Marca, ((Movil)o).Precio, ((Movil)o).Ram);
                        //dgv_extras.Rows.Add(((Movil)o).Id, ((Movil)o).So, ((Movil)o).Almacenamiento, ((Movil)o).DuracionBateria, "--", "--", "--");
                        break;
                    case "Tablet":
                        id = ((Ordenador)o).Id;
                        id++;
                        dgv_resumen.Rows.Add(id, t, ((Tablet)o).Nombre, ((Tablet)o).Marca, ((Tablet)o).Precio, ((Tablet)o).Ram);
                        //dgv_extras.Rows.Add(((Tablet)o).Id, "--", "--", ((Tablet)o).DuracionBateria, ((Tablet)o).Resolucion, "--", "--");
                        break;
                }
            }
        }

        private void eliminarColumnas(bool e)
        {
            dgv_resumen.Rows.Clear();
            dgv_extras.Rows.Clear();

            for (int i = 0; i < dgv_extras.Columns.Count; i++)
                dgv_extras.Columns[i].Visible = e;
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgv_resumen.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                //tienda.Eliminar();
            }
        }
    }
}
