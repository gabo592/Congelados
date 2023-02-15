using Models.Interfaces;

namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Materia Prima.
    /// </summary>
    public class MateriaPrima : IIdentity, IProduct, IActivable
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }
        
        public decimal Precio { get; set; }
        
        public double Cantidad { get; set; }

        public bool Estado { get; set; }
    }
}
