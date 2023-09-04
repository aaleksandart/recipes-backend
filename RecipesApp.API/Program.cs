using MongoDB.Driver;
using RecipesApp.API.Services;
using RecipesApp.API.Services.Interfaces;
using RecipesApp.DATA.Database;
using RecipesApp.DATA.Entities;
using RecipesApp.DATA.Repositories;
using RecipesApp.DATA.Repositories.Interfaces;
using RecipesApp.DATA.Services;
using RecipesApp.DATA.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var config = builder.Configuration;

// Add services to the container.
builder.Services.AddControllers();

//Services
services.AddScoped<IValidationService, ValidationService>();
services.AddScoped<IUserService, UserService>();
services.AddScoped<IRecipeService, RecipeService>();

//Repositories
services.AddSingleton<IUserRepository, UserRepository>();
services.AddSingleton<IRecipeRepository, RecipeRepository>();

//Database
services.Configure<RecipesDatabaseSettings>(options =>
{
    options.ConnectionString = config["MongoDB:Connection"] ?? string.Empty;
    options.DatabaseName = config["MongoDB:Database"] ?? string.Empty;
    options.UsersCollection = config["MongoDB:UsersCollection"] ?? string.Empty;
    options.RecipesCollection = config["MongoDB:RecipesCollection"] ?? string.Empty;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
