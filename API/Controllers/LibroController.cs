using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        public readonly ILibroRepository libroRepository;

        public LibroController(ILibroRepository libroRepository)
        {
            this.libroRepository = libroRepository;
        }


        

        // GET: api/<LibroController>
        [HttpGet]
        public IActionResult Get()
        {
            //Un IActionResult devuelve un estatus y el content
            //por eso el Ok que devuelve un status (eje: un 200) y el contenido que le pases entre parentesis

            var result = libroRepository.GetAll();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        // GET api/<LibroController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var result = libroRepository.GetID(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST api/<LibroController>
        [HttpPost]
        public void Post([FromBody] Libro libro)
        {
            libroRepository.Save(libro);
        }

        // PUT api/<LibroController>/5
        [HttpPut]
        public void Put( [FromBody] Libro libro)
        {
            libroRepository.Update(libro);
        }

        // DELETE api/<LibroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            libroRepository.Remove(id);
        }
    }
}