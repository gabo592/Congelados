namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un atributo Nombre por el cual puede identificarse.
    /// </summary>
    public interface INameable
    {
        /// <summary>
        /// Obtiene o establece el Nombre del modelo.
        /// </summary>
        string Nombre { get; set; }
    }
}
