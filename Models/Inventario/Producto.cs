using Models.Interfaces;

namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Producto.
    /// </summary>
    public class Producto : IIdentity, IProduct, IActivable
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public double Cantidad { get; set; }

        public bool Estado { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único de la Categoría de Producto a la que está asociado.
        /// </summary>
        public int IdCategoria { get; set; }
    }
}
