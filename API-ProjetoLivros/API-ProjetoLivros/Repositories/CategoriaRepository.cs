using API_ProjetoLivros.Context;
using API_ProjetoLivros.Interfaces;
using API_ProjetoLivros.Models;

namespace API_ProjetoLivros.Repositories
{
    internal class CategoriaRepository : ICategoriaRepository
    {
        private readonly ProjetoLivrosContext _context;
        public CategoriaRepository(ProjetoLivrosContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Categoria BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
