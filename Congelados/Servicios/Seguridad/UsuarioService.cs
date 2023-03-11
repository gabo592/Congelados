using Congelados.Servicios.Base;
using Congelados.Servicios.CapitalHumano;
using Congelados.ViewModels.Seguridad;
using Connection.Interfaces.Seguridad;
using Models.CapitalHumano;
using Models.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Congelados.Servicios.Seguridad
{
    /// <summary>
    /// Clase encargada de proveer los servicios a los Usuarios.
    /// </summary>
    internal class UsuarioService : ServicioBase
    {
        /// <summary>
        /// DAO para los Usuarios.
        /// </summary>
        private readonly IUsuarioDao usuarioDao;

        /// <summary>
        /// Servicio para los Empleados
        /// </summary>
        private readonly EmpleadoService empleadoService;

        public UsuarioService()
        {
            usuarioDao = DaoFactory.Get<IUsuarioDao>(Handler);
            empleadoService = new EmpleadoService();
        }

        /// <summary>
        /// Crea un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Usuario.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no son proporcionadas.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Usuario usuario = usuarioDao.Create(new Usuario
            {
                Nombre = properties["Nombre"].ToString(),
                Clave = properties["Clave"].ToString(),
                Rol = properties["Rol"].ToString(),
                IdEmpleado = (int)properties["IdEmpleado"]
            });

            if (usuario is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IUsuarioDao.GetById(int)"/>
        public Usuario GetById(int id) => usuarioDao.GetById(id);

        public IEnumerable<UsuarioView> GetUsuarios(string value)
        {
            IEnumerable<Usuario> usuarios = usuarioDao.Read(value);

            return usuarios.Select(usuario =>
            {
                Empleado empleado = empleadoService.GetById(usuario.IdEmpleado);

                return new UsuarioView
                {
                    Id = usuario.Id,
                    Nombre = usuario.Nombre,
                    Rol = usuario.Rol,
                    Empleado = $"{empleado.PrimerNombre} {empleado.PrimerApellido}"
                };
            });
        }

        /// <summary>
        /// Actualiza un registro dentro de la base de datos a partir de una colección de pares clave-valor que corresponden a las propiedades del objeto.
        /// </summary>
        /// <param name="properties">Propiedades del Usuario.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando las propiedades no son proporcionadas.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas.");

            Usuario usuario = usuarioDao.Update(new Usuario
            {
                Id = (int)properties["Id"],
                Nombre = properties["Nombre"].ToString(),
                Clave = properties["Clave"].ToString(),
                Rol = properties["Rol"].ToString(),
                Estado = (bool)properties["Estado"],
                IdEmpleado = (int)properties["IdEmpleado"]
            });

            if (usuario is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina al Usuario especificado de la base de datos.
        /// </summary>
        /// <param name="usuario">Usuario a eliminar.</param>
        public void Delete(Usuario usuario)
        {
            Usuario result = usuarioDao.Delete(usuario);

            if (result is null) Handler.Add("MODELO_NULO");
        }

        public void Login(string nombre, string clave)
        {
            Usuario usuario = usuarioDao.Login(nombre, clave);

            if (usuario is null)
            {
                Handler.Add("MODELO_NULO");
                return;
            }

            Session.Set(usuario);
        }

        public override void Dispose()
        {
            Handler.Clear();
            empleadoService.Dispose();
        }

        public override string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (empleadoService.HasError())
            {
                builder.AppendLine(empleadoService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public override bool HasError() => Handler.HasError() || empleadoService.HasError();
    }
}
