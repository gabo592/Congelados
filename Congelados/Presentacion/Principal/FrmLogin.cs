using Congelados.Properties;
using System;
using System.Windows.Forms;

namespace Congelados.Presentacion.Principal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Setup();
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

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
