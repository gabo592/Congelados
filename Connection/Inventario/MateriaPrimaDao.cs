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
    /// Clase encargada de implementar los métodos de acceso a datos para la Materias Primas
    /// </summary>
    internal class MateriaPrimaDao : BaseDao<MateriaPrima>, IMateriaPrimaDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public MateriaPrimaDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override MateriaPrima Create(MateriaPrima model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.MateriaPrimaCreate, new Dictionary<string, object>
            {
                {"Descripcion", model.Descripcion },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault();
        }

        public override MateriaPrima Delete(MateriaPrima model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.MateriaPrimaDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault();
        }

        public MateriaPrima GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.MateriaPrimaRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault();
        }

        public override IEnumerable<MateriaPrima> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<MateriaPrima> Read(string descripcion)
        {
            return Read(StoredProcedures.MateriaPrimaRead, new Dictionary<string, object>
            {
                {"Descripcion", descripcion },
                {"Estado", 1 }
            });
        }

        public override MateriaPrima Update(MateriaPrima model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.MateriaPrimaUpdate, new Dictionary<string, object>
            {
                {"Descripcion", model.Descripcion },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault();
        }
    }
}
