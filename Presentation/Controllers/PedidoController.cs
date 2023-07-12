using cjuridico.Domain.CQ.Commands.Handlers.PedidoC;
using cjuridico.Domain.CQ.Commands.Requests.Pedido;
using cjuridico.Domain.CQ.Commands.Requests.PedidoR;
using cjuridico.Domain.CQ.Querys.Handlers.Pedido;
using cjuridico.Domain.CQ.Querys.Responses.Pedido;
using cjuridico.Domain.Models.Enuns;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Presentation.Controllers;

//[Authorize(AuthenticationSchemes = "Bearer"), Authorize(Roles = "Cliente")]
[ApiController]
[Route("v1/pedido")]
public class PedidoController : ControllerBase
{
    [Route("criar")]
    [HttpPost]
    public async Task<ActionResult> Create([FromServices] ICreatePedidoHandler handler,
        [FromBody] CreatePedidoRequest request)
    {
        return await handler.Handle(request);
    }

    [Route("alterar")]
    [HttpPatch]
    public async Task<ActionResult> Change([FromServices] IChangePedidoData handler,
        [FromBody] ChangePedidoDataRequest request)
    {
        return await handler.Handle(request);
    }

    [Route("alterar/status")]
    [HttpPatch]
    public async Task<ActionResult> ChangeStatus([FromServices] IChangePedidoStatusHandler handler,
        [FromBody] ChangePedidoStatusRequest request)
    {
        return await handler.Handle(request);
    }

    [Route("listar")]
    [HttpGet]
    public async Task<List<GetAllPedidoResponse>> List([FromServices] IGetAllPedidosHandler handler, [FromQuery] int page, [FromQuery] EPedidoStatus? status)
    {
        return await handler.Handle(page, status);
    }

    [Route("add/comarca")]
    [HttpPut]
    public async Task<ActionResult> AddComarca([FromServices] IAddComarcaPedidoHandler handler,
        [FromBody] AddComarcaRequest request)
    {
        return await handler.Handle(request);
    }

    [Route("add/correspondente")]
    [HttpPut]
    public async Task<ActionResult> AddCorrespondente([FromServices] IAddCorrespondenteHandler handler,
        [FromBody] AddCorrespondenteRequest request)
    {
        return await handler.Handle(request);
    }
}