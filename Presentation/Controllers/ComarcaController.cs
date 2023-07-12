using cjuridico.Domain.CQ.Commands.Handlers.Comarca;
using cjuridico.Domain.CQ.Commands.Requests;
using cjuridico.Domain.CQ.Commands.Requests.Comarca;
using cjuridico.Domain.CQ.Querys.Handlers.Comarca;
using cjuridico.Domain.CQ.Querys.Responses.Comarca;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Presentation.Controllers;

[Route("v1/comarca")]
[ApiController]
public class ComarcaController : ControllerBase
{
    [HttpPost]
    [Route("criar")]
    public Task<ActionResult> Create([FromServices] ICreateComarcaHandler handler,
        [FromBody] CreateComarcaRequest request)
    {
        return handler.Handle(request);
    }

    [HttpDelete]
    [Route("")]
    public Task<ActionResult> Delete([FromServices] IDeleteComarcaHandler handler,
        [FromBody] DeleteRequest request)
    {
        return handler.Handle(request);
    }

    [HttpGet]
    [Route("")]
    public Task<List<ComarcaResponse>> GetAll([FromServices] IGetComarcaHandler handler)
    {
        return handler.Handle();
    }

    [HttpGet]
    [Route("{id:guid}")]
    public Task<ActionResult<ComarcaResponse>> GetById([FromServices] IGetComarcaPorIdHandler handler, Guid Id)
    {
        return handler.Handle(Id);
    }
}