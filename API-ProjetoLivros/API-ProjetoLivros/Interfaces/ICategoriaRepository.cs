using API_ProjetoLivros.Models;

namespace API_ProjetoLivros.Interfaces
{
    public interface ICategoriaRepository
    {

        //Criar metodos assincronos - Taks(tarefas)
        Task<List<Categoria>> ListarTodosAsync(); //metodo assincrono usa a palavra Task
        List<Categoria> ListarTodos();//metodo sincrono
        void Cadastrar(Categoria categoria);
        Categoria? Atualizar(int id, Categoria categoria); //modelo simples, ou seja, diferente do projeto Ecommerce
        Categoria? Deletar (int id);//modelo simples, ou seja, diferente do projeto Ecommerce

    }
}
