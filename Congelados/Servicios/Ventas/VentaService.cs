using Congelados.Servicios.Base;
using Congelados.Servicios.CapitalHumano;
using Congelados.Servicios.Inventario;
using Congelados.ViewModels.Ventas;
using Connection.Interfaces.Ventas;
using Models.CapitalHumano;
using Models.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congelados.Servicios.Ventas
{
    /// <summary>
    /// Clase encargada de proveer los servicios para las Ventas.
    /// </summary>
    internal class VentaService : ServicioBase
    {
        /// <summary>
        /// DAO para las Ventas.
        /// </summary>
        private readonly IVentaDao ventaDao;

        /// <summary>
        /// DAO para los Detalles de Venta.
        /// </summary>
        private readonly IDetalleVentaDao detalleVentaDao;

        /// <summary>
        /// Proveedor de servicios para los Productos.
        /// </summary>
        private readonly ProductoService productoService;

        /// <summary>
        /// Proveedor de servicios para los empleados.
        /// </summary>
        private readonly EmpleadoService empleadoService;

        /// <summary>
        /// Proveedor de servicios para los clientes.
        /// </summary>
        private readonly ClienteService clienteService;

        public VentaService()
        {
            ventaDao = DaoFactory.Get<IVentaDao>(Handler);
            detalleVentaDao = DaoFactory.Get<IDetalleVentaDao>(Handler);
            productoService = new ProductoService();
            empleadoService = new EmpleadoService();
            clienteService = new ClienteService();
        }

        /// <summary>
        /// Crea una Venta en la base de datos tomando en cuenta una colección de pares clave-valor correspondiente a las propiedades de la Venta y una lista de objetos de tipo Detalle de Venta.
        /// </summary>
        /// <param name="properties">Propiedades de la Venta.</param>
        /// <param name="detalleVentaViews">Detalles de Venta.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no son proporcionadas.</exception>
        /// <exception cref="NullReferenceException">Se dispara cuando no se logró crear la Venta en la base de datos.</exception>
        public void Create(IDictionary<string, object> properties, List<DetalleVentaView> detalleVentaViews)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades de la Venta no pueden ser nulas");

            Venta venta = ventaDao.Create(new Venta
            {
                IdCliente = (int)properties["IdCliente"],
                IdEmpleado = (int)properties["IdEmpleado"]
            }) ?? throw new NullReferenceException("No se logró crear la Venta");

            List<DetalleVenta> detalleVentas = detalleVentaViews.Select(detalle => new DetalleVenta
            {
                IdVenta = venta.Id,
                IdProducto = detalle.Id,
                Precio = detalle.Precio,
                Cantidad = detalle.Cantidad,
                Descuento = detalle.Descuento
            }).ToList();

            detalleVentas.ForEach(detalle => detalleVentaDao.Create(detalle));
        }

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar todos los registros de tipo Ventas junto con sus Detalles de Venta.
        /// </summary>
        /// <returns>Colección de objetos de tipo Venta desde una vista personalizada.</returns>
        public IEnumerable<VentaView> GetVentas()
        {
            IEnumerable<Venta> ventas = ventaDao.Read();

            return ventas.Select(venta =>
            {
                List<DetalleVenta> detalleVentas = detalleVentaDao.GetByIdVenta(venta.Id).ToList();
                decimal total = CalcularTotal(detalleVentas);

                Cliente cliente = clienteService.GetById(venta.IdCliente);
                Empleado empleado = empleadoService.GetById(venta.IdEmpleado);

                return new VentaView
                {
                    Id = venta.Id,
                    Fecha = venta.Fecha,
                    Productos = detalleVentas.Count,
                    Cantidad = detalleVentas.Sum(detalle => detalle.Cantidad),
                    Total = total,
                    Cliente = $"{cliente.PrimerNombre} {cliente.SegundoNombre} {cliente.PrimerApellido} {cliente.SegundoApellido}",
                    Empleado = $"{empleado.PrimerNombre} {empleado.SegundoNombre} {empleado.PrimerApellido} {empleado.SegundoApellido}"
                };
            });
        }

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar los registros de tipo Venta que coincidan con la Fecha a filtrar.
        /// </summary>
        /// <param name="fecha">Fecha de Venta.</param>
        /// <returns>Colección de objetos de tipo Venta desde una vista personalizada.</returns>
        public IEnumerable<VentaView> GetVentas(DateTime fecha)
        {
            IEnumerable<Venta> ventas = ventaDao.Read(fecha);

            return ventas.Select(venta =>
            {
                List<DetalleVenta> detalleVentas = detalleVentaDao.GetByIdVenta(venta.Id).ToList();
                decimal total = CalcularTotal(detalleVentas);

                Cliente cliente = clienteService.GetById(venta.IdCliente);
                Empleado empleado = empleadoService.GetById(venta.IdEmpleado);

                return new VentaView
                {
                    Id = venta.Id,
                    Fecha = venta.Fecha,
                    Productos = detalleVentas.Count,
                    Cantidad = detalleVentas.Sum(detalle => detalle.Cantidad),
                    Total = total,
                    Cliente = $"{cliente.PrimerNombre} {cliente.SegundoNombre} {cliente.PrimerApellido} {cliente.SegundoApellido}",
                    Empleado = $"{empleado.PrimerNombre} {empleado.SegundoNombre} {empleado.PrimerApellido} {empleado.SegundoApellido}"
                };
            });
        }

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar registros de tipo Venta que se encuentren dentro del rango de Fecha de Inicio y Fecha Final.
        /// </summary>
        /// <param name="fechaInicio">Fecha inicial del rango a filtrar.</param>
        /// <param name="fechaFinal">Fecha final del rango a filtrar.</param>
        /// <returns>Colección de objetos de tipo Venta desde una vista personalizada.</returns>
        public IEnumerable<VentaView> GetVentas(DateTime fechaInicio, DateTime fechaFinal)
        {
            IEnumerable<Venta> ventas = ventaDao.Read(fechaInicio, fechaFinal);

            return ventas.Select(venta =>
            {
                List<DetalleVenta> detalleVentas = detalleVentaDao.GetByIdVenta(venta.Id).ToList();
                decimal total = CalcularTotal(detalleVentas);

                Cliente cliente = clienteService.GetById(venta.IdCliente);
                Empleado empleado = empleadoService.GetById(venta.IdEmpleado);

                return new VentaView
                {
                    Id = venta.Id,
                    Fecha = venta.Fecha,
                    Productos = detalleVentas.Count,
                    Cantidad = detalleVentas.Sum(detalle => detalle.Cantidad),
                    Total = total,
                    Cliente = $"{cliente.PrimerNombre} {cliente.SegundoNombre} {cliente.PrimerApellido} {cliente.SegundoApellido}",
                    Empleado = $"{empleado.PrimerNombre} {empleado.SegundoNombre} {empleado.PrimerApellido} {empleado.SegundoApellido}"
                };
            });
        }

        /// <summary>
        /// Calcula el valor total de una venta a partir de una lista de objetos de tipo Detalle de Venta.
        /// </summary>
        /// <param name="detalleVentas">Detalles de Venta.</param>
        /// <returns>Valor total de la Venta.</returns>
        public decimal CalcularTotal(List<DetalleVenta> detalleVentas)
        {
            decimal total = 0;

            detalleVentas.ForEach(detalle =>
            {
                total += CalcularSubTotal(detalle.Cantidad, detalle.Precio, detalle.Descuento);
            });

            return total;
        }

        /// <summary>
        /// Calcula el valor total de una venta a partir de una lista de objetos de tipo Detalle de Venta desde una vista personalizada.
        /// </summary>
        /// <param name="detalleVentasView">Detalles de Venta.</param>
        /// <returns>Valor total de la Venta.</returns>
        public decimal CalcularTotal(List<DetalleVentaView> detalleVentasView)
        {
            decimal total = 0;

            detalleVentasView.ForEach(detalle =>
            {
                total += CalcularSubTotal(detalle.Cantidad, detalle.Precio, detalle.Descuento);
            });

            return total;
        }

        /// <summary>
        /// Calcula el subtotal de la venta tomando en cuenta la cantidad del producto, su precio de venta y el descuento aplicado en la venta.
        /// </summary>
        /// <param name="cantidad">Cantidad del Producto a vender.</param>
        /// <param name="precio">Precio de venta del Producto.</param>
        /// <param name="descuento">Descuento aplicado en la Venta.</param>
        /// <returns>Valor subtotal de la venta de un producto.</returns>
        public decimal CalcularSubTotal(double cantidad, decimal precio, double descuento) => (Convert.ToDecimal(cantidad) * precio) - (Convert.ToDecimal(cantidad) * precio * Convert.ToDecimal(descuento));

        /// <summary>
        /// Actualiza un registro de tipo Venta dentro de la base de datos a partir de una colección de pares clave-valor correspondientes a las propiedades de la Venta, junto con una lista de objetos de tipo Detalle de Ventas.
        /// </summary>
        /// <param name="properties">Propiedades de la Venta a actualizar.</param>
        /// <param name="detalleVentaViews">Detalles de Venta correspondiente.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no son proporcionadas.</exception>
        /// <exception cref="NullReferenceException">Se dispara cuando no se logró actualizar la Venta.</exception>
        public void Update(IDictionary<string, object> properties, List<DetalleVentaView> detalleVentaViews)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades de la Venta no pueden ser nulas.");

            Venta venta = ventaDao.Update(new Venta
            {
                Id = (int)properties["Id"],
                Fecha = (DateTime)properties["Fecha"],
                Estado = (bool)properties["Estado"],
                IdCliente = (int)properties["IdCliente"],
                IdEmpleado = (int)properties["IdEmpleado"]
            }) ?? throw new NullReferenceException("No se logró actualizar la Venta");

            List<DetalleVenta> detalleVentas = detalleVentaViews.Select(detalle => new DetalleVenta
            {
                IdVenta = venta.Id,
                IdProducto = detalle.Id,
                Cantidad = detalle.Cantidad,
                Precio = detalle.Precio,
                Descuento = detalle.Descuento
            }).ToList();

            detalleVentas.ForEach(detalle => detalleVentaDao.Update(detalle));
        }

        /// <summary>
        /// Elimina el registro de la Venta especificada dentro de la base de datos.
        /// </summary>
        /// <param name="venta">Venta a eliminar.</param>
        public void DeleteVenta(Venta venta)
        {
            Venta result = ventaDao.Delete(venta);

            if (result is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina los registros de los Detalles de Venta especificados dentro de la base de datos.
        /// </summary>
        /// <param name="detalleVentas">Lista de objetos Detalles de Venta a eliminar.</param>
        public void DeleteDetalles(List<DetalleVenta> detalleVentas) => detalleVentas.ForEach(detalle => detalleVentaDao.Delete(detalle));

        public override void Dispose()
        {
            Handler.Clear();
            productoService.Dispose();
            empleadoService.Dispose();
            clienteService.Dispose();
        }

        public override string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (productoService.HasError())
            {
                builder.AppendLine(productoService.GetErrorMessage());
            }

            if (empleadoService.HasError())
            {
                builder.AppendLine(empleadoService.GetErrorMessage());
            }

            if (clienteService.HasError())
            {
                builder.AppendLine(clienteService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public override bool HasError() => Handler.HasError() || productoService.HasError() || empleadoService.HasError() || clienteService.HasError();
    }
}
