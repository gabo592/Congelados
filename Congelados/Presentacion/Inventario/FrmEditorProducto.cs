using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Inventario;
using Congelados.ViewModels.Inventario;
using Models.Interfaces;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Congelados.Presentacion.Inventario
{
    public partial class FrmEditorProducto : Form, ISujeto
    {
        /// <summary>
        /// Producto a editar.
        /// </summary>
        private readonly Producto Producto;

        /// <summary>
        /// Servicio para los Productos.
        /// </summary>
        private readonly ProductoService Service;

        /// <summary>
        /// Lista de Observadores a los que ésta clase notificará los cambios.
        /// </summary>
        private readonly List<IObservador> Observadores;

        /// <summary>
        /// Servicio para las Categorías de Productos.
        /// </summary>
        private readonly CategoriaProductoService CategoriaProductoService;

        public FrmEditorProducto(Producto producto)
        {
            InitializeComponent();
            Producto = producto;
            Service = new ProductoService();
            CategoriaProductoService = new CategoriaProductoService();
            Observadores = new List<IObservador>();
            Init();
        }

        private void Init()
        {
            LoadCategorias();

            if (Producto is null) return;

            TxtDescripcion.Text = Producto.Descripcion;
            NumPrecio.Value = Producto.Precio;
            NumCantidad.Value = Convert.ToDecimal(Producto.Cantidad);

            CategoriaProductoView[] categorias = (CategoriaProductoView[])CmbCategoriaProducto.DataSource;
            CmbCategoriaProducto.SelectedItem = categorias.FirstOrDefault(value => value.Id == Producto.IdCategoria);
        }

        private void LoadCategorias()
        {
            CmbCategoriaProducto.DataSource = CategoriaProductoService.GetCategorias(string.Empty).ToArray();
            CmbCategoriaProducto.DisplayMember = nameof(INameable.Nombre);
        }

        public void AgregarObservador(IObservador observador) => Observadores.Add(observador);

        public void Notificar() => Observadores.ForEach(observador => observador.Actualizar());

        private void CategoríasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscadorCategoriasProductos buscadorCategoriasProductos = new FrmBuscadorCategoriasProductos();
            buscadorCategoriasProductos.ShowDialog();
            LoadCategorias();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CategoriaProductoView categoriaProducto = (CategoriaProductoView)CmbCategoriaProducto.SelectedItem;

            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Id", Producto?.Id },
                {"Descripcion", TxtDescripcion.Text },
                {"Precio", NumPrecio.Value },
                {"Cantidad", NumCantidad.Value },
                {"Estado", Producto?.Estado },
                {"IdCategoria", categoriaProducto.Id }
            };

            try
            {
                if (Producto is null)
                {
                    Service.Create(properties);
                }
                else
                {
                    Service.Update(properties);
                }

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notificar();
                MessageBox.Show(this, "¡Se ha guardado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Producto is null) Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            TxtDescripcion.Text = string.Empty;
            NumPrecio.Value = NumPrecio.Minimum;
            NumCantidad.Value = NumCantidad.Minimum;

            CmbCategoriaProducto.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
