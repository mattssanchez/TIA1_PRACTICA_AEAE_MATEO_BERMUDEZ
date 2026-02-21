using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TIA1
{
    partial class frmClientes
    {
        private Label lblTitulo;
        private TextBox txtCampo1;
        private TextBox txtCampo2;
        private Button btnAceptar;
        private Button btnSalir;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCampo1 = new System.Windows.Forms.TextBox();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formulario Clientes";
            // 
            // txtCampo1
            // 
            this.txtCampo1.Location = new System.Drawing.Point(20, 60);
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(200, 20);
            this.txtCampo1.TabIndex = 1;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(20, 100);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(200, 20);
            this.txtCampo2.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(20, 140);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(120, 140);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmClientes
            // 
            this.ClientSize = new System.Drawing.Size(260, 200);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCampo1);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}