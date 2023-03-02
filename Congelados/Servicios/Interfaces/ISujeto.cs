namespace Congelados.Servicios.Interfaces
{
    /// <summary>
    /// Indica que una clase debe notificar los cambios a otras de tipo IObservador.
    /// </summary>
    public interface ISujeto
    {
        /// <summary>
        /// Notifica los cambios a todos los objetos de tipo IObservador.
        /// </summary>
        void Notificar();

        /// <summary>
        /// Agrega un nuevo observador a la Lista.
        /// </summary>
        void AgregarObservador(IObservador observador);
    }
}
