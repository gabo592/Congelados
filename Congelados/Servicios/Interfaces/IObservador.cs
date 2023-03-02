namespace Congelados.Servicios.Interfaces
{
    /// <summary>
    /// Indica que una clase está al pendiente de los cambios notificados por otra clase de tipo ISujeto.
    /// </summary>
    public interface IObservador
    {
        /// <summary>
        /// Actualiza su estado a partir de los cambios notificados por la clase Sujeto.
        /// </summary>
        void Actualizar();
    }
}
