using Models.Interfaces;

namespace Models.Ventas
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Venta.
    /// </summary>
    public class DetalleVenta : ITransactionDetail
    {
        /// <summary>
        /// Obtiene o establece el identificador único de la Venta asociada al Detalle.
        /// </summary>
        public int IdVenta { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del Producto asociado al Detalle.
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Obtiene o establece el Precio de Venta del Producto.
        /// </summary>
        public decimal Precio { get; set; }

        public double Cantidad { get; set; }

        public double Descuento { get; set; }
    }
}
