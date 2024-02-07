using BaseRest.Core.API.Common;
using Model;
using Model.Common;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

#region Add services to the container

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbModelContext>();

#endregion

#region Aplication

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

#endregion


