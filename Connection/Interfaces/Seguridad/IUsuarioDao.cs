using Connection.Base;
using Models.Seguridad;
using System.Collections.Generic;

namespace Connection.Interfaces.Seguridad
{
    /// <summary>
    /// Indica que una clase implementa los métodos de acceso a datos para el objeto Usuario.
    /// </summary>
    public interface IUsuarioDao : IDao<Usuario>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Usuario a encontrar.</param>
        /// <returns>Objeto de tipo Usuario que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        Usuario GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una colección de registros que coincidan con el valor a filtrar.
        /// </summary>
        /// <param name="value">Valor a filtrar la búsqueda. Puede ser por Nombre o Rol.</param>
        /// <returns>Colección de objetos de tipo Usuario que resulten de la búsqueda; en caso de no encontrar, retorna una colección vacía.</returns>
        IEnumerable<Usuario> Read(string value);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID del Empleado a filtrar.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado asociado al Usuario a encontrar.</param>
        /// <returns>Objeto de tipo Usuario que resulte de la búsqueda; en caso de no encontrar, retorna nulo.</returns>
        Usuario GetByIdEmpleado(int idEmpleado);

        /// <summary>
        /// Realiza un inicio de sesión dentro de la base de datos a partir de un nombre de usuario y su clave o contraseña.
        /// </summary>
        /// <param name="nombre">Nombre de Usuario a iniciar sesión.</param>
        /// <param name="clave">Clave o contraseña del Usuario.</param>
        /// <returns>Objeto de tipo Usuario que coincida con las credenciales ingresadas; en caso de un error, retorna nulo.</returns>
        Usuario Login(string nombre, string clave);
    }
}
