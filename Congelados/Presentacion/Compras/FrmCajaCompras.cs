using Congelados.Presentacion.Base;
using Congelados.Servicios.Compras;
using Congelados.Servicios.Inventario;
using Congelados.ViewModels.Compras;
using Congelados.ViewModels.Inventario;
using Models.CapitalHumano;
using Models.Compras;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Congelados.Presentacion.Compras
{
    public partial class FrmCajaCompras : FrmCaja
    {
        #region Private Field

        /// <summary>
        /// Proveedor de servicios para las Compras.
        /// </summary>
        private readonly CompraService compraService;

        /// <summary>
        /// Servicio para las Materias Primas
        /// </summary>
        private readonly MateriaPrimaService materiaPrimaService;

        /// <summary>
        /// Servicio para los proveedores.
        /// </summary>
        private readonly ProveedorService proveedorService;

        /// <summary>
        /// Lista de Detalles de Compra desde una vista personalizada.
        /// </summary>
        private readonly List<DetalleCompraView> Detalles;

        #endregion

        public FrmCajaCompras()
        {
            InitializeComponent();
            compraService = new CompraService();
            materiaPrimaService = new MateriaPrimaService();
            proveedorService = new ProveedorService();
            Detalles = new List<DetalleCompraView>();
            Actualizar();
        }

        protected override void Actualizar()
        {
            LoadDataGrid(materiaPrimaService.GetMateriasPrimas(string.Empty), DgvCatalogo);
            LoadDataGrid(proveedorService.GetProveedores(string.Empty), DgvSujeto);
        }

        protected override void Limpiar()
        {
            Detalles.Clear();
            DgvCarrito.DataSource = Detalles.ToArray();
        }

        protected override void Setup()
        {
            LblTitulo.Text = "Compras";
            GbCatalogo.Text = "Materias Primas";
            GbSujeto.Text = "Proveedores";
            LblSujetoResumen.Text = "Proveedor:";
        }

        protected override void OnTxtBuscarCatalogoTextChanged(string text)
        {
            LoadDataGrid(materiaPrimaService.GetMateriasPrimas(text), DgvCatalogo);
        }

        protected override void OnDgvCatalogoCellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        protected override void OnDgvSujetoCellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProveedorView selected = GetSelected<ProveedorView>(DgvSujeto);

            if (selected is null)
            {
                MessageBox.Show(this, "Debe seleccionar un proveedor existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proveedor proveedor = proveedorService.GetById(selected.Id);

            if (proveedor is null)
            {
                MessageBox.Show(this, $"No existe el proveedor con ID: {selected.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TxtSujetoResumen.Text = proveedor.Nombre;
        }

        protected override void OnDgvCarritoDataSourceChanged(object sender, EventArgs e)
        {
            NumTotalResumen.Value = compraService.CalcularTotal(Detalles);
        }

        protected override void OnBtnAgregarCarritoClick(object sender, EventArgs e)
        {
            MateriaPrimaView materiaPrimaView = GetSelected<MateriaPrimaView>(DgvCatalogo);

            if (materiaPrimaView is null)
            {
                MessageBox.Show(this, "Para agregar una Materia Prima al carrito, primero debe seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double cantidad = Convert.ToDouble(NumCantidadCatalogo.Value);
            decimal costo = NumValorCatalogo.Value;
            double descuento = Convert.ToDouble(NumDescuentoCatalogo.Value / 100);

            DetalleCompraView detalleCompraView = new DetalleCompraView
            {
                Id = materiaPrimaView.Id,
                Descripcion = materiaPrimaView.Descripcion,
                Cantidad = cantidad,
                Costo = costo,
                Descuento = descuento,
                SubTotal = compraService.CalcularSubTotal(cantidad, costo, descuento)
            };

            MessageBox.Show(this, "¡Se ha añadido con éxito a su carrito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Detalles.RemoveAll(value => value.Id == detalleCompraView.Id);
            Detalles.Add(detalleCompraView);

            DgvCarrito.DataSource = Detalles.ToArray();
        }

        protected override void OnTxtBuscarSujetoTextChanged(string text)
        {
            LoadDataGrid(proveedorService.GetProveedores(text), DgvSujeto);
        }

        protected override void OnBtnEliminarCarritoTextChanged(object sender, EventArgs e)
        {
            DetalleCompraView detalleCompraView = GetSelected<DetalleCompraView>(DgvCarrito);

            if (detalleCompraView is null)
            {
                MessageBox.Show(this, "Para eliminar un Detalle de Compra del Carrito, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el Detalle con ID: {detalleCompraView.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            Detalles.RemoveAll(value => value.Id == detalleCompraView.Id);
            DgvCarrito.DataSource = Detalles.ToArray();
        }

        protected override void OnBtnRealizarTransaccionClick(object sender, EventArgs e)
        {
            ProveedorView proveedorView = GetSelected<ProveedorView>(DgvSujeto);

            if (proveedorView is null)
            {
                MessageBox.Show(this, "Se debe seleccionar un Proveedor para continuar con la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proveedor proveedor = proveedorService.GetById(proveedorView.Id);

            if (proveedor is null)
            {
                MessageBox.Show(this, "No se encontró al Proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Empleado is null)
            {
                MessageBox.Show(this, "No se encontró al Empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Fecha", DtResumen.Value},
                {"IdProveedor", proveedor.Id },
                {"IdEmpleado", Empleado.Id }
            };

            try
            {
                compraService.Create(properties, Detalles);

                if (compraService.HasError())
                {
                    MessageBox.Show(this, compraService.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(this, "¡La compra se ha realizado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
