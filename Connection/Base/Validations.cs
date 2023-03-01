using Common.Utils;
using Models.Interfaces;

namespace Connection.Base
{
    /// <summary>
    /// Clase encargada de realizar las validaciones respectivas para las operaciones del sistema.
    /// </summary>
    internal class Validations
    {
        /// <summary>
        /// Verifica si un modelo del tipo especificado posee la correcta información para realizar la operación indicada.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a validar.</typeparam>
        /// <param name="model">Modelo a validar.</param>
        /// <param name="handler">Instancia del administrador de errores.</param>
        /// <param name="operacion">Operación a realizar dentro de la base de datos.</param>
        /// <returns>Verdadero si se encuentra algún error; en caso contrario, Falso.</returns>
        public static bool HasError<TModel>(TModel model, ErrorHandler handler, Operations operacion = Operations.DEFAULT) where TModel : new()
        {
            if (model == null)
            {
                handler.Add("MODELO_NULO");
                return true;
            }

            if (model is IActivable activable && (operacion == Operations.UPDATE || operacion == Operations.DELETE))
            {
                if (!activable.Estado)
                {
                    handler.Add("MODELO_DESACTIVADO");
                }
            }

            if (model is IIdentity identity && (operacion == Operations.UPDATE || operacion == Operations.DELETE))
            {
                if (identity.Id.Equals(default) || identity.Id < 0)
                {
                    handler.Add("ID_DEFAULT");
                }
            }

            if (model is INameable nameable && (operacion == Operations.CREATE || operacion == Operations.UPDATE))
            {
                if (string.IsNullOrEmpty(nameable.Nombre))
                {
                    handler.Add("NOMBRE_VACIO");
                }
            }

            if (model is IPerson person && (operacion == Operations.CREATE || operacion == Operations.UPDATE))
            {
                if (string.IsNullOrEmpty(person.PrimerNombre))
                {
                    handler.Add("PRIMER_NOMBRE_DEFAULT");
                }

                if (person.PrimerNombre.Length > 50)
                {
                    handler.Add("LONGITUD_PRIMER_NOMBRE_EXCEDIDA");
                }

                if (person.SegundoNombre.Length > 50)
                {
                    handler.Add("LONGITUD_SEGUNDO_NOMBRE_EXCEDIDA");
                }

                if (string.IsNullOrEmpty(person.PrimerApellido))
                {
                    handler.Add("PRIMER_APELLIDO_DEFAULT");
                }

                if (person.PrimerApellido.Length > 50)
                {
                    handler.Add("LONGITUD_PRIMER_APELLIDO_EXCEDIDA");
                }

                if (person.SegundoApellido.Length > 50)
                {
                    handler.Add("LONGITUD_SEGUNDO_APELLIDO_EXCEDIDA");
                }

                if (!string.IsNullOrEmpty(person.Telefono) && person.Telefono.Length != 8)
                {
                    handler.Add("LONGITUD_TELEFONO");
                }

                if (!string.IsNullOrEmpty(person.Direccion) && person.Direccion.Length > 500)
                {
                    handler.Add("LONGITUD_DIRECCION_EXCEDIDA");
                }

                if (person.IdMunicipio.Equals(default) || person.IdMunicipio < 0)
                {
                    handler.Add("ID_MUNICIPIO_DEFAULT");
                }
            }

            if (model is IProduct product && (operacion == Operations.CREATE || operacion == Operations.UPDATE))
            {
                if (string.IsNullOrEmpty(product.Descripcion))
                {
                    handler.Add("DESCRIPCION_DEFAULT");
                }

                if (product.Descripcion.Length > 500)
                {
                    handler.Add("LONGITUD_DESCRIPCION_EXCEDIDA");
                }

                if (product.Precio < 0)
                {
                    handler.Add("PRECIO_NEGATIVO");
                }

                if (product.Cantidad < 0)
                {
                    handler.Add("CANTIDAD_NEGATIVA");
                }
            }

            if (model is ISecurity security && (operacion == Operations.CREATE || operacion == Operations.UPDATE))
            {
                if (string.IsNullOrEmpty(security.Clave))
                {
                    handler.Add("CLAVE_VACIA");
                }

                if (security.Clave.Length < 4)
                {
                    handler.Add("LONGITUD_CLAVE");
                }
            }

            if (model is ITransaction transaction && (operacion == Operations.CREATE || operacion == Operations.UPDATE))
            {
                if (transaction.IdEmpleado.Equals(default) || transaction.IdEmpleado < 0)
                {
                    handler.Add("ID_EMPLEADO_DEFAULT");
                }
            }

            if (model is ITransactionDetail transactionDetail && (operacion == Operations.CREATE || operacion == Operations.UPDATE))
            {
                if (transactionDetail.Cantidad < 0)
                {
                    handler.Add("CANITDAD_NEGATIVA");
                }

                if (transactionDetail.Descuento < 0)
                {
                    handler.Add("DESCUENTO_NEGATIVO");
                }
            }

            return handler.HasError();
        }

        /// <summary>
        /// Contiene todas las operaciones básicas a realizar en la base de datos que requieren de una validación.
        /// </summary>
        public enum Operations
        {
            DEFAULT = 0,
            CREATE = 1,
            UPDATE = 2,
            DELETE = 3
        }
    }
}
