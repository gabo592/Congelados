using Congelados.Servicios.CapitalHumano;
using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Ubicacion;
using Models.CapitalHumano;
using Models.Interfaces;
using Models.Ubicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Congelados.Presentacion.CapitalHumano
{
    public partial class FrmEditorEmpleado : Form, ISujeto
    {
        #region Private Fields

        /// <summary>
        /// Empleado a editar.
        /// </summary>
        private readonly Empleado Empleado;

        /// <summary>
        /// Servicio para Empleados.
        /// </summary>
        private readonly EmpleadoService Service;

        /// <summary>
        /// Lista de Observadores a los cuales ésta clase notifica los cambios.
        /// </summary>
        private readonly List<IObservador> Observadores;

        /// <summary>
        /// Servicio para las ubicaciones.
        /// </summary>
        private readonly UbicacionService UbicacionService;

        #endregion

        public FrmEditorEmpleado(Empleado empleado)
        {
            InitializeComponent();
            Empleado = empleado;
            Service = new EmpleadoService();
            UbicacionService = new UbicacionService();
            Observadores = new List<IObservador>();
            LoadComboBox();
            Init();
        }

        private void Init()
        {
            if (Empleado is null) return;

            TxtPrimerNombre.Text = Empleado.PrimerNombre;
            TxtSegundoNombre.Text = Empleado.SegundoNombre;
            TxtPrimerApellido.Text = Empleado.PrimerApellido;
            TxtSegundoApellido.Text = Empleado.SegundoApellido;
            TxtCedula.Text = Empleado.Cedula;
            TxtTelefono.Text = Empleado.Telefono;
            TxtDireccion.Text = Empleado.Direccion;

            Municipio municipio = UbicacionService.GetMunicipioById(Empleado.IdMunicipio);

            if (municipio is null) return;

            Departamento departamento = UbicacionService.GetDepartamentoById(municipio.IdDepartamento);

            if (departamento is null) return;

            Departamento[] departamentos = (Departamento[])CmbDepartamentos.DataSource;
            CmbDepartamentos.SelectedItem = departamentos.FirstOrDefault(value => value.Id == departamento.Id);

            Municipio[] municipios = (Municipio[])CmbMunicipios.DataSource;
            CmbMunicipios.SelectedItem = municipios.FirstOrDefault(value => value.Id == municipio.Id);
        }

        private void LoadComboBox()
        {
            CmbDepartamentos.DataSource = UbicacionService.GetDepartamentos(string.Empty).ToArray();
            CmbDepartamentos.DisplayMember = nameof(INameable.Nombre);

            Departamento departamento = (Departamento)CmbDepartamentos.SelectedItem;

            CmbMunicipios.DataSource = UbicacionService.GetMunicipios(departamento.Id).ToArray();
            CmbMunicipios.DisplayMember = nameof(INameable.Nombre);
        }

        private void LoadMunicipios()
        {
            Departamento departamento = (Departamento)CmbDepartamentos.SelectedItem;
            CmbMunicipios.DataSource = UbicacionService.GetMunicipios(departamento.Id).ToArray();
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
        }

        private void CmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMunicipios();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Municipio municipio = (Municipio)CmbMunicipios.SelectedItem;

            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Id", Empleado?.Id },
                {"PrimerNombre", TxtPrimerNombre.Text },
                {"SegundoNombre", TxtSegundoNombre.Text },
                {"PrimerApellido", TxtPrimerApellido.Text },
                {"SegundoApellido", TxtSegundoApellido.Text },
                {"Cedula", TxtCedula.Text },
                {"Telefono", TxtTelefono.Text },
                {"Direccion", TxtDireccion.Text },
                {"Estado", Empleado?.Estado },
                {"IdMunicipio", municipio.Id }
            };

            try
            {
                if (Empleado is null)
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

                if (Empleado is null) Limpiar();
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
            TxtPrimerNombre.Text = string.Empty;
            TxtSegundoNombre.Text = string.Empty;
            TxtPrimerApellido.Text = string.Empty;
            TxtSegundoApellido.Text = string.Empty;
            TxtCedula.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtDireccion.Text = string.Empty;

            CmbDepartamentos.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Notificar() => Observadores.ForEach(observador => observador.Actualizar());

        public void AgregarObservador(IObservador observador) => Observadores.Add(observador);
    }
}
