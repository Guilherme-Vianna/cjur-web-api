using cjuridico.Domain.CQ.Commands.Handlers.ExecutivoDeConta;
using cjuridico.Domain.CQ.Commands.Handlers.Usuario;
using cjuridico.Domain.CQ.Commands.Requests.ExecutivoDeConta;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Presentation.Controllers;

// [Authorize(AuthenticationSchemes = "Bearer")]
// [Authorize(Roles = "Administrador")]
[Route("v1/executivo")]
[ApiController]
public class ExecutivoDeContaController
{
    [HttpPost]
    [Route("criar")]
    public async Task<ActionResult> Create([FromServices] ICreateExecutivoDeContaHandler handle,
        [FromBody] CreateExecutivoDeContaRequest request, [FromServices] ICreateUsuarioHandler userManager)
    {
        return await handle.Handle(request, userManager);
    }
}