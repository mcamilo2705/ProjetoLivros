using API_ProjetoLivros.Context;
using API_ProjetoLivros.Interfaces;
using API_ProjetoLivros.Repositories;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

//Avisa que a api/aplicacao usa controllers
builder.Services.AddControllers();

//Adiciono o gerador de swagger
builder.Services.AddSwaggerGen();

//dotnet ef migrations add Inicial 
//dotnet ef database update
builder.Services.AddDbContext<ProjetoLivrosContext>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();


var app = builder.Build();

//Avisa o .NET que eu tenho Controladores
app.MapControllers();

//Para usar o swagger na aplicacao 
app.UseSwagger();
//Caso quiser que ao iniciar a aplicacao, ja carregue o swagger deverar fazer as linhas de comando abaixo



app.UseSwaggerUI(options => 
{ 
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"); 
    options.RoutePrefix = string.Empty;
}); 


app.Run();
