using Common.Utils;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Ubicacion;
using Models.Ubicacion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Ubicacion
{
    /// <summary>
    /// Clase encargada de implementar los métodos de acceso a datos para los Municipios.
    /// </summary>
    internal class MunicipioDao : BaseDao<Municipio>, IMunicipioDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public MunicipioDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Municipio Create(Municipio model)
        {
            throw new NotImplementedException();
        }

        public override Municipio Delete(Municipio model)
        {
            throw new NotImplementedException();
        }

        public Municipio GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.MunicipioRead, new Dictionary<string, object>
            {
                {"Id", id }
            }).FirstOrDefault();
        }

        public IEnumerable<Municipio> GetByIdDepartamento(int idDepartamento)
        {
            if (idDepartamento.Equals(default) || idDepartamento < 0)
            {
                Handler.Add("ID_DEPARTAMENTO_DEFAULT");
                return Enumerable.Empty<Municipio>();
            }

            return Read(StoredProcedures.MunicipioRead, new Dictionary<string, object>
            {
                {"IdDepartamento", idDepartamento }
            });
        }

        public override IEnumerable<Municipio> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Municipio> Read(string nombre)
        {
            return Read(StoredProcedures.MunicipioRead, new Dictionary<string, object>
            {
                {"Nombre", nombre }
            });
        }

        public override Municipio Update(Municipio model)
        {
            throw new NotImplementedException();
        }
    }
}
