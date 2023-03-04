namespace Connection.Constantes
{
    /// <summary>
    /// Clase encargada de contener los procedimientos almacenados a ejecutar por el programa. Esta clase no puede heredarse.
    /// </summary>
    internal sealed class StoredProcedures
    {
        #region CapitalHumano

        public const string EmpleadoCreate = "CapitalHumano.EMPLEADO_CREATE";
        public const string EmpleadoRead = "CapitalHumano.EMPLEADO_READ";
        public const string EmpleadoUpdate = "CapitalHumano.EMPLEADO_UPDATE";
        public const string EmpleadoDelete = "CapitalHumano.EMPLEADO_DELETE";

        #endregion

        #region Compras

        public const string CompraCreate = "Compras.COMPRA_CREATE";
        public const string CompraRead = "Compras.COMPRA_READ";
        public const string CompraReadByDates = "Compras.COMPRA_READ_BY_DATES";
        public const string CompraUpdate = "Compras.COMPRA_UPDATE";
        public const string CompraDelete = "Compras.COMPRA_DELETE";

        public const string DetalleCompraCreate = "Compras.DETALLE_COMPRA_CREATE";
        public const string DetalleCompraRead = "Compras.DETALLE_COMPRA_READ";
        public const string DetalleCompraUpdate = "Compras.DETALLE_COMPRA_UPDATE";
        public const string DetalleCompraDelete = "Compras.DETALLE_COMPRA_DELETE";

        public const string ProveedorCreate = "Compras.PROVEEDOR_CREATE";
        public const string ProveedorRead = "Compras.PROVEEDOR_READ";
        public const string ProveedorUpdate = "Compras.PROVEEDOR_UPDATE";
        public const string ProveedorDelete = "Compras.PROVEEDOR_DELETE";

        #endregion

        #region Inventario

        public const string CategoriaProductoCreate = "Inventario.CATEGORIA_PRODUCTO_CREATE";
        public const string CategoriaProductoRead = "Inventario.CATEGORIA_PRODUCTO_READ";
        public const string CategoriaProductoUpdate = "Inventario.CATEGORIA_PRODUCTO_UPDATE";
        public const string CategoriaProductoDelete = "Inventario.CATEGORIA_PRODUCTO_DELETE";

        public const string MateriaPrimaCreate = "Inventario.MATERIA_PRIMA_CREATE";
        public const string MateriaPrimaRead = "Inventario.MATERIA_PRIMA_READ";
        public const string MateriaPrimaUpdate = "Inventario.MATERIA_PRIMA_UPDATE";
        public const string MateriaPrimaDelete = "Inventario.MATERIA_PRIMA_DELETE";

        public const string ProductoCreate = "Inventario.PRODUCTO_CREATE";
        public const string ProductoRead = "Inventario.PRODUCTO_READ";
        public const string ProductoUpdate = "Inventario.PRODUCTO_UPDATE";
        public const string ProductoDelete = "Inventario.PRODUCTO_DELETE";

        #endregion

        #region Seguridad

        public const string UsuarioCreate = "Seguridad.USUARIO_CREATE";
        public const string UsuarioRead = "Seguridad.USUARIO_READ";
        public const string UsuarioUpdate = "Seguridad.USUARIO_UPDATE";
        public const string UsuarioDelete = "Seguridad.USUARIO_DELETE";
        public const string UsuarioLogin = "Seguridad.USUARIO_LOGIN";

        #endregion

        #region Ubicacion

        public const string DepartamentoRead = "Ubicacion.DEPARTAMENTO_READ";
        public const string MunicipioRead = "Ubicacion.MUNICIPIO_READ";

        #endregion

        #region Ventas

        public const string ClienteCreate = "Ventas.CLIENTE_CREATE";
        public const string ClienteRead = "Ventas.CLIENTE_READ";
        public const string ClienteUpdate = "Ventas.CLIENTE_UPDATE";
        public const string ClienteDelete = "Ventas.CLIENTE_DELETE";

        public const string DetalleVentaCreate = "Ventas.DETALLE_VENTA_CREATE";
        public const string DetalleVentaRead = "Ventas.DETALLE_VENTA_READ";
        public const string DetalleVentaUpdate = "Ventas.DETALLE_VENTA_UPDATE";
        public const string DetalleVentaDelete = "Ventas.DETALLE_VENTA_DELETE";

        public const string VentaCreate = "Ventas.VENTA_CREATE";
        public const string VentaRead = "Ventas.VENTA_READ";
        public const string VentaReadByDates = "Ventas.VENTA_READ_BY_DATES";
        public const string VentaUpdate = "Ventas.VENTA_UPDATE";
        public const string VentaDelete = "Ventas.VENTA_DELETE";

        #endregion
    }
}
