using Models.Interfaces;

namespace Models.Seguridad
{
    /// <summary>
    /// Objeto simple de tipo Usuario.
    /// </summary>
    public class Usuario : IIdentity, INameable, ISecurity, IActivable
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Clave { get; set; }

        /// <summary>
        /// Obtiene o establece el Rol del Usuario dentro del sistema.
        /// </summary>
        public string Rol { get; set; }

        public bool Estado { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del Empleado asociado a este Usuario.
        /// </summary>
        public int IdEmpleado { get; set; }
    }
}
