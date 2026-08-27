using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TIA1
{
    partial class frmClientes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
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
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(225, 20);
            this.lblTitulo.Text = "NUEVO REGISTRO CLIENTE";

            this.grpCliente.Location = new System.Drawing.Point(80, 65);
            this.grpCliente.Size = new System.Drawing.Size(540, 325);
            this.grpCliente.Text = "Información del cliente";

            this.lblId.AutoSize = true; this.lblId.Location = new System.Drawing.Point(25, 35); this.lblId.Text = "ID Cliente:";
            this.txtIdCliente.Location = new System.Drawing.Point(150, 32); this.txtIdCliente.Size = new System.Drawing.Size(330, 27);

            this.lblNombre.AutoSize = true; this.lblNombre.Location = new System.Drawing.Point(25, 80); this.lblNombre.Text = "Nombre Cliente:";
            this.txtNombreCliente.Location = new System.Drawing.Point(150, 77); this.txtNombreCliente.Size = new System.Drawing.Size(330, 27);

            this.lblDocumento.AutoSize = true; this.lblDocumento.Location = new System.Drawing.Point(25, 125); this.lblDocumento.Text = "Documento:";
            this.txtDocumento.Location = new System.Drawing.Point(150, 122); this.txtDocumento.Size = new System.Drawing.Size(330, 27);

            this.lblDireccion.AutoSize = true; this.lblDireccion.Location = new System.Drawing.Point(25, 170); this.lblDireccion.Text = "Dirección:";
            this.txtDireccion.Location = new System.Drawing.Point(150, 167); this.txtDireccion.Size = new System.Drawing.Size(330, 27);

            this.lblTelefono.AutoSize = true; this.lblTelefono.Location = new System.Drawing.Point(25, 215); this.lblTelefono.Text = "Teléfono:";
            this.txtTelefono.Location = new System.Drawing.Point(150, 212); this.txtTelefono.Size = new System.Drawing.Size(330, 27);

            this.lblEmail.AutoSize = true; this.lblEmail.Location = new System.Drawing.Point(25, 260); this.lblEmail.Text = "Email:";
            this.txtEmail.Location = new System.Drawing.Point(150, 257); this.txtEmail.Size = new System.Drawing.Size(330, 27);

            this.grpCliente.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblId, this.txtIdCliente, this.lblNombre, this.txtNombreCliente, this.lblDocumento, this.txtDocumento, this.lblDireccion, this.txtDireccion, this.lblTelefono, this.txtTelefono, this.lblEmail, this.txtEmail });

            this.btnActualizar.Location = new System.Drawing.Point(430, 410);
            this.btnActualizar.Size = new System.Drawing.Size(120, 35);
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;

            this.btnSalir.Location = new System.Drawing.Point(560, 410);
            this.btnSalir.Size = new System.Drawing.Size(80, 35);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitulo, this.grpCliente, this.btnActualizar, this.btnSalir });
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.grpCliente.ResumeLayout(false); this.grpCliente.PerformLayout();
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}