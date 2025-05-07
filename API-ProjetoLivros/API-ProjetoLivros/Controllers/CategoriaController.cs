using API_ProjetoLivros.Context;
using API_ProjetoLivros.Interfaces;
using API_ProjetoLivros.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ProjetoLivros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        //Injetar o Repository
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            var categoria = _categoriaRepository.ListarTodos();
            return Ok(categoria);
        }

        [HttpPost]
        public IActionResult Cadastrar(Categoria categoria)
        {
            _categoriaRepository.Cadastrar(categoria);
            return Created();
        }
    }
}
