namespace Ejercicios_Practicas
{
    partial class Datos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.tb_ram = new System.Windows.Forms.TextBox();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pt_opcional = new System.Windows.Forms.Panel();
            this.tb_opcional3 = new System.Windows.Forms.TextBox();
            this.tb_opcional2 = new System.Windows.Forms.TextBox();
            this.tb_opcional1 = new System.Windows.Forms.TextBox();
            this.pl_opcional = new System.Windows.Forms.Panel();
            this.la_opcional3 = new System.Windows.Forms.Label();
            this.la_opcional2 = new System.Windows.Forms.Label();
            this.la_opcional1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pt_opcional.SuspendLayout();
            this.pl_opcional.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(121, 119);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(121, 20);
            this.tb_precio.TabIndex = 5;
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Ordenador",
            "Movil",
            "Tablet"});
            this.cb_tipo.Location = new System.Drawing.Point(121, 15);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo.TabIndex = 4;
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_SelectedIndexChanged);
            // 
            // tb_ram
            // 
            this.tb_ram.Location = new System.Drawing.Point(121, 93);
            this.tb_ram.Name = "tb_ram";
            this.tb_ram.Size = new System.Drawing.Size(121, 20);
            this.tb_ram.TabIndex = 3;
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(121, 66);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(121, 20);
            this.tb_marca.TabIndex = 2;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(121, 41);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(121, 20);
            this.tb_nombre.TabIndex = 1;
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(32, 252);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 23);
            this.bt_agregar.TabIndex = 13;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Visible = false;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Memoria RAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Precio";
            // 
            // pt_opcional
            // 
            this.pt_opcional.Controls.Add(this.tb_opcional3);
            this.pt_opcional.Controls.Add(this.tb_opcional2);
            this.pt_opcional.Controls.Add(this.tb_opcional1);
            this.pt_opcional.Location = new System.Drawing.Point(121, 140);
            this.pt_opcional.Name = "pt_opcional";
            this.pt_opcional.Size = new System.Drawing.Size(121, 79);
            this.pt_opcional.TabIndex = 21;
            // 
            // tb_opcional3
            // 
            this.tb_opcional3.Location = new System.Drawing.Point(0, 59);
            this.tb_opcional3.Name = "tb_opcional3";
            this.tb_opcional3.Size = new System.Drawing.Size(121, 20);
            this.tb_opcional3.TabIndex = 2;
            this.tb_opcional3.Visible = false;
            // 
            // tb_opcional2
            // 
            this.tb_opcional2.Location = new System.Drawing.Point(0, 34);
            this.tb_opcional2.Name = "tb_opcional2";
            this.tb_opcional2.Size = new System.Drawing.Size(121, 20);
            this.tb_opcional2.TabIndex = 1;
            this.tb_opcional2.Visible = false;
            // 
            // tb_opcional1
            // 
            this.tb_opcional1.Location = new System.Drawing.Point(0, 6);
            this.tb_opcional1.Name = "tb_opcional1";
            this.tb_opcional1.Size = new System.Drawing.Size(121, 20);
            this.tb_opcional1.TabIndex = 0;
            this.tb_opcional1.Visible = false;
            // 
            // pl_opcional
            // 
            this.pl_opcional.Controls.Add(this.la_opcional3);
            this.pl_opcional.Controls.Add(this.la_opcional2);
            this.pl_opcional.Controls.Add(this.la_opcional1);
            this.pl_opcional.Location = new System.Drawing.Point(12, 140);
            this.pl_opcional.Name = "pl_opcional";
            this.pl_opcional.Size = new System.Drawing.Size(95, 79);
            this.pl_opcional.TabIndex = 22;
            // 
            // la_opcional3
            // 
            this.la_opcional3.AutoSize = true;
            this.la_opcional3.Location = new System.Drawing.Point(0, 62);
            this.la_opcional3.Name = "la_opcional3";
            this.la_opcional3.Size = new System.Drawing.Size(85, 13);
            this.la_opcional3.TabIndex = 30;
            this.la_opcional3.Text = "Almacenamiento";
            this.la_opcional3.Visible = false;
            // 
            // la_opcional2
            // 
            this.la_opcional2.AutoSize = true;
            this.la_opcional2.Location = new System.Drawing.Point(0, 37);
            this.la_opcional2.Name = "la_opcional2";
            this.la_opcional2.Size = new System.Drawing.Size(28, 13);
            this.la_opcional2.TabIndex = 29;
            this.la_opcional2.Text = "S.O,";
            this.la_opcional2.Visible = false;
            // 
            // la_opcional1
            // 
            this.la_opcional1.AutoSize = true;
            this.la_opcional1.Location = new System.Drawing.Point(0, 9);
            this.la_opcional1.Name = "la_opcional1";
            this.la_opcional1.Size = new System.Drawing.Size(86, 13);
            this.la_opcional1.TabIndex = 28;
            this.la_opcional1.Text = "Duracion Bateria";
            this.la_opcional1.Visible = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(133, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(271, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pl_opcional);
            this.Controls.Add(this.pt_opcional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.tb_ram);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.tb_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Datos";
            this.Text = "Datos";
            this.pt_opcional.ResumeLayout(false);
            this.pt_opcional.PerformLayout();
            this.pl_opcional.ResumeLayout(false);
            this.pl_opcional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.TextBox tb_ram;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pt_opcional;
        private System.Windows.Forms.Panel pl_opcional;
        private System.Windows.Forms.Label la_opcional3;
        private System.Windows.Forms.Label la_opcional2;
        private System.Windows.Forms.Label la_opcional1;
        private System.Windows.Forms.TextBox tb_opcional3;
        private System.Windows.Forms.TextBox tb_opcional2;
        private System.Windows.Forms.TextBox tb_opcional1;
        private System.Windows.Forms.Button button1;
    }
}