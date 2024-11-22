using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<MongoDBSettings>(
    builder.Configuration.GetSection("MongoDBSettings"));

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("MongoDBSettings:ConnectionString")));

builder.Services.AddScoped(s =>
   s.GetRequiredService<IMongoClient>().GetDatabase(
       builder.Configuration.GetValue<string>("MongoDBSettings:DatabaseName")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<vRootDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
        mysqlOptions =>
        {
            mysqlOptions.MigrationsAssembly(typeof(vRootDbContext).Assembly.FullName);
        }));

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
