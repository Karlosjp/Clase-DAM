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
    public partial class SeleccionClientes : Form
    {
        private int cliente;
        private List<string> nClientes;
        List<string> dClientes;

        public SeleccionClientes(List<string> nClientes, List<string> dClientes)
        {
            InitializeComponent();
            cliente = 0;
            this.nClientes = nClientes;
            this.dClientes = dClientes;
        }

        private void dgvSeleccionCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente = e.RowIndex;
            this.Visible = false;
        }

        public int Cliente { get { return cliente; } }

        private void SeleccionClientes_Load(object sender, EventArgs e)
        {
            foreach (String c in clientes)
                dgvSeleccionCliente.Rows.Add();
        }
    }
}
