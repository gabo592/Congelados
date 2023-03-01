using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para los Productos.
    /// </summary>
    public interface IProductoDao : IDao<Producto>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Producto a buscar.</param>
        /// <returns>Objeto de tipo Producto que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        Producto GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con la Descripción a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción del Producto a buscar.</param>
        /// <returns>Colección de objetos de tipo Producto que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Producto> Read(string descripcion);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID de la Categoría a filtrar.
        /// </summary>
        /// <param name="idCategoria">Identificador único de la Categoría de Producto a buscar.</param>
        /// <returns>Colección de objetos de tipo Producto que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Producto> GetByIdCategoria(int idCategoria);
    }
}
