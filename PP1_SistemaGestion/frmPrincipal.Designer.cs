namespace PP1_SistemaGestion
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cierreDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dejarUnaNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDetallesDeUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDatosDeUnProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosAdelantosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeFacturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1448, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acerdaDeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.acerdaDeToolStripMenuItem.Text = "Acerca de...";
            this.acerdaDeToolStripMenuItem.Click += new System.EventHandler(this.acerdaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarVentaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cierreDeCajaToolStripMenuItem,
            this.dejarUnaNotaToolStripMenuItem});
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // cargarVentaToolStripMenuItem
            // 
            this.cargarVentaToolStripMenuItem.Name = "cargarVentaToolStripMenuItem";
            this.cargarVentaToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cargarVentaToolStripMenuItem.Text = "Cargar venta...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 6);
            // 
            // cierreDeCajaToolStripMenuItem
            // 
            this.cierreDeCajaToolStripMenuItem.Name = "cierreDeCajaToolStripMenuItem";
            this.cierreDeCajaToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cierreDeCajaToolStripMenuItem.Text = "Cierre de caja";
            // 
            // dejarUnaNotaToolStripMenuItem
            // 
            this.dejarUnaNotaToolStripMenuItem.Name = "dejarUnaNotaToolStripMenuItem";
            this.dejarUnaNotaToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.dejarUnaNotaToolStripMenuItem.Text = "Dejar una nota";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.consultarListaDeClientesToolStripMenuItem,
            this.consultarDetallesDeUnClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo cliente...";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // consultarListaDeClientesToolStripMenuItem
            // 
            this.consultarListaDeClientesToolStripMenuItem.Name = "consultarListaDeClientesToolStripMenuItem";
            this.consultarListaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.consultarListaDeClientesToolStripMenuItem.Text = "Consultar lista de clientes...";
            this.consultarListaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarListaDeClientesToolStripMenuItem_Click);
            // 
            // consultarDetallesDeUnClienteToolStripMenuItem
            // 
            this.consultarDetallesDeUnClienteToolStripMenuItem.Name = "consultarDetallesDeUnClienteToolStripMenuItem";
            this.consultarDetallesDeUnClienteToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.consultarDetallesDeUnClienteToolStripMenuItem.Text = "Consultar detalles de un cliente...";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProveedorToolStripMenuItem,
            this.listaDeProveedoresToolStripMenuItem,
            this.consultarDatosDeUnProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo proveedor...";
            // 
            // listaDeProveedoresToolStripMenuItem
            // 
            this.listaDeProveedoresToolStripMenuItem.Name = "listaDeProveedoresToolStripMenuItem";
            this.listaDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.listaDeProveedoresToolStripMenuItem.Text = "Lista de proveedores...";
            // 
            // consultarDatosDeUnProveedorToolStripMenuItem
            // 
            this.consultarDatosDeUnProveedorToolStripMenuItem.Name = "consultarDatosDeUnProveedorToolStripMenuItem";
            this.consultarDatosDeUnProveedorToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.consultarDatosDeUnProveedorToolStripMenuItem.Text = "Consultar datos de un proveedor...";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMEmpleadosToolStripMenuItem,
            this.pagosAdelantosToolStripMenuItem,
            this.datosDeFacturaciónToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // aBMEmpleadosToolStripMenuItem
            // 
            this.aBMEmpleadosToolStripMenuItem.Name = "aBMEmpleadosToolStripMenuItem";
            this.aBMEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.aBMEmpleadosToolStripMenuItem.Text = "ABM empleados...";
            // 
            // pagosAdelantosToolStripMenuItem
            // 
            this.pagosAdelantosToolStripMenuItem.Name = "pagosAdelantosToolStripMenuItem";
            this.pagosAdelantosToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.pagosAdelantosToolStripMenuItem.Text = "Pagos/Adelantos";
            // 
            // datosDeFacturaciónToolStripMenuItem
            // 
            this.datosDeFacturaciónToolStripMenuItem.Name = "datosDeFacturaciónToolStripMenuItem";
            this.datosDeFacturaciónToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.datosDeFacturaciónToolStripMenuItem.Text = "Datos de facturación";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 794);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FINCA BERON - Sistema de Gestión ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cierreDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dejarUnaNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarListaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDetallesDeUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDatosDeUnProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosAdelantosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeFacturaciónToolStripMenuItem;
    }
}

