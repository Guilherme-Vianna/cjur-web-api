namespace cjuridico.Domain.CQ.Commands.Requests.PedidoR;

public class AddComarcaRequest
{
    public AddComarcaRequest(Guid comarcaid, Guid pedidoid)
    {
        ComarcaId = comarcaid;
        PedidoId = pedidoid;
    }

    public Guid ComarcaId { get; private set; }
    public Guid PedidoId { get; private set; }
}