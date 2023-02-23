using Common.Utils;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.CapitalHumano;
using Models.CapitalHumano;
using System.Collections.Generic;
using System.Linq;

namespace Connection.CapitalHumano
{
    /// <summary>
    /// Clase encargada de implementar los métodos de acceso a datos para los Empleados.
    /// </summary>
    internal class EmpleadoDao : BaseDao<Empleado>, IEmpleadoDao
    {
        /// <summary>
        /// Instancia del Administrador de Errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public EmpleadoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Empleado Create(Empleado model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.EmpleadoCreate, new Dictionary<string, object>
            {
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Cedula", model.Cedula },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault();
        }

        public override Empleado Delete(Empleado model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.EmpleadoCreate, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault();
        }

        public Empleado GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.EmpleadoRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault();
        }

        public IEnumerable<Empleado> GetByIdMunicipio(int idMunicipio)
        {
            if (idMunicipio.Equals(default) || idMunicipio < 0)
            {
                Handler.Add("ID_MUNICIPIO_DEFAULT");
                return Enumerable.Empty<Empleado>();
            }

            return Read(StoredProcedures.EmpleadoRead, new Dictionary<string, object>
            {
                {"IdMunicipio", idMunicipio },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<Empleado> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Empleado> Read(string value)
        {
            return Read(StoredProcedures.EmpleadoRead, new Dictionary<string, object>
            {
                {"PrimerNombre", value },
                {"SegundoNombre", value },
                {"PrimerApellido", value },
                {"SegundoApellido", value },
                {"Direccion", value },
                {"Estado", 1 }
            });
        }

        public override Empleado Update(Empleado model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.EmpleadoUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Cedula", model.Cedula },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault();
        }
    }
}
