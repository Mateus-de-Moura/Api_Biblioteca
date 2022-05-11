using Api_Biblioteca.Model;
using Api_Biblioteca.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController : ControllerBase
    {
        private readonly InterfaceLivros _Livros;
        public BibliotecaController()
        {
            _Livros = new LivroRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_Livros.Get());
        }
        [HttpPost]
        public IActionResult Post([FromBody] LivrosModel Livro) 
        {
            _Livros.Post(Livro);
            return Ok(Livro);
        }
        [HttpPut]
        public IActionResult Put([FromBody] LivrosModel Livro) 
        {
            _Livros.Put(Livro);
            return Ok(Livro);
        }
        [HttpDelete]
        public IActionResult Put(int id)
        {
            _Livros.Delete(id);
            return Ok();
        }

    }
}
