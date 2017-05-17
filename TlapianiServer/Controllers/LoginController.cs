using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using Tlapiani;

namespace TlapianiServer.Controllers
{
    

    public class LoginController : ApiController
    {
        
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public Boolean Post([FromBody]USUARIO usuario)
        {
            ControladorDB.configConexion("TLAPIANI","sa","contra2");
            return ControladorDB.probarConexion();
            //return ControladorUsuario.iniciarSesion(usuario);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
