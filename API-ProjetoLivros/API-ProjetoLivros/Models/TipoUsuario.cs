namespace API_ProjetoLivros.Models
{
    public class TipoUsuario
    {
        //Definindo as propriedade do tipo de usuario, a propriedade TipoUsuarioId, por padrao precisa ter o nome da tabela "TipoUsuario" e na sequencia "Id", desta formao entityframework reconhece como chave primaria
        public int TipoUsuarioId { get; set; } 
        public string DescricaoTipo { get; set; }
        public List<Usuario> Usuarios { get; set; } = new();//Criar uma lista de usuario para que, pelo tipo do usuario seja possivel visualizar todos os usuarios vinculados ao tipo do usuario. O new() serve para nao retornar uma lista nula
    }
}
