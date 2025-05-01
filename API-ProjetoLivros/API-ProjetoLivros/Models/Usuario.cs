﻿namespace API_ProjetoLivros.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int TipoUsuarioId { get; set; }
        public TipoUsuario? TipoUsuario { get; set; } //Criar navegacao para a tabela tipo usuario, interrogacao (?) indica que este campo pode ser nulo ou opcional e o entityframework que vai preeencher automaticamente este campo  
    }
}
