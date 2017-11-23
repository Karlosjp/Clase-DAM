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
        ArrayList checks = new ArrayList();
        int numero = 0, max = 0;

        public fLoteria()
        {
            InitializeComponent();
        }

        private void fLoteria_Load(object sender, EventArgs e)
        {
            foreach (Control c in pOpciones.Controls)
                if (c is CheckBox)
                    checks.Add(c);
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
                        reiniciarChecks();
                        modEstadoEleccion(true);
                        rBManual.Checked = true;
                        break;
                    case 1:
                        max = 6;
                        reiniciarChecks();
                        modEstadoEleccion(true);
                        rBManual.Checked = true;
                        break;
                    case 2:
                        max = 8;
                        reiniciarChecks();
                        modEstadoEleccion(true);
                        rBManual.Checked = true;
                        break;
                    default: break;
                }

                numero = rand.Next(1, 10);
                tBReintegro.Text = numero.ToString();
            }
        } 

        private int contarCheck()
        {
            int numCheck = 0;

            foreach (CheckBox c in checks)
                {
                    if (c.Checked)
                        numCheck++;
                }

            return numCheck;
        }

        private void reiniciarChecks()
        {
            foreach (CheckBox c in checks)
                c.Checked = false;
        }

        private void reiniciarChecks(bool opcion)
        {
            foreach (CheckBox c in checks)
                c.Enabled = opcion;
        }

        private void contarChecks(CheckBox c)
        {
            if (contarCheck() > max)
                c.Checked = false;
        }

        private void modEstadoEleccion(bool opcion)
        {
            pOpciones.Enabled = opcion;
            rBAutomática.Enabled = opcion;
            rBManual.Enabled = opcion;
            dTPFecha.Enabled = opcion;
            tBReintegro.Enabled = opcion;
            bValidar.Enabled = opcion;
        }

        private void bValidar_Click(object sender, EventArgs e)
        {
            CheckBox ch;
            int num = 0;
            string mensaje = "Quedan números por seleccionar";
            string titulo = "Faltan numeros";
            MessageBoxButtons opciones = MessageBoxButtons.OK;
            DialogResult result;

            if (contarCheck() == max)
            {
                gBElecion.Enabled = false;
                gBResguardo.Enabled = true;

                foreach (CheckBox c in checks)
                {
                    if (c.Checked)
                    {
                        lBResguardo.Items.Add("Numero " + num + ": " + c.Text);
                        num++;
                    }
                }

                lBResguardo.Items.Add("Reintegro: " + tBReintegro.Text);
            }
            else
            {
                result = MessageBox.Show(mensaje, titulo, opciones, MessageBoxIcon.Error);
            }
        }

        private void rBAutomática_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch;
            int maxCheck = 0;

            if (rBAutomática.Checked)
            {
                reiniciarChecks();
                reiniciarChecks(false);

                while (maxCheck <= max)
                {
                    numero = rand.Next(0, pOpciones.Controls.Count);
                    ch = (CheckBox)pOpciones.Controls[numero];

                    if (!ch.Checked)
                    {
                        maxCheck++;
                        ch.Checked = true;
                    }
                }
            }
        }

        private void rBManual_CheckedChanged(object sender, EventArgs e)
        {
            reiniciarChecks();
            reiniciarChecks(true);
        }

        private void bApostar_Click(object sender, EventArgs e)
        {
            gBResguardo.Enabled = false;
            gBElecion.Enabled = true;
            modEstadoEleccion(false);
            cBApuesta.SelectedIndex = -1;
            lBResguardo.Items.Clear();
            rBManual.Checked = true;
            tBReintegro.Text = "";
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Dsea salir?";
            string titulo = "Salir";
            MessageBoxButtons opciones = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(mensaje, titulo, opciones, MessageBoxIcon.Exclamation);

            if (result == System.Windows.Forms.DialogResult.OK)
                Application.Exit();
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
