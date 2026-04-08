using Capa_Dato;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        CD_Usuarios datos = new CD_Usuarios();

        public List<CE_Usuarios> SelectAll()
        {
            return datos.SelectAll();
        }

        public void Insert(CE_Usuarios usuario)
        {
            if (string.IsNullOrEmpty(usuario.UserFullName))
                throw new Exception("El nombre del usuario es obligatorio.");

            if (string.IsNullOrEmpty(usuario.UserName))
                throw new Exception("El nombre de usuario es obligatorio.");

            if (string.IsNullOrEmpty(usuario.UserPassword))
                throw new Exception("La contraseña es obligatoria.");

            if (usuario.UserPassword.Length < 6)
                throw new Exception("La contraseña debe tener al menos 6 caracteres.");

            if (string.IsNullOrEmpty(usuario.UserEmail))
                throw new Exception("El email es obligatorio.");

            if (!usuario.UserEmail.Contains("@"))
                throw new Exception("El email no tiene un formato válido.");

            datos.Insert(usuario);
        }

        public void Delete(int userId)
        {
            if (userId <= 0)
                throw new Exception("El usuario no es válido.");

            datos.Delete(userId);
        }

        public CE_Usuarios Login(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
                throw new Exception("El nombre de usuario es obligatorio.");

            if (string.IsNullOrEmpty(password))
                throw new Exception("La contraseña es obligatoria.");

            CE_Usuarios usuario = datos.Login(userName, password);

            if (usuario == null)
                throw new Exception("Usuario o contraseña incorrectos.");

            return usuario;
        }
    }
}
