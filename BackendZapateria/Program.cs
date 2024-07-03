using ApiWeb.Middleware.Error;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using UtilityAutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Control de Almacen de Zapateria D`Lopez",
        Description = "Control de Almacen de Zapatos, Material y ventas",
        Contact = new OpenApiContact
        {
            Name = "Nombre del Programador ",
            Email = "Correo"
        }
    });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPathname = Path.Combine(AppContext.BaseDirectory, xmlFilename);
    //options.IncludeXmlComments(xmlPathname, includeControllerXmlComments: true);
});
// Configuracion del AutoMapper
builder.Services.AddAutoMapper(typeof(IStartup).Assembly, typeof(UtilAutomapperProfile).Assembly);


builder.Services.AddAuthentication("Bearer").AddJwtBearer(opt =>
{
    var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]));
    var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature);
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = false,
        ValidateIssuer = false,
        IssuerSigningKey = signingKey
    };

});
//Configuracion de cors
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "origins", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
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
app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware(typeof(ApiMiddleware));

app.UseCors("origins");
app.MapControllers();

app.Run();
