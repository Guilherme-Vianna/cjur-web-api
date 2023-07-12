using cjuridico.Domain.CQ.Commands.Handlers.Usuario;
using cjuridico.Domain.CQ.Commands.Requests.Usuario;
using cjuridico.Domain.CQ.Commands.Responses;
using cjuridico.Domain.CQ.Querys.Handlers.Usuario;
using cjuridico.Domain.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Presentation.Controllers;

[Route("v1/user")]
[ApiController]
public class UsuarioController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    public async Task<UserData> GetData([FromServices] IGetUsuarioData handler, string id)
    {
        return await handler.Handle(id);
    }

    [HttpPost("register")]
    public async Task<ActionResult<CreateUsuarioResponse>> RegisterUser([FromServices] ICreateUsuarioHandler handler,
        [FromBody] UsuarioDTO model)
    {
        return await handler.Handle(model);
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoginUsuarioResponse>> Login([FromServices] ILoginUsuarioHandler handler,
        [FromBody] UsuarioLogin userInfo)
    {
        return await handler.Handle(userInfo);
    }

    [HttpPost("changepwd")]
    public async Task<ActionResult> ChangePassword([FromServices] IChangeUsuarioPasswordHandler handler,
        [FromBody] ChangeSenhaRequest request)
    {
        return await handler.Handle(request);
    }
}