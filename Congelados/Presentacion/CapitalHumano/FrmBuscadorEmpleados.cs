using Congelados.Presentacion.Base;
using Congelados.Servicios.CapitalHumano;
using Congelados.Servicios.Interfaces;
using Congelados.ViewModels.CapitalHumano;
using Models.CapitalHumano;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Congelados.Presentacion.CapitalHumano
{
    public partial class FrmBuscadorEmpleados : FrmBuscador, IObservador
    {
        /// <summary>
        /// Servicio para los Empleados.
        /// </summary>
        private readonly EmpleadoService Service;

        public FrmBuscadorEmpleados() : base("Empleados")
        {
            InitializeComponent();
            Service = new EmpleadoService();
            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(Service.GetEmpleados(string.Empty));
        }

        protected override void OnBtnAgregarClick(object sender, EventArgs e)
        {
            FrmEditorEmpleado editorEmpleado = new FrmEditorEmpleado(null);
            editorEmpleado.AgregarObservador(this);
            editorEmpleado.ShowDialog();
        }

        protected override void OnBtnEliminarClick(object sender, EventArgs e)
        {
            EmpleadoView selected = GetSelected<EmpleadoView>();

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para eliminar un Empleado, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Empleado empleado = Service.GetById(selected.Id);

            if (empleado is null || empleado.Id == 1)
            {
                MessageBox.Show(this, "No es posible eliminar al Empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar al Empleado con ID: {empleado.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                Service.Delete(empleado);

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

        protected override void OnBtnModificarClick(object sender, EventArgs e)
        {
            EmpleadoView selected = GetSelected<EmpleadoView>();

            if (selected.Equals(default))
            {
                MessageBox.Show(this, "Para actualizar un Empleado, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Empleado empleado = Service.GetById(selected.Id);

            if (empleado is null || empleado.Id == 1)
            {
                MessageBox.Show(this, "No es posible actualizar al Empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorEmpleado editorEmpleado = new FrmEditorEmpleado(empleado);
            editorEmpleado.AgregarObservador(this);
            editorEmpleado.ShowDialog();
        }

        protected override void OnTxtBuscarTextChanged(string text)
        {
            LoadDataGrid(Service.GetEmpleados(text));
        }
    }
}
