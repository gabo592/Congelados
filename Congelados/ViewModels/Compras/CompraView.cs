using System;

namespace Congelados.ViewModels.Compras
{
    /// <summary>
    /// Objeto simple de tipo Compra desde una vista personalizada.
    /// </summary>
    internal class CompraView
    {
        /// <summary>
        /// Identificador único de la Compra.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fecha en que se realizó la compra.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Nombre del empleado quién efectuó la compra.
        /// </summary>
        public string Empleado { get; set; }

        /// <summary>
        /// Nombre del Proveedor a quien se le realizó la compra.
        /// </summary>
        public string Proveedor { get; set; }

        /// <summary>
        /// Número de productos comprados.
        /// </summary>
        public int Productos { get; set; }

        /// <summary>
        /// Cantidad total de producto comprado.
        /// </summary>
        public double Cantidad { get; set; }

        /// <summary>
        /// Costo total de la compra.
        /// </summary>
        public decimal Total { get; set; }
    }
}
