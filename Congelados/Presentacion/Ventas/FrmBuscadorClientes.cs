using Congelados.Presentacion.Base;
using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Ventas;
using Congelados.ViewModels.Ventas;
using Models.Ventas;
using System;
using System.Windows.Forms;

namespace Congelados.Presentacion.Ventas
{
    public partial class FrmBuscadorClientes : FrmBuscador, IObservador
    {
        /// <summary>
        /// Servicio para los clientes.
        /// </summary>
        private readonly ClienteService service;

        public FrmBuscadorClientes() : base("Clientes")
        {
            InitializeComponent();
            service = new ClienteService();
            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(service.GetClientes(string.Empty));
        }

        protected override void OnTxtBuscarTextChanged(string text)
        {
            LoadDataGrid(service.GetClientes(text));
        }

        protected override void OnBtnAgregarClick(object sender, EventArgs e)
        {
            FrmEditorCliente editorCliente = new FrmEditorCliente(null);
            editorCliente.AgregarObservador(this);
            editorCliente.ShowDialog();
        }

        protected override void OnBtnModificarClick(object sender, EventArgs e)
        {
            ClienteView selected = GetSelected<ClienteView>();

            if (selected is null)
            {
                MessageBox.Show(this, "Para actualizar un Cliente, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = service.GetById(selected.Id);

            if (cliente is null)
            {
                MessageBox.Show(this, "No se encontró al Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorCliente editorCliente = new FrmEditorCliente(cliente);
            editorCliente.AgregarObservador(this);
            editorCliente.ShowDialog();
        }

        protected override void OnBtnEliminarClick(object sender, EventArgs e)
        {
            ClienteView selected = GetSelected<ClienteView>();

            if (selected is null)
            {
                MessageBox.Show(this, "Para eliminar un Cliente, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = service.GetById(selected.Id);

            if (cliente is null)
            {
                MessageBox.Show(this, "No se encontró al Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el Cliente con ID: {cliente.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(cliente);

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
