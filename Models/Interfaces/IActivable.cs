namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un atributo que indica su estado activo o inactivo.
    /// </summary>
    public interface IActivable
    {
        /// <summary>
        /// Obtiene o establece el estado del modelo. Este puede ser Activo (true) o Inactivo (false).
        /// </summary>
        bool Estado { get; set; }
    }
}
