using cjuridico.Domain.CQ.Querys.Handlers.Cliente;
using cjuridico.Domain.CQ.Querys.Responses.Cliente;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Presentation.Controllers;

[Authorize(AuthenticationSchemes = "Bearer")]
[Authorize(Roles = "Administrador")]
[Route("v1/cliente")]
[ApiController]
public class ClienteController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public List<ClienteResponse> GetCliente([FromServices] IGetClienteHandler getHandler)
    {
        return getHandler.Handle();
    }

    [HttpGet]
    [Route("completo")]
    public List<ClienteCompletoResponse> GetClienteCompleto([FromServices] IGetClienteCompletoHandler getHandler)
    {
        return getHandler.Handle();
    }

    [HttpGet]
    [Route("{id:guid}")]
    public List<ClientePorIdResponse> GetClientePorId([FromServices] IGetClientePorIdHandler getHandler, Guid id)
    {
        return getHandler.Handle(id);
    }
}