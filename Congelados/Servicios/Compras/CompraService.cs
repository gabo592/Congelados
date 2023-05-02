using Congelados.Servicios.Base;
using Congelados.Servicios.CapitalHumano;
using Congelados.Servicios.Inventario;
using Congelados.ViewModels.Compras;
using Connection.Interfaces.Compras;
using Models.CapitalHumano;
using Models.Compras;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Congelados.Servicios.Compras
{
    /// <summary>
    /// Clase encargada de proveer los servicios para las Compras.
    /// </summary>
    internal class CompraService : ServicioBase
    {
        #region Private Fields

        /// <summary>
        /// DAO para las Compras.
        /// </summary>
        private readonly ICompraDao compraDao;

        /// <summary>
        /// DAO para los Detalles de Compras.
        /// </summary>
        private readonly IDetalleCompraDao detalleCompraDao;

        /// <summary>
        /// Servicio de Materias Primas.
        /// </summary>
        private readonly MateriaPrimaService materiaPrimaService;

        /// <summary>
        /// Servicio de Proveedores.
        /// </summary>
        private readonly ProveedorService proveedorService;

        /// <summary>
        /// Servicio de Empleados.
        /// </summary>
        private readonly EmpleadoService empleadoService;

        #endregion

        public CompraService()
        {
            compraDao = DaoFactory.Get<ICompraDao>(Handler);
            detalleCompraDao = DaoFactory.Get<IDetalleCompraDao>(Handler);
            materiaPrimaService = new MateriaPrimaService();
            proveedorService = new ProveedorService();
            empleadoService = new EmpleadoService();
        }

        /// <summary>
        /// Crea una Compra en la base de datos tomando en cuenta una colección de pares clave-valor correspondientes a las propiedades del objeto y una lista de Detalles de Compras desde una vista personalizada.
        /// </summary>
        /// <param name="properties">Propiedades de la Compra.</param>
        /// <param name="detalleCompraViews">Lista de Detalles de Compra.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        /// <exception cref="NullReferenceException">Se dispara cuando no fue posible crear la Compra.</exception>
        public void Create(IDictionary<string, object> properties, List<DetalleCompraView> detalleCompraViews)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Compra compra = compraDao.Create(new Compra
            {
                Fecha = (DateTime)properties["Fecha"],
                IdProveedor = (int)properties["IdProveedor"],
                IdEmpleado = (int)properties["IdEmpleado"]
            }) ?? throw new NullReferenceException("No se logró crear la Compra.");

            List<DetalleCompra> detalleCompras = detalleCompraViews.Select(detalle => new DetalleCompra
            {
                IdCompra = compra.Id,
                IdMateriaPrima = detalle.Id,
                Cantidad = detalle.Cantidad,
                Costo = detalle.Costo,
                Descuento = detalle.Descuento
            }).ToList();

            detalleCompras.ForEach(detalle =>
            {
                DetalleCompra detalleCompra = detalleCompraDao.Create(detalle);
            });
        }

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta obtener todas las Compras.
        /// </summary>
        /// <returns>Colección de objetos de tipo Compra desde una vista personalizada.</returns>
        public IEnumerable<CompraView> GetCompras()
        {
            IEnumerable<Compra> compras = compraDao.Read();

            return compras.Select(compra =>
            {
                List<DetalleCompra> detalleCompras = detalleCompraDao.GetByIdCompra(compra.Id).ToList();
                decimal total = CalcularTotal(detalleCompras);

                Proveedor proveedor = proveedorService.GetById(compra.IdProveedor);
                Empleado empleado = empleadoService.GetById(compra.IdEmpleado);

                return new CompraView
                {
                    Id = compra.Id,
                    Fecha = compra.Fecha,
                    Productos = detalleCompras.Count,
                    Cantidad = detalleCompras.Sum(detalle => detalle.Cantidad),
                    Total = total,
                    Proveedor = proveedor.Nombre,
                    Empleado = $"{empleado.PrimerNombre} {empleado.SegundoNombre} {empleado.PrimerApellido} {empleado.SegundoApellido}"
                };
            });
        }

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta obtener todas las Compras que coincidan con la fecha a buscar.
        /// </summary>
        /// <param name="fecha">Fecha de Compra a filtrar.</param>
        /// <returns>Colección de objetos de tipo Compra desde una vista personalizada que resulten de la búsqueda.</returns>
        public IEnumerable<CompraView> GetCompras(DateTime fecha)
        {
            IEnumerable<Compra> compras = compraDao.Read(fecha);

            return compras.Select(compra =>
            {
                List<DetalleCompra> detalleCompras = detalleCompraDao.GetByIdCompra(compra.Id).ToList();
                decimal total = CalcularTotal(detalleCompras);

                Proveedor proveedor = proveedorService.GetById(compra.IdProveedor);
                Empleado empleado = empleadoService.GetById(compra.IdEmpleado);

                return new CompraView
                {
                    Id = compra.Id,
                    Fecha = compra.Fecha,
                    Productos = detalleCompras.Count,
                    Cantidad = detalleCompras.Sum(detalle => detalle.Cantidad),
                    Total = total,
                    Proveedor = proveedor.Nombre,
                    Empleado = $"{empleado.PrimerNombre} {empleado.SegundoNombre} {empleado.PrimerApellido} {empleado.SegundoApellido}"
                };
            });
        }

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta obtener todas las Compras que se encuentren en el rango de fechas a buscar.
        /// </summary>
        /// <param name="fechaInicio">Fecha de Inicio del intervalo a buscar.</param>
        /// <param name="fechaFinal">Fecha Final del intervalo a buscar.</param>
        /// <returns>Colección de objetos de tipo Compra desde una vista personalizada que resulten de la búsqueda.</returns>
        public IEnumerable<CompraView> GetCompras(DateTime fechaInicio, DateTime fechaFinal)
        {
            IEnumerable<Compra> compras = compraDao.Read(fechaInicio, fechaFinal);

            return compras.Select(compra =>
            {
                List<DetalleCompra> detalleCompras = detalleCompraDao.GetByIdCompra(compra.Id).ToList();
                decimal total = CalcularTotal(detalleCompras);

                Proveedor proveedor = proveedorService.GetById(compra.IdProveedor);
                Empleado empleado = empleadoService.GetById(compra.IdEmpleado);

                return new CompraView
                {
                    Id = compra.Id,
                    Fecha = compra.Fecha,
                    Productos = detalleCompras.Count,
                    Cantidad = detalleCompras.Sum(detalle => detalle.Cantidad),
                    Total = total,
                    Proveedor = proveedor.Nombre,
                    Empleado = $"{empleado.PrimerNombre} {empleado.SegundoNombre} {empleado.PrimerApellido} {empleado.SegundoApellido}"
                };
            });
        }

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro de tipo Compra que coincida con el ID especificado, junto con la lista de Detalles de Compra.
        /// </summary>
        /// <param name="id">Identificador único de la Compra a buscar.</param>
        /// <returns>Objeto de tipo Compra y su lista de objetos de tipo Detalles de Compras que resulten de la búsqueda.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Se dispara cuando el valor del ID se encuentra fuera de los valores permitidos.</exception>
        /// <exception cref="NullReferenceException">Se dispara cuando no se logró encontrar la Compra con el ID especificado.</exception>
        public (Compra compra, List<DetalleCompraView> detalleCompraViews) GetCompra(int id)
        {
            if (id.Equals(default) || id < 0) throw new ArgumentOutOfRangeException(nameof(id), "El ID de la Compra no puede ser nulo o un número menor o igual a cero.");

            Compra compra = compraDao.GetById(id) ?? throw new NullReferenceException("No se encuentra la Compra con ese ID.");

            IEnumerable<DetalleCompraView> detalleCompraViews = detalleCompraDao.GetByIdCompra(compra.Id).Select(detalle =>
            {
                MateriaPrima materiaPrima = materiaPrimaService.GetById(detalle.IdMateriaPrima);

                return new DetalleCompraView
                {
                    Id = materiaPrima.Id,
                    Descripcion = materiaPrima.Descripcion,
                    Cantidad = detalle.Cantidad,
                    Costo = detalle.Costo,
                    Descuento = detalle.Descuento,
                    SubTotal = CalcularSubTotal(detalle.Cantidad, detalle.Costo, detalle.Descuento)
                };
            });

            return (compra, detalleCompraViews.ToList());
        }

        /// <inheritdoc cref="IDetalleCompraDao.Read(int, int)"/>
        public DetalleCompra GetDetalleCompra(int idCompra, int idMateriaPrima) => detalleCompraDao.Read(idCompra, idMateriaPrima);

        /// <summary>
        /// Elimina dentro de la base de datos la Compra especificada.
        /// </summary>
        /// <param name="compra">Compra a eliminar.</param>
        public void DeleteCompra(Compra compra)
        {
            Compra result = compraDao.Delete(compra);

            if (result is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina permanentemente de la base de datos los Detalles de Compras contenidos en la Lista proporcionada.
        /// </summary>
        /// <param name="detalleCompras">Lista de objetos de tipo Detalle de Compra a eliminar.</param>
        public void DeleteDetalles(List<DetalleCompra> detalleCompras) => detalleCompras.ForEach(detalle => detalleCompraDao.Delete(detalle));

        /// <summary>
        /// Calcula el valor total a pagar dentro de una lista de objetos de tipo Detalle de Compra.
        /// </summary>
        /// <param name="detalleCompras">Lista de objetos de tipo Detalle de Compra necesaria para calcular el total de la Compra.</param>
        /// <returns>Cantidad total a pagar en la Compra.</returns>
        public decimal CalcularTotal(List<DetalleCompra> detalleCompras)
        {
            decimal total = 0;

            detalleCompras.ForEach(detalle =>
            {
                total += CalcularSubTotal(detalle.Cantidad, detalle.Costo, detalle.Descuento);
            });

            return total;
        }

        /// <summary>
        /// Calcula el valor total a pagar dentro de una lista de objetos de tipo Detalle de Compra desde una vista personalizada.
        /// </summary>
        /// <param name="detalleComprasView">Lista de objetos de tipo Detalle de Compra desde una vista personalizada, necesaria para calcular el total de la Compra.</param>
        /// <returns>Cantidad total a pagar en la Compra.</returns>
        public decimal CalcularTotal(List<DetalleCompraView> detalleComprasView)
        {
            decimal total = 0;

            detalleComprasView.ForEach(detalle =>
            {
                total += CalcularSubTotal(detalle.Cantidad, detalle.Costo, detalle.Descuento);
            });

            return total;
        }

        /// <summary>
        /// Calcula el valor subtotal a pagar tomando en cuenta la cantidad de la materia prima, el costo por adquirirla y el descuento aplicado a su Compra.
        /// </summary>
        /// <param name="cantidad">Cantidad de Materia Prima a Comprar.</param>
        /// <param name="costo">Costo de la Materia Prima.</param>
        /// <param name="descuento">Descuento de la Compra expresado en decimales de entre 0 y 1.</param>
        /// <returns>Cantidad subtotal a pagar por la Materia Prima.</returns>
        public decimal CalcularSubTotal(double cantidad, decimal costo, double descuento) => (Convert.ToDecimal(cantidad) * costo) - (Convert.ToDecimal(cantidad) * costo * Convert.ToDecimal(descuento));

        public override void Dispose()
        {
            Handler.Clear();
            materiaPrimaService.Dispose();
            empleadoService.Dispose();
            proveedorService.Dispose();
        }

        public override string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (materiaPrimaService != null && materiaPrimaService.HasError())
            {
                builder.AppendLine(materiaPrimaService.GetErrorMessage());
            }

            if (empleadoService != null && empleadoService.HasError())
            {
                builder.AppendLine(empleadoService.GetErrorMessage());
            }

            if (proveedorService != null && proveedorService.HasError())
            {
                builder.AppendLine(proveedorService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public override bool HasError() => Handler.HasError() || empleadoService.HasError() || materiaPrimaService.HasError() || proveedorService.HasError();
    }
}