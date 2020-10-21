namespace Examen_loteria
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
            this.gBRegistro = new System.Windows.Forms.GroupBox();
            this.LOGIN = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gBRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBRegistro
            // 
            this.gBRegistro.Controls.Add(this.textBox1);
            this.gBRegistro.Location = new System.Drawing.Point(12, 12);
            this.gBRegistro.Name = "gBRegistro";
            this.gBRegistro.Size = new System.Drawing.Size(503, 476);
            this.gBRegistro.TabIndex = 0;
            this.gBRegistro.TabStop = false;
            this.gBRegistro.Text = "REGISTRO";
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(521, 12);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(396, 476);
            this.LOGIN.TabIndex = 1;
            this.LOGIN.TabStop = false;
            this.LOGIN.Text = "LOGIN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 500);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.gBRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBRegistro.ResumeLayout(false);
            this.gBRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBRegistro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox LOGIN;
    }
}

