using Models.Seguridad;

namespace Congelados.Servicios.Base
{
    /// <summary>
    /// Clase encargada de contener los valores globales de sesión a utilizar propios del usuario.
    /// </summary>
    internal static class Session
    {
        /// <summary>
        /// Perfil de autenticación del Usuario .
        /// </summary>
        public static Usuario Usuario { get; private set; }

        /// <summary>
        /// Indica si existe una sesión activa dentro del sistema.
        /// </summary>
        public static bool IsActive => Usuario != null && !Usuario.Id.Equals(default) && Usuario.Estado;

        public static void Set(Usuario usuario)
        {
            if (usuario is null || usuario.Id.Equals(default))
            {
                Close();
                return;
            }

            Usuario = usuario;
        }

        /// <summary>
        /// Cierra la sesión actual.
        /// </summary>
        private static void Close() => Usuario = null;
    }
}
