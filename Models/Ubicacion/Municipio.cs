using Models.Interfaces;

namespace Models.Ubicacion
{
    /// <summary>
    /// Objeto simple de tipo Municipio.
    /// </summary>
    public class Municipio : IIdentity, INameable
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del Departamento asociado al Municipio.
        /// </summary>
        public int IdDepartamento { get; set; }
    }
}
