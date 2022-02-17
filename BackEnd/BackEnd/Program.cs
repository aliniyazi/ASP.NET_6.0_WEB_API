using BackEnd.Data;
using BackEnd.Repositories;
using BackEnd.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;

var myAllowOrigins = "AllowOrigin";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Added DbConnection
builder.Services.AddDbContext<DBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//Added CORS 
builder.Services.AddCors(options =>
{
    options.AddPolicy(name:myAllowOrigins, x =>
    {
        x.AllowAnyHeader();
        x.AllowAnyMethod();
        x.AllowAnyOrigin();
    });
});
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(myAllowOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
