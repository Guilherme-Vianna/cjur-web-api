namespace cjuridico.Domain.CQ.Commands.Requests.PedidoR
{
    public class AddCorrespondenteRequest
    {
        public AddCorrespondenteRequest(Guid pedidoId, Guid correspondenteId)
        {
            PedidoId = pedidoId;
            CorrespondenteId = correspondenteId;
        }
        public Guid PedidoId { get; set; }
        public Guid CorrespondenteId { get; set; }
    }
}