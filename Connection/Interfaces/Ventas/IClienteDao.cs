using Connection.Base;
using Models.Ventas;
using System.Collections.Generic;

namespace Connection.Interfaces.Ventas
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para los Clientes.
    /// </summary>
    public interface IClienteDao : IDao<Cliente>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Cliente a buscar.</param>
        /// <returns>Objeto de tipo Cliente que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        Cliente GetById(int id);

        /// <summary>
        /// Realiza un búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por Nombres, Apellidos o Dirección.</param>
        /// <returns>Colección de objetos de tipo Cliente que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Cliente> Read(string value);

        /// <summary>
        /// Realiza un búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID del Municipio a filtrar.
        /// </summary>
        /// <param name="idMunicipio">Identificador único del Municipio asociado a los Clientes a encontrar.</param>
        /// <returns>Colección de objetos de tipo Cliente que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Cliente> GetByIdMunicipio(int idMunicipio);
    }
}
