using Models.Interfaces;
using System;

namespace Models.Compras
{
    /// <summary>
    /// Objeto simple de tipo Compra.
    /// </summary>
    public class Compra : IIdentity, ITransaction, IActivable
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public bool Estado { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del Proveedor asociado a la Compra.
        /// </summary>
        public int IdProveedor { get; set; }

        public int IdEmpleado { get; set; }
    }
}
