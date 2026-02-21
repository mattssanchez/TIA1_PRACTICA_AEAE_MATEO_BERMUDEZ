using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesItem_Click(object sender, EventArgs e)
        {
            new frmClientes().Show();
        }

        private void productosItem_Click(object sender, EventArgs e)
        {
            new frmProductos().Show();
        }

        private void categoriasItem_Click(object sender, EventArgs e)
        {
            new frmCategorias().Show();
        }

        private void facturasItem_Click(object sender, EventArgs e)
        {
            new frmFacturas().Show();
        }

        private void informesItem_Click(object sender, EventArgs e)
        {
            new frmInformes().Show();
        }

        private void empleadosItem_Click(object sender, EventArgs e)
        {
            new frmEmpleados().Show();
        }

        private void rolesItem_Click(object sender, EventArgs e)
        {
            new frmRoles().Show();
        }

        private void usuariosItem_Click(object sender, EventArgs e)
        {
            new frmUsuarios().Show();
        }

        private void ayudaItem_Click(object sender, EventArgs e)
        {
            new frmAyuda().Show();
        }

        private void acercaItem_Click(object sender, EventArgs e)
        {
            new frmAcercaDe().Show();
        }

        private void salirItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

