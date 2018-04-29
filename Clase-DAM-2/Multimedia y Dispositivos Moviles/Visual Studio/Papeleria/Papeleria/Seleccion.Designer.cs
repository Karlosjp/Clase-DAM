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
            // Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 261);
            this.Controls.Add(this.dgvSeleccionCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Seleccion";
            this.Text = "SeleccionClientes";
            this.Load += new System.EventHandler(this.SeleccionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeleccionCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sColumna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sColumna2;
    }
}