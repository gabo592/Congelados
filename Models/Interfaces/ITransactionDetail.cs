namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee atributos donde se especifican los detalles de una transacción.
    /// </summary>
    public interface ITransactionDetail
    {
        /// <summary>
        /// Obtiene o establece la Cantidad de un Producto o Materia Prima en una transacción.
        /// </summary>
        double Cantidad { get; set; }

        /// <summary>
        /// Obtiene o establece el Descuento aplicado al Producto o Materia Prima en la transacción.
        /// </summary>
        double Descuento { get; set; }
    }
}
