using Connection.Base;
using Models.Compras;
using System.Collections.Generic;

namespace Connection.Interfaces.Compras
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para los Proveedores.
    /// </summary>
    public interface IProveedorDao : IDao<Proveedor>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Proveedor a buscar.</param>
        /// <returns>Objeto de tipo Proveedor que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        Proveedor GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda, puede ser por: Nombre o Dirección.</param>
        /// <returns>Colección de objetos de tipo Proveedor que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Proveedor> Read(string value);
    }
}
