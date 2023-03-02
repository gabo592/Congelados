using Common.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Connection
{
    /// <summary>
    /// Clase encargada de conectar directamente con la base de datos para la ejecución de procedimientos almacenados. Esta clase no puede heredarse.
    /// </summary>
    internal sealed class Database
    {
        #region Private Fields

        /// <summary>
        /// Cadena de conexión a base de datos.
        /// </summary>
        private readonly string ConnectionString;

        /// <summary>
        /// Instancia del administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        #endregion

        public Database(string connectionString, ErrorHandler handler)
        {
            if (string.IsNullOrEmpty(connectionString)) throw new ArgumentNullException(nameof(connectionString), "La cadena de conexión a la base de datos no puede estar vacía.");

            ConnectionString = connectionString;
            Handler = handler;
        }

        /// <summary>
        /// Realiza la lectura de un procedimiento almacenado tomando en cuenta una colección de pares clave-valor correspondiente a los parámetros del procedimiento.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a extraer.</typeparam>
        /// <param name="procedure">Nombre del procedimiento almacenado.</param>
        /// <param name="parameters">Parámetros del procedimiento almacenados.</param>
        /// <returns>Colección genérica de objetos del tipo especificado que resulten de la ejecución del procedimiento.</returns>
        /// <exception cref="ArgumentNullException">Se dispara cuando el nombre del procedimiento no es proporcionado.</exception>
        /// <exception cref="ArgumentException">Se dispara cuando la conexión a la base de datos no es exitosa.</exception>
        public IEnumerable<TModel> Read<TModel>(string procedure, IDictionary<string, object> parameters) where TModel : new()
        {
            if (string.IsNullOrEmpty(procedure)) throw new ArgumentNullException(nameof(procedure), "El nombre del procedimiento almacenado no puede estar vacío.");

            if (parameters is null) parameters = new Dictionary<string, object>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    throw new ArgumentException("No se logró establecer la conexión.");
                }

                using (SqlCommand command = new SqlCommand(procedure, connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 20
                })
                {
                    SqlCommandBuilder.DeriveParameters(command);

                    foreach (SqlParameter parameter in command.Parameters)
                    {
                        parameters.TryGetValue(RemoveSign(parameter.ParameterName), out object value);

                        if (value is null)
                        {
                            parameter.Value = DBNull.Value;
                            continue;
                        }

                        parameter.Value = value;
                    }

                    try
                    {
                        SqlDataReader dataReader = command.ExecuteReader();

                        return MapToObject<TModel>(dataReader).ToArray();
                    }
                    catch (Exception ex)
                    {
                        Handler.Add(ex);
                        return Enumerable.Empty<TModel>();
                    }
                }
            }
        }

        /// <summary>
        /// Mappea el resultado de la ejecución de un procedimiento almacenado a un objeto de tipo especificado.
        /// </summary>
        /// <typeparam name="TModel">Tipo de objeto a realizar el Mapping.</typeparam>
        /// <param name="reader">Lector de datos cuyo resultado es de la ejecución de un procedimiento o comando.</param>
        /// <returns>Colección genérica de objetos del tipo especificado.</returns>
        private IEnumerable<TModel> MapToObject<TModel>(IDataReader reader) where TModel : new()
        {
            Type type = typeof(TModel);

            while (reader.Read())
            {
                TModel model = new TModel();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string name = reader.GetName(i);
                    PropertyInfo property = type.GetProperty(name);

                    if (property is null) continue;

                    object value = reader.IsDBNull(i) ? null : reader.GetValue(i);

                    ConvertTypeOfValue(ref value, property);

                    property.SetValue(model, value);
                }

                yield return model;
            }
        }

        /// <summary>
        /// Convierte el tipo de dato del valor proporcionado en base a la información de la propiedad del objeto.
        /// </summary>
        /// <param name="value">Valor a cambiar el tipo.</param>
        /// <param name="property">Propiedad del objeto a insertar.</param>
        private void ConvertTypeOfValue(ref object value, PropertyInfo property)
        {
            if (value is decimal && property.PropertyType == typeof(double)) value = Convert.ToDouble(value);

            if (value is double && property.PropertyType == typeof(decimal)) value = Convert.ToDecimal(value);

            if (value is decimal && property.PropertyType == typeof(float)) value = Convert.ToSingle(value);

            if (value is float && property.PropertyType == typeof(decimal)) value = Convert.ToDecimal(value);

            if (value is double && property.PropertyType == typeof(float)) value = Convert.ToSingle(value);

            if (value is float && property.PropertyType == typeof(double)) value = Convert.ToDouble(value);

            if (value is byte[] && property.PropertyType == typeof(string)) value = string.Empty;

            if (value is byte[] && property.PropertyType == typeof(Image)) value = ConvertByteArrayToImage(value as byte[]);

            if (value is Image && property.PropertyType == typeof(byte[])) value = ConvertImageToByteArray(value as Image);
        }

        /// <summary>
        /// Convierte una imagen a su respectivo arreglo de bytes.
        /// </summary>
        /// <param name="image">Imagen a convertir.</param>
        /// <returns>Arreglo de bytes que contiene la información de la imagen.</returns>
        private byte[] ConvertImageToByteArray(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();

            image.Save(memoryStream, image.RawFormat);

            return memoryStream.ToArray();
        }

        /// <summary>
        /// Convierte un arreglo de bytes a su respectivo objeto de tipo Image.
        /// </summary>
        /// <param name="imageBytes">Bytes de imagen a convertir.</param>
        /// <returns>Imagen contenida en el arreglo de bytes.</returns>
        private Image ConvertByteArrayToImage(byte[] imageBytes)
        {
            MemoryStream memoryStream = new MemoryStream(imageBytes);

            return Image.FromStream(memoryStream);
        }

        /// <summary>
        /// Remueve el primer caracter del nombre del parámetro, asumiendo que es un arroba.
        /// </summary>
        /// <param name="name">Nombre del parámetro.</param>
        /// <returns>Nombre del parámetro sin el arroba.</returns>
        private string RemoveSign(string name) => name.Substring(1);
    }
}
