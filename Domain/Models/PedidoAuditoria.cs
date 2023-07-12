using cjuridico.Domain.Models.Enuns;
using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.Models;

public sealed class PedidoAuditoria : Entity
{
    public PedidoAuditoria()
    {
    }

    public PedidoAuditoria(Pedido pedido, Guid responsavel, DateTime data, EPedidoStatus pedidoStatus)
    {
        Pedido = pedido;
        Responsavel = responsavel;
        Data = data;
        PedidoStatus = pedidoStatus;
    }

    public Pedido Pedido { get; private set; }
    public Guid Responsavel { get; private set; }
    public DateTime Data { get; private set; }
    public EPedidoStatus PedidoStatus { get; private set; }
}