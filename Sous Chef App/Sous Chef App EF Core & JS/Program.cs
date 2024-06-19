using Sous_Chef_App.Services;
using Sous_Chef_App.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Register dependencies for depednency injection

    // The UserController needs to access the UserService methods.
    // When an object of type IUserService is needed, create one using the UserService constructor and inject it where it's needed
    builder.Services.AddScoped<IUserService, UserService>();

    // The User Service needs to access UserData methods
    // When an object of type IUserData is needed, create one using the UserData constructor and inject it where it's needed
    builder.Services.AddScoped<IUserData, UserData>();// This adds our UserStorageEFRepo (data-access layer), that our UserService asks for. 

    builder.Services.AddScoped<IMealPlanService, MealPlanService>(); // 
    builder.Services.AddScoped<IMealPlanData, MealPlanData>();// 



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
