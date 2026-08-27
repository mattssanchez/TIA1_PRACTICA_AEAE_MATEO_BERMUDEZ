namespace TIA1
{
    partial class frmCategorias
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();

            this.pnlContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenido.Location = new System.Drawing.Point(35, 75);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(530, 235);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(165, 25);
            this.lblTitulo.Text = "CATEGORÍA DE PRODUCTOS";

            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(35, 45);
            this.lblIdCategoria.Text = "ID Categoría:";

            this.txtIdCategoria.Location = new System.Drawing.Point(160, 42);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(280, 27);

            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(35, 90);
            this.lblNombreCategoria.Text = "Nombre Categoría:";

            this.txtNombreCategoria.Location = new System.Drawing.Point(160, 87);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(280, 27);

            this.btnActualizar.Location = new System.Drawing.Point(270, 145);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 35);
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;

            this.btnSalir.Location = new System.Drawing.Point(380, 145);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 35);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;

            this.pnlContenido.Controls.Add(this.lblIdCategoria);
            this.pnlContenido.Controls.Add(this.txtIdCategoria);
            this.pnlContenido.Controls.Add(this.lblNombreCategoria);
            this.pnlContenido.Controls.Add(this.txtNombreCategoria);
            this.pnlContenido.Controls.Add(this.btnActualizar);
            this.pnlContenido.Controls.Add(this.btnSalir);

            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCategoriaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoría de Productos";
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}