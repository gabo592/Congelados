using Common.Utils;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Compras;
using Models.Compras;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Compras
{
    /// <summary>
    /// Clase encargada de implementar los métodos de acceso a datos para las Compras.
    /// </summary>
    internal class CompraDao : BaseDao<Compra>, ICompraDao
    {
        /// <summary>
        /// Instancia del Administrador de Errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public CompraDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Compra Create(Compra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.CompraCreate, new Dictionary<string, object>
            {
                {"Fecha", model.Fecha },
                {"IdProveedor", model.IdProveedor },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault();
        }

        public override Compra Delete(Compra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.CompraDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault();
        }

        public Compra GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault();
        }

        public IEnumerable<Compra> GetByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default) || idEmpleado < 0)
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return Enumerable.Empty<Compra>();
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Estado", 1 },
                {"IdEmpleado", idEmpleado }
            });
        }

        public IEnumerable<Compra> GetByIdProveedor(int idProveedor)
        {
            if (idProveedor.Equals(default) || idProveedor < 0)
            {
                Handler.Add("ID_PROVEEDOR_DEFAULT");
                return Enumerable.Empty<Compra>();
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Estado", 1 },
                {"IdProveedor", idProveedor }
            });
        }

        public override IEnumerable<Compra> Read()
        {
            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        public IEnumerable<Compra> Read(DateTime fecha)
        {
            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Fecha", fecha },
                {"Estado", 1 }
            });
        }

        public IEnumerable<Compra> Read(DateTime fechaInicio, DateTime fechaFinal)
        {
            return Read(StoredProcedures.CompraReadByDates, new Dictionary<string, object>
            {
                {"FechaInicio", fechaInicio },
                {"FechaFinal", fechaFinal },
                {"Estado", 1 }
            });
        }

        public override Compra Update(Compra model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.CompraUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Fecha", model.Fecha },
                {"IdProveedor", model.IdProveedor },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault();
        }
    }
}
