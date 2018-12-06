using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Documento.Prueba.Interfaces;
using Documento.Prueba.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Documento.Prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FicheroController : ControllerBase
    {
        private IFicheroRepositorio _ficheroRepo;

        public FicheroController(IFicheroRepositorio repo)
        {

        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/fichero/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/fichero
        [HttpPost]
        public void Post(FicheroModel fichero)
        {

        }

        // PUT api/fichero/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/fichero/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}