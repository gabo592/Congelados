using Congelados.Presentacion.Base;
using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Seguridad;
using Congelados.ViewModels.Seguridad;
using Models.Seguridad;
using System;
using System.Windows.Forms;

namespace Congelados.Presentacion.Seguridad
{
    public partial class FrmBuscadorUsuarios : FrmBuscador, IObservador
    {
        /// <summary>
        /// Servicio para los usuarios.
        /// </summary>
        private readonly UsuarioService service;

        public FrmBuscadorUsuarios() : base("Usuarios")
        {
            InitializeComponent();
            service = new UsuarioService();
            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(service.GetUsuarios(string.Empty));
        }

        protected override void OnTxtBuscarTextChanged(string text)
        {
            LoadDataGrid(service.GetUsuarios(text));
        }

        protected override void OnBtnAgregarClick(object sender, EventArgs e)
        {
            FrmEditorUsuario editorUsuario = new FrmEditorUsuario(null);
            editorUsuario.AgregarObservador(this);
            editorUsuario.ShowDialog();
        }

        protected override void OnBtnModificarClick(object sender, EventArgs e)
        {
            UsuarioView selected = GetSelected<UsuarioView>();

            if (selected is null)
            {
                MessageBox.Show(this, "Para modificar un Usuario, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = service.GetById(selected.Id);

            if (usuario is null || usuario.Id == 1)
            {
                MessageBox.Show(this, "No es posible modificar al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorUsuario editorUsuario = new FrmEditorUsuario(usuario);
            editorUsuario.AgregarObservador(this);
            editorUsuario.ShowDialog();
        }

        protected override void OnBtnEliminarClick(object sender, EventArgs e)
        {
            UsuarioView selected = GetSelected<UsuarioView>();

            if (selected is null)
            {
                MessageBox.Show(this, "Para eliminar un Usuario, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = service.GetById(selected.Id);

            if (usuario is null || usuario.Id == 1)
            {
                MessageBox.Show(this, "No es posible eliminar al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar al Usuario con ID: {usuario.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(usuario);

                if (service.HasError())
                {
                    MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Actualizar();
                MessageBox.Show(this, "¡Se ha eliminado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
