using cjuridico.Domain.CQ.Commands.Handlers.Usuario;
using cjuridico.Domain.CQ.Commands.Requests.ExecutivoDeConta;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.ExecutivoDeConta;

public interface ICreateExecutivoDeContaHandler
{
    public Task<ActionResult> Handle(CreateExecutivoDeContaRequest request, ICreateUsuarioHandler usuarioHandler);
}