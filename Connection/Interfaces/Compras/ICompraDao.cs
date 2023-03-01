using Connection.Base;
using Models.Compras;
using System;
using System.Collections.Generic;

namespace Connection.Interfaces.Compras
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para las Compras.
    /// </summary>
    public interface ICompraDao : IDao<Compra>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único de la Compra a buscar.</param>
        /// <returns>Objeto de tipo Compra que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        Compra GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con la fecha a filtrar.
        /// </summary>
        /// <param name="fecha">Fecha de Compra a filtrar.</param>
        /// <returns>Colección de objetos de tipo Compra que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Compra> Read(DateTime fecha);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que se encuentren dentro del rango de fecha especificado.
        /// </summary>
        /// <param name="fechaInicio">Fecha de la Compra a iniciar la búsqueda.</param>
        /// <param name="fechaFinal">Fecha de la Compra a finalizar la búsqueda.</param>
        /// <returns>Colección de objetos de tipo Compra que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Compra> Read(DateTime fechaInicio, DateTime fechaFinal);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID del Proveedor asociado a la Compra.
        /// </summary>
        /// <param name="idProveedor">Identificador único del Proveedor asociado a la Compra.</param>
        /// <returns>Colección de objetos de tipo Compra que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Compra> GetByIdProveedor(int idProveedor);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID del Empleado asociado a la Compra.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado asociado a la Compra.</param>
        /// <returns>Colección de objetos de tipo Compra que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Compra> GetByIdEmpleado(int idEmpleado);
    }
}
