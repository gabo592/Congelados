using Congelados.Servicios.Base;
using Connection.Interfaces.Ubicacion;
using Models.Ubicacion;
using System.Collections.Generic;

namespace Congelados.Servicios.Ubicacion
{
    /// <summary>
    /// Clase encargada de proveer los servicios para los Municipios y Departamentos.
    /// </summary>
    internal class UbicacionService : ServicioBase
    {
        /// <summary>
        /// DAO para los Departamentos.
        /// </summary>
        private readonly IDepartamentoDao DepartamentoDao;

        /// <summary>
        /// DAO para los Municipios.
        /// </summary>
        private readonly IMunicipioDao MunicipioDao;

        public UbicacionService()
        {
            DepartamentoDao = DaoFactory.Get<IDepartamentoDao>(Handler);
            MunicipioDao = DaoFactory.Get<IMunicipioDao>(Handler);
        }

        /// <inheritdoc cref="IDepartamentoDao.GetById(int)"/>
        public Departamento GetDepartamentoById(int id) => DepartamentoDao.GetById(id);

        /// <inheritdoc cref="IMunicipioDao.GetById(int)"/>
        public Municipio GetMunicipioById(int id) => MunicipioDao.GetById(id);

        /// <inheritdoc cref="IDepartamentoDao.Read(string)"/>
        public IEnumerable<Departamento> GetDepartamentos(string nombre) => DepartamentoDao.Read(nombre);

        public IEnumerable<Municipio> GetMunicipios(int idDepartamento) => MunicipioDao.GetByIdDepartamento(idDepartamento);

        public override void Dispose() => Handler.Clear();

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
