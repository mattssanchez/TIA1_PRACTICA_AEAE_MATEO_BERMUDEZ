namespace TIA1
{
    partial class frmProductos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoReferencia;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.TextBox txtDetallesProducto;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label(); this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label(); this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label(); this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label(); this.txtCodigoReferencia = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label(); this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.lblCompra = new System.Windows.Forms.Label(); this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblVenta = new System.Windows.Forms.Label(); this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label(); this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label(); this.txtDetallesProducto = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button(); this.btnSalir = new System.Windows.Forms.Button();
            this.grpProducto.SuspendLayout();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(300, 18);
            this.lblTitulo.Text = "ADMINISTRACIÓN DE PRODUCTOS";

            this.grpProducto.Location = new System.Drawing.Point(35, 60);
            this.grpProducto.Size = new System.Drawing.Size(880, 410);
            this.grpProducto.Text = "Datos del producto";

            this.lblId.AutoSize = true; this.lblId.Location = new System.Drawing.Point(25, 35); this.lblId.Text = "ID Producto:";
            this.txtIdProducto.Location = new System.Drawing.Point(145, 32); this.txtIdProducto.Size = new System.Drawing.Size(260, 27);

            this.lblNombre.AutoSize = true; this.lblNombre.Location = new System.Drawing.Point(25, 80); this.lblNombre.Text = "Nombre Producto:";
            this.txtNombreProducto.Location = new System.Drawing.Point(145, 77); this.txtNombreProducto.Size = new System.Drawing.Size(260, 27);

            this.lblCategoria.AutoSize = true; this.lblCategoria.Location = new System.Drawing.Point(25, 125); this.lblCategoria.Text = "Categoría:";
            this.cmbCategoria.Location = new System.Drawing.Point(145, 122); this.cmbCategoria.Size = new System.Drawing.Size(260, 28); this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblCodigo.AutoSize = true; this.lblCodigo.Location = new System.Drawing.Point(25, 170); this.lblCodigo.Text = "Código Referencia:";
            this.txtCodigoReferencia.Location = new System.Drawing.Point(145, 167); this.txtCodigoReferencia.Size = new System.Drawing.Size(260, 27);

            this.lblRuta.AutoSize = true; this.lblRuta.Location = new System.Drawing.Point(470, 35); this.lblRuta.Text = "Ruta Imagen:";
            this.txtRutaImagen.Location = new System.Drawing.Point(580, 32); this.txtRutaImagen.Size = new System.Drawing.Size(260, 27);

            this.lblCompra.AutoSize = true; this.lblCompra.Location = new System.Drawing.Point(470, 80); this.lblCompra.Text = "Precio Compra:";
            this.txtPrecioCompra.Location = new System.Drawing.Point(580, 77); this.txtPrecioCompra.Size = new System.Drawing.Size(260, 27);

            this.lblVenta.AutoSize = true; this.lblVenta.Location = new System.Drawing.Point(470, 125); this.lblVenta.Text = "Precio Venta:";
            this.txtPrecioVenta.Location = new System.Drawing.Point(580, 122); this.txtPrecioVenta.Size = new System.Drawing.Size(260, 27);

            this.lblStock.AutoSize = true; this.lblStock.Location = new System.Drawing.Point(470, 170); this.lblStock.Text = "Cantidad stock:";
            this.txtCantidadStock.Location = new System.Drawing.Point(580, 167); this.txtCantidadStock.Size = new System.Drawing.Size(260, 27);

            this.lblDetalles.AutoSize = true; this.lblDetalles.Location = new System.Drawing.Point(25, 225); this.lblDetalles.Text = "Detalles producto:";
            this.txtDetallesProducto.Location = new System.Drawing.Point(145, 222); this.txtDetallesProducto.Multiline = true; this.txtDetallesProducto.Size = new System.Drawing.Size(695, 110);

            this.grpProducto.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblId, this.txtIdProducto, this.lblNombre, this.txtNombreProducto, this.lblCategoria, this.cmbCategoria, this.lblCodigo, this.txtCodigoReferencia, this.lblRuta, this.txtRutaImagen, this.lblCompra, this.txtPrecioCompra, this.lblVenta, this.txtPrecioVenta, this.lblStock, this.txtCantidadStock, this.lblDetalles, this.txtDetallesProducto });

            this.btnActualizar.Location = new System.Drawing.Point(690, 490);
            this.btnActualizar.Size = new System.Drawing.Size(120, 35);
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;

            this.btnSalir.Location = new System.Drawing.Point(820, 490);
            this.btnSalir.Size = new System.Drawing.Size(80, 35);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitulo, this.grpProducto, this.btnActualizar, this.btnSalir });
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.grpProducto.ResumeLayout(false); this.grpProducto.PerformLayout();
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}