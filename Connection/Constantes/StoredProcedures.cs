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

        public const string DetalleProductoCreate = "Inventario.DETALLE_PRODUCTO_CREATE";
        public const string DetalleProductoRead = "Inventario.DETALLE_PRODUCTO_READ";
        public const string DetalleProductoUpdate = "Inventario.DETALLE_PRODUCTO_UPDATE";
        public const string DetalleProductoDelete = "Inventario.DETALLE_PRODUCTO_DELETE";

        public const string MateriaPrimaCreate = "Inventario.MATERIA_PRIMA_CREATE";
        public const string MateriaPrimaRead = "Inventario.MATERIA_PRIMA_READ";
        public const string MateriaPrimaUpdate = "Inventario.MATERIA_PRIMA_UPDATE";
        public const string MateriaPrimaDelete = "Inventario.MATERIA_PRIMA_DELETE";

        public const string ProductoCreate = "Inventario.PRODUCTO_CREATE";
        public const string ProductoRead = "Inventario.PRODUCTO_READ";
        public const string ProductoUpdate = "Inventario.PRODUCTO_UPDATE";
        public const string ProductoDelete = "Inventario.PRODUCTO_DELETE";

        #endregion
    }
}
