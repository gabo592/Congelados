using Models.Interfaces;

namespace Models.CapitalHumano
{
    /// <summary>
    /// Objeto simple de tipo Empleado.
    /// </summary>
    public class Empleado : IIdentity, IPerson, IActivable
    {
        public int Id { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        /// <summary>
        /// Obtiene o establece el número de Cédula del Empleado.
        /// </summary>
        public string Cedula { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public bool Estado { get; set; }

        public int IdMunicipio { get; set; }
    }
}
