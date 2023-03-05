using Congelados.Servicios.Base;
using Congelados.ViewModels.Compras;
using Connection.Interfaces.Compras;
using Models.Compras;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Congelados.Servicios.Compras
{
    /// <summary>
    /// Clase encargada de proveer los servicios a los Proveedores.
    /// </summary>
    internal class ProveedorService : ServicioBase
    {
        /// <summary>
        /// DAO para los Proveedores.
        /// </summary>
        private readonly IProveedorDao proveedorDao;

        public ProveedorService()
        {
            proveedorDao = DaoFactory.Get<IProveedorDao>(Handler);
        }

        /// <summary>
        /// Crea un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Proveedor a crear.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Proveedor proveedor = proveedorDao.Create(new Proveedor
            {
                Nombre = properties["Nombre"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString()
            });

            if (proveedor is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IProveedorDao.GetById(int)"/>
        public Proveedor GetById(int id) => proveedorDao.GetById(id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por Nombre o Dirección.</param>
        /// <returns>Colección de objetos de tipo Proveedor desde una vista personalizada.</returns>
        public IEnumerable<ProveedorView> GetProveedores(string value)
        {
            IEnumerable<Proveedor> proveedores = proveedorDao.Read(value);

            return proveedores.Select(proveedor =>
            {
                return new ProveedorView
                {
                    Id = proveedor.Id,
                    Nombre = proveedor.Nombre,
                    Telefono = proveedor.Telefono,
                    Direccion = proveedor.Direccion
                };
            });
        }

        /// <summary>
        /// Actualiza un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Proveedor a actualizar.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Proveedor proveedor = proveedorDao.Update(new Proveedor
            {
                Id = (int)properties["Id"],
                Nombre = properties["Nombre"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                Estado = (bool)properties["Estado"]
            });

            if (proveedor is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina el Proveedor especificado de la base de datos.
        /// </summary>
        /// <param name="proveedor">Proveedor a eliminar.</param>
        public void Delete(Proveedor proveedor)
        {
            Proveedor result = proveedorDao.Delete(proveedor);

            if (result is null) Handler.Add("MODELO_NULO");
        }

        public override void Dispose() => Handler.Clear();

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
