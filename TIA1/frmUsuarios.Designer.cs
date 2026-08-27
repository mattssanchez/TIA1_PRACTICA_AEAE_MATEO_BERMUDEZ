namespace TIA1
{
    partial class frmUsuarios
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.Label lblEmpleado, lblUsuario, lblClave;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.TextBox txtUsuario, txtClave;
        private System.Windows.Forms.Button btnActualizar, btnSalir;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label(); this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.lblEmpleado = new System.Windows.Forms.Label(); this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label(); this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label(); this.txtClave = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button(); this.btnSalir = new System.Windows.Forms.Button();
            this.grpUsuario.SuspendLayout(); this.SuspendLayout();

            this.lblTitulo.AutoSize = true; this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(170, 18); this.lblTitulo.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";

            this.grpUsuario.Location = new System.Drawing.Point(70, 70); this.grpUsuario.Size = new System.Drawing.Size(560, 270); this.grpUsuario.Text = "Datos del usuario";

            this.lblEmpleado.AutoSize = true; this.lblEmpleado.Location = new System.Drawing.Point(30, 45); this.lblEmpleado.Text = "Empleado:";
            this.cmbEmpleado.Location = new System.Drawing.Point(140, 42); this.cmbEmpleado.Size = new System.Drawing.Size(350, 28); this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblUsuario.AutoSize = true; this.lblUsuario.Location = new System.Drawing.Point(30, 100); this.lblUsuario.Text = "Usuario:";
            this.txtUsuario.Location = new System.Drawing.Point(140, 97); this.txtUsuario.Size = new System.Drawing.Size(350, 27);

            this.lblClave.AutoSize = true; this.lblClave.Location = new System.Drawing.Point(30, 155); this.lblClave.Text = "Clave:";
            this.txtClave.Location = new System.Drawing.Point(140, 152); this.txtClave.Size = new System.Drawing.Size(350, 27); this.txtClave.UseSystemPasswordChar = true;

            this.grpUsuario.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblEmpleado, this.cmbEmpleado, this.lblUsuario, this.txtUsuario, this.lblClave, this.txtClave });

            this.btnActualizar.Location = new System.Drawing.Point(420, 365); this.btnActualizar.Size = new System.Drawing.Size(120, 35); this.btnActualizar.Text = "ACTUALIZAR"; this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnSalir.Location = new System.Drawing.Point(550, 365); this.btnSalir.Size = new System.Drawing.Size(80, 35); this.btnSalir.Text = "SALIR"; this.btnSalir.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(700, 430); this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitulo, this.grpUsuario, this.btnActualizar, this.btnSalir });
            this.Name = "frmUsuarios"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.Text = "Usuarios";
            this.grpUsuario.ResumeLayout(false); this.grpUsuario.PerformLayout(); this.ResumeLayout(false); this.PerformLayout();
        }
    }
}