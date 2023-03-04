using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Inventario;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Congelados.Presentacion.Inventario
{
    public partial class FrmEditorCategoriaProducto : Form, ISujeto
    {
        /// <summary>
        /// Categoría de Producto a editar.
        /// </summary>
        private readonly CategoriaProducto Categoria;

        /// <summary>
        /// Lista de Observadores a los que esta clase notificará los cambios.
        /// </summary>
        private readonly List<IObservador> Observadores;

        /// <summary>
        /// Servicio para las Categorías de Productos.
        /// </summary>
        private readonly CategoriaProductoService Service;

        public FrmEditorCategoriaProducto(CategoriaProducto categoria)
        {
            InitializeComponent();
            Observadores = new List<IObservador>();
            Service = new CategoriaProductoService();
            Categoria = categoria;
            Init();
        }

        private void Init()
        {
            if (Categoria is null) return;

            TxtNombre.Text = Categoria.Nombre;
            TxtDescripcion.Text = Categoria.Descripcion;
        }

        public void AgregarObservador(IObservador observador) => Observadores.Add(observador);

        public void Notificar() => Observadores.ForEach(observador => observador.Actualizar());

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Id", Categoria?.Id },
                {"Nombre", TxtNombre.Text },
                {"Descripcion", TxtDescripcion.Text },
                {"Estado", Categoria?.Estado }
            };

            try
            {
                if (Categoria is null)
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

                if (Categoria is null) Limpiar();
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
            TxtDescripcion.Text = string.Empty;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
