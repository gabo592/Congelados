namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un atributo de seguridad como una Clave o Contraseña.
    /// </summary>
    public interface ISecurity
    {
        /// <summary>
        /// Obtiene o establece la Clave o Contraseña para proteger la información del objeto.
        /// </summary>
        string Clave { get; set; }
    }
}
