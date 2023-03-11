using Congelados.Servicios.CapitalHumano;
using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Seguridad;
using Congelados.ViewModels.CapitalHumano;
using Models.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Congelados.Presentacion.Seguridad
{
    public partial class FrmEditorUsuario : Form, ISujeto
    {
        /// <summary>
        /// Usuario a editar.
        /// </summary>
        private readonly Usuario Usuario;

        /// <summary>
        /// Lista de observadores a los cuales ésta clase notificará los cambios.
        /// </summary>

        private readonly List<IObservador> Observadores;

        /// <summary>
        /// Servicio para los usuarios.
        /// </summary>

        private readonly UsuarioService service;

        /// <summary>
        /// Servicio para los empleados.
        /// </summary>
        private readonly EmpleadoService empleadoService;

        public FrmEditorUsuario(Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            Observadores = new List<IObservador>();
            service = new UsuarioService();
            empleadoService = new EmpleadoService();

            Init();
        }

        private void Init()
        {
            CmbRoles.SelectedIndex = 0;

            EmpleadoView[] empleados = empleadoService.GetEmpleados(string.Empty).ToArray();
            DgvEmpleados.DataSource = empleados;

            if (Usuario is null) return;

            TxtNombre.Text = Usuario.Nombre;
            TxtClave.Text = Usuario.Clave;

            CmbRoles.SelectedIndex = CmbRoles.Items.IndexOf(Usuario.Rol);

            SelectEmpleado();
        }

        private void SelectEmpleado()
        {
            foreach (DataGridViewRow row in DgvEmpleados.Rows)
            {
                int currentId = (int)row.Cells[0].Value;

                if (currentId == Usuario.IdEmpleado)
                {
                    row.Selected = true;
                    DgvEmpleados.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private EmpleadoView GetSelectedEmpleado()
        {
            EmpleadoView[] empleados = (EmpleadoView[])DgvEmpleados.DataSource;

            return empleados[DgvEmpleados.SelectedRows[0].Index];
        }

        public void AgregarObservador(IObservador observador) => Observadores.Add(observador);

        public void Notificar() => Observadores.ForEach(observador => observador.Actualizar());

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            EmpleadoView empleado = GetSelectedEmpleado();

            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Id", Usuario?.Id },
                {"Nombre", TxtNombre.Text },
                {"Clave", TxtClave.Text },
                {"Rol", CmbRoles.SelectedItem.ToString() },
                {"Estado", Usuario?.Estado },
                {"IdEmpleado", empleado.Id }
            };

            try
            {
                if (Usuario is null)
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

                if (Usuario is null) Limpiar();
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
            TxtClave.Text = string.Empty;
            TxtBuscar.Text = string.Empty;

            CmbRoles.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
