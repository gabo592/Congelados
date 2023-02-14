namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un atributo único de identidad.
    /// </summary>
    public interface IIdentity
    {
        /// <summary>
        /// Identificador único del modelo.
        /// </summary>
        int Id { get; set; }
    }
}
