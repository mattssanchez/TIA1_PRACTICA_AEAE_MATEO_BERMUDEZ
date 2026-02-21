using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TIA1
{
    partial class frmLogin
    {
        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnSalir;

        private void InitializeComponent()
        {
            lblUser = new Label();
            lblPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnSalir = new Button();

            lblUser.Text = "Usuario";
            lblUser.Location = new System.Drawing.Point(20, 20);

            txtUser.Location = new System.Drawing.Point(100, 20);
            txtUser.Width = 150;

            lblPass.Text = "Contraseña";
            lblPass.Location = new System.Drawing.Point(20, 60);

            txtPass.Location = new System.Drawing.Point(100, 60);
            txtPass.Width = 150;

            btnLogin.Text = "Login";
            btnLogin.Location = new System.Drawing.Point(40, 100);
            btnLogin.Click += btnLogin_Click;

            btnSalir.Text = "Salir";
            btnSalir.Location = new System.Drawing.Point(140, 100);
            btnSalir.Click += btnSalir_Click;

            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
            Controls.Add(btnSalir);

            Text = "Login";
            ClientSize = new System.Drawing.Size(280, 160);
        }
    }
}
