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
            this.components = new System.ComponentModel.Container();
            this.dgv_resumen = new System.Windows.Forms.DataGridView();
            this.bt_eliminar = new System.Windows.Forms.Button();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_extras = new System.Windows.Forms.DataGridView();
            this.id_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionBateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_produc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_extras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_resumen
            // 
            this.dgv_resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produc,
            this.tipo,
            this.nombre,
            this.marca,
            this.precio,
            this.ram});
            this.dgv_resumen.Location = new System.Drawing.Point(12, 65);
            this.dgv_resumen.Name = "dgv_resumen";
            this.dgv_resumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resumen.Size = new System.Drawing.Size(594, 270);
            this.dgv_resumen.TabIndex = 0;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(626, 65);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(108, 23);
            this.bt_eliminar.TabIndex = 1;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.Bt_eliminar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
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
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.VentaToolStripMenuItem_Click);
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
            this.todoToolStripMenuItem.Click += new System.EventHandler(this.TodoToolStripMenuItem_Click);
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
            this.ordenadoresToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ordenadoresToolStripMenuItem.Text = "Ordenadores";
            this.ordenadoresToolStripMenuItem.Click += new System.EventHandler(this.OrdenadoresToolStripMenuItem_Click);
            // 
            // movilesToolStripMenuItem
            // 
            this.movilesToolStripMenuItem.Name = "movilesToolStripMenuItem";
            this.movilesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.movilesToolStripMenuItem.Text = "Moviles";
            this.movilesToolStripMenuItem.Click += new System.EventHandler(this.MovilesToolStripMenuItem_Click);
            // 
            // tabletsToolStripMenuItem
            // 
            this.tabletsToolStripMenuItem.Name = "tabletsToolStripMenuItem";
            this.tabletsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.tabletsToolStripMenuItem.Text = "Tablets";
            this.tabletsToolStripMenuItem.Click += new System.EventHandler(this.TabletsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Productos de la tienda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datos Extras.";
            // 
            // dgv_extras
            // 
            this.dgv_extras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_extras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_extra,
            this.so,
            this.almacenamiento,
            this.duracionBateria,
            this.resolucion,
            this.velocidad,
            this.puertos});
            this.dgv_extras.Location = new System.Drawing.Point(12, 341);
            this.dgv_extras.Name = "dgv_extras";
            this.dgv_extras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_extras.Size = new System.Drawing.Size(594, 102);
            this.dgv_extras.TabIndex = 6;
            // 
            // id_extra
            // 
            this.id_extra.HeaderText = "ID";
            this.id_extra.Name = "id_extra";
            this.id_extra.Visible = false;
            // 
            // so
            // 
            this.so.HeaderText = "S.O.";
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
            this.duracionBateria.Width = 55;
            // 
            // resolucion
            // 
            this.resolucion.HeaderText = "Resolución";
            this.resolucion.Name = "resolucion";
            this.resolucion.ReadOnly = true;
            this.resolucion.Visible = false;
            this.resolucion.Width = 70;
            // 
            // velocidad
            // 
            this.velocidad.HeaderText = "Velocidad";
            this.velocidad.Name = "velocidad";
            this.velocidad.ReadOnly = true;
            this.velocidad.Visible = false;
            this.velocidad.Width = 60;
            // 
            // puertos
            // 
            this.puertos.HeaderText = "Puertos";
            this.puertos.Name = "puertos";
            this.puertos.ReadOnly = true;
            this.puertos.Visible = false;
            this.puertos.Width = 50;
            // 
            // id_produc
            // 
            this.id_produc.HeaderText = "ID";
            this.id_produc.Name = "id_produc";
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
            // ram
            // 
            this.ram.HeaderText = "Memoria RAM";
            this.ram.Name = "ram";
            this.ram.ReadOnly = true;
            // 
            // Resumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 466);
            this.Controls.Add(this.dgv_extras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.dgv_resumen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resumen";
            this.Text = "Resumen";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_extras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_resumen;
        private System.Windows.Forms.Button bt_eliminar;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn so;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionBateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ram;
    }
}

