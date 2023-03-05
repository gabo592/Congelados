using Congelados.Servicios.Base;
using Congelados.Servicios.Ubicacion;
using Congelados.ViewModels.CapitalHumano;
using Connection.Interfaces.CapitalHumano;
using Models.CapitalHumano;
using Models.Ubicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Congelados.Servicios.CapitalHumano
{
    /// <summary>
    /// Clase encargada de proveer los servicios a los Empleados.
    /// </summary>
    internal class EmpleadoService : ServicioBase
    {
        /// <summary>
        /// DAO para los Empleados.
        /// </summary>
        private readonly IEmpleadoDao empleadoDao;

        /// <summary>
        /// Servicio de Ubicaciones.
        /// </summary>
        private readonly UbicacionService ubicacionService;

        public EmpleadoService()
        {
            empleadoDao = DaoFactory.Get<IEmpleadoDao>(Handler);
            ubicacionService = new UbicacionService();
        }

        /// <summary>
        /// Crea un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del Empleado.
        /// </summary>
        /// <param name="properties">Propiedades del Empleado a agregar.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no son proporcionadas.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Empleado empleado = empleadoDao.Create(new Empleado
            {
                PrimerNombre = properties["PrimerNombre"].ToString(),
                SegundoNombre = properties["SegundoNombre"].ToString(),
                PrimerApellido = properties["PrimerApellido"].ToString(),
                SegundoApellido = properties["SegundoApellido"].ToString(),
                Cedula = properties["Cedula"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                IdMunicipio = (int)properties["IdMunicipio"]
            });

            if (empleado is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IEmpleadoDao.GetById(int)"/>
        public Empleado GetById(int id) => empleadoDao.GetById(id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por: Nombres, Apellidos, Dirección.</param>
        /// <returns>Colección de objetos de tipo Empleado desde una vista personalizada.</returns>
        public IEnumerable<EmpleadoView> GetEmpleados(string value)
        {
            IEnumerable<Empleado> empleados = empleadoDao.Read(value);

            return empleados.Select(empleado =>
            {
                Municipio municipio = ubicacionService.GetMunicipioById(empleado.IdMunicipio);
                Departamento departamento = ubicacionService.GetDepartamentoById(municipio.IdDepartamento);

                return new EmpleadoView
                {
                    Id = empleado.Id,
                    Nombres = $"{empleado.PrimerNombre} {empleado.SegundoNombre}",
                    Apellidos = $"{empleado.PrimerApellido} {empleado.SegundoApellido}",
                    Cedula = empleado.Cedula,
                    Telefono = empleado.Telefono,
                    Direccion = empleado.Direccion,
                    Municipio = municipio.Nombre,
                    Departamento = departamento.Nombre
                };
            });
        }

        /// <summary>
        /// Actualiza un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del Empleado.
        /// </summary>
        /// <param name="properties">Propiedades del Empleado a actualizar.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no son proporcionadas.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Empleado empleado = empleadoDao.Update(new Empleado
            {
                Id = (int)properties["Id"],
                PrimerNombre = properties["PrimerNombre"].ToString(),
                SegundoNombre = properties["SegundoNombre"].ToString(),
                PrimerApellido = properties["PrimerApellido"].ToString(),
                SegundoApellido = properties["SegundoApellido"].ToString(),
                Cedula = properties["Cedula"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                Estado = (bool)properties["Estado"],
                IdMunicipio = (int)properties["IdMunicipio"]
            });

            if (empleado is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina al Empleado especificado de la base de datos.
        /// </summary>
        /// <param name="empleado">Empleado a eliminar.</param>
        public void Delete(Empleado empleado)
        {
            Empleado result = empleadoDao.Delete(empleado);

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

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (ubicacionService != null && ubicacionService.HasError())
            {
                builder.AppendLine(ubicacionService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public override bool HasError() => Handler.HasError() || ubicacionService.HasError();
    }
}
