using cjuridico.Domain.CQ.Commands.Handlers.Usuario;
using cjuridico.Domain.CQ.Commands.Requests.Correspondente;
using cjuridico.Domain.Models.DTO;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.Correspondente;

public class CreateCorrespondenteHandler : Commitable, ICreateCorrespondenteHandler
{
    public CreateCorrespondenteHandler(DataBase commandDb) : base(commandDb)
    {
    }

    public async Task<ActionResult> Handle(CreateCorrespondenteRequest request, ICreateUsuarioHandler usuarioHandler)
    {
        try
        {
            await using (CommandDB)
            {
                var newCorrespondente = new Models.Correspondente(
                    await CommandDB.Comarca.FindAsync(request.ComarcaId),
                    request.Aprovado,
                    request.Email,
                    request.Nome,
                    request.NumeroOAB,
                    request.OABUF,
                    request.Cpf,
                    request.Rg
                );

                var usuarioDTO = new UsuarioDTO(request.Email, "Correspondente", request.Nome);

                var register = usuarioHandler.Handle(usuarioDTO).Result;

                if (register is not OkResult)
                    throw new Exception();

                await CommandDB.Correspondente.AddAsync(newCorrespondente);
                await CommandDB.SaveChangesAsync();
                return new OkObjectResult("Cadastrado com Sucesso");
            }
        }
        catch (Exception)
        {
            return new BadRequestObjectResult("Erro ao Cadastrar");
        }
    }
}