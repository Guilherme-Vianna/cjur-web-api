using cjuridico.Domain.CQ.Querys.Handlers.Esfera;
using cjuridico.Domain.CQ.Querys.Responses.Esfera;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Presentation.Controllers;

[Route("cjuridico/esfera")]
[ApiController]
public class EsferaController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public List<GetEsferaResponse> GetEsfera([FromServices] IGetEsferaHandler getHandler)
    {
        return getHandler.Handle();
    }
}