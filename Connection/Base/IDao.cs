using System.Collections.Generic;

namespace Connection.Base
{
    /// <summary>
    /// Indica que una clase implementa los métodos necesarios para el acceso a datos de los modelos.
    /// </summary>
    public interface IDao<TModel> where TModel : new()
    {
        /// <summary>
        /// Crea un registro dentro de la base de datos a partir de un objeto del tipo especificado.
        /// </summary>
        /// <param name="model">Modelo a crear en la base de datos.</param>
        /// <returns>Objeto ya creado en la base de datos del tipo especificado; en caso de algún error, retorna nulo.</returns>
        TModel Create(TModel model);

        /// <summary>
        /// Obtiene los registros de la base de datos para los modelos del tipo especificado.
        /// </summary>
        /// <returns>Colección genérica de objetos del tipo especificado; en caso de algún error, retorna nulo.</returns>
        IEnumerable<TModel> Read();

        /// <summary>
        /// Actualiza un registro de la base de datos a partir de un objeto del tipo especificado.
        /// </summary>
        /// <param name="model">Modelo a actualizar en la base de datos.</param>
        /// <returns>Objeto ya actualizado en la base de datos del tipo especificado; en caso de algún error, retorna nulo.</returns>
        TModel Update(TModel model);

        /// <summary>
        /// Elimina un registro de la base de datos a paritr de un objeto del tipo especificado.
        /// </summary>
        /// <param name="model">Modelo a eliminar de la base de datos.</param>
        /// <returns>Objeto ya eliminado de la base de datos; en caso de algún error, retorna nulo.</returns>
        TModel Delete(TModel model);
    }
}
