using cjuridico.Domain.CQ.Commands.Requests.PedidoR;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.PedidoC;

public interface IAddComarcaPedidoHandler
{
    public Task<ActionResult> Handle(AddComarcaRequest pedidoHandler);
}