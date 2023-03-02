using Common.Utils;

namespace Congelados.Servicios.Base
{
    /// <summary>
    /// Clase encargada de proveer los métodos y propiedades necesarios para proveer servicios.
    /// </summary>
    internal abstract class ServicioBase : IServicioBase
    {
        /// <summary>
        /// Instancia del Administrador de Errores.
        /// </summary>
        protected readonly ErrorHandler Handler;

        public ServicioBase()
        {
            Handler = new ErrorHandler();
        }

        public abstract void Dispose();

        public abstract string GetErrorMessage();

        public abstract bool HasError();
    }
}
