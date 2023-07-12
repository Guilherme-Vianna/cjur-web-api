using cjuridico.Domain.CQ.Commands.Requests.PedidoR;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cjuridico.Domain.CQ.Commands.Handlers.PedidoC;

public class ChangePedidoStatusHandler : Commitable, IChangePedidoStatusHandler
{
    public ChangePedidoStatusHandler(DataBase commandDb) : base(commandDb)
    {
    }

    public async Task<ActionResult> Handle(ChangePedidoStatusRequest request)
    {
        await using (CommandDB)
        {
            try
            {
                var pedido = CommandDB.Pedido.AsTracking().FirstAsync(p => p.Id == request.PedidoId).Result;
                pedido.PedidoStatus = request.NovoStatus;

                await CommandDB.SaveChangesAsync();
                return new OkObjectResult("Status do Pedido Atualizado com Sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}