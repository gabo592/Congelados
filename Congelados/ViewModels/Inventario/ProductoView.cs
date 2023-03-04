namespace Congelados.ViewModels.Inventario
{
    /// <summary>
    /// Objeto simle de tipo Producto desde una vista personalizada.
    /// </summary>
    internal class ProductoView
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public double Cantidad { get; set; }

        public string Categoria { get; set; }
    }
}
