using System;

namespace Congelados.ViewModels.Ventas
{
    /// <summary>
    /// Objeto simple de tipo Venta desde una vista personalizada.
    /// </summary>
    internal class VentaView
    {
        /// <summary>
        /// Identificador único de la Venta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fecha en que se realizó la venta.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Nombre del Empleado involucrado en la venta.
        /// </summary>
        public string Empleado { get; set; }

        /// <summary>
        /// Nombre del Cliente al que se le realizó la venta.
        /// </summary>
        public string Cliente { get; set; }

        /// <summary>
        /// Número de productos vendidos.
        /// </summary>
        public int Productos { get; set; }

        /// <summary>
        /// Cantidad total de productos vendidos.
        /// </summary>
        public double Cantidad { get; set; }

        /// <summary>
        /// Valor total de la venta.
        /// </summary>
        public decimal Total { get; set; }
    }
}
