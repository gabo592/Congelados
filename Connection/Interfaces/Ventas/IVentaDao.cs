using Connection.Base;
using Models.Ventas;
using System;
using System.Collections.Generic;

namespace Connection.Interfaces.Ventas
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para las Ventas.
    /// </summary>
    public interface IVentaDao : IDao<Venta>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único de la Venta a buscar.</param>
        /// <returns>Objeto de tipo Venta que resulten de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        Venta GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con la Fecha a filtrar.
        /// </summary>
        /// <param name="fecha">Fecha de las Ventas a buscar.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Venta> Read(DateTime fecha);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que se encuentren dentro del rango de fecha especificado.
        /// </summary>
        /// <param name="fechaInicio">Fecha de la Venta a iniciar la búsqueda.</param>
        /// <param name="fechaFinal">Fecha de la Venta a finalizar la búsqueda.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Venta> Read(DateTime fechaInicio, DateTime fechaFinal);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID del Cliente a filtrar.
        /// </summary>
        /// <param name="idCliente">Identificador único del Cliente asociado a la Venta a buscar.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Venta> GetByIdCliente(int idCliente);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID del Empleado a filtrar.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado asociado a la Venta a buscar.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Venta> GetByIdEmpleado(int idEmpleado);
    }
}
