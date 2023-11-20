using ApplicationService.Application;
using ApplicationService.Interface;
using DDD.Infra.SQLServer;
using DDD.Infra.SQLServer.Interfaces;
using DDD.Infra.SQLServer.Repositories;
using DomainService.Interface;
using DomainService.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
//using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//Autorização para requisição com o CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
        builder.WithOrigins("*")
               .AllowAnyMethod()
               .AllowAnyHeader());
});


// Add services to the container.

//IOC - Dependency Injection
//builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepositorySqlServer>();
builder.Services.AddScoped<ITipoDeCrimeRepository, TipoDeCrimeRepositorySqlServer>();
builder.Services.AddScoped<IEstadoRepository, EstadoRepositorySqlServer>();
builder.Services.AddScoped<ICidadeRepository, CidadeRepositorySqlServer>();
builder.Services.AddScoped<IDenunciasRepository, DenunciasRepositorySqlServer>();
builder.Services.AddScoped<IDenunciasConfirmRepository, DenunciasConfirmRepositorySqlServer>();

//Dependency Injection Application
builder.Services.AddScoped<ITipoDeCrimeApplication, TipoDeCrimeApplication>();
builder.Services.AddScoped<ICidadeApplication, CidadeApplication>();
builder.Services.AddScoped<IEstadoApplication, EstadoApplication>();
builder.Services.AddScoped<IDenunciaApplication, DenunciaApplication>();
builder.Services.AddScoped<IUsuarioApplication, UsuarioApplication>();
builder.Services.AddScoped<IDenunciaConfirmApplication, DenunciaConfirmApplication>();


//Dependency Injection Service
builder.Services.AddScoped<ITipoDeCrimeService, TipoDeCrimeService>();
builder.Services.AddScoped<ICidadeService, CidadeService>();
builder.Services.AddScoped<IDenunciaService, DenunciaService>();
builder.Services.AddScoped<IEstadoService, EstadoService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IDenunciaConfirmService, DenunciaConfirmService>();



////Dependency Injection SqlContext
builder.Services.AddScoped<SqlContext, SqlContext>();

//builder.Services.AddControllers().AddJsonOptions(x =>
//   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
    {
        new OpenApiSecurityScheme
        {
        Reference = new OpenApiReference
            {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
            },
            Scheme = "oauth2",
            Name = "Bearer",
            In = ParameterLocation.Header,

        },
        new List<string>()
        }
    });
}
);

var key = Encoding.ASCII.GetBytes(DDD.Domain.Key.Secret);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigin");


app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
