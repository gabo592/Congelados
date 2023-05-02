using Congelados.Presentacion.Compras;
using Congelados.Presentacion.Inventario;
using Congelados.Presentacion.Ventas;
using Congelados.Servicios.Base;
using Congelados.Servicios.CapitalHumano;
using Models.CapitalHumano;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Congelados.Presentacion.Base
{
    public abstract partial class FrmCaja : Form
    {
        /// <summary>
        /// Proveedor de servicios para los Empleados.
        /// </summary>
        private readonly EmpleadoService empleadoService;

        /// <summary>
        /// Empleado involucrado en la transacción
        /// </summary>
        protected Empleado Empleado { get; private set; }

        public FrmCaja()
        {
            InitializeComponent();
            empleadoService = new EmpleadoService();

            Empleado = empleadoService.GetById(Session.Usuario.IdEmpleado);
            TxtEmpleadoResumen.Text = $"{Empleado.PrimerNombre} {Empleado.SegundoNombre} {Empleado.PrimerApellido} {Empleado.SegundoApellido}";

            Setup();
        }

        #region Protected Methods

        protected abstract void Actualizar();

        protected abstract void Limpiar();

        protected abstract void Setup();

        protected abstract void OnTxtBuscarCatalogoTextChanged(string text);

        protected abstract void OnDgvCatalogoCellClick(object sender, DataGridViewCellEventArgs e);

        protected abstract void OnDgvSujetoCellClick(object sender, DataGridViewCellEventArgs e);

        protected abstract void OnDgvCarritoDataSourceChanged(object sender, EventArgs e);

        protected abstract void OnBtnAgregarCarritoClick(object sender, EventArgs e);

        protected abstract void OnTxtBuscarSujetoTextChanged(string text);

        protected abstract void OnBtnEliminarCarritoTextChanged(object sender, EventArgs e);

        protected abstract void OnBtnRealizarTransaccionClick(object sender, EventArgs e);

        /// <summary>
        /// Carga el DataGridView especificado con la información contenida en la colección de modelos de tipo especificado.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a mostrar en el DataGridView.</typeparam>
        /// <param name="models">Colección de modelos de tipo especificado que se mostrará en el DataGridView.</param>
        /// <param name="dataGridView">DataGridView en donde se mostrarán los modelos.</param>
        protected void LoadDataGrid<TModel>(IEnumerable<TModel> models, DataGridView dataGridView) where TModel : new()
        {
            if (models is null) return;

            dataGridView.DataSource = models.ToArray();
        }

        /// <summary>
        /// Busca dentro de las filas seleccionadas del DataGridView especificado y retorna la primera coincidencia.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo contenido en el DataGridView.</typeparam>
        /// <param name="dataGridView">DataGridView en donde se encuentra el modelo a extraer.</param>
        /// <returns>Primer elemento seleccionado del DataGridView; en caso de no existir elementos seleccionados, retorna el valor por defecto.</returns>
        protected TModel GetSelected<TModel>(DataGridView dataGridView) where TModel : new()
        {
            if (dataGridView.SelectedRows.Count == 0) return default;

            TModel[] models = (TModel[])dataGridView.DataSource;

            return models[dataGridView.SelectedRows[0].Index];
        }

        #endregion

        #region Private Methods

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscadorProveedores buscadorProveedores = new FrmBuscadorProveedores();
            buscadorProveedores.ShowDialog();
            Actualizar();
        }

        private void HistorialComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MateriasPrimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscadorMateriasPrimas buscadorMateriasPrimas = new FrmBuscadorMateriasPrimas();
            buscadorMateriasPrimas.ShowDialog();
            Actualizar();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscadorProductos buscadorProductos = new FrmBuscadorProductos();
            buscadorProductos.ShowDialog();
            Actualizar();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscadorClientes buscadorClientes = new FrmBuscadorClientes();
            buscadorClientes.ShowDialog();
            Actualizar();
        }

        private void HistorialVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TxtBuscarCatalogo_TextChanged(object sender, EventArgs e)
        {
            OnTxtBuscarCatalogoTextChanged(TxtBuscarCatalogo.Text);
        }

        private void DgvCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OnDgvCatalogoCellClick(sender, e);
        }

        private void BtnAgregarCarrito_Click(object sender, EventArgs e)
        {
            OnBtnAgregarCarritoClick(sender, e);
        }

        private void TxtBuscarSujeto_TextChanged(object sender, EventArgs e)
        {
            OnTxtBuscarSujetoTextChanged(TxtBuscarSujeto.Text);
        }

        private void DgvSujeto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OnDgvSujetoCellClick(sender, e);
        }

        private void DgvCarrito_DataSourceChanged(object sender, EventArgs e)
        {
            OnDgvCarritoDataSourceChanged(sender, e);
        }

        private void BtnEliminarCarrito_Click(object sender, EventArgs e)
        {
            OnBtnEliminarCarritoTextChanged(sender, e);
        }

        private void NumPagaResumen_ValueChanged(object sender, EventArgs e)
        {
            decimal total = NumTotalResumen.Value;
            decimal paga = NumPagaResumen.Value;

            if (paga < total)
            {
                MessageBox.Show(this, "La cantidad recibida es menor al total de la transacción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumPagaResumen.Value = NumPagaResumen.Minimum;
                return;
            }

            NumVueltoResumen.Value = total - paga;
        }

        private void BtnRealizarTransaccion_Click(object sender, EventArgs e)
        {
            OnBtnRealizarTransaccionClick(sender, e);
        }

        private void BtnLimpiarTransaccion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "¿Desea limpiar el formulario? Los cambios pueden no guardarse.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            TxtBuscarCatalogo.Text = string.Empty;
            TxtBuscarSujeto.Text = string.Empty;

            Limpiar();            
        }

        #endregion
    }
}
