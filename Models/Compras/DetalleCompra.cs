using Models.Interfaces;

namespace Models.Compras
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Compra.
    /// </summary>
    public class DetalleCompra : ITransactionDetail
    {
        /// <summary>
        /// Obtiene o establece el identificador único de la Compra asociada al Detalle.
        /// </summary>
        public int IdCompra { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único de la Materia Prima asociada al Detalle.
        /// </summary>
        public int IdMateriaPrima { get; set; }

        /// <summary>
        /// Obtiene o establece el Costo aplicado por la Materia Prima en la Compra.
        /// </summary>
        public decimal Costo { get; set; }

        public double Cantidad { get; set; }

        public double Descuento { get; set; }
    }
}
