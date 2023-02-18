using Models.Interfaces;

namespace Models.Ventas
{
    /// <summary>
    /// Objeto simple de tipo Cliente.
    /// </summary>
    public class Cliente : IIdentity, IPerson, IActivable
    {
        public int Id { get; set; }
        
        public string PrimerNombre { get; set; }
        
        public string SegundoNombre { get; set; }
        
        public string PrimerApellido { get; set; }
        
        public string SegundoApellido { get; set; }
        
        public string Telefono { get; set; }
        
        public string Direccion { get; set; }

        public bool Estado { get; set; }

        public int IdMunicipio { get; set; }
    }
}
