namespace Congelados.ViewModels.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Materia Prima desde una vista personalizada.
    /// </summary>
    internal class MateriaPrimaView
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public double Cantidad { get; set; }
    }
}
