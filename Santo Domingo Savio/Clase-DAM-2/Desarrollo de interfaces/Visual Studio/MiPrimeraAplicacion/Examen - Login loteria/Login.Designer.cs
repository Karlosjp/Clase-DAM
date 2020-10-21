namespace Examen___Login_loteria
{
    partial class Login
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
            this.gBLogin = new System.Windows.Forms.GroupBox();
            this.cBMostrar = new System.Windows.Forms.CheckBox();
            this.bLimpiarLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBMostrar = new System.Windows.Forms.TextBox();
            this.tBContrasenaLogin = new System.Windows.Forms.TextBox();
            this.tBUsuarioLogin = new System.Windows.Forms.TextBox();
            this.bJugar = new System.Windows.Forms.Button();
            this.gBRegistro = new System.Windows.Forms.GroupBox();
            this.bAcceso = new System.Windows.Forms.Button();
            this.bLimpiarRegistro = new System.Windows.Forms.Button();
            this.dTPNacimiento = new System.Windows.Forms.DateTimePicker();
            this.pBImagen = new System.Windows.Forms.PictureBox();
            this.tBContrasenaRegistro = new System.Windows.Forms.TextBox();
            this.tBUsuarioRegistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oFDImagen = new System.Windows.Forms.OpenFileDialog();
            this.gBLogin.SuspendLayout();
            this.gBRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gBLogin
            // 
            this.gBLogin.Controls.Add(this.cBMostrar);
            this.gBLogin.Controls.Add(this.bLimpiarLogin);
            this.gBLogin.Controls.Add(this.label6);
            this.gBLogin.Controls.Add(this.label5);
            this.gBLogin.Controls.Add(this.tBMostrar);
            this.gBLogin.Controls.Add(this.tBContrasenaLogin);
            this.gBLogin.Controls.Add(this.tBUsuarioLogin);
            this.gBLogin.Controls.Add(this.bJugar);
            this.gBLogin.Enabled = false;
            this.gBLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBLogin.Location = new System.Drawing.Point(477, 12);
            this.gBLogin.Name = "gBLogin";
            this.gBLogin.Size = new System.Drawing.Size(451, 429);
            this.gBLogin.TabIndex = 0;
            this.gBLogin.TabStop = false;
            this.gBLogin.Text = "LOGIN";
            // 
            // cBMostrar
            // 
            this.cBMostrar.AutoSize = true;
            this.cBMostrar.Location = new System.Drawing.Point(119, 90);
            this.cBMostrar.Name = "cBMostrar";
            this.cBMostrar.Size = new System.Drawing.Size(75, 20);
            this.cBMostrar.TabIndex = 7;
            this.cBMostrar.Text = "Mostrar:";
            this.cBMostrar.UseVisualStyleBackColor = true;
            this.cBMostrar.CheckedChanged += new System.EventHandler(this.cBMostrar_CheckedChanged);
            // 
            // bLimpiarLogin
            // 
            this.bLimpiarLogin.Location = new System.Drawing.Point(212, 372);
            this.bLimpiarLogin.Name = "bLimpiarLogin";
            this.bLimpiarLogin.Size = new System.Drawing.Size(75, 42);
            this.bLimpiarLogin.TabIndex = 6;
            this.bLimpiarLogin.Text = "Limpiar";
            this.bLimpiarLogin.UseVisualStyleBackColor = true;
            this.bLimpiarLogin.Click += new System.EventHandler(this.bLimpiarLogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Introduzca contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Introduzca email de usuario:";
            // 
            // tBMostrar
            // 
            this.tBMostrar.Location = new System.Drawing.Point(200, 88);
            this.tBMostrar.Name = "tBMostrar";
            this.tBMostrar.Size = new System.Drawing.Size(238, 22);
            this.tBMostrar.TabIndex = 3;
            // 
            // tBContrasenaLogin
            // 
            this.tBContrasenaLogin.Location = new System.Drawing.Point(200, 57);
            this.tBContrasenaLogin.Name = "tBContrasenaLogin";
            this.tBContrasenaLogin.Size = new System.Drawing.Size(238, 22);
            this.tBContrasenaLogin.TabIndex = 2;
            this.tBContrasenaLogin.TextChanged += new System.EventHandler(this.tBContrasenaLogin_TextChanged);
            // 
            // tBUsuarioLogin
            // 
            this.tBUsuarioLogin.Location = new System.Drawing.Point(200, 27);
            this.tBUsuarioLogin.Name = "tBUsuarioLogin";
            this.tBUsuarioLogin.Size = new System.Drawing.Size(238, 22);
            this.tBUsuarioLogin.TabIndex = 1;
            // 
            // bJugar
            // 
            this.bJugar.Location = new System.Drawing.Point(293, 372);
            this.bJugar.Name = "bJugar";
            this.bJugar.Size = new System.Drawing.Size(145, 42);
            this.bJugar.TabIndex = 0;
            this.bJugar.Text = "Jugar Loteria";
            this.bJugar.UseVisualStyleBackColor = true;
            this.bJugar.Click += new System.EventHandler(this.bJugar_Click);
            // 
            // gBRegistro
            // 
            this.gBRegistro.Controls.Add(this.bAcceso);
            this.gBRegistro.Controls.Add(this.bLimpiarRegistro);
            this.gBRegistro.Controls.Add(this.dTPNacimiento);
            this.gBRegistro.Controls.Add(this.pBImagen);
            this.gBRegistro.Controls.Add(this.tBContrasenaRegistro);
            this.gBRegistro.Controls.Add(this.tBUsuarioRegistro);
            this.gBRegistro.Controls.Add(this.label4);
            this.gBRegistro.Controls.Add(this.label3);
            this.gBRegistro.Controls.Add(this.label2);
            this.gBRegistro.Controls.Add(this.label1);
            this.gBRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBRegistro.Location = new System.Drawing.Point(12, 12);
            this.gBRegistro.Name = "gBRegistro";
            this.gBRegistro.Size = new System.Drawing.Size(448, 429);
            this.gBRegistro.TabIndex = 1;
            this.gBRegistro.TabStop = false;
            this.gBRegistro.Text = "REGISTRO";
            // 
            // bAcceso
            // 
            this.bAcceso.Location = new System.Drawing.Point(302, 376);
            this.bAcceso.Name = "bAcceso";
            this.bAcceso.Size = new System.Drawing.Size(126, 38);
            this.bAcceso.TabIndex = 20;
            this.bAcceso.Text = "Acceso Login >>";
            this.bAcceso.UseVisualStyleBackColor = true;
            this.bAcceso.Click += new System.EventHandler(this.bAcceso_Click);
            // 
            // bLimpiarRegistro
            // 
            this.bLimpiarRegistro.Location = new System.Drawing.Point(209, 376);
            this.bLimpiarRegistro.Name = "bLimpiarRegistro";
            this.bLimpiarRegistro.Size = new System.Drawing.Size(87, 38);
            this.bLimpiarRegistro.TabIndex = 19;
            this.bLimpiarRegistro.Text = "Limpiar";
            this.bLimpiarRegistro.UseVisualStyleBackColor = true;
            this.bLimpiarRegistro.Click += new System.EventHandler(this.bLimpiarRegistro_Click);
            // 
            // dTPNacimiento
            // 
            this.dTPNacimiento.CustomFormat = "dd-MMMM-yyyy dddd";
            this.dTPNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNacimiento.Location = new System.Drawing.Point(209, 92);
            this.dTPNacimiento.Name = "dTPNacimiento";
            this.dTPNacimiento.Size = new System.Drawing.Size(219, 22);
            this.dTPNacimiento.TabIndex = 18;
            // 
            // pBImagen
            // 
            this.pBImagen.BackColor = System.Drawing.SystemColors.Control;
            this.pBImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBImagen.Location = new System.Drawing.Point(209, 120);
            this.pBImagen.Name = "pBImagen";
            this.pBImagen.Size = new System.Drawing.Size(219, 250);
            this.pBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBImagen.TabIndex = 17;
            this.pBImagen.TabStop = false;
            this.pBImagen.Click += new System.EventHandler(this.pBImagen_Click);
            // 
            // tBContrasenaRegistro
            // 
            this.tBContrasenaRegistro.Location = new System.Drawing.Point(209, 59);
            this.tBContrasenaRegistro.Name = "tBContrasenaRegistro";
            this.tBContrasenaRegistro.PasswordChar = '*';
            this.tBContrasenaRegistro.Size = new System.Drawing.Size(219, 22);
            this.tBContrasenaRegistro.TabIndex = 16;
            // 
            // tBUsuarioRegistro
            // 
            this.tBUsuarioRegistro.Location = new System.Drawing.Point(209, 27);
            this.tBUsuarioRegistro.Name = "tBUsuarioRegistro";
            this.tBUsuarioRegistro.Size = new System.Drawing.Size(219, 22);
            this.tBUsuarioRegistro.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seleccione foto de perfil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Introduzca fecha nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Introduzca contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Introduzca email de usuario:";
            // 
            // oFDImagen
            // 
            this.oFDImagen.FileName = "openFileDialog1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 457);
            this.Controls.Add(this.gBRegistro);
            this.Controls.Add(this.gBLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Acceso a Loterias";
            this.gBLogin.ResumeLayout(false);
            this.gBLogin.PerformLayout();
            this.gBRegistro.ResumeLayout(false);
            this.gBRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBLogin;
        private System.Windows.Forms.Button bJugar;
        private System.Windows.Forms.CheckBox cBMostrar;
        private System.Windows.Forms.Button bLimpiarLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBMostrar;
        private System.Windows.Forms.TextBox tBContrasenaLogin;
        private System.Windows.Forms.TextBox tBUsuarioLogin;
        private System.Windows.Forms.GroupBox gBRegistro;
        private System.Windows.Forms.Button bAcceso;
        private System.Windows.Forms.Button bLimpiarRegistro;
        private System.Windows.Forms.DateTimePicker dTPNacimiento;
        private System.Windows.Forms.PictureBox pBImagen;
        private System.Windows.Forms.TextBox tBContrasenaRegistro;
        private System.Windows.Forms.TextBox tBUsuarioRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog oFDImagen;
    }
}

