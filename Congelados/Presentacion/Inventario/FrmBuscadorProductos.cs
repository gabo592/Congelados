using Congelados.Presentacion.Base;
using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Inventario;
using Congelados.ViewModels.Inventario;
using Models.Inventario;
using System;
using System.Windows.Forms;

namespace Congelados.Presentacion.Inventario
{
    public partial class FrmBuscadorProductos : FrmBuscador, IObservador
    {
        /// <summary>
        /// Servicio para los Productos.
        /// </summary>
        private readonly ProductoService Service;

        public FrmBuscadorProductos() : base("Productos")
        {
            InitializeComponent();
            Service = new ProductoService();
            Actualizar();
        }

        protected override void OnTxtBuscarTextChanged(string text)
        {
            LoadDataGrid(Service.GetProductos(text));
        }

        protected override void OnBtnAgregarClick(object sender, EventArgs e)
        {
            FrmEditorProducto editorProducto = new FrmEditorProducto(null);
            editorProducto.AgregarObservador(this);
            editorProducto.ShowDialog();
        }

        protected override void OnBtnModificarClick(object sender, EventArgs e)
        {
            ProductoView selected = GetSelected<ProductoView>();

            if (selected is null || selected.Equals(default))
            {
                MessageBox.Show(this, "Para modificar un Producto, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto producto = Service.GetById(selected.Id);

            if (producto is null)
            {
                MessageBox.Show(this, "No se encontró el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorProducto editorProducto = new FrmEditorProducto(producto);
            editorProducto.AgregarObservador(this);
            editorProducto.ShowDialog();
        }

        protected override void OnBtnEliminarClick(object sender, EventArgs e)
        {
            ProductoView selected = GetSelected<ProductoView>();

            if (selected is null || selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar un Producto, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto producto = Service.GetById(selected.Id);

            if (producto is null)
            {
                MessageBox.Show(this, "No se encontró el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el Producto con ID: {producto.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                Service.Delete(producto);

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
            LoadDataGrid(Service.GetProductos(string.Empty));
        }
    }
}
