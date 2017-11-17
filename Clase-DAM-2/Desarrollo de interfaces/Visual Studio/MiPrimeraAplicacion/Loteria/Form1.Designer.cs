namespace Loteria
{
    partial class fLoteria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bValidar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dTPFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rBAutomática = new System.Windows.Forms.RadioButton();
            this.rBManual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cB16 = new System.Windows.Forms.CheckBox();
            this.cB15 = new System.Windows.Forms.CheckBox();
            this.cB14 = new System.Windows.Forms.CheckBox();
            this.cB13 = new System.Windows.Forms.CheckBox();
            this.cB12 = new System.Windows.Forms.CheckBox();
            this.cB11 = new System.Windows.Forms.CheckBox();
            this.cB10 = new System.Windows.Forms.CheckBox();
            this.cB09 = new System.Windows.Forms.CheckBox();
            this.cB08 = new System.Windows.Forms.CheckBox();
            this.cB07 = new System.Windows.Forms.CheckBox();
            this.cB06 = new System.Windows.Forms.CheckBox();
            this.cB05 = new System.Windows.Forms.CheckBox();
            this.cB04 = new System.Windows.Forms.CheckBox();
            this.cB03 = new System.Windows.Forms.CheckBox();
            this.cB02 = new System.Windows.Forms.CheckBox();
            this.cB01 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBApuesta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.bApostar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bValidar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dTPFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rBAutomática);
            this.groupBox1.Controls.Add(this.rBManual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBApuesta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "APUESTA DE LOTERIA";
            // 
            // bValidar
            // 
            this.bValidar.Enabled = false;
            this.bValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bValidar.Location = new System.Drawing.Point(12, 192);
            this.bValidar.Name = "bValidar";
            this.bValidar.Size = new System.Drawing.Size(151, 29);
            this.bValidar.TabIndex = 27;
            this.bValidar.Text = "Validar apuesta >>";
            this.bValidar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(309, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(43, 21);
            this.textBox1.TabIndex = 26;
            // 
            // dTPFecha
            // 
            this.dTPFecha.Enabled = false;
            this.dTPFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFecha.Location = new System.Drawing.Point(67, 148);
            this.dTPFecha.Name = "dTPFecha";
            this.dTPFecha.Size = new System.Drawing.Size(96, 21);
            this.dTPFecha.TabIndex = 25;
            this.dTPFecha.ValueChanged += new System.EventHandler(this.dTPFecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nº Reintegro [1 - 10]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sorteo:";
            // 
            // rBAutomática
            // 
            this.rBAutomática.AutoSize = true;
            this.rBAutomática.Enabled = false;
            this.rBAutomática.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBAutomática.Location = new System.Drawing.Point(71, 102);
            this.rBAutomática.Name = "rBAutomática";
            this.rBAutomática.Size = new System.Drawing.Size(86, 19);
            this.rBAutomática.TabIndex = 22;
            this.rBAutomática.TabStop = true;
            this.rBAutomática.Text = "Automática";
            this.rBAutomática.UseVisualStyleBackColor = true;
            // 
            // rBManual
            // 
            this.rBManual.AutoSize = true;
            this.rBManual.Checked = true;
            this.rBManual.Enabled = false;
            this.rBManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBManual.Location = new System.Drawing.Point(71, 80);
            this.rBManual.Name = "rBManual";
            this.rBManual.Size = new System.Drawing.Size(67, 19);
            this.rBManual.TabIndex = 21;
            this.rBManual.TabStop = true;
            this.rBManual.Text = "Manual";
            this.rBManual.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tipo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cB16);
            this.panel1.Controls.Add(this.cB15);
            this.panel1.Controls.Add(this.cB14);
            this.panel1.Controls.Add(this.cB13);
            this.panel1.Controls.Add(this.cB12);
            this.panel1.Controls.Add(this.cB11);
            this.panel1.Controls.Add(this.cB10);
            this.panel1.Controls.Add(this.cB09);
            this.panel1.Controls.Add(this.cB08);
            this.panel1.Controls.Add(this.cB07);
            this.panel1.Controls.Add(this.cB06);
            this.panel1.Controls.Add(this.cB05);
            this.panel1.Controls.Add(this.cB04);
            this.panel1.Controls.Add(this.cB03);
            this.panel1.Controls.Add(this.cB02);
            this.panel1.Controls.Add(this.cB01);
            this.panel1.Enabled = false;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(176, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 123);
            this.panel1.TabIndex = 19;
            // 
            // cB16
            // 
            this.cB16.AutoSize = true;
            this.cB16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB16.Location = new System.Drawing.Point(138, 90);
            this.cB16.Name = "cB16";
            this.cB16.Size = new System.Drawing.Size(38, 19);
            this.cB16.TabIndex = 15;
            this.cB16.Text = "16";
            this.cB16.UseVisualStyleBackColor = true;
            // 
            // cB15
            // 
            this.cB15.AutoSize = true;
            this.cB15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB15.Location = new System.Drawing.Point(138, 65);
            this.cB15.Name = "cB15";
            this.cB15.Size = new System.Drawing.Size(38, 19);
            this.cB15.TabIndex = 14;
            this.cB15.Text = "15";
            this.cB15.UseVisualStyleBackColor = true;
            // 
            // cB14
            // 
            this.cB14.AutoSize = true;
            this.cB14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB14.Location = new System.Drawing.Point(138, 40);
            this.cB14.Name = "cB14";
            this.cB14.Size = new System.Drawing.Size(38, 19);
            this.cB14.TabIndex = 13;
            this.cB14.Text = "14";
            this.cB14.UseVisualStyleBackColor = true;
            // 
            // cB13
            // 
            this.cB13.AutoSize = true;
            this.cB13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB13.Location = new System.Drawing.Point(138, 15);
            this.cB13.Name = "cB13";
            this.cB13.Size = new System.Drawing.Size(38, 19);
            this.cB13.TabIndex = 12;
            this.cB13.Text = "13";
            this.cB13.UseVisualStyleBackColor = true;
            // 
            // cB12
            // 
            this.cB12.AutoSize = true;
            this.cB12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB12.Location = new System.Drawing.Point(95, 90);
            this.cB12.Name = "cB12";
            this.cB12.Size = new System.Drawing.Size(38, 19);
            this.cB12.TabIndex = 11;
            this.cB12.Text = "12";
            this.cB12.UseVisualStyleBackColor = true;
            // 
            // cB11
            // 
            this.cB11.AutoSize = true;
            this.cB11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB11.Location = new System.Drawing.Point(95, 65);
            this.cB11.Name = "cB11";
            this.cB11.Size = new System.Drawing.Size(38, 19);
            this.cB11.TabIndex = 10;
            this.cB11.Text = "11";
            this.cB11.UseVisualStyleBackColor = true;
            // 
            // cB10
            // 
            this.cB10.AutoSize = true;
            this.cB10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB10.Location = new System.Drawing.Point(95, 40);
            this.cB10.Name = "cB10";
            this.cB10.Size = new System.Drawing.Size(38, 19);
            this.cB10.TabIndex = 9;
            this.cB10.Text = "10";
            this.cB10.UseVisualStyleBackColor = true;
            // 
            // cB09
            // 
            this.cB09.AutoSize = true;
            this.cB09.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB09.Location = new System.Drawing.Point(95, 15);
            this.cB09.Name = "cB09";
            this.cB09.Size = new System.Drawing.Size(32, 19);
            this.cB09.TabIndex = 8;
            this.cB09.Text = "9";
            this.cB09.UseVisualStyleBackColor = true;
            // 
            // cB08
            // 
            this.cB08.AutoSize = true;
            this.cB08.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB08.Location = new System.Drawing.Point(54, 90);
            this.cB08.Name = "cB08";
            this.cB08.Size = new System.Drawing.Size(32, 19);
            this.cB08.TabIndex = 7;
            this.cB08.Text = "8";
            this.cB08.UseVisualStyleBackColor = true;
            // 
            // cB07
            // 
            this.cB07.AutoSize = true;
            this.cB07.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB07.Location = new System.Drawing.Point(54, 65);
            this.cB07.Name = "cB07";
            this.cB07.Size = new System.Drawing.Size(32, 19);
            this.cB07.TabIndex = 6;
            this.cB07.Text = "7";
            this.cB07.UseVisualStyleBackColor = true;
            // 
            // cB06
            // 
            this.cB06.AutoSize = true;
            this.cB06.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB06.Location = new System.Drawing.Point(54, 40);
            this.cB06.Name = "cB06";
            this.cB06.Size = new System.Drawing.Size(32, 19);
            this.cB06.TabIndex = 5;
            this.cB06.Text = "6";
            this.cB06.UseVisualStyleBackColor = true;
            // 
            // cB05
            // 
            this.cB05.AutoSize = true;
            this.cB05.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB05.Location = new System.Drawing.Point(54, 15);
            this.cB05.Name = "cB05";
            this.cB05.Size = new System.Drawing.Size(32, 19);
            this.cB05.TabIndex = 4;
            this.cB05.Text = "5";
            this.cB05.UseVisualStyleBackColor = true;
            // 
            // cB04
            // 
            this.cB04.AutoSize = true;
            this.cB04.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB04.Location = new System.Drawing.Point(14, 90);
            this.cB04.Name = "cB04";
            this.cB04.Size = new System.Drawing.Size(32, 19);
            this.cB04.TabIndex = 3;
            this.cB04.Text = "4";
            this.cB04.UseVisualStyleBackColor = true;
            // 
            // cB03
            // 
            this.cB03.AutoSize = true;
            this.cB03.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB03.Location = new System.Drawing.Point(14, 65);
            this.cB03.Name = "cB03";
            this.cB03.Size = new System.Drawing.Size(32, 19);
            this.cB03.TabIndex = 2;
            this.cB03.Text = "3";
            this.cB03.UseVisualStyleBackColor = true;
            // 
            // cB02
            // 
            this.cB02.AutoSize = true;
            this.cB02.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB02.Location = new System.Drawing.Point(14, 40);
            this.cB02.Name = "cB02";
            this.cB02.Size = new System.Drawing.Size(32, 19);
            this.cB02.TabIndex = 1;
            this.cB02.Text = "2";
            this.cB02.UseVisualStyleBackColor = true;
            // 
            // cB01
            // 
            this.cB01.AutoSize = true;
            this.cB01.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB01.Location = new System.Drawing.Point(14, 15);
            this.cB01.Name = "cB01";
            this.cB01.Size = new System.Drawing.Size(32, 19);
            this.cB01.TabIndex = 0;
            this.cB01.Text = "1";
            this.cB01.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elija sus números de apuesta:";
            // 
            // cBApuesta
            // 
            this.cBApuesta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBApuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBApuesta.FormattingEnabled = true;
            this.cBApuesta.Items.AddRange(new object[] {
            "SIMPLE",
            "MÚLTIPLE",
            "EXTREMA"});
            this.cBApuesta.Location = new System.Drawing.Point(67, 29);
            this.cBApuesta.Name = "cBApuesta";
            this.cBApuesta.Size = new System.Drawing.Size(96, 23);
            this.cBApuesta.TabIndex = 1;
            this.cBApuesta.SelectedIndexChanged += new System.EventHandler(this.cBApuesta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apuesta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bSalir);
            this.groupBox2.Controls.Add(this.bApostar);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(404, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESGUARDO";
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(109, 194);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(62, 29);
            this.bSalir.TabIndex = 2;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            // 
            // bApostar
            // 
            this.bApostar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bApostar.Location = new System.Drawing.Point(14, 194);
            this.bApostar.Name = "bApostar";
            this.bApostar.Size = new System.Drawing.Size(89, 29);
            this.bApostar.TabIndex = 1;
            this.bApostar.Text = "Apostar";
            this.bApostar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(14, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 154);
            this.listBox1.TabIndex = 0;
            // 
            // fLoteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fLoteria";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fLoteria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBApuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cB16;
        private System.Windows.Forms.CheckBox cB15;
        private System.Windows.Forms.CheckBox cB14;
        private System.Windows.Forms.CheckBox cB13;
        private System.Windows.Forms.CheckBox cB12;
        private System.Windows.Forms.CheckBox cB11;
        private System.Windows.Forms.CheckBox cB10;
        private System.Windows.Forms.CheckBox cB09;
        private System.Windows.Forms.CheckBox cB08;
        private System.Windows.Forms.CheckBox cB07;
        private System.Windows.Forms.CheckBox cB06;
        private System.Windows.Forms.CheckBox cB05;
        private System.Windows.Forms.CheckBox cB04;
        private System.Windows.Forms.CheckBox cB03;
        private System.Windows.Forms.CheckBox cB02;
        private System.Windows.Forms.CheckBox cB01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rBAutomática;
        private System.Windows.Forms.RadioButton rBManual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dTPFecha;
        private System.Windows.Forms.Button bValidar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bApostar;
    }
}

