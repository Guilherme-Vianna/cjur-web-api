using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Requests.PedidoR;

public interface IChangePedidoStatusHandler
{
    public Task<ActionResult> Handle(ChangePedidoStatusRequest request);
}