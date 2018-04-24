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
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaImporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.resumenToolStripMenuItem,
            this.actualizarProductosToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(719, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.comprarToolStripMenuItem.Text = "Comprar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.clienteToolStripMenuItem1});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.compraToolStripMenuItem.Text = "Compra";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaDeCompraToolStripMenuItem,
            this.importeToolStripMenuItem,
            this.fechaImporteToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // fechaDeCompraToolStripMenuItem
            // 
            this.fechaDeCompraToolStripMenuItem.Name = "fechaDeCompraToolStripMenuItem";
            this.fechaDeCompraToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fechaDeCompraToolStripMenuItem.Text = "Fecha de compra";
            // 
            // importeToolStripMenuItem
            // 
            this.importeToolStripMenuItem.Name = "importeToolStripMenuItem";
            this.importeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.importeToolStripMenuItem.Text = "Importe";
            // 
            // fechaImporteToolStripMenuItem
            // 
            this.fechaImporteToolStripMenuItem.Name = "fechaImporteToolStripMenuItem";
            this.fechaImporteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fechaImporteToolStripMenuItem.Text = "Fecha/Importe";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porMesToolStripMenuItem,
            this.porTipoToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.listarToolStripMenuItem.Text = "Listar compras";
            // 
            // porMesToolStripMenuItem
            // 
            this.porMesToolStripMenuItem.Name = "porMesToolStripMenuItem";
            this.porMesToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.porMesToolStripMenuItem.Text = "Mes";
            // 
            // porTipoToolStripMenuItem
            // 
            this.porTipoToolStripMenuItem.Name = "porTipoToolStripMenuItem";
            this.porTipoToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.porTipoToolStripMenuItem.Text = "Tipo";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // resumenToolStripMenuItem
            // 
            this.resumenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porProductoToolStripMenuItem,
            this.totalToolStripMenuItem});
            this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            this.resumenToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.resumenToolStripMenuItem.Text = "Resumen";
            // 
            // porProductoToolStripMenuItem
            // 
            this.porProductoToolStripMenuItem.Name = "porProductoToolStripMenuItem";
            this.porProductoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.porProductoToolStripMenuItem.Text = "Producto";
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.totalToolStripMenuItem.Text = "Total";
            // 
            // actualizarProductosToolStripMenuItem
            // 
            this.actualizarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.actualizarProductosToolStripMenuItem.Name = "actualizarProductosToolStripMenuItem";
            this.actualizarProductosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.actualizarProductosToolStripMenuItem.Text = "Productos";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // PrincipalPapeleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 542);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "PrincipalPapeleria";
            this.Text = "Principal";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaImporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
    }
}

