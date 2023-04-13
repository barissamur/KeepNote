using KeepNoteAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var cs = builder.Configuration.GetConnectionString("BaglantiCumlesi"); // appsettings.json dosyas�ndaki Connection String c�mlesini al�yoruz
builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(cs));

//CORS ayarlar�
builder.Services.AddCors(options => options
    .AddDefaultPolicy(policy => policy
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()));

builder.Services.AddControllers();
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

// CORS ayarlar�
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
