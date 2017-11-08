namespace MiPrimeraAplicacion
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBOrigen = new System.Windows.Forms.ComboBox();
            this.cBDestino = new System.Windows.Forms.ComboBox();
            this.cBBilletes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rBIV = new System.Windows.Forms.RadioButton();
            this.rBSoId = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caracteristicas de si billete";
            // 
            // cBOrigen
            // 
            this.cBOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBOrigen.FormattingEnabled = true;
            this.cBOrigen.Location = new System.Drawing.Point(173, 77);
            this.cBOrigen.Name = "cBOrigen";
            this.cBOrigen.Size = new System.Drawing.Size(121, 28);
            this.cBOrigen.TabIndex = 1;
            // 
            // cBDestino
            // 
            this.cBDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDestino.FormattingEnabled = true;
            this.cBDestino.Location = new System.Drawing.Point(173, 109);
            this.cBDestino.Name = "cBDestino";
            this.cBDestino.Size = new System.Drawing.Size(121, 28);
            this.cBDestino.TabIndex = 2;
            // 
            // cBBilletes
            // 
            this.cBBilletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBBilletes.FormattingEnabled = true;
            this.cBBilletes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cBBilletes.Location = new System.Drawing.Point(173, 141);
            this.cBBilletes.Name = "cBBilletes";
            this.cBBilletes.Size = new System.Drawing.Size(41, 28);
            this.cBBilletes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Origen:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destino:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nº de billetes:";
            // 
            // rBIV
            // 
            this.rBIV.AutoSize = true;
            this.rBIV.Location = new System.Drawing.Point(6, 19);
            this.rBIV.Name = "rBIV";
            this.rBIV.Size = new System.Drawing.Size(61, 17);
            this.rBIV.TabIndex = 7;
            this.rBIV.TabStop = true;
            this.rBIV.Text = "Ida/Vta";
            this.rBIV.UseVisualStyleBackColor = true;
            // 
            // rBSoId
            // 
            this.rBSoId.AutoSize = true;
            this.rBSoId.Location = new System.Drawing.Point(274, 208);
            this.rBSoId.Name = "rBSoId";
            this.rBSoId.Size = new System.Drawing.Size(63, 17);
            this.rBSoId.TabIndex = 8;
            this.rBSoId.TabStop = true;
            this.rBSoId.Text = "Sólo ida";
            this.rBSoId.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBIV);
            this.groupBox1.Location = new System.Drawing.Point(107, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rBSoId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBBilletes);
            this.Controls.Add(this.cBDestino);
            this.Controls.Add(this.cBOrigen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBOrigen;
        private System.Windows.Forms.ComboBox cBDestino;
        private System.Windows.Forms.ComboBox cBBilletes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rBIV;
        private System.Windows.Forms.RadioButton rBSoId;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

