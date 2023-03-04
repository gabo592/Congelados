using Common.Utils;
using Connection.CapitalHumano;
using Connection.Compras;
using Connection.Interfaces.CapitalHumano;
using Connection.Interfaces.Compras;
using Connection.Interfaces.Inventario;
using Connection.Interfaces.Seguridad;
using Connection.Interfaces.Ubicacion;
using Connection.Interfaces.Ventas;
using Connection.Inventario;
using Connection.Seguridad;
using Connection.Ubicacion;
using Connection.Ventas;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Connection
{
    /// <summary>
    /// Clase encargada de fabricar los DAO que se encuentren mapeados por el sistema.
    /// </summary>
    public static class Factory
    {
        private static readonly IDictionary<Type, Type> Daos = new Dictionary<Type, Type> 
        {
            {typeof(IEmpleadoDao), typeof(EmpleadoDao) },

            {typeof(ICompraDao), typeof(CompraDao) },
            {typeof(IDetalleCompraDao), typeof(DetalleCompraDao) },
            {typeof(IProveedorDao), typeof(ProveedorDao) },

            {typeof(ICategoriaProductoDao), typeof(CategoriaProductoDao) },
            {typeof(IMateriaPrimaDao), typeof(MateriaPrimaDao) },
            {typeof(IProductoDao), typeof(ProductoDao) },

            {typeof(IUsuarioDao), typeof(UsuarioDao) },

            {typeof(IDepartamentoDao), typeof(DepartamentoDao) },
            {typeof(IMunicipioDao), typeof(MunicipioDao) },

            {typeof(IClienteDao), typeof(ClienteDao) },
            {typeof(IDetalleVentaDao), typeof(DetalleVentaDao) },
            {typeof(IVentaDao), typeof(VentaDao) }
        };

        /// <summary>
        /// Realiza la invocación al DAO del tipo especificado que se encuentra mapeado.
        /// </summary>
        /// <typeparam name="TDao">Tipo de DAO a invocar.</typeparam>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        /// <param name="handler">Administrador de errores.</param>
        /// <returns>Tipo de DAO solicitado; en caso de no encontrar, genera una excepción.</returns>
        /// <exception cref="ArgumentException">Se dispara cuando no se encuentra el DAO solicitado.</exception>
        /// <exception cref="ArgumentNullException">Se dispara cuando el DAO no tiene un constructor apropiado.</exception>
        public static TDao Invoke<TDao>(string connectionString, ErrorHandler handler)
        {
            if (!Daos.TryGetValue(typeof(TDao), out Type daoType)) throw new ArgumentException("El tipo de DAO a invocar no se encuentra mapeado");

            ConstructorInfo constructor = daoType.GetConstructor(new Type[] { typeof(string), typeof(ErrorHandler) });

            if (constructor is null) throw new ArgumentNullException("El DAO a invocar no tiene configurado un constuctor que considere la cadena de conexion");

            return (TDao)constructor.Invoke(new object[] { connectionString, handler });
        }
    }
}
