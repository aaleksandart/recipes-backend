using RecipesApp.API.Helpers;
using RecipesApp.API.Helpers.Interfaces;
using RecipesApp.DATA.Database;
using RecipesApp.DATA.Repositories;
using RecipesApp.DATA.Repositories.Interfaces;
using RecipesApp.DATA.Services;
using RecipesApp.DATA.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var config = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();

//Helpers
services.AddScoped<IUserValidation, UserValidation>();
services.AddScoped<IRecipeValidation, RecipeValidation>();

//Services
services.AddScoped<IUserService, UserService>();
services.AddScoped<IRecipeService, RecipeService>();

//Repositories
services.AddSingleton<IUserRepository, UserRepository>();
services.AddSingleton<IRecipeRepository, RecipeRepository>();

//Database
services.Configure<RecipesDatabaseSettings>(config.GetSection("MongoDB:Database"));

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
