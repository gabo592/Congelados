using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace Common.Utils
{
    /// <summary>
    /// Clase encargada de manejar los errores dentro de la aplicación.
    /// </summary>
    public class ErrorHandler : List<string>
    {
        /// <summary>
        /// Agrega una excepción al administrador de errores.
        /// </summary>
        /// <param name="exception">Excepción a agregar.</param>
        public void Add(Exception exception)
        {
            if (exception is null) return;

            if (exception.InnerException != null)
            {
                Add(exception.InnerException);
                return;
            }

            Add(exception.Message);
        }

        /// <summary>
        /// Verifica si el administrador contiene errores almacenados.
        /// </summary>
        /// <returns>Verdadero si contiene errores; de lo contrario, Falso.</returns>
        public bool HasError() => Count > 0;

        /// <summary>
        /// Obtiene todos los mensajes que contienen los errores almacenados por el administrador.
        /// </summary>
        /// <returns>Mensajes de errores almacenados.</returns>
        public string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            ResourceManager resourceManager = new ResourceManager(typeof(Resources.Messages));

            foreach (string value in this)
            {
                string message = resourceManager.GetString(value);

                if (message is null) message = value;

                builder.AppendLine(message);
            }

            return builder.ToString();
        }
    }
}
