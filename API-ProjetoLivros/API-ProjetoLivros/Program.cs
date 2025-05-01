using API_ProjetoLivros.Context;

var builder = WebApplication.CreateBuilder(args);

//dotnet ef migrations add Inicial 
//dotnet ef database update
builder.Services.AddDbContext<ProjetoLivrosContext>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
