namespace TIA1
{
    partial class frmRoles
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpRol;
        private System.Windows.Forms.Label lblId, lblNombreRol, lblDescripcion;
        private System.Windows.Forms.TextBox txtIdRol, txtNombreRol, txtDescripcionRol;
        private System.Windows.Forms.Button btnActualizar, btnSalir;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label(); this.grpRol = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label(); this.txtIdRol = new System.Windows.Forms.TextBox();
            this.lblNombreRol = new System.Windows.Forms.Label(); this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label(); this.txtDescripcionRol = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button(); this.btnSalir = new System.Windows.Forms.Button();
            this.grpRol.SuspendLayout(); this.SuspendLayout();

            this.lblTitulo.AutoSize = true; this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(235, 18); this.lblTitulo.Text = "ROL DE EMPLEADOS";

            this.grpRol.Location = new System.Drawing.Point(60, 65); this.grpRol.Size = new System.Drawing.Size(650, 300); this.grpRol.Text = "Información del rol";

            this.lblId.AutoSize = true; this.lblId.Location = new System.Drawing.Point(30, 40); this.lblId.Text = "ID Rol:";
            this.txtIdRol.Location = new System.Drawing.Point(180, 37); this.txtIdRol.Size = new System.Drawing.Size(380, 27);

            this.lblNombreRol.AutoSize = true; this.lblNombreRol.Location = new System.Drawing.Point(30, 85); this.lblNombreRol.Text = "Nombre Rol:";
            this.txtNombreRol.Location = new System.Drawing.Point(180, 82); this.txtNombreRol.Size = new System.Drawing.Size(380, 27);

            this.lblDescripcion.AutoSize = true; this.lblDescripcion.Location = new System.Drawing.Point(30, 130); this.lblDescripcion.Text = "Descripción detallada del Rol:";
            this.txtDescripcionRol.Location = new System.Drawing.Point(180, 127); this.txtDescripcionRol.Multiline = true; this.txtDescripcionRol.Size = new System.Drawing.Size(380, 100);

            this.grpRol.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblId, this.txtIdRol, this.lblNombreRol, this.txtNombreRol, this.lblDescripcion, this.txtDescripcionRol });

            this.btnActualizar.Location = new System.Drawing.Point(500, 390); this.btnActualizar.Size = new System.Drawing.Size(120, 35); this.btnActualizar.Text = "ACTUALIZAR"; this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnSalir.Location = new System.Drawing.Point(630, 390); this.btnSalir.Size = new System.Drawing.Size(80, 35); this.btnSalir.Text = "SALIR"; this.btnSalir.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(760, 460); this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitulo, this.grpRol, this.btnActualizar, this.btnSalir });
            this.Name = "frmRolEmpleados"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.Text = "Roles de Empleados";
            this.grpRol.ResumeLayout(false); this.grpRol.PerformLayout(); this.ResumeLayout(false); this.PerformLayout();
        }
    }
}