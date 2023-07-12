using cjuridico.Domain.CQ.Commands.Requests.PedidoR;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.PedidoC
{
    public class AddCorrespondenteHandler : Commitable, IAddCorrespondenteHandler
    {
        public AddCorrespondenteHandler(DataBase commandDb) : base(commandDb)
        {
        }

        public async Task<ActionResult> Handle(AddCorrespondenteRequest request)
        {
            try
            {
                await using(CommandDB)
                {
                    var pedido = CommandDB.Pedido.FindAsync(request.PedidoId).Result;
                    var correspondente = CommandDB.Correspondente.FindAsync(request.CorrespondenteId).Result;
                    
                    if(pedido == null)
                        return new BadRequestObjectResult("Pedido não encontrado");

                    if(correspondente == null)
                        return new BadRequestObjectResult("Correspondente não encontrado");

                    pedido.ProfissionalSelecionado = correspondente; 
                    CommandDB.Pedido.Update(pedido);
                    await CommandDB.SaveChangesAsync(); 
                    return new OkObjectResult("Correspondente adicionado com sucesso");
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}