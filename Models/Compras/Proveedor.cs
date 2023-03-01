using Models.Interfaces;

namespace Models.Compras
{
    /// <summary>
    /// Objeto simple de tipo Proveedor.
    /// </summary>
    public class Proveedor : IIdentity, INameable, IActivable
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece el número de teléfono del Proveedor.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Obtiene o establece la Dirección donde se encuentra el Proveedor.
        /// </summary>
        public string Direccion { get; set; }

        public bool Estado { get; set; }
    }
}
