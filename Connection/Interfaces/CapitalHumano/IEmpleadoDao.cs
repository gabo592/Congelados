using Connection.Base;
using Models.CapitalHumano;
using System.Collections.Generic;

namespace Connection.Interfaces.CapitalHumano
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para los Empleados.
    /// </summary>
    public interface IEmpleadoDao : IDao<Empleado>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Empleado a buscar.</param>
        /// <returns>Objeto de tipo Empleado que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        Empleado GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar, puede ser: Nombres, Apellidos o Dirección.</param>
        /// <returns>Colección de objetos de tipo Empleado que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Empleado> Read(string value);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el ID de Municipio a filtrar.
        /// </summary>
        /// <param name="idMunicipio">Identificador único del Municipio asociado al Empleado.</param>
        /// <returns>Colección de objetos de tipo Empleado que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Empleado> GetByIdMunicipio(int idMunicipio);
    }
}
