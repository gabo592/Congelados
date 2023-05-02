namespace Congelados.ViewModels.Compras
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Compra desde una vista personalizada.
    /// </summary>
    internal class DetalleCompraView
    {
        /// <summary>
        /// Obtiene o establece el identificador único de la Materia Prima.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene o establece la descripción de la Materia Prima.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad a comprar de Materia Prima.
        /// </summary>
        public double Cantidad { get; set; }

        /// <summary>
        /// Obtiene o establece el costo de la compra de Materia Prima.
        /// </summary>
        public decimal Costo { get; set; }

        /// <summary>
        /// Obtiene o establece el descuento aplicado a la compra de la Materia Prima.
        /// </summary>
        public double Descuento { get; set; }

        /// <summary>
        /// Obtiene o establece el subtotal de la compra.
        /// </summary>
        public decimal SubTotal { get; set; }
    }
}
