
using CarCharging.Core.Service;
using CarCharging.Core.Mapping;
using CarCharging.Core.Repositories;
using CarCharging.Data;
using CarCharging.Data.Repositories;
using CarCharging.Service;
using CarCharging.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(@"Server=DESKTOP-9QGFF01;DataBase=Car_Charging_Db;TrustServerCertificate=True;Trusted_Connection=True"));

builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(PostModelsMappingProfile));

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
