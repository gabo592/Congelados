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
    /// Clase encargada de implementar los métodos de acceso a datos para los Proveedores.
    /// </summary>
    internal class ProveedorDao : BaseDao<Proveedor>, IProveedorDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public ProveedorDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Proveedor Create(Proveedor model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.ProveedorCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion }
            }).FirstOrDefault();
        }

        public override Proveedor Delete(Proveedor model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.ProveedorDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault();
        }

        public Proveedor GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.ProveedorRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault();
        }

        public override IEnumerable<Proveedor> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Proveedor> Read(string value)
        {
            return Read(StoredProcedures.ProveedorRead, new Dictionary<string, object>
            {
                {"Nombre", value },
                {"Direccion", value },
                {"Estado", 1 }
            });
        }

        public override Proveedor Update(Proveedor model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.ProveedorUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion }
            }).FirstOrDefault();
        }
    }
}
