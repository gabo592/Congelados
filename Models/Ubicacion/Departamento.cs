using Models.Interfaces;

namespace Models.Ubicacion
{
    /// <summary>
    /// Objeto simple de tipo Departamento.
    /// </summary>
    public class Departamento : IIdentity, INameable
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
