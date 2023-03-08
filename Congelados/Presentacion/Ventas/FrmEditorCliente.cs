using Congelados.Servicios.Interfaces;
using Congelados.Servicios.Ubicacion;
using Congelados.Servicios.Ventas;
using Models.Interfaces;
using Models.Ubicacion;
using Models.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Congelados.Presentacion.Ventas
{
    public partial class FrmEditorCliente : Form, ISujeto
    {
        /// <summary>
        /// Cliente a editar.
        /// </summary>
        private readonly Cliente Cliente;

        /// <summary>
        /// Servicio para los Clientes.
        /// </summary>
        private readonly ClienteService Service;

        /// <summary>
        /// Lista de observadores a los que esta clase notificará los cambios.
        /// </summary>
        private readonly List<IObservador> Observadores;

        /// <summary>
        /// Servicio de ubicaciones.
        /// </summary>
        private readonly UbicacionService UbicacionService;

        public FrmEditorCliente(Cliente cliente)
        {
            InitializeComponent();
            Cliente = cliente;
            Service = new ClienteService();
            Observadores = new List<IObservador>();
            UbicacionService = new UbicacionService();

            LoadComboBox();
            Init();
        }

        private void Init()
        {
            if (Cliente is null) return;

            TxtPrimerNombre.Text = Cliente.PrimerNombre;
            TxtSegundoNombre.Text = Cliente.SegundoNombre;
            TxtPrimerApellido.Text = Cliente.PrimerApellido;
            TxtSegundoApellido.Text = Cliente.SegundoApellido;
            TxtTelefono.Text = Cliente.Telefono;
            TxtDireccion.Text = Cliente.Direccion;

            Municipio municipio = UbicacionService.GetMunicipioById(Cliente.IdMunicipio);

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

        public void AgregarObservador(IObservador observador) => Observadores.Add(observador);

        public void Notificar() => Observadores.ForEach(observador => observador.Actualizar());

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
                {"Id", Cliente?.Id },
                {"PrimerNombre", TxtPrimerNombre.Text },
                {"SegundoNombre", TxtSegundoNombre.Text },
                {"PrimerApellido", TxtPrimerApellido.Text },
                {"SegundoApellido", TxtSegundoApellido.Text },
                {"Telefono", TxtTelefono.Text },
                {"Direccion", TxtDireccion.Text },
                {"Estado", Cliente?.Estado },
                {"IdMunicipio", municipio.Id }
            };

            try
            {
                if (Cliente is null)
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

                if (Cliente is null) Limpiar();
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
            TxtTelefono.Text = string.Empty;
            TxtDireccion.Text = string.Empty;

            CmbDepartamentos.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
