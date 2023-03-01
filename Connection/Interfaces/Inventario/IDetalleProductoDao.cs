using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para los Detalles de Productos.
    /// </summary>
    public interface IDetalleProductoDao : IDao<DetalleProducto>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con los ID de Producto y Materia Prima a filtrar.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto asociado al Detalle.</param>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociada al Detalle.</param>
        /// <returns>Objeto de tipo Detalle de Producto que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        DetalleProducto Read(int idProducto, int idMateriaPrima);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el ID de Producto a filtrar.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto asociado al Detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Producto que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleProducto> GetByIdProducto(int idProducto);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el ID de la Materia Prima a filtrar.
        /// </summary>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociada al Detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Producto que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleProducto> GetByIdMateriaPrima(int idMateriaPrima);
    }
}
