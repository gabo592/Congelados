using Common.Utils;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Compras;
using Models.Compras;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Compras
{
    /// <summary>
    /// Clase encargada de implementar los métodos de acceso a datos para los Detalles de Compra.
    /// </summary>
    internal class DetalleCompraDao : BaseDao<DetalleCompra>, IDetalleCompraDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DetalleCompraDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override DetalleCompra Create(DetalleCompra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.DetalleCompraCreate, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Costo", model.Costo },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault();
        }

        public override DetalleCompra Delete(DetalleCompra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.DetalleCompraDelete, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima }
            }).FirstOrDefault();
        }

        public IEnumerable<DetalleCompra> GetByIdCompra(int idCompra)
        {
            if (idCompra.Equals(default) || idCompra < 0)
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return Enumerable.Empty<DetalleCompra>();
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", idCompra }
            });
        }

        public IEnumerable<DetalleCompra> GetByIdMateriaPrima(int idMateriaPrima)
        {
            if (idMateriaPrima.Equals(default) || idMateriaPrima < 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return Enumerable.Empty<DetalleCompra>();
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdMateriaPrima", idMateriaPrima }
            });
        }

        public override IEnumerable<DetalleCompra> Read()
        {
            return Read(StoredProcedures.DetalleCompraRead);
        }

        public DetalleCompra Read(int idCompra, int idMateriaPrima)
        {
            if (idCompra.Equals(default) || idCompra < 0)
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return null;
            }

            if (idMateriaPrima.Equals(default) || idMateriaPrima < 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", idCompra },
                {"IdMateriaPrima", idMateriaPrima }
            }).FirstOrDefault();
        }

        public override DetalleCompra Update(DetalleCompra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.DetalleCompraUpdate, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Costo", model.Costo },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault();
        }
    }
}
