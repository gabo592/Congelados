using Congelados.Servicios.Base;
using Congelados.ViewModels.Inventario;
using Connection.Interfaces.Inventario;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Congelados.Servicios.Inventario
{
    /// <summary>
    /// Clase encargada de proveer los servicios para las Materias Primas.
    /// </summary>
    internal class MateriaPrimaService : ServicioBase
    {
        /// <summary>
        /// DAO para las Materias Primas.
        /// </summary>
        private readonly IMateriaPrimaDao materiaPrimaDao;

        public MateriaPrimaService()
        {
            materiaPrimaDao = DaoFactory.Get<IMateriaPrimaDao>(Handler);
        }

        /// <summary>
        /// Crea un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades de la Materia Prima.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no son proporcionadas.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas");

            MateriaPrima materiaPrima = materiaPrimaDao.Create(new MateriaPrima
            {
                Descripcion = properties["Descripcion"].ToString(),
                Precio = Convert.ToDecimal(properties["Precio"]),
                Cantidad = Convert.ToDouble(properties["Cantidad"])
            });

            if (materiaPrima is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IMateriaPrimaDao.GetById(int)"/>
        public MateriaPrima GetById(int id) => materiaPrimaDao.GetById(id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de objetos que coincidan con la Descripcion a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción de la Materia Prima a buscar.</param>
        /// <returns>Colección de objetos de tipo Materia Prima desde una vista personalizada.</returns>
        public IEnumerable<MateriaPrimaView> GetMateriasPrimas(string descripcion)
        {
            IEnumerable<MateriaPrima> materiasPrimas = materiaPrimaDao.Read(descripcion);

            return materiasPrimas.Select(materiaPrima =>
            {
                return new MateriaPrimaView
                {
                    Id = materiaPrima.Id,
                    Descripcion = materiaPrima.Descripcion,
                    Precio = materiaPrima.Precio,
                    Cantidad = materiaPrima.Cantidad
                };
            });
        }

        /// <summary>
        /// Actualiza un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades de la Materia Prima.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no son proporcionadas.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas");

            MateriaPrima materiaPrima = materiaPrimaDao.Update(new MateriaPrima
            {
                Id = (int)properties["Id"],
                Descripcion = properties["Descripcion"].ToString(),
                Precio = Convert.ToDecimal(properties["Precio"]),
                Cantidad = Convert.ToDouble(properties["Cantidad"]),
                Estado = (bool)properties["Estado"]
            });

            if (materiaPrima is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina la Materia Prima indicada de la base de datos.
        /// </summary>
        /// <param name="materiaPrima">Materia Prima a eliminar.</param>
        public void Delete(MateriaPrima materiaPrima)
        {
            MateriaPrima result = materiaPrimaDao.Delete(materiaPrima);

            if (result is null) Handler.Add("MODELO_NULO");
        }

        public override void Dispose() => Handler.Clear();

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
