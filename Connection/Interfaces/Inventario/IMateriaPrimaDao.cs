using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para las Materias Primas.
    /// </summary>
    public interface IMateriaPrimaDao : IDao<MateriaPrima>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único para la Materia Prima a buscar.</param>
        /// <returns>Objeto de tipo Materia Prima que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        MateriaPrima GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con la descripción a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción a buscar.</param>
        /// <returns>Colección de objetos de tipo Materia Prima que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<MateriaPrima> Read(string descripcion);
    }
}
