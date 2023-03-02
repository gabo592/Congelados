using Congelados.Properties;
using Congelados.Servicios.Seguridad;
using System;
using System.Windows.Forms;

namespace Congelados.Presentacion.Principal
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Proveedor de servicios para los Usuarios.
        /// </summary>
        private readonly UsuarioService Service;

        public FrmLogin()
        {
            InitializeComponent();
            Setup();
            Service = new UsuarioService();
        }

        private void Setup()
        {
            MinimumSize = Size;
            MaximumSize = Size;
        }

        private void PbRevelarClave_Click(object sender, EventArgs e)
        {
            TxtClave.UseSystemPasswordChar = !TxtClave.UseSystemPasswordChar;

            PbRevelarClave.Image = TxtClave.UseSystemPasswordChar ? Resources.eye : Resources.eye_crossed;
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                Login();

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Hide();
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login()
        {
            string nombre = TxtUsuario.Text;
            string clave = TxtClave.Text;

            Service.Login(nombre, clave);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
