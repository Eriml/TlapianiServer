using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace Tlapiani
{
    public static class ControladorDB 
    {
        private static OdbcConnection conex;
        private static OdbcDataReader reader;
        private static OdbcCommand command;
        public static string DSN;
        public static string Pass;
        public static string Servidor;
        public static SqlConnection connection;


        public static Boolean probarConexion()
        {
            if (DSN == "" || Servidor == "" || Pass == "")
            {
                try
                {
                    conex.Open();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al abrir la base de datos");
                    return false;
                }

                return true;
            }
            else
            {
                Console.WriteLine("No se ha configurado la conexion");
                return false;
            }
        }

        public static void configConexion(String servidor,string dsn,string pass)
        {
            Servidor = servidor;
            DSN = dsn;
            Pass = pass;
            conex = new OdbcConnection("DSN=" + Servidor + ";UID=" + DSN + ";PWD=" + Pass);

            connection= new SqlConnection("Server = tcp:tlapianiserver.database.windows.net, 1433; Initial Catalog = TLAPIANI; Persist Security Info = False; User ID = ADMINISTRADOR; Password =abc123ABC; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
        }
    }
}
