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
            eliminarColumnas();
            dgv_extras.Columns["velocidad"].Visible = true;
            dgv_extras.Columns["puertos"].Visible = true;

            lista = tienda.Mostrar("Ordenadores");

            foreach (Ordenador or in lista)
            {
                dgv_resumen.Rows.Add("Ordenador", or.Nombre, or.Marca, or.Precio, or.Ram);
                dgv_extras.Rows.Add(or.Velocidad, or.Puertos);
            }
        }

        private void movilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarColumnas();
            dgv_extras.Columns["duracionBateria"].Visible = true;
            dgv_extras.Columns["almacenamiento"].Visible = true;
            dgv_extras.Columns["so"].Visible = true;
            
            lista = tienda.Mostrar("Movil");

            foreach (Movil mov in lista)
            {
                dgv_resumen.Rows.Add("Movil", mov.Nombre, mov.Marca, mov.Precio, mov.Ram);
                dgv_extras.Rows.Add(mov.So, mov.Almacenamiento, mov.DuracionBateria);
            }
        }

        private void tabletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarColumnas();
            dgv_extras.Columns["duracionBateria"].Visible = true;
            dgv_extras.Columns["resolicion"].Visible = true;
            
            lista = tienda.Mostrar("Tablet");

            foreach (Tablet tab in lista)
            {
                dgv_resumen.Rows.Add("Tablet", tab.Nombre, tab.Marca, tab.Precio, tab.Ram);
                dgv_extras.Rows.Add(tab.DuracionBateria, tab.Resolucion);
            }
        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_resumen.Columns.Count; i++)
                dgv_resumen.Columns[i].Visible = true;

            lista = tienda.Productos;

            for(int j = 0; j <lista.Count;j++)
            {
                if(lista[j].GetType().ToString().Equals("Ordenador"))
                    dgv_resumen.Rows.Add("Ordenador", ((Ordenador)lista[j]).Nombre, ((Ordenador)lista[j]).Marca,
                        ((Ordenador)lista[j]).Precio, ((Ordenador)lista[j]).Ram);
                else if (lista[j].GetType().ToString().Equals("Tablet"))
                    dgv_resumen.Rows.Add("Tablet", ((Ordenador)lista[j]).Nombre, ((Ordenador)lista[j]).Marca,
                        ((Tablet)lista[j]).Precio, ((Ordenador)lista[j]).Ram);
                else if (lista[j].GetType().ToString().Equals("Movil"))
                    dgv_resumen.Rows.Add("Movil", ((Ordenador)lista[j]).Nombre, ((Ordenador)lista[j]).Marca,
                        ((Movil)lista[j]).Precio, ((Ordenador)lista[j]).Ram);
            }
        }

        private void eliminarColumnas()
        {
            for (int i = 0; i > dgv_resumen.Columns.Count; i++)
                dgv_extras.Columns[i].Visible = false;
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
