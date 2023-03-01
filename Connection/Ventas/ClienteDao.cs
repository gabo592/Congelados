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
    /// Clase encargada de implementar los métodos de acceso a datos para los Clientes.
    /// </summary>
    internal class ClienteDao : BaseDao<Cliente>, IClienteDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public ClienteDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Cliente Create(Cliente model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.ClienteCreate, new Dictionary<string, object>
            {
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault();
        }

        public override Cliente Delete(Cliente model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.ClienteDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault();
        }

        public Cliente GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.ClienteRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault();
        }

        public IEnumerable<Cliente> GetByIdMunicipio(int idMunicipio)
        {
            if (idMunicipio.Equals(default) || idMunicipio < 0)
            {
                Handler.Add("ID_MUNICIPIO_DEFAULT");
                return Enumerable.Empty<Cliente>();
            }

            return Read(StoredProcedures.ClienteRead, new Dictionary<string, object>
            {
                {"IdMunicipio", idMunicipio },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<Cliente> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Cliente> Read(string value)
        {
            return Read(StoredProcedures.ClienteRead, new Dictionary<string, object>
            {
                {"PrimerNombre", value },
                {"SegundoNombre", value },
                {"PrimerApellido", value },
                {"SegundoApellido", value },
                {"Direccion", value },
                {"Estado", 1 }
            });
        }

        public override Cliente Update(Cliente model)
        {
            if (Validations.HasError(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.ClienteUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault();
        }
    }
}
