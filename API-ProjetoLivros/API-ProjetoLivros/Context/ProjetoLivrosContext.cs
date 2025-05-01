//No context sera definido onde as tabelas serao criadas

using System.Reflection.Metadata.Ecma335;
using API_ProjetoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ProjetoLivros.Context
{
    public class ProjetoLivrosContext : DbContext //Todos context precisa herdar o contexto do entityframework
    {
        //Cada tabela precisa ter um DbSet, ou seja, uma tabela no banco de dados

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet <TipoUsuario> TiposUsuarios { get; set; }
        public DbSet<Assinatura> Assinaturas { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        //Cria um construtor com atalho ctor
        public ProjetoLivrosContext(DbContextOptions<ProjetoLivrosContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Informar a string de conexao
            optionsBuilder.UseSqlServer("Data Source=NOTE10-S28\\SQLEXPRESS;Initial Catalog=Livros;User Id=sa;Password=Senai@134;TrustServerCertificate=true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Modelagem da tabela usuario
            modelBuilder.Entity<Usuario>(
                entity => //variavel para representar uma tabela
                {
                    //Definicao da propriedades da tabela
                    //Primary key
                    entity.HasKey(u => u.UsuarioId); //informando que a tabale de usuario tem o campo u.UsuarioId

                    //Selecionando o campo para cofigurar os campos
                    entity.Property(u => u.NomeCompleto)
                    .IsRequired() //campo obrigatorio
                    .HasMaxLength(150) //maximo de caracteres
                    .IsUnicode(false); //nao vai gerar o campo do tipo nvarchar

                    entity.Property(u=>u.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode (false);

                    entity.HasIndex(u => u.Email) //configuracao para definir que o email seja unico
                    .IsUnique();//configuracao para definir que o email seja unico. Todo campo unico e um index no banco de dados

                    entity.Property(u => u.Senha)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                    entity.Property(u => u.Telefone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                    entity.Property(u => u.DataCadastro)
                    .IsRequired();

                    entity.Property(u => u.DataAtualizacao)
                    .IsRequired();

                    entity.HasOne(u => u.TipoUsuario) //Da tabela usuario para fazer o relacionamento com a tabela tipo de usuario
                    .WithMany(t => t.Usuarios)
                    .HasForeignKey(u => u.UsuarioId) //definindo a chave estrangeira
                    .OnDelete(DeleteBehavior.Cascade); //cascade --> se apagar o tipo de usuario administrator, ele vai remover                                      todos os usuario que tem vinculo com o tipo administrador
                                                        //setnull --> todos os cliente que era administrador, o campo fica com o                            valor nulo
                                           
                    
                }

             );
        }
    }
}
