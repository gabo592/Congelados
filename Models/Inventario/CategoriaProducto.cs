using Models.Interfaces;

namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Categoría de Producto.
    /// </summary>
    public class CategoriaProducto : IIdentity, INameable, IActivable
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece la Descripción de la Categoría de Producto.
        /// </summary>
        public string Descripcion { get; set; }

        public bool Estado { get; set; }
    }
}
