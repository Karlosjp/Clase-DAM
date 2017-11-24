using Loteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen___Login_loteria
{
    public partial class Login : Form
    {
        string user, pass;
        bool mostrar = false;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bAcceso_Click(object sender, EventArgs e)
        {
            string mensajeUser = "Error email",
                mensajePass = "Error en la contraseña",
                mensajeFecha = "Debe ser mayor de edad",
                mensajeImagen = "Error en la imagen",
                mensajeFinal = "Registro correcto",
                tituloFinal = "Correcto",
                tituloError = "Error";
            MessageBoxButtons opciones = MessageBoxButtons.OK;
            DialogResult result;

            if (cUser(tBUsuarioRegistro.Text))
                if (cPass(tBContrasenaRegistro.Text))
                    if (cFecha(dTPNacimiento.Value))
                        if (pBImagen.Image != null)
                        {
                            result = MessageBox.Show(mensajeFinal, tituloFinal, opciones, MessageBoxIcon.Information);
                            gBLogin.Enabled = true;
                            gBRegistro.Enabled = false;
                            pass = tBContrasenaRegistro.Text;
                            user = tBUsuarioRegistro.Text;
                            limpiarRegistro();
                        } else
                            result = MessageBox.Show(mensajeImagen, tituloError, opciones, MessageBoxIcon.Warning);
                    else
                        result = MessageBox.Show(mensajeFecha, tituloError, opciones, MessageBoxIcon.Warning);
                else
                    result = MessageBox.Show(mensajePass, tituloError, opciones, MessageBoxIcon.Warning);
            else
                result = MessageBox.Show(mensajeUser, tituloError, opciones, MessageBoxIcon.Warning);
        }

        private bool cUser(string dato)
        {
            bool aux = false;
            string[] dDivididos;

            dDivididos = dato.Split('@');

            if (dDivididos.Length == 2)
                if (dDivididos[0].Length > 0)
                    if (dDivididos[1].Equals("gmail.com"))
                        aux = true;

            return aux;
        }

        private bool cPass(string dato)
        {
            bool aux = false;

            if (dato.Length >= 4)
                for (int i = 0; i < dato.Length; i++)
                    auxPass(dato[i], ref aux);

            return aux;
        }

        private void auxPass(char d, ref bool aux)
        {
            switch (d)
            {
                case '+':
                    aux = true;
                    break;
                case '-':
                    aux = true;
                    break;
                case '/':
                    aux = true;
                    break;
                case '*':
                    aux = true;
                    break;
            }
        }

        private bool cFecha(DateTime fecha)
        {
            DateTime fechaHoy = DateTime.Today;
            DateTime fechaMod = new DateTime(fechaHoy.Year - 18, fechaHoy.Month, fechaHoy.Day);

            return fecha <= fechaMod;
        }

        private void pBImagen_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            oFDImagen.InitialDirectory = "C:\\";
            oFDImagen.Filter = "Archivos de imágenes (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp";
            oFDImagen.RestoreDirectory = true;

            if (oFDImagen.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = oFDImagen.OpenFile()) != null)
                    pBImagen.ImageLocation = oFDImagen.FileName;
            }
        }

        private void limpiarRegistro()
        {
            pBImagen.Image = null;            
            tBContrasenaRegistro.Text = "";
            tBUsuarioRegistro.Text = "";
        }

        private void bLimpiarRegistro_Click(object sender, EventArgs e)
        {
            limpiarRegistro();
        }

        private void bLimpiarLogin_Click(object sender, EventArgs e)
        {
            limpiarLogin();
        }

        private void bJugar_Click(object sender, EventArgs e)
        {
            string mensajeErr = "Error en el acceso", mensajeCor = "Acceso correcto",
                tituloErr = "Error", tituloCor = "Correcto";
            MessageBoxButtons opciones = MessageBoxButtons.OK;
            DialogResult result;

            if (tBUsuarioLogin.Text.Equals(user) && tBContrasenaLogin.Text.Equals(pass))
            {
                result = MessageBox.Show(mensajeCor, tituloCor, opciones, MessageBoxIcon.Information);

                Loteria.Loteria loto = new Loteria.Loteria();
                this.Visible = false;
                loto.Show();
            }
            else
                result = MessageBox.Show(mensajeErr, tituloErr, opciones, MessageBoxIcon.Warning);
        }

        private void cBMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cBMostrar.Checked)
            {
                mostrar = true;
                tBMostrar.Text = tBContrasenaLogin.Text;
            }
            else
            {
                tBMostrar.Text = "";
                mostrar = false;
            }
                
        }

        private void tBContrasenaLogin_TextChanged(object sender, EventArgs e)
        {
            if (mostrar)
                tBMostrar.Text =  tBContrasenaLogin.Text;
        }

        private void limpiarLogin()
        {
            tBContrasenaLogin.Text = "";
            tBUsuarioLogin.Text = "";
            tBMostrar.Text = "";
        }
    }
}
