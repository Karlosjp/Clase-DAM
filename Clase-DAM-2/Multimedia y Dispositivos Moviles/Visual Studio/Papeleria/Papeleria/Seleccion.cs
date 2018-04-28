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
        private int cliente;
        private List<string> nClientes;
        private List<string> dClientes;

        public Seleccion()
        {
            InitializeComponent();
            cliente = -1;
            this.nClientes = Datos.ListaNombresClientes();
            this.dClientes = Datos.ListaDNIClientes();
        }

        public int Cliente { get { return cliente; } }

        // Registra el cliente que hace la compra 
        private void dgvSeleccionCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSeleccionCliente.SelectedRows.Count > 0)
            {
                cliente = e.RowIndex;
                this.Visible = false;
            }
        }

        // Carga los DNI y Nombres de los clientes
        private void SeleccionClientes_Load(object sender, EventArgs e)
        {
            for (int i =0; i<nClientes.Count();i++)
                dgvSeleccionCliente.Rows.Add(dClientes[i], nClientes[i]);
        }
    }
}
