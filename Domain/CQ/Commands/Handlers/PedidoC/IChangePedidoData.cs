using cjuridico.Domain.CQ.Commands.Requests.PedidoR;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.PedidoC;

public interface IChangePedidoData
{
    public Task<ActionResult> Handle(ChangePedidoDataRequest request);
}