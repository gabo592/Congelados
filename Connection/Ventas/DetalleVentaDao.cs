using Common.Utils;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Ventas;
using Models.Ventas;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Ventas
{
    /// <summary>
    /// Clase encargada de implementar los métodos de acceso a datos para los Detalles de Venta.
    /// </summary>
    internal class DetalleVentaDao : BaseDao<DetalleVenta>, IDetalleVentaDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DetalleVentaDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override DetalleVenta Create(DetalleVenta model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.DetalleVentaCreate, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault();
        }

        public override DetalleVenta Delete(DetalleVenta model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.DetalleVentaDelete, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto }
            }).FirstOrDefault();
        }

        public IEnumerable<DetalleVenta> GetByIdProducto(int idProducto)
        {
            if (idProducto.Equals(default) || idProducto < 0)
            {
                Handler.Add("ID_PRODUCTO_READ");
                return Enumerable.Empty<DetalleVenta>();
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto }
            });
        }

        public IEnumerable<DetalleVenta> GetByIdVenta(int idVenta)
        {
            if (idVenta.Equals(default) || idVenta < 0)
            {
                Handler.Add("ID_VENTA_READ");
                return Enumerable.Empty<DetalleVenta>();
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdVenta", idVenta }
            });
        }

        public override IEnumerable<DetalleVenta> Read()
        {
            return Read(StoredProcedures.DetalleVentaRead);
        }

        public DetalleVenta Read(int idVenta, int idProducto)
        {
            if (idVenta.Equals(default) || idVenta < 0)
            {
                Handler.Add("ID_VENTA_READ");
                return null;
            }

            if (idProducto.Equals(default) || idProducto < 0)
            {
                Handler.Add("ID_PRODUCTO_READ");
                return null;
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdVenta", idVenta },
                {"IdProducto", idProducto }
            }).FirstOrDefault();
        }

        public override DetalleVenta Update(DetalleVenta model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.DetalleVentaUpdate, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault();
        }
    }
}
