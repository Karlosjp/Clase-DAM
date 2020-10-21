namespace Papeleria
{
    partial class Seleccion
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
            this.dgvSeleccionCliente = new System.Windows.Forms.DataGridView();
            this.sColumna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sColumna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.dtpFechaNueva = new System.Windows.Forms.DateTimePicker();
            this.lbImporte = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeleccionCliente
            // 
            this.dgvSeleccionCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sColumna1,
            this.sColumna2});
            this.dgvSeleccionCliente.Location = new System.Drawing.Point(13, 13);
            this.dgvSeleccionCliente.Name = "dgvSeleccionCliente";
            this.dgvSeleccionCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccionCliente.Size = new System.Drawing.Size(244, 236);
            this.dgvSeleccionCliente.TabIndex = 0;
            this.dgvSeleccionCliente.Visible = false;
            this.dgvSeleccionCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeleccionCliente_CellClick);
            // 
            // sColumna1
            // 
            this.sColumna1.HeaderText = "Columna1";
            this.sColumna1.Name = "sColumna1";
            this.sColumna1.ReadOnly = true;
            // 
            // sColumna2
            // 
            this.sColumna2.HeaderText = "Columna2";
            this.sColumna2.Name = "sColumna2";
            this.sColumna2.ReadOnly = true;
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(77, 72);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(100, 20);
            this.tbImporte.TabIndex = 1;
            this.tbImporte.Visible = false;
            // 
            // dtpFechaNueva
            // 
            this.dtpFechaNueva.Location = new System.Drawing.Point(77, 129);
            this.dtpFechaNueva.Name = "dtpFechaNueva";
            this.dtpFechaNueva.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNueva.TabIndex = 4;
            this.dtpFechaNueva.Visible = false;
            // 
            // lbImporte
            // 
            this.lbImporte.AutoSize = true;
            this.lbImporte.Location = new System.Drawing.Point(77, 47);
            this.lbImporte.Name = "lbImporte";
            this.lbImporte.Size = new System.Drawing.Size(73, 13);
            this.lbImporte.TabIndex = 5;
            this.lbImporte.Text = "Indica importe";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(77, 110);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(66, 13);
            this.lbFecha.TabIndex = 6;
            this.lbFecha.Text = "Indica fecha";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(92, 173);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "Guardar";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 263);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbImporte);
            this.Controls.Add(this.dtpFechaNueva);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.dgvSeleccionCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Seleccion";
            this.Text = "SeleccionClientes";
            this.Load += new System.EventHandler(this.SeleccionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeleccionCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sColumna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sColumna2;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.DateTimePicker dtpFechaNueva;
        private System.Windows.Forms.Label lbImporte;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button btSalir;
    }
}