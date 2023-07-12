using cjuridico.Domain.CQ.Commands.Handlers.Usuario;
using cjuridico.Domain.CQ.Commands.Requests.Correspondente;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.Correspondente;

public interface ICreateCorrespondenteHandler
{
    public Task<ActionResult> Handle(CreateCorrespondenteRequest request, ICreateUsuarioHandler usuarioHandler);
}