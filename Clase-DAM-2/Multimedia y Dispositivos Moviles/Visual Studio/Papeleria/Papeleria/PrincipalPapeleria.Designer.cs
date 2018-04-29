namespace Papeleria
{
    partial class PrincipalPapeleria
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
            Datos.GuardarVentas();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porTipoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porMesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaDeCompraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaImporteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.pColumna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pColumna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pColumna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pColumna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pColumna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pColumna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pColumna7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papeleriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSecunadario = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprografiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papeleriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecunadario)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(470, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarToolStripMenuItem1,
            this.mostrarToolStripMenuItem});
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.comprarToolStripMenuItem.Text = "Productos";
            // 
            // comprarToolStripMenuItem1
            // 
            this.comprarToolStripMenuItem1.Name = "comprarToolStripMenuItem1";
            this.comprarToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.comprarToolStripMenuItem1.Text = "Comprar";
            this.comprarToolStripMenuItem1.Click += new System.EventHandler(this.comprarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.clienteToolStripMenuItem1,
            this.modificarToolStripMenuItem1});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eliminarToolStripMenuItem.Text = "Ventas";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem1,
            this.clienteToolStripMenuItem2});
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.compraToolStripMenuItem.Text = "Eliminar";
            // 
            // compraToolStripMenuItem1
            // 
            this.compraToolStripMenuItem1.Name = "compraToolStripMenuItem1";
            this.compraToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.compraToolStripMenuItem1.Text = "Compra";
            this.compraToolStripMenuItem1.Click += new System.EventHandler(this.compraToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem2.Text = "Cliente";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem1,
            this.porTipoToolStripMenuItem1,
            this.porMesToolStripMenuItem1,
            this.clienteToolStripMenuItem3,
            this.productoToolStripMenuItem});
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.clienteToolStripMenuItem1.Text = "Mostrar resumen";
            // 
            // totalToolStripMenuItem1
            // 
            this.totalToolStripMenuItem1.Name = "totalToolStripMenuItem1";
            this.totalToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.totalToolStripMenuItem1.Text = "Total";
            this.totalToolStripMenuItem1.Click += new System.EventHandler(this.totalToolStripMenuItem1_Click);
            // 
            // porTipoToolStripMenuItem1
            // 
            this.porTipoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consumibleToolStripMenuItem,
            this.reprografiaToolStripMenuItem,
            this.accesorioToolStripMenuItem});
            this.porTipoToolStripMenuItem1.Name = "porTipoToolStripMenuItem1";
            this.porTipoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.porTipoToolStripMenuItem1.Text = "Por tipo";
            // 
            // porMesToolStripMenuItem1
            // 
            this.porMesToolStripMenuItem1.Name = "porMesToolStripMenuItem1";
            this.porMesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.porMesToolStripMenuItem1.Text = "Por mes";
            this.porMesToolStripMenuItem1.Click += new System.EventHandler(this.porMesToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem3
            // 
            this.clienteToolStripMenuItem3.Name = "clienteToolStripMenuItem3";
            this.clienteToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem3.Text = "Por cliente";
            this.clienteToolStripMenuItem3.Click += new System.EventHandler(this.clienteToolStripMenuItem3_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productoToolStripMenuItem.Text = "Por producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaDeCompraToolStripMenuItem1,
            this.importeToolStripMenuItem1,
            this.fechaImporteToolStripMenuItem1});
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // fechaDeCompraToolStripMenuItem1
            // 
            this.fechaDeCompraToolStripMenuItem1.Name = "fechaDeCompraToolStripMenuItem1";
            this.fechaDeCompraToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.fechaDeCompraToolStripMenuItem1.Text = "Fecha de Compra";
            // 
            // importeToolStripMenuItem1
            // 
            this.importeToolStripMenuItem1.Name = "importeToolStripMenuItem1";
            this.importeToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.importeToolStripMenuItem1.Text = "Importe";
            // 
            // fechaImporteToolStripMenuItem1
            // 
            this.fechaImporteToolStripMenuItem1.Name = "fechaImporteToolStripMenuItem1";
            this.fechaImporteToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.fechaImporteToolStripMenuItem1.Text = "Fecha/Importe";
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pColumna1,
            this.pColumna2,
            this.pColumna3,
            this.pColumna4,
            this.pColumna5,
            this.pColumna6,
            this.pColumna7});
            this.dgvPrincipal.Location = new System.Drawing.Point(12, 63);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(444, 187);
            this.dgvPrincipal.TabIndex = 1;
            this.dgvPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrincipal_CellClick);
            // 
            // pColumna1
            // 
            this.pColumna1.HeaderText = "Columna1";
            this.pColumna1.Name = "pColumna1";
            this.pColumna1.ReadOnly = true;
            // 
            // pColumna2
            // 
            this.pColumna2.HeaderText = "Columna2";
            this.pColumna2.Name = "pColumna2";
            this.pColumna2.ReadOnly = true;
            // 
            // pColumna3
            // 
            this.pColumna3.HeaderText = "Columna3";
            this.pColumna3.Name = "pColumna3";
            this.pColumna3.ReadOnly = true;
            // 
            // pColumna4
            // 
            this.pColumna4.HeaderText = "Columna4";
            this.pColumna4.Name = "pColumna4";
            this.pColumna4.ReadOnly = true;
            // 
            // pColumna5
            // 
            this.pColumna5.HeaderText = "Columna5";
            this.pColumna5.Name = "pColumna5";
            this.pColumna5.ReadOnly = true;
            this.pColumna5.Visible = false;
            // 
            // pColumna6
            // 
            this.pColumna6.HeaderText = "Columna6";
            this.pColumna6.Name = "pColumna6";
            this.pColumna6.ReadOnly = true;
            this.pColumna6.Visible = false;
            // 
            // pColumna7
            // 
            this.pColumna7.HeaderText = "Columna7";
            this.pColumna7.Name = "pColumna7";
            this.pColumna7.ReadOnly = true;
            this.pColumna7.Visible = false;
            // 
            // dgvSecunadario
            // 
            this.dgvSecunadario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecunadario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2,
            this.columna3});
            this.dgvSecunadario.Location = new System.Drawing.Point(12, 256);
            this.dgvSecunadario.Name = "dgvSecunadario";
            this.dgvSecunadario.Size = new System.Drawing.Size(444, 99);
            this.dgvSecunadario.TabIndex = 2;
            // 
            // columna1
            // 
            this.columna1.HeaderText = "Columna1";
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            this.columna1.Visible = false;
            // 
            // columna2
            // 
            this.columna2.HeaderText = "Columna2";
            this.columna2.Name = "columna2";
            this.columna2.ReadOnly = true;
            this.columna2.Visible = false;
            // 
            // columna3
            // 
            this.columna3.HeaderText = "Columna3";
            this.columna3.Name = "columna3";
            this.columna3.ReadOnly = true;
            this.columna3.Visible = false;
            // 
            // consumibleToolStripMenuItem
            // 
            this.consumibleToolStripMenuItem.Name = "consumibleToolStripMenuItem";
            this.consumibleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consumibleToolStripMenuItem.Text = "Consumible";
            this.consumibleToolStripMenuItem.Click += new System.EventHandler(this.consumibleToolStripMenuItem_Click);
            // 
            // reprografiaToolStripMenuItem
            // 
            this.reprografiaToolStripMenuItem.Name = "reprografiaToolStripMenuItem";
            this.reprografiaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reprografiaToolStripMenuItem.Text = "Reprografia";
            this.reprografiaToolStripMenuItem.Click += new System.EventHandler(this.reprografiaToolStripMenuItem_Click);
            // 
            // accesorioToolStripMenuItem
            // 
            this.accesorioToolStripMenuItem.Name = "accesorioToolStripMenuItem";
            this.accesorioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accesorioToolStripMenuItem.Text = "Accesorio";
            this.accesorioToolStripMenuItem.Click += new System.EventHandler(this.accesorioToolStripMenuItem_Click);
            // 
            // PrincipalPapeleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 370);
            this.Controls.Add(this.dgvSecunadario);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.msMenu;
            this.Name = "PrincipalPapeleria";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.PrincipalPapeleria_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papeleriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecunadario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.BindingSource papeleriaBindingSource;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSecunadario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porTipoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porMesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fechaDeCompraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fechaImporteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn pColumna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pColumna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pColumna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pColumna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pColumna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn pColumna6;
        private System.Windows.Forms.DataGridViewTextBoxColumn pColumna7;
        private System.Windows.Forms.ToolStripMenuItem consumibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprografiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesorioToolStripMenuItem;
    }
}

