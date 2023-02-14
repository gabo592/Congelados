namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee atributos asociados a una persona.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Obtiene o establece el Primer Nombre de la persona.
        /// </summary>
        string PrimerNombre { get; set; }

        /// <summary>
        /// Obtiene o establece el Segundo Nombre de la persona.
        /// </summary>
        string SegundoNombre { get; set; }

        /// <summary>
        /// Obtiene o establece el Primer Apellido de la persona.
        /// </summary>
        string PrimerApellido { get; set; }

        /// <summary>
        /// Obtiene o establece el Segundo Apellido de la persona.
        /// </summary>
        string SegundoApellido { get; set; }

        /// <summary>
        /// Obtiene o establece el número de teléfono de la persona.
        /// </summary>
        string Telefono { get; set; }

        /// <summary>
        /// Obtiene o establece la Dirección de la persona.
        /// </summary>
        string Direccion { get; set; }

        /// <summary>
        /// Obtiene o establece el ID del Municipio al que pertenece la persona.
        /// </summary>
        int IdMunicipio { get; set; }
    }
}
