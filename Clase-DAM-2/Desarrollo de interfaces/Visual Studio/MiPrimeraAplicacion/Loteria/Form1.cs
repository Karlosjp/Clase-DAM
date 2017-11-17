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

namespace Loteria
{
    public partial class fLoteria : Form
    {
        public fLoteria()
        {
            InitializeComponent();
        }

        private void fLoteria_Load(object sender, EventArgs e)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add(groupBox1);
            myAL.Add(cBApuesta);
            myAL.Add(label1);
            myAL.Add(label2);
            myAL.Add(panel1);
            myAL.Add(cB16);
            myAL.Add(cB15);
            myAL.Add(cB14);
            myAL.Add(cB13);
            myAL.Add(cB12);
            myAL.Add(cB11);
            myAL.Add(cB10);
            myAL.Add(cB09);
            myAL.Add(cB08);
            myAL.Add(cB07);
            myAL.Add(cB06);
            myAL.Add(cB05);
            myAL.Add(cB04);
            myAL.Add(cB03);
            myAL.Add(cB02);
            myAL.Add(cB01);
            myAL.Add(label3);
            myAL.Add(rBAutomática);
            myAL.Add(rBManual);
            myAL.Add(label5);
            myAL.Add(label4);
            myAL.Add(textBox1);
            myAL.Add(dTPFecha);
            myAL.Add(bValidar);
            myAL.Add(groupBox2);
            myAL.Add(listBox1);
            myAL.Add(bSalir);
            myAL.Add(bApostar);
        }

        private void dTPFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Today;
            DateTime fEleccion = dTPFecha.Value;

            string mensaje = "La fecha no puede ser anterior a hoy";
            string titulo = "Error en datos";
            MessageBoxButtons opciones = MessageBoxButtons.OK;
            DialogResult result;

            if (fEleccion.Date < fechaHoy.Date)
                 result = MessageBox.Show(mensaje, titulo, opciones, MessageBoxIcon.Information);
        }

        private void cBApuesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBApuesta.SelectedItem != "")
                ;
        }
    }
}
