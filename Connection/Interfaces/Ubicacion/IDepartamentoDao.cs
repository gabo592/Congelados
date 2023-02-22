using Connection.Base;
using Models.Ubicacion;
using System.Collections.Generic;

namespace Connection.Interfaces.Ubicacion
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para los Departamentos.
    /// </summary>
    public interface IDepartamentoDao : IDao<Departamento>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Departamento a buscar.</param>
        /// <returns>Objeto de tipo Departamento que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        Departamento GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el Nombre a filtrar.
        /// </summary>
        /// <param name="nombre">Nombre del Departamento a filtrar.</param>
        /// <returns>Colección de objetos de tipo Departamento que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Departamento> Read(string nombre);
    }
}
