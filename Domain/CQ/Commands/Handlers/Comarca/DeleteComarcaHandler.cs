using cjuridico.Domain.CQ.Commands.Requests;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cjuridico.Domain.CQ.Commands.Handlers.Comarca
{
    public class DeleteComarcaHandler : Commitable, IDeleteComarcaHandler
    {
        public DeleteComarcaHandler(DataBase commandDb) : base(commandDb)
        {
        }

        public async Task<ActionResult> Handle(DeleteRequest request)
        {
            try
            {
                await using(CommandDB)
                {
                    var comarca = await CommandDB.Comarca.FirstAsync(c => c.Id == request.EntityId);    

                    if(comarca == null)
                        return new BadRequestObjectResult("Comarca não encontrada!");

                    CommandDB.Comarca.Remove(comarca);

                    await CommandDB.SaveChangesAsync();

                    return new OkObjectResult("Comarca Removida com Sucesso!");
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}