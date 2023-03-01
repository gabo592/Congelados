using System;

namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee atributos para realizar movimientos transaccionales.
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// Obtiene o establece la Fecha en que se realizó la transacción.
        /// </summary>
        DateTime Fecha { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del Empleado asociado a la transacción.
        /// </summary>
        int IdEmpleado { get; set; }
    }
}
