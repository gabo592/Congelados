using Connection.Base;
using Models.Compras;
using System.Collections.Generic;

namespace Connection.Interfaces.Compras
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para los Detalles de Compra.
    /// </summary>
    public interface IDetalleCompraDao : IDao<DetalleCompra>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con los ID de Compra y Materia Prima a filtrar.
        /// </summary>
        /// <param name="idCompra">Identificador único de la Compra asociada al Detalle.</param>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociada al Detalle.</param>
        /// <returns>Objeto de tipo Detalle de Compra que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        DetalleCompra Read(int idCompra, int idMateriaPrima);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID de la Compra a filtrar.
        /// </summary>
        /// <param name="idCompra">Identificador único de la Compra asociada al Detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleCompra> GetByIdCompra(int idCompra);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID de la Materia Prima a filtrar.
        /// </summary>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociada al Detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<DetalleCompra> GetByIdMateriaPrima(int idMateriaPrima);
    }
}
