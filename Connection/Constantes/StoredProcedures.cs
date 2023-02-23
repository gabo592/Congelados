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
    }
}
