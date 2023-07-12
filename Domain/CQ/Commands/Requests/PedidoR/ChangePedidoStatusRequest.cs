using cjuridico.Domain.Models.Enuns;

namespace cjuridico.Domain.CQ.Commands.Requests.PedidoR;

public class ChangePedidoStatusRequest
{
    public ChangePedidoStatusRequest(Guid pedidoId, EPedidoStatus novoStatus)
    {
        PedidoId = pedidoId;
        NovoStatus = novoStatus;
    }

    public Guid PedidoId { get; private set; }
    public EPedidoStatus NovoStatus { get; private set; }
}