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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            //this.Visible = false;
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
            dgv_resumen.Columns["velocidad"].Visible = true;
            dgv_resumen.Columns["puertos"].Visible = true;

            lista = tienda.Mostrar("Ordenadores");

            foreach (Ordenador or in lista)
                dgv_resumen.Rows.Add("Ordenador", or.Nombre, or.Marca, or.Precio, or.Ram, or.Velocidad, or.Puertos);

        }

        private void movilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarColumnas();
            dgv_resumen.Columns["duracionBateria"].Visible = true;
            dgv_resumen.Columns["almacenamiento"].Visible = true;
            dgv_resumen.Columns["so"].Visible = true;
            
            lista = tienda.Mostrar("Movil");

            foreach (Movil mov in lista)
                dgv_resumen.Rows.Add("Movil", mov.Nombre, mov.Marca, mov.Precio, mov.Ram, mov.DuracionBateria, mov.Almacenamiento, mov.So);
        }
        private void tabletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarColumnas();
            dgv_resumen.Columns["duracionBateria"].Visible = true;
            dgv_resumen.Columns["resolicion"].Visible = true;
            
            lista = tienda.Mostrar("Tablet");

            foreach (Tablet tab in lista)
                dgv_resumen.Rows.Add("Tablet", tab.Nombre, tab.Marca, tab.Precio, tab.Ram, tab.DuracionBateria, tab.Resolucion);
        }
        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i=0; i<dgv_resumen.Columns.Count;i++)
            dgv_resumen.Columns[i].Visible = true;

            lista = tienda.Mostrar("Tablet");

            foreach (Tablet tab in lista)
                dgv_resumen.Rows.Add("Tablet", tab.Nombre, tab.Marca, tab.Precio, tab.Ram,"--","--", tab.DuracionBateria, tab.Resolucion,"--","--");

            lista = tienda.Mostrar("Movil");

            foreach (Movil mov in lista)
                dgv_resumen.Rows.Add("Movil", mov.Nombre, mov.Marca, mov.Precio, mov.Ram, mov.So, mov.Almacenamiento, mov.DuracionBateria,"--","--");

            lista = tienda.Mostrar("Ordenadores");

            foreach (Ordenador ord in lista)
                dgv_resumen.Rows.Add("Ordenadores", ord.Nombre, ord.Marca, ord.Precio, ord.Ram, "--", "--", "--", "--", ord.Velocidad, ord.Puertos);
        }

        private void eliminarColumnas()
        {
            if (dgv_resumen.Columns["almacenamiento"].Visible)
                dgv_resumen.Columns["almacenamiento"].Visible = false;
            if (dgv_resumen.Columns["duracionBateria"].Visible)
                dgv_resumen.Columns["duracionBateria"].Visible = false;
            if (dgv_resumen.Columns["resolicion"].Visible)
                dgv_resumen.Columns["resolicion"].Visible = false;
            if (dgv_resumen.Columns["velocidad"].Visible)
                dgv_resumen.Columns["velocidad"].Visible = false;
            if (dgv_resumen.Columns["puertos"].Visible)
                dgv_resumen.Columns["puertos"].Visible = false;
            if (dgv_resumen.Columns["so"].Visible)
                dgv_resumen.Columns["so"].Visible = false;
        }
    }
}
