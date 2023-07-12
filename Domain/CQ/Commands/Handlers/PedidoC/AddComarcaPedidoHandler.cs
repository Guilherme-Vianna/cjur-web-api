using cjuridico.Domain.CQ.Commands.Requests.PedidoR;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cjuridico.Domain.CQ.Commands.Handlers.PedidoC;

public class AddComarcaPedidoHandler : Commitable, IAddComarcaPedidoHandler
{
    public AddComarcaPedidoHandler(DataBase commandDb) : base(commandDb)
    {
    }

    public async Task<ActionResult> Handle(AddComarcaRequest pedidoHandler)
    {
        try
        {
            await using (CommandDB)
            {
                var pedido = CommandDB.Pedido.AsTracking().FirstAsync(p => p.Id == pedidoHandler.PedidoId).Result;
                var newComarca = CommandDB.Comarca.FirstAsync(c => c.Id == pedidoHandler.ComarcaId).Result;
                pedido.Comarca = newComarca;

                await CommandDB.SaveChangesAsync();
                return new OkResult();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}