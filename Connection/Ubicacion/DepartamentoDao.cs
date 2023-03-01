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
    /// Clase encargada de implementar los métodos de acceso a datos para los Departamentos
    /// </summary>
    internal class DepartamentoDao : BaseDao<Departamento>, IDepartamentoDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DepartamentoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Departamento Create(Departamento model)
        {
            throw new NotImplementedException();
        }

        public override Departamento Delete(Departamento model)
        {
            throw new NotImplementedException();
        }

        public Departamento GetById(int id)
        {
            if (id.Equals(default) || id < 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DepartamentoRead, new Dictionary<string, object>
            {
                {"Id", id }
            }).FirstOrDefault();
        }

        public override IEnumerable<Departamento> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Departamento> Read(string nombre)
        {
            return Read(StoredProcedures.DepartamentoRead, new Dictionary<string, object>
            {
                {"Nombre", nombre }
            });
        }

        public override Departamento Update(Departamento model)
        {
            throw new NotImplementedException();
        }
    }
}
