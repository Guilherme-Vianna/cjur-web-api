using cjuridico.Domain.CQ.Commands.Handlers.Usuario;
using cjuridico.Domain.CQ.Commands.Requests.ExecutivoDeConta;
using cjuridico.Domain.Models.DTO;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.ExecutivoDeConta;

public class CreateExecutivoDeContaHandler : Commitable, ICreateExecutivoDeContaHandler
{
    public CreateExecutivoDeContaHandler(DataBase commandDb) : base(commandDb)
    {
    }

    public async Task<ActionResult> Handle(CreateExecutivoDeContaRequest request, ICreateUsuarioHandler usuarioHandler)
    {
        await using (CommandDB)
        {
            try
            {
                var newExecutivoDeConta = new Models.ExecutivoDeConta(
                    request.Nome
                );

                var usuarioDTO = new UsuarioDTO(request.Email, "Administrador", request.Nome);

                var register = usuarioHandler.Handle(usuarioDTO).Result;

                if (register is not OkResult)
                    throw new Exception();

                await CommandDB.ExecutivoDeConta.AddAsync(newExecutivoDeConta);
                await CommandDB.SaveChangesAsync();
                return new OkObjectResult("Cadastrado com Sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}