using cjuridico.Domain.CQ.Commands.Requests.PedidoR;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cjuridico.Domain.CQ.Commands.Handlers.PedidoC;

public class ChangePedidoData : Commitable, IChangePedidoData
{
    public ChangePedidoData(DataBase commandDb) : base(commandDb)
    {
    }

    public async Task<ActionResult> Handle(ChangePedidoDataRequest request)
    {
        await using (CommandDB)
        {
            try
            {
                var pedido = CommandDB.Pedido.AsTracking().FirstAsync(p => p.Id == request.PedidoId).Result;

                pedido.Descricao = request.Descricao;
                pedido.Conclusao = request.Conclusao;

                if (request.ComarcaId != null)
                    pedido.Comarca = CommandDB.Comarca.AsTracking().FirstAsync(p => p.Id == request.ComarcaId)
                        .Result;

                await CommandDB.SaveChangesAsync();
                return new OkObjectResult("Pedido Atualizado com Sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}