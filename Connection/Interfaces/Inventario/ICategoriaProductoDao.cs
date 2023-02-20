using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementa los métodos para el acceso a datos para las Categoría de Productos.
    /// </summary>
    public interface ICategoriaProductoDao : IDao<CategoriaProducto>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único de la Categoría de Producto a buscar.</param>
        /// <returns>Objeto de tipo Categoría de Producto que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        CategoriaProducto GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por Nombre o Descripción.</param>
        /// <returns>Colección de objetos de tipo Categoría de Producto que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<CategoriaProducto> Read(string value);
    }
}
