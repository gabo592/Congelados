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
        private readonly IDepartamentoDao departamentoDao;

        /// <summary>
        /// DAO para los Municipios.
        /// </summary>
        private readonly IMunicipioDao municipioDao;

        public UbicacionService()
        {
            departamentoDao = DaoFactory.Get<IDepartamentoDao>(Handler);
            municipioDao = DaoFactory.Get<IMunicipioDao>(Handler);
        }

        /// <inheritdoc cref="IDepartamentoDao.GetById(int)"/>
        public Departamento GetDepartamentoById(int id) => departamentoDao.GetById(id);

        /// <inheritdoc cref="IMunicipioDao.GetById(int)"/>
        public Municipio GetMunicipioById(int id) => municipioDao.GetById(id);

        /// <inheritdoc cref="IDepartamentoDao.Read(string)"/>
        public IEnumerable<Departamento> GetDepartamentos(string nombre) => departamentoDao.Read(nombre);

        public IEnumerable<Municipio> GetMunicipios(int idDepartamento) => municipioDao.GetByIdDepartamento(idDepartamento);

        public override void Dispose() => Handler.Clear();

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
