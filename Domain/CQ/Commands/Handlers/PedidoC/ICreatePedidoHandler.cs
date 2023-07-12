using cjuridico.Domain.CQ.Commands.Requests.Pedido;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.PedidoC;

public interface ICreatePedidoHandler
{
    public Task<ActionResult> Handle(CreatePedidoRequest request);
}