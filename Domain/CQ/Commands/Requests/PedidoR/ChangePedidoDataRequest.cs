namespace cjuridico.Domain.CQ.Commands.Requests.PedidoR;

public class ChangePedidoDataRequest
{
    public ChangePedidoDataRequest(Guid pedidoId, Guid? comarcaId, string? descricao, string? conclusao)
    {
        PedidoId = pedidoId;
        ComarcaId = comarcaId;
        Descricao = descricao;
        Conclusao = conclusao;
    }

    public Guid PedidoId { get; private set; }
    public Guid? ComarcaId { get; private set; }
    public string? Descricao { get; private set; }
    public string? Conclusao { get; private set; }
}