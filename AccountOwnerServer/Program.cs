using AccountOwnerServer.Extensions;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureCors();//Agregado
builder.Services.ConfigureIISIntegration();//Agregado
builder.Services.ConfigureMySqlContext(builder.Configuration);//Agregado
builder.Services.ConfigureRepositories();//Agregado

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

//Agregado
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseHsts();

//Quitar este comentario cuando se publiquen los microservicios correspondientes en el AKS
//app.UseHttpsRedirection();

app.UseStaticFiles();//Agregado

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});//Agregado

app.UseCors("CorsPolicy");//Agregado

app.UseAuthorization();

app.MapControllers();

app.Run();
