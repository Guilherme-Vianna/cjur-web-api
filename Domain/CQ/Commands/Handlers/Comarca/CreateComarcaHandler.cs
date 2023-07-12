using cjuridico.Domain.CQ.Commands.Requests.Comarca;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.Comarca;

public class CreateComarcaHandler : Commitable, ICreateComarcaHandler
{
    public CreateComarcaHandler(DataBase commandDb) : base(commandDb)
    {
    }

    public async Task<ActionResult> Handle(CreateComarcaRequest request)
    {
        try
        {
            await using (CommandDB)
            {
                var newComarca = new Models.Comarca(request.Nome, request.EstadoUF);
                await CommandDB.Comarca.AddAsync(newComarca);
                await CommandDB.SaveChangesAsync();

                return new OkObjectResult("Comarca cadastrada com Sucesso!");
            }
        }
        catch
        {
            return new OkObjectResult("Cadastro mal Sucedido!");
        }
    }
}