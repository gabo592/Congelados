using Common.Utils;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Inventario;
using Models.Inventario;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Inventario
{
    /// <summary>
    /// Clase encargada de implementar los métodos de acceso a datos para los Detalles de Producto.
    /// </summary>
    internal class DetalleProductoDao : BaseDao<DetalleProducto>, IDetalleProductoDao
    {
        /// <summary>
        /// Administrador de Errorres.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DetalleProductoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override DetalleProducto Create(DetalleProducto model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.DetalleProductoCreate, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault();
        }

        public override DetalleProducto Delete(DetalleProducto model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.DetalleProductoDelete, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima }
            }).FirstOrDefault();
        }

        public IEnumerable<DetalleProducto> GetByIdMateriaPrima(int idMateriaPrima)
        {
            if (idMateriaPrima.Equals(default) || idMateriaPrima < 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return Enumerable.Empty<DetalleProducto>();
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdMateriaPrima", idMateriaPrima }
            });
        }

        public IEnumerable<DetalleProducto> GetByIdProducto(int idProducto)
        {
            if (idProducto.Equals(default) || idProducto < 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return Enumerable.Empty<DetalleProducto>();
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto }
            });
        }

        public override IEnumerable<DetalleProducto> Read()
        {
            return Read(StoredProcedures.DetalleProductoRead);
        }

        public DetalleProducto Read(int idProducto, int idMateriaPrima)
        {
            if (idProducto.Equals(default) || idProducto < 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            if (idMateriaPrima.Equals(default) || idMateriaPrima < 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto },
                {"IdMateriaPrima", idMateriaPrima }
            }).FirstOrDefault();
        }

        public override DetalleProducto Update(DetalleProducto model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.DetalleProductoUpdate, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault();
        }
    }
}
