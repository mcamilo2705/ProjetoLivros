namespace API_ProjetoLivros.Models
{
    public class Assinatura
    {
        public int AssinaturaId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Status { get; set; }
        public Usuario? Usuario { get; set; }//Criar navegacao para a tabela usuario, interrogacao (?) indica que este campo pode ser nulo ou opcional e o entityframework que vai preeencher automaticamente este campo
    }
}
