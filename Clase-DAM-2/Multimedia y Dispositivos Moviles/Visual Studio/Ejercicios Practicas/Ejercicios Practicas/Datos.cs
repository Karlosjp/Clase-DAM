using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Practicas
{
    public partial class Datos : Form
    {
        private ArrayList campos = new ArrayList();
        Tienda tienda = new Tienda();

        public Datos()
        {
            InitializeComponent();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

            campos.Add(ti.ToTitleCase(cb_tipo.SelectedItem.ToString()));

            campos.Add(ti.ToTitleCase(tb_marca.Text));
            campos.Add(ti.ToTitleCase(tb_nombre.Text));
            campos.Add(tb_ram.Text);
            campos.Add(tb_precio.Text);
            campos.Add(tb_opcional1.Text);
            campos.Add(tb_opcional2.Text);

            if (cb_tipo.SelectedItem.ToString().Equals("Movil"))
                campos.Add(tb_opcional3.Text);

            tienda.Anotar(campos);
            this.Close();
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sele = cb_tipo.SelectedItem.ToString();

            la_opcional1.Visible = true;
            la_opcional2.Visible = true;
            tb_opcional1.Visible = true;
            tb_opcional2.Visible = true;
            la_opcional3.Visible = false;
            tb_opcional3.Visible = false;
            bt_agregar.Visible = true;

            switch (sele)
            {
                case "Ordenador":
                    anaOrd();
                    break;
                case "Movil":
                    anaMov();
                    break;
                case "Tablet":
                    anaTab();
                    break;
            }
        }

        private void anaOrd()
        {
            la_opcional1.Text = "Velocidad";
            la_opcional2.Text = "Puertos";
            bt_agregar.Text = "Agregar Ordenador";
        }

        private void anaMov()
        {
            la_opcional1.Text = "Duracion Bateria";
            la_opcional2.Text = "Almacenamiento";
            la_opcional3.Text = "S.O.";
            bt_agregar.Text = "Agregar Ordenador";

            la_opcional3.Visible = true;
            tb_opcional3.Visible = true;
        }

        private void anaTab()
        {
            la_opcional1.Text = "Duracion Bateria";
            la_opcional2.Text = "Resolucion";
            bt_agregar.Text = "Agregar Ordenador";
        }
    }
}
