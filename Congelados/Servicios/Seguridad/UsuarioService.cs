using Congelados.Servicios.Base;
using Connection.Interfaces.Seguridad;
using Models.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IUsuarioDao UsuarioDao;

        public UsuarioService()
        {
            UsuarioDao = DaoFactory.Get<IUsuarioDao>(Handler);
        }

        public void Login(string nombre, string clave)
        {
            Usuario usuario = UsuarioDao.Login(nombre, clave);

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
        }

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
