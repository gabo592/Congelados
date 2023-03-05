using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Inventario;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Congelados.Presentacion.Inventario
{
    public partial class FrmEditorMateriaPrima : Form, ISujeto
    {
        /// <summary>
        /// Lista de observadores a los que esta clase notificará los cambios.
        /// </summary>
        private readonly List<IObservador> Observadores;

        /// <summary>
        /// Servicios para las Materias Primas.
        /// </summary>
        private readonly MateriaPrimaService service;

        /// <summary>
        /// Materia Prima a editar.
        /// </summary>
        private readonly MateriaPrima MateriaPrima;

        public FrmEditorMateriaPrima(MateriaPrima materiaPrima)
        {
            InitializeComponent();
            Observadores = new List<IObservador>();
            service = new MateriaPrimaService();
            MateriaPrima = materiaPrima;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Id", MateriaPrima?.Id },
                {"Descripcion", TxtDescripcion.Text },
                {"Precio", NumPrecio.Value },
                {"Cantidad", NumCantidad.Value },
                {"Estado", MateriaPrima?.Estado }
            };

            try
            {
                if (MateriaPrima is null)
                {
                    service.Create(properties);
                }
                else
                {
                    service.Update(properties);
                }

                if (service.HasError())
                {
                    MessageBox.Show(this, service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notificar();
                MessageBox.Show(this, "¡Se ha guardado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MateriaPrima is null) Limpiar();
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
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Notificar() => Observadores.ForEach(observador => observador.Actualizar());

        public void AgregarObservador(IObservador observador) => Observadores.Add(observador);
    }
}
