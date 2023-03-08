using Congelados.Servicios.Base;
using Congelados.Servicios.Ubicacion;
using Congelados.ViewModels.Ventas;
using Connection.Interfaces.Ventas;
using Models.Ubicacion;
using Models.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Congelados.Servicios.Ventas
{
    /// <summary>
    /// Clase encargada de proveer los servicios para los Clientes.
    /// </summary>
    internal class ClienteService : ServicioBase
    {
        /// <summary>
        /// DAO para los Clientes.
        /// </summary>
        private readonly IClienteDao clienteDao;

        /// <summary>
        /// Servicio de ubicaciones.
        /// </summary>

        private readonly UbicacionService ubicacionService;

        public ClienteService()
        {
            clienteDao = DaoFactory.Get<IClienteDao>(Handler);
            ubicacionService = new UbicacionService();
        }

        /// <summary>
        /// Crea un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Cliente.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades no pueden ser nulas.");

            Cliente cliente = clienteDao.Create(new Cliente
            {
                PrimerNombre = properties["PrimerNombre"].ToString(),
                SegundoNombre = properties["SegundoNombre"].ToString(),
                PrimerApellido = properties["PrimerApellido"].ToString(),
                SegundoApellido = properties["SegundoApellido"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                IdMunicipio = (int)properties["IdMunicipio"]
            });

            if (cliente is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IClienteDao.GetById(int)"/>
        public Cliente GetById(int id) => clienteDao.GetById(id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por: Nombres, Apellidos, Dirección.</param>
        /// <returns>Colección de objetos de tipo Cliente desde una vista personalizada.</returns>
        public IEnumerable<ClienteView> GetClientes(string value)
        {
            IEnumerable<Cliente> clientes = clienteDao.Read(value);

            return clientes.Select(cliente =>
            {
                Municipio municipio = ubicacionService.GetMunicipioById(cliente.IdMunicipio);
                Departamento departamento = ubicacionService.GetDepartamentoById(municipio.IdDepartamento);

                return new ClienteView
                {
                    Id = cliente.Id,
                    Nombres = $"{cliente.PrimerNombre} {cliente.SegundoNombre}",
                    Apellidos = $"{cliente.PrimerApellido} {cliente.SegundoApellido}",
                    Telefono = cliente.Telefono,
                    Direccion = cliente.Direccion,
                    Municipio = municipio.Nombre,
                    Departamento = departamento.Nombre
                };
            });
        }

        /// <summary>
        /// Actualiza un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Cliente.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades no pueden ser nulas.");

            Cliente cliente = clienteDao.Update(new Cliente
            {
                Id = (int)properties["Id"],
                PrimerNombre = properties["PrimerNombre"].ToString(),
                SegundoNombre = properties["SegundoNombre"].ToString(),
                PrimerApellido = properties["PrimerApellido"].ToString(),
                SegundoApellido = properties["SegundoApellido"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                Estado = (bool)properties["Estado"],
                IdMunicipio = (int)properties["IdMunicipio"]
            });

            if (cliente is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina el Clientes especificado de la base de datos.
        /// </summary>
        /// <param name="cliente">Cliente a eliminar.</param>
        public void Delete(Cliente cliente)
        {
            Cliente result = clienteDao.Delete(cliente);

            if (result is null) Handler.Add("MODELO_NULO");
        }

        public override void Dispose()
        {
            Handler.Clear();
            ubicacionService.Dispose();
        }

        public override string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (ubicacionService.HasError())
            {
                builder.AppendLine(ubicacionService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public override bool HasError() => Handler.HasError() || ubicacionService.HasError();
    }
}
