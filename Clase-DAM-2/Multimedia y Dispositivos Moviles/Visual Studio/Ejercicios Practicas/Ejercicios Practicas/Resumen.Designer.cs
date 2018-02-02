namespace Ejercicios_Practicas
{
    partial class Resumen
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
            this.dgv_resumen = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarTodasLasRamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarRamDeUnTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionBateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_resumen
            // 
            this.dgv_resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.nombre,
            this.marca,
            this.precio,
            this.so,
            this.almacenamiento,
            this.duracionBateria,
            this.resolicion,
            this.velocidad,
            this.puertos});
            this.dgv_resumen.Location = new System.Drawing.Point(12, 96);
            this.dgv_resumen.Name = "dgv_resumen";
            this.dgv_resumen.Size = new System.Drawing.Size(593, 270);
            this.dgv_resumen.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarTodasLasRamToolStripMenuItem,
            this.cambiarRamDeUnTipoToolStripMenuItem,
            this.cambiarPrecioToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // cambiarTodasLasRamToolStripMenuItem
            // 
            this.cambiarTodasLasRamToolStripMenuItem.Name = "cambiarTodasLasRamToolStripMenuItem";
            this.cambiarTodasLasRamToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cambiarTodasLasRamToolStripMenuItem.Text = "Cambiar todas las ram";
            // 
            // cambiarRamDeUnTipoToolStripMenuItem
            // 
            this.cambiarRamDeUnTipoToolStripMenuItem.Name = "cambiarRamDeUnTipoToolStripMenuItem";
            this.cambiarRamDeUnTipoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cambiarRamDeUnTipoToolStripMenuItem.Text = "Cambiar ram de un tipo";
            // 
            // cambiarPrecioToolStripMenuItem
            // 
            this.cambiarPrecioToolStripMenuItem.Name = "cambiarPrecioToolStripMenuItem";
            this.cambiarPrecioToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cambiarPrecioToolStripMenuItem.Text = "Cambiar precio";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todoToolStripMenuItem,
            this.ventasPorTipoToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // todoToolStripMenuItem
            // 
            this.todoToolStripMenuItem.Name = "todoToolStripMenuItem";
            this.todoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.todoToolStripMenuItem.Text = "Todas las ventas";
            this.todoToolStripMenuItem.Click += new System.EventHandler(this.todoToolStripMenuItem_Click);
            // 
            // ventasPorTipoToolStripMenuItem
            // 
            this.ventasPorTipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenadoresToolStripMenuItem,
            this.movilesToolStripMenuItem,
            this.tabletsToolStripMenuItem});
            this.ventasPorTipoToolStripMenuItem.Name = "ventasPorTipoToolStripMenuItem";
            this.ventasPorTipoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ventasPorTipoToolStripMenuItem.Text = "Ventas por tipo";
            // 
            // ordenadoresToolStripMenuItem
            // 
            this.ordenadoresToolStripMenuItem.Name = "ordenadoresToolStripMenuItem";
            this.ordenadoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ordenadoresToolStripMenuItem.Text = "Ordenadores";
            this.ordenadoresToolStripMenuItem.Click += new System.EventHandler(this.ordenadoresToolStripMenuItem_Click);
            // 
            // movilesToolStripMenuItem
            // 
            this.movilesToolStripMenuItem.Name = "movilesToolStripMenuItem";
            this.movilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.movilesToolStripMenuItem.Text = "Moviles";
            this.movilesToolStripMenuItem.Click += new System.EventHandler(this.movilesToolStripMenuItem_Click);
            // 
            // tabletsToolStripMenuItem
            // 
            this.tabletsToolStripMenuItem.Name = "tabletsToolStripMenuItem";
            this.tabletsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tabletsToolStripMenuItem.Text = "Tablets";
            this.tabletsToolStripMenuItem.Click += new System.EventHandler(this.tabletsToolStripMenuItem_Click);
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.FillWeight = 50F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 50;
            // 
            // so
            // 
            this.so.HeaderText = "SO";
            this.so.Name = "so";
            this.so.ReadOnly = true;
            this.so.Visible = false;
            // 
            // almacenamiento
            // 
            this.almacenamiento.HeaderText = "Almacenamiento";
            this.almacenamiento.Name = "almacenamiento";
            this.almacenamiento.ReadOnly = true;
            this.almacenamiento.Visible = false;
            // 
            // duracionBateria
            // 
            this.duracionBateria.HeaderText = "Duracion Bateria";
            this.duracionBateria.Name = "duracionBateria";
            this.duracionBateria.ReadOnly = true;
            this.duracionBateria.Visible = false;
            // 
            // resolicion
            // 
            this.resolicion.HeaderText = "Resolución";
            this.resolicion.Name = "resolicion";
            this.resolicion.Visible = false;
            // 
            // velocidad
            // 
            this.velocidad.HeaderText = "Velocidad";
            this.velocidad.Name = "velocidad";
            this.velocidad.ReadOnly = true;
            this.velocidad.Visible = false;
            // 
            // puertos
            // 
            this.puertos.HeaderText = "Puertos";
            this.puertos.Name = "puertos";
            this.puertos.ReadOnly = true;
            this.puertos.Visible = false;
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_resumen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Resumen";
            this.Text = "Resumen";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_resumen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarTodasLasRamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarRamDeUnTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabletsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn so;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionBateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertos;
    }
}

