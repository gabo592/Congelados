namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee propiedades asociadas a un Producto o Materia Prima.
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Obtiene o establece la Descripción del Prodcuto o Materia Prima.
        /// </summary>
        string Descripcion { get; set; }

        /// <summary>
        /// Obtiene o establece el Precio en catálogo del Producto o Materia Prima.
        /// </summary>
        decimal Precio { get; set; }

        /// <summary>
        /// Obtiene o establece la Cantidad en stock del Producto o Materia Prima.
        /// </summary>
        double Cantidad { get; set; }
    }
}
