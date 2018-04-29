using System;
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
    public partial class Seleccion : Form
    {
        private int eleccion;
        Papeleria p;

        public Seleccion()
        {
            InitializeComponent();
            p = new Papeleria();
            eleccion = -1;
            this.datos = "";
        }

        public int Eleccion { get { return eleccion; } }
        public string datos { get; set; }
       
        // Carga la fecha y/o importe al form
        public void Modificacion(string importe, DateTime fecha)
        {
            tbImporte.Text = importe;
            dtpFechaNueva.Value = fecha;
        }

        // Devuelve la fecha e importe indicados
        public bool Modificacion(ref string importe, ref DateTime fecha)
        {
            bool estado = false;

            if (!importe.Equals(tbImporte.Text))
            {
                importe = tbImporte.Text;
                estado = true;
            }

            if (!fecha.Equals(dtpFechaNueva.Value))
            {
                fecha = dtpFechaNueva.Value;
                estado = true;
            }

            return estado;
        }

        // Carga los clientes al grid
        public void CargarClientes()
        {
            dgvSeleccionCliente.Visible = true;

            dgvSeleccionCliente.Columns[0].HeaderText = "Codigo";
            dgvSeleccionCliente.Columns[1].HeaderText = "Cliente";
            dgvSeleccionCliente.Columns[1].Visible = true;

            string[] datosMostrar;

            foreach (string s in p.ListaDatosClientes())
            {
                datosMostrar = s.Split(Datos.Separador, StringSplitOptions.RemoveEmptyEntries);
                dgvSeleccionCliente.Rows.Add(datosMostrar[0], datosMostrar[1]);
            }
        }

        // Carga los productos al grid
        public void CargarProductos()
        {
            dgvSeleccionCliente.Visible = true;

            dgvSeleccionCliente.Columns[0].HeaderText = "Codigo";
            dgvSeleccionCliente.Columns[1].HeaderText = "Producto";
            dgvSeleccionCliente.Columns[1].Visible = true;

            foreach (Producto p in Datos.Productos)
                dgvSeleccionCliente.Rows.Add(p.codigo, p.nombre);
        }

        // Carga los meses al grid
        public void CargarMeses()
        {
            dgvSeleccionCliente.Visible = true;

            dgvSeleccionCliente.Columns[0].HeaderText = "Mes";
            dgvSeleccionCliente.Columns[1].Visible = false;

            foreach (string s in Datos.meses)
                dgvSeleccionCliente.Rows.Add(s);
        }

        // Registra el cliente que hace la compra 
        private void dgvSeleccionCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSeleccionCliente.SelectedRows.Count > 0)
            {
                eleccion = e.RowIndex;
                this.Visible = false;
            }
        }

        // Carga los DNI y Nombres de los clientes
        private void SeleccionClientes_Load(object sender, EventArgs e)
        {
            dgvSeleccionCliente.Visible = false;
            tbImporte.Visible = false;
            lbFecha.Visible = false;
            lbImporte.Visible = false;
            dtpFechaNueva.Visible = false;

            dgvSeleccionCliente.Rows.Clear();

            if (datos.Equals(Datos.CLIENTE))
                CargarClientes();
            else if (datos.Equals(Datos.PRODUCTO))
                CargarProductos();
            else if (datos.Equals(Datos.MES))
                CargarMeses();
            else if (datos.Equals(Datos.MODIFICACION))
                Modificacion();
        }

        // Hace visible los campos para las modificaciones
        private void Modificacion()
        {
            tbImporte.Visible = true;
            lbFecha.Visible = true;
            lbImporte.Visible = true;
            dtpFechaNueva.Visible = true;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
