using Congelados.Presentacion.Base;
using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Inventario;
using Congelados.ViewModels.Inventario;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Congelados.Presentacion.Inventario
{
    public partial class FrmBuscadorMateriasPrimas : FrmBuscador, IObservador
    {
        /// <summary>
        /// Servicios para las Materias Primas.
        /// </summary>
        private readonly MateriaPrimaService service;

        public FrmBuscadorMateriasPrimas() : base ("Materias Primas")
        {
            InitializeComponent();
            service = new MateriaPrimaService();
            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(service.GetMateriasPrimas(string.Empty));
        }

        protected override void OnTxtBuscarTextChanged(string text)
        {
            LoadDataGrid(service.GetMateriasPrimas(text));
        }

        protected override void OnBtnAgregarClick(object sender, EventArgs e)
        {
            FrmEditorMateriaPrima editorMateriaPrima = new FrmEditorMateriaPrima(null);
            editorMateriaPrima.AgregarObservador(this);
            editorMateriaPrima.ShowDialog();
        }

        protected override void OnBtnModificarClick(object sender, EventArgs e)
        {
            MateriaPrimaView selected = GetSelected<MateriaPrimaView>();

            if (selected is null)
            {
                MessageBox.Show(this, "Para modificar una Materia Prima, primero debe seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MateriaPrima materiaPrima = service.GetById(selected.Id);

            if (materiaPrima is null)
            {
                MessageBox.Show(this, "No se encontró la Materia Prima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEditorMateriaPrima editorMateriaPrima = new FrmEditorMateriaPrima(materiaPrima);
            editorMateriaPrima.AgregarObservador(this);
            editorMateriaPrima.ShowDialog();
        }

        protected override void OnBtnEliminarClick(object sender, EventArgs e)
        {
            MateriaPrimaView selected = GetSelected<MateriaPrimaView>();

            if (selected is null)
            {
                MessageBox.Show(this, "Para eliminar una Materia Prima, primero debe seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MateriaPrima materiaPrima = service.GetById(selected.Id);

            if (materiaPrima is null)
            {
                MessageBox.Show(this, "No se encontró la Materia Prima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar la Materia Prima con ID: {materiaPrima.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                service.Delete(materiaPrima);

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
