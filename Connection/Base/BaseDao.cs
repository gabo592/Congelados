using Common.Utils;
using System.Collections.Generic;

namespace Connection.Base
{
    /// <summary>
    /// Clase encargada de proveer los métodos para la implementación del acceso a datos de un objeto.
    /// </summary>
    internal abstract class BaseDao<TModel> : IDao<TModel> where TModel : new()
    {
        /// <summary>
        /// Instancia de la clase encargada de comunicarse con la base de datos.
        /// </summary>
        private readonly Database Database;

        public BaseDao(string connectionString, ErrorHandler handler)
        {
            Database = new Database(connectionString, handler);
        }

        public abstract TModel Create(TModel model);

        public abstract TModel Delete(TModel model);

        public abstract IEnumerable<TModel> Read();

        public abstract TModel Update(TModel model);

        /// <inheritdoc cref="Database.Read{TModel}(string, IDictionary{string, object})"/>
        public IEnumerable<TModel> Read(string procedure, IDictionary<string, object> parameters = null) => Database.Read<TModel>(procedure, parameters);
    }
}
