using cjuridico.Domain.CQ.Commands.Requests.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.Usuario;

public interface IChangeUsuarioPasswordHandler
{
    public Task<ActionResult> Handle(ChangeSenhaRequest request);
}