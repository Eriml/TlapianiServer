using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tlapiani.Models;

namespace Tlapiani.Controllers
{

    //////////////LOGIN/////////////
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "valor";
        }
        // POST de Login
        
        [HttpPost]
        public Boolean Post([FromBody]Usuario usuario)
        {
            return ControladorUsuario.iniciarSesion(new Usuario { Id = usuario.Id, Clave = usuario.Clave });
        }
    }

    //////////////CONSULTA/////////////
    [Route("api/[controller]")]
    public class ConsultaController : Controller
    {
        // POST de Login
        [HttpPost]
        public List<String> Post([FromBody]Usuario[] datos)
        {
            Console.WriteLine(datos[0].Id);
            return new List<string> { datos[0].Id, datos[1].Id };
        }
    }

    [Route("api/[controller]")]
    public class ControlRequests : Controller
    {




        // GET api/values
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return new Usuario[] { new Usuario { Id = "ADMIN", Clave = "9A3CF797CFA2A88760A3CC4338527DC3AABC7B368A78F9489955E26A7EAD3FF9" } };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Boolean Get(String id)
        {
            Console.WriteLine(id);
            Console.WriteLine(id);

            return ControladorUsuario.iniciarSesion(new Usuario { Nombre = id, Clave = "9A3CF797CFA2A88760A3CC4338527DC3AABC7B368A78F9489955E26A7EAD3FF9" });
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Usuario value)
        {
            return CreatedAtAction("Get", new { id = value.Id }, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }


}
