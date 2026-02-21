using System.Windows.Forms;

namespace TIA1
{
    partial class frmPrincipal
    {
        private MenuStrip menu;
        private ToolStripMenuItem tablasMenu;
        private ToolStripMenuItem clientesItem;
        private ToolStripMenuItem productosItem;
        private ToolStripMenuItem categoriasItem;

        private ToolStripMenuItem facturacionMenu;
        private ToolStripMenuItem facturasItem;
        private ToolStripMenuItem informesItem;

        private ToolStripMenuItem seguridadMenu;
        private ToolStripMenuItem empleadosItem;
        private ToolStripMenuItem rolesItem;
        private ToolStripMenuItem usuariosItem;

        private ToolStripMenuItem ayudaMenu;
        private ToolStripMenuItem ayudaItem;
        private ToolStripMenuItem acercaItem;

        private ToolStripMenuItem salirItem;

        private void InitializeComponent()
        {
            menu = new MenuStrip();

            tablasMenu = new ToolStripMenuItem("Tablas");
            clientesItem = new ToolStripMenuItem("Clientes");
            productosItem = new ToolStripMenuItem("Productos");
            categoriasItem = new ToolStripMenuItem("Categorías");

            facturacionMenu = new ToolStripMenuItem("Facturación");
            facturasItem = new ToolStripMenuItem("Facturas");
            informesItem = new ToolStripMenuItem("Informes");

            seguridadMenu = new ToolStripMenuItem("Seguridad");
            empleadosItem = new ToolStripMenuItem("Empleados");
            rolesItem = new ToolStripMenuItem("Roles");
            usuariosItem = new ToolStripMenuItem("Usuarios");

            ayudaMenu = new ToolStripMenuItem("Ayuda");
            ayudaItem = new ToolStripMenuItem("Ver Ayuda");
            acercaItem = new ToolStripMenuItem("Acerca de");

            salirItem = new ToolStripMenuItem("Salir");

            clientesItem.Click += clientesItem_Click;
            productosItem.Click += productosItem_Click;
            categoriasItem.Click += categoriasItem_Click;
            facturasItem.Click += facturasItem_Click;
            informesItem.Click += informesItem_Click;
            empleadosItem.Click += empleadosItem_Click;
            rolesItem.Click += rolesItem_Click;
            usuariosItem.Click += usuariosItem_Click;
            ayudaItem.Click += ayudaItem_Click;
            acercaItem.Click += acercaItem_Click;
            salirItem.Click += salirItem_Click;

            tablasMenu.DropDownItems.Add(clientesItem);
            tablasMenu.DropDownItems.Add(productosItem);
            tablasMenu.DropDownItems.Add(categoriasItem);

            facturacionMenu.DropDownItems.Add(facturasItem);
            facturacionMenu.DropDownItems.Add(informesItem);

            seguridadMenu.DropDownItems.Add(empleadosItem);
            seguridadMenu.DropDownItems.Add(rolesItem);
            seguridadMenu.DropDownItems.Add(usuariosItem);

            ayudaMenu.DropDownItems.Add(ayudaItem);
            ayudaMenu.DropDownItems.Add(acercaItem);

            menu.Items.Add(tablasMenu);
            menu.Items.Add(facturacionMenu);
            menu.Items.Add(seguridadMenu);
            menu.Items.Add(ayudaMenu);
            menu.Items.Add(salirItem);

            Controls.Add(menu);
            MainMenuStrip = menu;

            Text = "Formulario Principal";
            ClientSize = new System.Drawing.Size(900, 500);
        }
    }
}
