using Congelados.Servicios.Base;
using Congelados.ViewModels.Inventario;
using Connection.Interfaces.Inventario;
using Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Congelados.Servicios.Inventario
{
    /// <summary>
    /// Proveedor de servicios para los Productos.
    /// </summary>
    internal class ProductoService : ServicioBase
    {
        /// <summary>
        /// DAO para los Productos.
        /// </summary>
        private readonly IProductoDao ProductoDao;

        /// <summary>
        /// Servicios para las Categorías de Productos.
        /// </summary>
        private readonly CategoriaProductoService CategoriaProductoService;

        public ProductoService()
        {
            ProductoDao = DaoFactory.Get<IProductoDao>(Handler);
            CategoriaProductoService = new CategoriaProductoService();
        }

        /// <summary>
        /// Crea un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Producto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionana.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Producto producto = ProductoDao.Create(new Producto
            {
                Descripcion = properties["Descripcion"].ToString(),
                Precio = Convert.ToDecimal(properties["Precio"]),
                Cantidad = Convert.ToDouble(properties["Cantidad"]),
                IdCategoria = (int)properties["IdCategoria"]
            });

            if (producto is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IProductoDao.GetById(int)"/>
        public Producto GetById(int id) => ProductoDao.GetById(id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con la Descripción a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción de los Productos a buscar.</param>
        /// <returns>Colección de objetos de tipo Producto desde una vista personalizada.</returns>
        public IEnumerable<ProductoView> GetProductos(string descripcion)
        {
            IEnumerable<Producto> productos = ProductoDao.Read(descripcion);

            return productos.Select(producto =>
            {
                CategoriaProducto categoriaProducto = CategoriaProductoService.GetById(producto.IdCategoria);

                return new ProductoView
                {
                    Id = producto.Id,
                    Descripcion = producto.Descripcion,
                    Precio = producto.Precio,
                    Cantidad = producto.Cantidad,
                    Categoria = categoriaProducto.Nombre
                };
            });
        }

        /// <summary>
        /// Actualiza un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Producto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no se proporcionana.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Producto producto = ProductoDao.Update(new Producto
            {
                Id = (int)properties["Id"],
                Descripcion = properties["Descripcion"].ToString(),
                Precio = Convert.ToDecimal(properties["Precio"]),
                Cantidad = Convert.ToDouble(properties["Cantidad"]),
                Estado = (bool)properties["Estado"],
                IdCategoria = (int)properties["IdCategoria"]
            });

            if (producto is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina el Producto especificado de la base de datos.
        /// </summary>
        /// <param name="producto">Producto a eliminar.</param>
        public void Delete(Producto producto)
        {
            Producto result = ProductoDao.Delete(producto);

            if (result is null) Handler.Add("MODELO_NULO");
        }

        public override void Dispose()
        {
            Handler.Clear();
            CategoriaProductoService.Dispose();
        }

        public override string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (CategoriaProductoService.HasError())
            {
                builder.AppendLine(CategoriaProductoService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public override bool HasError() => Handler.HasError() || CategoriaProductoService.HasError();
    }
}
