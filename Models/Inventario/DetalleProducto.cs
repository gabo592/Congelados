namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Producto.
    /// </summary>
    public class DetalleProducto
    {
        /// <summary>
        /// Obtiene o establece el identificador único para el Producto asociado en el Detalle.
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único para la Materia Prima asociada en el Detalle.
        /// </summary>
        public int IdMateriaPrima { get; set; }

        /// <summary>
        /// Obtiene o establece la Cantidad utilizada de Materia Prima en la elaboración del Producto.
        /// </summary>
        public double Cantidad { get; set; }
    }
}
