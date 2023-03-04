using Congelados.Presentacion.Base;
using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Inventario;
using Congelados.ViewModels.Inventario;
using Models.Inventario;
using System;
using System.Windows.Forms;

namespace Congelados.Presentacion.Inventario
{
    public partial class FrmBuscadorCategoriasProductos : FrmBuscador, IObservador
    {
        /// <summary>
        /// Servicio para las Categorias de Productos.
        /// </summary>
        private readonly CategoriaProductoService Service;

        public FrmBuscadorCategoriasProductos() : base("Categorías de Productos")
        {
            InitializeComponent();
            Service = new CategoriaProductoService();
            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(Service.GetCategorias(string.Empty));
        }

        protected override void OnTxtBuscarTextChanged(string text)
        {
            LoadDataGrid(Service.GetCategorias(text));
        }

        protected override void OnBtnAgregarClick(object sender, EventArgs e)
        {
            FrmEditorCategoriaProducto editorCategoriaProducto = new FrmEditorCategoriaProducto(null);
            editorCategoriaProducto.AgregarObservador(this);
            editorCategoriaProducto.ShowDialog();
        }

        protected override void OnBtnModificarClick(object sender, EventArgs e)
        {
            CategoriaProductoView selected = GetSelected<CategoriaProductoView>();

            if (selected is null || selected.Equals(default))
            {
                MessageBox.Show(this, "Para actualizar una Categoría de Producto, primero debe seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoriaProducto categoriaProducto = Service.GetById(selected.Id);

            if (categoriaProducto is null)
            {
                MessageBox.Show(this, "No se encontró la Categoría de Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorCategoriaProducto editorCategoriaProducto = new FrmEditorCategoriaProducto(categoriaProducto);
            editorCategoriaProducto.AgregarObservador(this);
            editorCategoriaProducto.ShowDialog();
        }

        protected override void OnBtnEliminarClick(object sender, EventArgs e)
        {
            CategoriaProductoView selected = GetSelected<CategoriaProductoView>();

            if (selected is null || selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar una Categoría de Producto, primero debe seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoriaProducto categoriaProducto = Service.GetById(selected.Id);

            if (categoriaProducto is null)
            {
                MessageBox.Show(this, "No se encontró la Categoría de Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar la Categoría de Producto con ID: {categoriaProducto.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                Service.Delete(categoriaProducto);

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
    }
}
