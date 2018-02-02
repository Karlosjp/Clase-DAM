using System;
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


        public Resumen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            this.Visible = false;
            datos.Show();
        }

        private void ordenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarColumnas();
            dgv_resumen.Columns["velocidad"].Visible = true;
            dgv_resumen.Columns["puertos"].Visible = true;
        }

        private void movilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarColumnas();
            dgv_resumen.Columns["duracionBateria"].Visible = true;
            dgv_resumen.Columns["almacenamiento"].Visible = true;
            dgv_resumen.Columns["so"].Visible = true;
        }
        private void tabletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarColumnas();
            dgv_resumen.Columns["resolicion"].Visible = true;
            dgv_resumen.Columns["duracionBateria"].Visible = true;
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

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_resumen.Columns["almacenamiento"].Visible = true;
            dgv_resumen.Columns["duracionBateria"].Visible = true;
            dgv_resumen.Columns["resolicion"].Visible = true;
            dgv_resumen.Columns["velocidad"].Visible = true;
            dgv_resumen.Columns["puertos"].Visible = true;
            dgv_resumen.Columns["so"].Visible = true;
        }     
    }
}
