using cjuridico.Domain.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.Usuario;

public interface ICreateUsuarioHandler
{
    public Task<ActionResult> Handle(UsuarioDTO model);
}