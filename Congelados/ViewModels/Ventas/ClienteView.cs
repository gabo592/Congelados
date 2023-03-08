namespace Congelados.ViewModels.Ventas
{
    /// <summary>
    /// Objeto simple de tipo Cliente desde una vista personalizada.
    /// </summary>
    internal class ClienteView
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Municipio { get; set; }

        public string Departamento { get; set; }
    }
}
