using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tlapiani.Models;

namespace Tlapiani
{
    public sealed class ControladorUsuario
    {
        List<Usuario> usuarios;

        public static Boolean registrarUsuario(Usuario usuario) {
            return true;
        }

        public static Boolean iniciarSesion(Usuario usuario) {

            if (usuario.Id == "ADMIN" && usuario.Clave == "9A3CF797CFA2A88760A3CC4338527DC3AABC7B368A78F9489955E26A7EAD3FF9")
                return true;
            else
                return false;
        }

        public static Usuario buscarUsuario(Usuario usuario) {
            return usuario;
        }


    }
}
