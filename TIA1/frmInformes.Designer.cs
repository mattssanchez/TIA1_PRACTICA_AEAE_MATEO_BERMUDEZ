namespace TIA1
{
    partial class frmInformes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.RadioButton rbFactura;
        private System.Windows.Forms.RadioButton rbDetalle;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvInforme;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblFechaInicio = new System.Windows.Forms.Label(); this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label(); this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblOrdenar = new System.Windows.Forms.Label(); this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.rbFactura = new System.Windows.Forms.RadioButton(); this.rbDetalle = new System.Windows.Forms.RadioButton();
            this.btnGenerarInforme = new System.Windows.Forms.Button(); this.btnSalir = new System.Windows.Forms.Button();
            this.dgvInforme = new System.Windows.Forms.DataGridView();
            this.grpFiltros.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvInforme)).BeginInit(); this.SuspendLayout();

            this.lblTitulo.AutoSize = true; this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(250, 18); this.lblTitulo.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";

            this.grpFiltros.Location = new System.Drawing.Point(25, 60); this.grpFiltros.Size = new System.Drawing.Size(800, 125); this.grpFiltros.Text = "Filtros";

            this.lblFechaInicio.AutoSize = true; this.lblFechaInicio.Location = new System.Drawing.Point(20, 32); this.lblFechaInicio.Text = "Fecha inicio:";
            this.dtpFechaInicio.Location = new System.Drawing.Point(105, 29); this.dtpFechaInicio.Size = new System.Drawing.Size(130, 27); this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblFechaFinal.AutoSize = true; this.lblFechaFinal.Location = new System.Drawing.Point(250, 32); this.lblFechaFinal.Text = "Fecha final:";
            this.dtpFechaFinal.Location = new System.Drawing.Point(325, 29); this.dtpFechaFinal.Size = new System.Drawing.Size(130, 27); this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblOrdenar.AutoSize = true; this.lblOrdenar.Location = new System.Drawing.Point(470, 32); this.lblOrdenar.Text = "Ordenar por:";
            this.cmbOrdenar.Location = new System.Drawing.Point(550, 29); this.cmbOrdenar.Size = new System.Drawing.Size(200, 28); this.cmbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.rbFactura.AutoSize = true; this.rbFactura.Location = new System.Drawing.Point(105, 75); this.rbFactura.Text = "Factura"; this.rbFactura.Checked = true;
            this.rbDetalle.AutoSize = true; this.rbDetalle.Location = new System.Drawing.Point(190, 75); this.rbDetalle.Text = "Detalle";

            this.grpFiltros.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblFechaInicio, this.dtpFechaInicio, this.lblFechaFinal, this.dtpFechaFinal, this.lblOrdenar, this.cmbOrdenar, this.rbFactura, this.rbDetalle });

            this.dgvInforme.AllowUserToAddRows = false; this.dgvInforme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInforme.Location = new System.Drawing.Point(25, 200); this.dgvInforme.Size = new System.Drawing.Size(800, 250);
            this.dgvInforme.Columns.Add("colFactura", "Factura"); this.dgvInforme.Columns.Add("colCliente", "Cliente"); this.dgvInforme.Columns.Add("colFecha", "Fecha"); this.dgvInforme.Columns.Add("colTotal", "Total");

            this.btnGenerarInforme.Location = new System.Drawing.Point(25, 470); this.btnGenerarInforme.Size = new System.Drawing.Size(145, 35); this.btnGenerarInforme.Text = "GENERAR INFORME"; this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnSalir.Location = new System.Drawing.Point(730, 470); this.btnSalir.Size = new System.Drawing.Size(95, 35); this.btnSalir.Text = "SALIR"; this.btnSalir.UseVisualStyleBackColor = true;

            this.ClientSize = new System.Drawing.Size(850, 530);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitulo, this.grpFiltros, this.dgvInforme, this.btnGenerarInforme, this.btnSalir });
            this.Name = "frmInformes"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.Text = "Informes";
            this.grpFiltros.ResumeLayout(false); this.grpFiltros.PerformLayout(); ((System.ComponentModel.ISupportInitialize)(this.dgvInforme)).EndInit(); this.ResumeLayout(false); this.PerformLayout();
        }
    }
}