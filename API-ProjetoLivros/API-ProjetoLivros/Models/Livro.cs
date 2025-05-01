namespace API_ProjetoLivros.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; } //Criar navegacao para a tabela categoria, interrogacao (?) indica que este campo pode ser nulo ou opcional e o entityframework que vai preeencher automaticamente este campo
    }
}
