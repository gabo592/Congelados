using Connection.Base;
using Models.Ubicacion;
using System.Collections.Generic;

namespace Connection.Interfaces.Ubicacion
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para los Municipios.
    /// </summary>
    public interface IMunicipioDao : IDao<Municipio>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Municipio a buscar.</param>
        /// <returns>Objeto de tipo Municipio que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        Municipio GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el Nombre a filtrar.
        /// </summary>
        /// <param name="nombre">Nombre del Municipio a buscar.</param>
        /// <returns>Colección de objetos de tipo Municipio que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Municipio> Read(string nombre);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID del Departamento a filtrar.
        /// </summary>
        /// <param name="idDepartamento">Identificador único del Departamento asociado a los Municipios a buscar.</param>
        /// <returns>Colección de objetos de tipo Municipio que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Municipio> GetByIdDepartamento(int idDepartamento);
    }
}
