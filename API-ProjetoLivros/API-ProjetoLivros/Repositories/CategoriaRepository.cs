using API_ProjetoLivros.Context;
using API_ProjetoLivros.Interfaces;
using API_ProjetoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ProjetoLivros.Repositories
{
    //1- Herdar e implementar os metodos
    //2- Injetar o contexto
    public class CategoriaRepository : ICategoriaRepository // heranca
    {
        private readonly ProjetoLivrosContext _context; //injetar o contexto
        public CategoriaRepository(ProjetoLivrosContext context)//injetar o contexto
        {
            _context = context;//injetar o contexto
        }

        public Categoria? Atualizar(int id, Categoria categoria)
        {
            //1-Procuro quem atualizar
            var categoriaEncontrada = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);

            //2-Se nao acho, retorno julo
            if(categoriaEncontrada == null) return null;

            //3-Se acho eu atualizo as informacoes
            categoriaEncontrada.NomeCategoria = categoria.NomeCategoria;

            _context.SaveChanges();

            return categoriaEncontrada;

        }

        public void Cadastrar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges(); 
        }

        public Categoria? Deletar(int id)
        {
            //1-Produrar quem quer apagar
                      
            var categoria = _context.Categorias.Find(id); //o metodo Find s[o procura por id da tabela
            //2-Se nao achei, retorno nulo
            if (categoria == null) return null;
            
            //3-Se achei apago
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();

            return categoria;
        }

        public List<Categoria> ListarTodos() //metodo sincrono
        {
            return _context.Categorias
                .OrderBy(c => c.NomeCategoria)
                .ToList();
        }

        public async Task<List<Categoria>> ListarTodosAsync() //Metodo assincrono
        {
            return await _context.Categorias.ToListAsync();
        }
    }
}
