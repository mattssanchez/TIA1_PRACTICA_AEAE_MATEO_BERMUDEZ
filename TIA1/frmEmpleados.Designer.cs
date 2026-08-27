namespace TIA1
{
    partial class frmEmpleados
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpEmpleado;
        private System.Windows.Forms.Label lblId, lblNombre, lblDocumento, lblDireccion, lblTelefono, lblEmail, lblRol, lblIngreso, lblRetiro;
        private System.Windows.Forms.TextBox txtIdEmpleado, txtNombreEmpleado, txtDocumento, txtDireccion, txtTelefono, txtEmail;
        private System.Windows.Forms.ComboBox cmbRolEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso, dtpFechaRetiro;
        private System.Windows.Forms.Button btnActualizar, btnSalir;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpEmpleado = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label(); this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label(); this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label(); this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label(); this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label(); this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label(); this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label(); this.cmbRolEmpleado = new System.Windows.Forms.ComboBox();
            this.lblIngreso = new System.Windows.Forms.Label(); this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblRetiro = new System.Windows.Forms.Label(); this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button(); this.btnSalir = new System.Windows.Forms.Button();
            this.grpEmpleado.SuspendLayout(); this.SuspendLayout();

            this.lblTitulo.AutoSize = true; this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(290, 18); this.lblTitulo.Text = "ADMINISTRACIÓN DE EMPLEADOS";

            this.grpEmpleado.Location = new System.Drawing.Point(35, 60); this.grpEmpleado.Size = new System.Drawing.Size(780, 400); this.grpEmpleado.Text = "Datos del empleado";

            this.lblId.AutoSize = true; this.lblId.Location = new System.Drawing.Point(25, 35); this.lblId.Text = "ID Empleado:"; this.txtIdEmpleado.Location = new System.Drawing.Point(145, 32); this.txtIdEmpleado.Size = new System.Drawing.Size(250, 27);
            this.lblNombre.AutoSize = true; this.lblNombre.Location = new System.Drawing.Point(25, 75); this.lblNombre.Text = "Nombre Empleado:"; this.txtNombreEmpleado.Location = new System.Drawing.Point(145, 72); this.txtNombreEmpleado.Size = new System.Drawing.Size(250, 27);
            this.lblDocumento.AutoSize = true; this.lblDocumento.Location = new System.Drawing.Point(25, 115); this.lblDocumento.Text = "Documento:"; this.txtDocumento.Location = new System.Drawing.Point(145, 112); this.txtDocumento.Size = new System.Drawing.Size(250, 27);
            this.lblDireccion.AutoSize = true; this.lblDireccion.Location = new System.Drawing.Point(25, 155); this.lblDireccion.Text = "Dirección:"; this.txtDireccion.Location = new System.Drawing.Point(145, 152); this.txtDireccion.Size = new System.Drawing.Size(250, 27);
            this.lblTelefono.AutoSize = true; this.lblTelefono.Location = new System.Drawing.Point(25, 195); this.lblTelefono.Text = "Teléfono:"; this.txtTelefono.Location = new System.Drawing.Point(145, 192); this.txtTelefono.Size = new System.Drawing.Size(250, 27);
            this.lblEmail.AutoSize = true; this.lblEmail.Location = new System.Drawing.Point(25, 235); this.lblEmail.Text = "Email:"; this.txtEmail.Location = new System.Drawing.Point(145, 232); this.txtEmail.Size = new System.Drawing.Size(250, 27);
            this.lblRol.AutoSize = true; this.lblRol.Location = new System.Drawing.Point(430, 35); this.lblRol.Text = "Rol Empleado:"; this.cmbRolEmpleado.Location = new System.Drawing.Point(530, 32); this.cmbRolEmpleado.Size = new System.Drawing.Size(220, 28); this.cmbRolEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblIngreso.AutoSize = true; this.lblIngreso.Location = new System.Drawing.Point(430, 80); this.lblIngreso.Text = "F. Ingreso:"; this.dtpFechaIngreso.Location = new System.Drawing.Point(530, 77); this.dtpFechaIngreso.Size = new System.Drawing.Size(220, 27); this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblRetiro.AutoSize = true; this.lblRetiro.Location = new System.Drawing.Point(430, 125); this.lblRetiro.Text = "F. Retiro:"; this.dtpFechaRetiro.Location = new System.Drawing.Point(530, 122); this.dtpFechaRetiro.Size = new System.Drawing.Size(220, 27); this.dtpFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.grpEmpleado.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblId, this.txtIdEmpleado, this.lblNombre, this.txtNombreEmpleado, this.lblDocumento, this.txtDocumento, this.lblDireccion, this.txtDireccion, this.lblTelefono, this.txtTelefono, this.lblEmail, this.txtEmail, this.lblRol, this.cmbRolEmpleado, this.lblIngreso, this.dtpFechaIngreso, this.lblRetiro, this.dtpFechaRetiro });

            this.btnActualizar.Location = new System.Drawing.Point(620, 480); this.btnActualizar.Size = new System.Drawing.Size(120, 35); this.btnActualizar.Text = "ACTUALIZAR"; this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnSalir.Location = new System.Drawing.Point(750, 480); this.btnSalir.Size = new System.Drawing.Size(80, 35); this.btnSalir.Text = "SALIR"; this.btnSalir.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(860, 540); this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitulo, this.grpEmpleado, this.btnActualizar, this.btnSalir });
            this.Name = "frmEmpleados"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.Text = "Empleados";
            this.grpEmpleado.ResumeLayout(false); this.grpEmpleado.PerformLayout(); this.ResumeLayout(false); this.PerformLayout();
        }
    }
}