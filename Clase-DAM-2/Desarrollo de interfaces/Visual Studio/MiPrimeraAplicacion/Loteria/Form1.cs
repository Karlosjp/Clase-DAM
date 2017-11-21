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
        Random rand = new Random();
        int numero = 0, maxCheck = 0, max = 0;

        public fLoteria()
        {
            InitializeComponent();
        }

        private void fLoteria_Load(object sender, EventArgs e)
        {

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
            if (cBApuesta.SelectedItem != null)
            {
                switch (cBApuesta.SelectedIndex)
                {
                    case 0:
                        max = 4;
                        limpiarChecks();
                        activarApuesta();
                        break;
                    case 1:
                        max = 6;
                        limpiarChecks();
                        activarApuesta();
                        break;
                    case 2:
                        max = 8;
                        limpiarChecks();
                        activarApuesta();
                        break;
                    default: break;
                }

                numero = rand.Next(1, 10);
                tBReintegro.Text = numero.ToString();
            }
        } 

        private int contarCheck()
        {
            CheckBox ch;
            int numCheck = 0;

            foreach (Control c in pOpciones.Controls)
                if (c is CheckBox)
                {
                    ch = (CheckBox)c;
                    if (ch.Checked)
                        numCheck++;
                }

            return numCheck;
        }

        private void limpiarChecks()
        {
            CheckBox ch;

            foreach (Control c in pOpciones.Controls)
                if (c is CheckBox)
                {
                    ch = (CheckBox)c;
                    ch.Checked = false;
                }
        }

        private void contarChecks(CheckBox c)
        {
            if (contarCheck() > max)
                c.Checked = false;
        }

        private void activarApuesta()
        {
            pOpciones.Enabled = true;
            rBAutomática.Enabled = true;
            rBManual.Enabled = true;
            dTPFecha.Enabled = true;
            tBReintegro.Enabled = true;
            bValidar.Enabled = true;
        }

        private void bValidar_Click(object sender, EventArgs e)
        {
            gBResguardo.Enabled = true;
        }
        private void rBAutomática_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch;

            for (int i = 0; i < max; i++)
            {
                numero = rand.Next(0, pOpciones.Controls.Count);
                ch = (CheckBox)pOpciones.Controls[numero];
                ch.Checked = true;
            }
        }

        #region checks
        private void cB01_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB01);
        }

        private void cB02_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB02);
        }

        private void cB03_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB03);
        }

        private void cB04_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB04);
        }

        private void cB05_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB05);
        }

        private void cB06_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB06);
        }

        private void cB07_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB07);
        }

        private void cB08_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB08);
        }

        private void cB09_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB09);
        }

        private void cB10_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB10);
        }

        private void cB11_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB11);
        }

        private void cB12_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB12);
        }

        private void cB13_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB13);
        }

        private void cB14_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB14);
        }

        private void cB15_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB15);
        }

        private void cB16_CheckedChanged(object sender, EventArgs e)
        {
            contarChecks(cB16);
        }
        #endregion
    }
}
