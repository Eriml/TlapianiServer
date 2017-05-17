using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TlapianiServer;

namespace Tlapiani
{
    public sealed class ControladorUsuario
    {
        List<USUARIO> usuarios;

        public static Boolean registrarUsuario(USUARIO usuario) {
            return true;
        }

        public static Boolean iniciarSesion(USUARIO usuario) {

            if (usuario.id == "ADMIN" && usuario.Clave == "9A3CF797CFA2A88760A3CC4338527DC3AABC7B368A78F9489955E26A7EAD3FF9")
                return true;
            else
                return false;
        }

        public static USUARIO buscarUsuario(USUARIO usuario) {
            return usuario;
        }


    }
}
