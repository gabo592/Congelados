using Congelados.Presentacion.Base;
using Congelados.Servicios.Inventario;
using Congelados.Servicios.Ventas;
using Congelados.ViewModels.Inventario;
using Congelados.ViewModels.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Congelados.Presentacion.Ventas
{
    public partial class FrmCajaVentas : FrmCaja
    {
        #region Private Fields

        /// <summary>
        /// Proveedor de servicios para los productos.
        /// </summary>
        private readonly ProductoService productoService;

        /// <summary>
        /// Proveedor de servicios para los clientes.
        /// </summary>
        private readonly ClienteService clienteService;

        /// <summary>
        /// Proveedor de servicios para las ventas.
        /// </summary>
        private readonly VentaService ventaService;

        /// <summary>
        /// Lista de Detalles de Venta.
        /// </summary>
        private readonly List<DetalleVentaView> Detalles;

        #endregion

        public FrmCajaVentas()
        {
            InitializeComponent();
            productoService = new ProductoService();
            clienteService = new ClienteService();
            ventaService = new VentaService();
            Detalles = new List<DetalleVentaView>();

            Actualizar();
        }

        protected override void Actualizar()
        {
            LoadDataGrid(productoService.GetProductos(string.Empty), DgvCatalogo);
            LoadDataGrid(clienteService.GetClientes(string.Empty), DgvSujeto);
        }

        protected override void Limpiar()
        {
            Actualizar();
            Detalles.Clear();
            DgvCarrito.DataSource = Detalles.ToArray();
        }

        protected override void Setup()
        {
            LblTitulo.Text = "Ventas";
            GbCatalogo.Text = "Productos";
            GbSujeto.Text = "Clientes";
        }

        protected override void OnTxtBuscarCatalogoTextChanged(string text)
        {
            LoadDataGrid(productoService.GetProductos(text), DgvCatalogo);
        }

        protected override void OnDgvCatalogoCellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoView producto = GetSelected<ProductoView>(DgvCatalogo);

            if (producto is null)
            {
                MessageBox.Show(this, "No se ha seleccionado ningún producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NumCantidadCatalogo.Maximum = Convert.ToDecimal(producto.Cantidad);
        }

        protected override void OnDgvSujetoCellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteView cliente = GetSelected<ClienteView>(DgvSujeto);

            if (cliente is null)
            {
                MessageBox.Show(this, "No se ha seleccionado ningún cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TxtSujetoResumen.Text = $"{cliente.Nombres} {cliente.Apellidos}";
        }

        protected override void OnDgvCarritoDataSourceChanged(object sender, EventArgs e)
        {
            NumTotalResumen.Value = ventaService.CalcularTotal(Detalles);
        }

        protected override void OnBtnAgregarCarritoClick(object sender, EventArgs e)
        {
            ProductoView productoView = GetSelected<ProductoView>(DgvCatalogo);

            if (productoView is null)
            {
                MessageBox.Show(this, "Debe seleccionar un producto para agregar al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double cantidad = Convert.ToDouble(NumCantidadCatalogo.Value);
            decimal precio = NumValorCatalogo.Value;
            double descuento = Convert.ToDouble(NumDescuentoCatalogo.Value / 100);

            DetalleVentaView detalleVentaView = new DetalleVentaView
            {
                Id = productoView.Id,
                Descripcion = productoView.Descripcion,
                Cantidad = cantidad,
                Precio = precio,
                Descuento = descuento,
                SubTotal = ventaService.CalcularSubTotal(cantidad, precio, descuento)
            };

            Detalles.RemoveAll(detalle => detalle.Id == detalleVentaView.Id);
            Detalles.Add(detalleVentaView);

            MessageBox.Show(this, "¡Se ha agregado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DgvCarrito.DataSource = Detalles.ToArray();
        }

        protected override void OnTxtBuscarSujetoTextChanged(string text)
        {
            LoadDataGrid(clienteService.GetClientes(text), DgvSujeto);
        }

        protected override void OnBtnEliminarCarritoTextChanged(object sender, EventArgs e)
        {
            DetalleVentaView detalleVentaView = GetSelected<DetalleVentaView>(DgvCarrito);

            if (detalleVentaView is null)
            {
                MessageBox.Show(this, "Primero debe seleccionar un elemento del carrito para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el producto con ID: {detalleVentaView.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            Detalles.RemoveAll(detalle => detalle.Id == detalleVentaView.Id);
            DgvCarrito.DataSource = Detalles.ToArray();

            MessageBox.Show(this, "¡Se ha eliminado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override void OnBtnRealizarTransaccionClick(object sender, EventArgs e)
        {
            ClienteView cliente = GetSelected<ClienteView>(DgvSujeto);

            if (cliente is null)
            {
                MessageBox.Show(this, "No se encontró al Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Empleado is null)
            {
                MessageBox.Show(this, "No se encontró al Empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"IdCliente", cliente.Id },
                {"IdEmpleado", Empleado.Id }
            };

            try
            {
                ventaService.Create(properties, Detalles);

                if (ventaService.HasError())
                {
                    MessageBox.Show(this, ventaService.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(this, "¡La venta se ha realizado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
