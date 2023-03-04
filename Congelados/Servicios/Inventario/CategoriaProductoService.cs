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
    /// Proveedor de serivicios para las Categorías de Productos
    /// </summary>
    internal class CategoriaProductoService : ServicioBase
    {
        /// <summary>
        /// DAO para las Categorías de Productos.
        /// </summary>
        private readonly ICategoriaProductoDao CategoriaProductoDao;

        public CategoriaProductoService()
        {
            CategoriaProductoDao = DaoFactory.Get<ICategoriaProductoDao>(Handler);
        }

        /// <summary>
        /// Crea un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades de la Categoría de Producto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            CategoriaProducto categoriaProducto = CategoriaProductoDao.Create(new CategoriaProducto
            {
                Nombre = properties["Nombre"].ToString(),
                Descripcion = properties["Descripcion"].ToString()
            });

            if (categoriaProducto is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="ICategoriaProductoDao.GetById(int)"/>
        public CategoriaProducto GetById(int id) => CategoriaProductoDao.GetById(id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por Nombre o Descripción.</param>
        /// <returns>Colección de objetos de tipo Categoría de Producto desde una vista personalizada.</returns>
        public IEnumerable<CategoriaProductoView> GetCategorias(string value)
        {
            IEnumerable<CategoriaProducto> categoriasProductos = CategoriaProductoDao.Read(value);

            return categoriasProductos.Select(categoria =>
            {
                return new CategoriaProductoView
                {
                    Id = categoria.Id,
                    Nombre = categoria.Nombre,
                    Descripcion = categoria.Descripcion
                };
            });
        }

        /// <summary>
        /// Actualiza un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades de la Categoría de Producto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionan.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            CategoriaProducto categoriaProducto = CategoriaProductoDao.Update(new CategoriaProducto
            {
                Id = (int)properties["Id"],
                Nombre = properties["Nombre"].ToString(),
                Descripcion = properties["Descripcion"].ToString(),
                Estado = (bool)properties["Estado"]
            });

            if (categoriaProducto is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina la Categoría de Producto especificada de la base de datos.
        /// </summary>
        /// <param name="categoriaProducto">Categoría de Producto a eliminar.</param>
        public void Delete(CategoriaProducto categoriaProducto)
        {
            CategoriaProducto result = CategoriaProductoDao.Delete(categoriaProducto);

            if (result is null) Handler.Add("MODELO_NULO");
        }

        public override void Dispose() => Handler.Clear();

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
