namespace Congelados.ViewModels.Ventas
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Venta desde una vista personalizada.
    /// </summary>
    internal class DetalleVentaView
    {
        /// <summary>
        /// Identificador único del Producto a vender.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descripción del producto a vender.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Cantidad del producto a vender.
        /// </summary>
        public double Cantidad { get; set; }

        /// <summary>
        /// Precio de venta del producto.
        /// </summary>
        public decimal Precio { get; set; }

        /// <summary>
        /// Descuento aplicado en la venta del producto.
        /// </summary>
        public double Descuento { get; set; }

        /// <summary>
        /// Subtotal de la venta tomando en cuenta el precio, la cantidad y el descuento.
        /// </summary>
        public decimal SubTotal { get; set; }
    }
}
