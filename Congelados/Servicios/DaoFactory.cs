using Common.Utils;
using Congelados.Properties;
using Connection;

namespace Congelados.Servicios
{
    /// <summary>
    /// Clase encargada de implementarla creación de los DAO.
    /// </summary>
    internal static class DaoFactory
    {
        /// <summary>
        /// Cadena de conexión a base de datos
        /// </summary>
        private static readonly string connectionString;

        static DaoFactory()
        {
            connectionString = Settings.Default.ConnectionString;
        }

        /// <summary>
        /// Realiza la invocación de un DAO del tipo especificado.
        /// </summary>
        /// <typeparam name="TDao">Tipo de DAO a invocar.</typeparam>
        /// <param name="handler">Administrador de errores.</param>
        /// <returns>Tipo de DAO solicitado que está mapeado por el sistema.</returns>
        public static TDao Get<TDao>(ErrorHandler handler) => Factory.Invoke<TDao>(connectionString, handler);
    }
}
