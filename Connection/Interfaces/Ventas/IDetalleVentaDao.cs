using Connection.Base;
using Models.Ventas;
using System.Collections.Generic;

namespace Connection.Interfaces.Ventas
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para los Detalles de Venta.
    /// </summary>
    public interface IDetalleVentaDao : IDao<DetalleVenta>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con los ID de Venta y Producto a filtrar.
        /// </summary>
        /// <param name="idVenta">Identificador único de la Venta asociada al Detalle a buscar.</param>
        /// <param name="idProducto">Identificador único del Producto asociado al Detalle a buscar.</param>
        /// <returns>Objeto de tipo Detalle de Venta que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        DetalleVenta Read(int idVenta, int idProducto);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID de Venta a filtrar.
        /// </summary>
        /// <param name="idVenta">Identificador único de la Venta asociada al Detalle a buscar.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleVenta> GetByIdVenta(int idVenta);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID de Producto a filtrar.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto asociado al Detalle a buscar.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleVenta> GetByIdProducto(int idProducto);
    }
}
