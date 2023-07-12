using cjuridico.Domain.CQ.Commands.Responses;
using cjuridico.Domain.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.Usuario;

public interface ILoginUsuarioHandler
{
    public Task<ActionResult<LoginUsuarioResponse>> Handle(UsuarioLogin userInfo);
}