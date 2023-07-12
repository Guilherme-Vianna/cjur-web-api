using System.Text;
using cjuridico.Domain.CQ.Commands.Handlers.Comarca;
using cjuridico.Domain.CQ.Commands.Handlers.Correspondente;
using cjuridico.Domain.CQ.Commands.Handlers.ExecutivoDeConta;
using cjuridico.Domain.CQ.Commands.Handlers.PedidoC;
using cjuridico.Domain.CQ.Commands.Handlers.Usuario;
using cjuridico.Domain.CQ.Commands.Requests.PedidoR;
using cjuridico.Domain.CQ.Querys.Handlers.Cliente;
using cjuridico.Domain.CQ.Querys.Handlers.Comarca;
using cjuridico.Domain.CQ.Querys.Handlers.Correspondente;
using cjuridico.Domain.CQ.Querys.Handlers.Pedido;
using cjuridico.Domain.CQ.Querys.Handlers.Solicitacao;
using cjuridico.Domain.CQ.Querys.Handlers.Usuario;
using cjuridico.Infra;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataBase>(options =>
{
    options.UseSqlServer("name=ConnectionStrings:DefaultConnection");
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
}, ServiceLifetime.Transient);


builder.Services.AddTransient<IGetClienteHandler, GetClienteHandler>();

builder.Services.AddTransient<IGetComarcaHandler, GetComarcaHandler>();

builder.Services.AddTransient<ILoginUsuarioHandler, LoginUsuarioHandler>();
builder.Services.AddTransient<ICreateUsuarioHandler, CreateUsuarioHandler>();
builder.Services.AddTransient<IChangeUsuarioPasswordHandler, ChangeUsuarioPasswordHandler>();

builder.Services.AddTransient<ICreatePedidoHandler, CreatePedidoHandler>();
builder.Services.AddTransient<IChangePedidoStatusHandler, ChangePedidoStatusHandler>();
builder.Services.AddTransient<IChangePedidoData, ChangePedidoData>();
builder.Services.AddTransient<IAddCorrespondenteHandler, AddCorrespondenteHandler>();
builder.Services.AddTransient<IGetAllPedidosHandler, GetAllPedidoHandler>();
builder.Services.AddTransient<IAddComarcaPedidoHandler, AddComarcaPedidoHandler>();

builder.Services.AddTransient<ICreateExecutivoDeContaHandler, CreateExecutivoDeContaHandler>();

builder.Services.AddTransient<IGetUsuarioData, GetUsuarioData>();

builder.Services.AddTransient<IGetComarcaHandler, GetComarcaHandler>();
builder.Services.AddTransient<IDeleteComarcaHandler, DeleteComarcaHandler>();
builder.Services.AddTransient<ICreateComarcaHandler, CreateComarcaHandler>();
builder.Services.AddTransient<IGetComarcaPorIdHandler, GetComarcaPorIdHandler>();

builder.Services.AddTransient<IGetSolicitacaoHandler, GetSolicitacaoHandler>();
builder.Services.AddTransient<IGetSolicitacaoTipoDeTrabalhoHandler, GetSolicitacaoTipoDeTrabalhoHandler>();

builder.Services.AddTransient<ICreateCorrespondenteHandler, CreateCorrespondenteHandler>();
builder.Services.AddTransient<IGetAllCorrespondenteHandler, GetAllCorrespondenteHandler>();
builder.Services.AddTransient<IChangeCorrespondenteDataHandler, ChangeCorrespondenteDataHandler>();


builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<DataBase>()
    .AddDefaultTokenProviders();


builder.Services.AddAuthentication(
    JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidAudience = builder.Configuration["TokenConfiguration:Audience"],
        ValidIssuer = builder.Configuration["TokenConfiguration:Issuer"],
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["Jwt:key"]))
    });

builder.Services.AddCors();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsStaging())
{
}

app.UseHttpsRedirection();

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

app.MapControllers();

app.Run();