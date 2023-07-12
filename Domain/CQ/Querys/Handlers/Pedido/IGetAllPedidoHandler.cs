using cjuridico.Domain.CQ.Querys.Responses.Pedido;

namespace cjuridico.Domain.CQ.Querys.Handlers.Pedido;

public interface IGetAllPedidosHandler
{
    public Task<List<GetAllPedidoResponse>> Handle(int page, Models.Enuns.EPedidoStatus? status);
}