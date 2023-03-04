using Congelados.Servicios.Compras;
using Congelados.Servicios.Interfaces;
using Models.Compras;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Congelados.Presentacion.Compras
{
    public partial class FrmEditorProveedor : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Proveedor a editar.
        /// </summary>
        private readonly Proveedor Proveedor;

        /// <summary>
        /// Servicios para los Proveedores
        /// </summary>
        private readonly ProveedorService Service;

        /// <summary>
        /// Lista de Observadores a los cuales ésta clase notificará los cambios.
        /// </summary>
        private readonly List<IObservador> Observadores;

        #endregion

        public FrmEditorProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            Service = new ProveedorService();
            Observadores = new List<IObservador>();
            Proveedor = proveedor;
            Init();
        }

        private void Init()
        {
            if (Proveedor is null) return;

            TxtNombre.Text = Proveedor.Nombre;
            TxtTelefono.Text = Proveedor.Telefono;
            TxtDireccion.Text = Proveedor.Direccion;
        }

        public void AgregarObservador(IObservador observador) => Observadores.Add(observador);

        public void Notificar() => Observadores.ForEach(observador => observador.Actualizar());

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Id", Proveedor?.Id },
                {"Nombre", TxtNombre.Text },
                {"Telefono", TxtTelefono.Text },
                {"Direccion", TxtDireccion.Text },
                {"Estado", Proveedor?.Estado }
            };

            try
            {
                if (Proveedor is null)
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

                if (Proveedor is null) Limpiar();
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
            TxtNombre.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
