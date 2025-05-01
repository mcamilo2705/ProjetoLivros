namespace API_ProjetoLivros.Models
{
    public class Categoria
    {
        //Definindo as propriedade do tipo de usuario
        public int CategoriaId { get; set; }
        public string NomeCategoria { get; set; }
        public List<Livro> Livros { get; set; } = new();//Criar uma lista de livro para que, pela categoria do livro seja possivel visualizar todos os livros vinculados ao a categoria. O new() serve para nao retornar uma lista nula
    }
}
