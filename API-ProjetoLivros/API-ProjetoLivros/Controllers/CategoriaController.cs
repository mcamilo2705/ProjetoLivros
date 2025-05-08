using System.Diagnostics.CodeAnalysis;
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

        [HttpGet("/ListarTodos")]
        public async Task<IActionResult> ListarTodosAsync()
        {
            var categoria = await _categoriaRepository.ListarTodosAsync();
            return Ok(categoria);
        }

        [HttpPost]
        public IActionResult Cadastrar(Categoria categoria)
        {
            _categoriaRepository.Cadastrar(categoria);
            return Created();
        }

        [HttpPut]
        public IActionResult Atualizar(int id, Categoria categoria)
        {
            var categoriaEncontrada = _categoriaRepository.Atualizar(id, categoria);

            return Ok(categoriaEncontrada);
        }
    }
}
