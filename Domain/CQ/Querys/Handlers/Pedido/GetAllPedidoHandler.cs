using cjuridico.Domain.CQ.Querys.Responses.Pedido;
using cjuridico.Infra;

namespace cjuridico.Domain.CQ.Querys.Handlers.Pedido;

public class GetAllPedidoHandler : Queryable, IGetAllPedidosHandler
{
    public GetAllPedidoHandler(DataBase dataBase) : base(dataBase)
    {
    }

    public async Task<List<GetAllPedidoResponse>> Handle(int page, Models.Enuns.EPedidoStatus? status)
    {
        try
        {
            await using (QueryDB)
            {
                List<GetAllPedidoResponse> response;

                if(status == null)
                {
                    response = QueryDB.Pedido
                    .Skip(page * 2)
                    .Take(2)
                    .Select(pedido => 
                        new GetAllPedidoResponse(
                        pedido.Id.ToString(),
                        pedido.Comarca.EstadoUF,
                        pedido.Cliente.Email,
                        pedido.NumeroPedido.ToString(),
                        pedido.NumeroDoProcesso,
                        pedido.ProfissionalSelecionado.Nome,
                        pedido.Executivo.Nome,
                        pedido.DataDoPedido,
                        pedido.DataDeCumprimento,
                        pedido.PedidoStatus.ToString()
                        )
                    ).ToList();

                    return response;
                } 

                response = QueryDB.Pedido
                    .Skip(page * 2)
                    .Where(pedido => pedido.PedidoStatus == status)
                    .Take(2)
                    .Select(pedido => 
                        new GetAllPedidoResponse(
                        pedido.Id.ToString(),
                        pedido.Comarca.EstadoUF,
                        pedido.Cliente.Email,
                        pedido.NumeroPedido.ToString(),
                        pedido.NumeroDoProcesso,
                        pedido.ProfissionalSelecionado.Nome,
                        pedido.Executivo.Nome,
                        pedido.DataDoPedido,
                        pedido.DataDeCumprimento,
                        pedido.PedidoStatus.ToString()
                        )
                    ).ToList();
                
                return response;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}