using cjuridico.Domain.CQ.Commands.Handlers.Correspondente;
using cjuridico.Domain.CQ.Commands.Handlers.Usuario;
using cjuridico.Domain.CQ.Commands.Requests.Correspondente;
using cjuridico.Domain.CQ.Querys.Handlers.Correspondente;
using cjuridico.Domain.CQ.Querys.Responses.Correspondente;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Presentation.Controllers;

[Route("v1/correspondente")]
[ApiController]
public class CorrespondenteController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<CorrespondenteResponse>>> GetAll(
        [FromServices] IGetAllCorrespondenteHandler getAllHandler, [FromQuery] string? UF)
    {
        return await getAllHandler.Handle(UF);
    }

    [HttpPost]
    [Route("criar")]
    public async Task<ActionResult> Create([FromServices] ICreateCorrespondenteHandler getHandler,
        [FromBody] CreateCorrespondenteRequest request, [FromServices] ICreateUsuarioHandler usuarioHandler)
    {
        return await getHandler.Handle(request, usuarioHandler);
    }

    [HttpPatch]
    [Route("")]
    public async Task<ActionResult> Update([FromServices] IChangeCorrespondenteDataHandler getHandler, [FromBody] ChangeCorrespondenteDataRequest request)
    {
        return await getHandler.Handle(request);
    }
}