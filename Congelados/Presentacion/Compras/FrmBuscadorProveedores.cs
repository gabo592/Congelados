using Congelados.Presentacion.Base;
using Congelados.Servicios.Compras;
using Congelados.Servicios.Interfaces;
using Congelados.ViewModels.Compras;
using Models.Compras;
using System;
using System.Windows.Forms;

namespace Congelados.Presentacion.Compras
{
    public partial class FrmBuscadorProveedores : FrmBuscador, IObservador
    {
        /// <summary>
        /// Servicio de los Proveedores.
        /// </summary>
        private readonly ProveedorService Service;

        public FrmBuscadorProveedores() : base("Proveedores")
        {
            InitializeComponent();
            Service = new ProveedorService();
            Actualizar();
        }

        protected override void OnTxtBuscarTextChanged(string text)
        {
            LoadDataGrid(Service.GetProveedores(text));
        }

        protected override void OnBtnAgregarClick(object sender, EventArgs e)
        {
            FrmEditorProveedor editorProveedor = new FrmEditorProveedor(null);
            editorProveedor.AgregarObservador(this);
            editorProveedor.ShowDialog();
        }

        protected override void OnBtnModificarClick(object sender, EventArgs e)
        {
            ProveedorView selected = GetSelected<ProveedorView>();

            if (selected is null || selected.Equals(default))
            {
                MessageBox.Show(this, "Para modificar un Proveedor, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proveedor proveedor = Service.GetById(selected.Id);

            if (proveedor is null)
            {
                MessageBox.Show(this, "No se encontró al Proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorProveedor editorProveedor = new FrmEditorProveedor(proveedor);
            editorProveedor.AgregarObservador(this);
            editorProveedor.ShowDialog();
        }

        protected override void OnBtnEliminarClick(object sender, EventArgs e)
        {
            ProveedorView selected = GetSelected<ProveedorView>();

            if (selected is null || selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar un Proveedor, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proveedor proveedor = Service.GetById(selected.Id);

            if (proveedor is null)
            {
                MessageBox.Show(this, "No se encontró al Proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar al Proveedor con ID: {proveedor.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                Service.Delete(proveedor);

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void Actualizar()
        {
            LoadDataGrid(Service.GetProveedores(string.Empty));
        }
    }
}
