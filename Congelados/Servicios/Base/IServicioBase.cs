using System;

namespace Congelados.Servicios.Base
{
    /// <summary>
    /// Indica que una clase implementará los métodos básicos necesarios para proveer servicios.
    /// </summary>
    internal interface IServicioBase : IDisposable
    {
        /// <summary>
        /// Busca dentro del Administrador de Errores los mensajes de error.
        /// </summary>
        /// <returns>Mensajes de errores contenidos a lo largo de la ejecución del programa.</returns>
        string GetErrorMessage();

        /// <summary>
        /// Verifica si el Sdministrador de Errores contiene errores almacenados
        /// </summary>
        /// <returns></returns>
        bool HasError();
    }
}
