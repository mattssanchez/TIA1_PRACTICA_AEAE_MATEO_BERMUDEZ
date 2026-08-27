namespace TIA1
{
    partial class frmFacturas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblTotal;
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(285, 20);
            this.lblTitulo.Text = "ADMINISTRACIÓN FACTURAS";

            this.grpDatos.Location = new System.Drawing.Point(30, 60);
            this.grpDatos.Size = new System.Drawing.Size(790, 145);
            this.grpDatos.Text = "Datos de la factura";

            this.lblFactura.AutoSize = true; this.lblFactura.Location = new System.Drawing.Point(20, 35); this.lblFactura.Text = "No. Factura:";
            this.txtNoFactura.Location = new System.Drawing.Point(115, 32); this.txtNoFactura.Size = new System.Drawing.Size(145, 27);

            this.lblCliente.AutoSize = true; this.lblCliente.Location = new System.Drawing.Point(290, 35); this.lblCliente.Text = "Cliente:";
            this.cmbCliente.Location = new System.Drawing.Point(350, 32); this.cmbCliente.Size = new System.Drawing.Size(170, 28); this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblFecha.AutoSize = true; this.lblFecha.Location = new System.Drawing.Point(540, 35); this.lblFecha.Text = "Fecha:";
            this.dtpFechaRegistro.Location = new System.Drawing.Point(590, 32); this.dtpFechaRegistro.Size = new System.Drawing.Size(170, 27);

            this.lblEmpleado.AutoSize = true; this.lblEmpleado.Location = new System.Drawing.Point(20, 85); this.lblEmpleado.Text = "Empleado:";
            this.cmbEmpleado.Location = new System.Drawing.Point(115, 82); this.cmbEmpleado.Size = new System.Drawing.Size(170, 28); this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblEstado.AutoSize = true; this.lblEstado.Location = new System.Drawing.Point(310, 85); this.lblEstado.Text = "Estado:";
            this.cmbEstado.Location = new System.Drawing.Point(370, 82); this.cmbEstado.Size = new System.Drawing.Size(150, 28); this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.grpDatos.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblFactura, this.txtNoFactura, this.lblCliente, this.cmbCliente, this.lblEmpleado, this.cmbEmpleado, this.lblFecha, this.dtpFechaRegistro, this.lblEstado, this.cmbEstado });

            this.grpDetalle.Location = new System.Drawing.Point(30, 220);
            this.grpDetalle.Size = new System.Drawing.Size(790, 245);
            this.grpDetalle.Text = "DETALLE FACTURA";

            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(15, 25);
            this.dgvDetalle.Size = new System.Drawing.Size(760, 180);
            this.dgvDetalle.Columns.Add("colProducto", "Producto");
            this.dgvDetalle.Columns.Add("colCantidad", "Cantidad");
            this.dgvDetalle.Columns.Add("colPrecio", "Precio");
            this.dgvDetalle.Columns.Add("colTotal", "Total");

            this.grpDetalle.Controls.Add(this.dgvDetalle);

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(560, 480);
            this.lblTotal.Text = "Total factura: $0.00";

            this.btnActualizar.Location = new System.Drawing.Point(560, 515);
            this.btnActualizar.Size = new System.Drawing.Size(120, 35);
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;

            this.btnSalir.Location = new System.Drawing.Point(690, 515);
            this.btnSalir.Size = new System.Drawing.Size(80, 35);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(850, 570);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitulo, this.grpDatos, this.grpDetalle, this.lblTotal, this.btnActualizar, this.btnSalir });
            this.Name = "frmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.grpDatos.ResumeLayout(false); this.grpDatos.PerformLayout();
            this.grpDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}