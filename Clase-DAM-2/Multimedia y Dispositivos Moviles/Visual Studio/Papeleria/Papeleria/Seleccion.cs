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
            dgvSeleccionCliente.Rows.Clear();

            if (datos.Equals(Datos.CLIENTE))
            {
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
            else if (datos.Equals(Datos.PRODUCTO))
            {
                dgvSeleccionCliente.Columns[0].HeaderText = "Codigo";
                dgvSeleccionCliente.Columns[1].HeaderText = "Producto";
                dgvSeleccionCliente.Columns[1].Visible = true;
                foreach (Producto p in Datos.Productos)
                    dgvSeleccionCliente.Rows.Add(p.codigo, p.nombre);
            }
            else if (datos.Equals(Datos.MES))
            {
                dgvSeleccionCliente.Columns[0].HeaderText = "Mes";
                dgvSeleccionCliente.Columns[1].Visible = false;

                foreach (string s in Datos.meses)
                    dgvSeleccionCliente.Rows.Add(s);
            }
                
        }
    }
}
