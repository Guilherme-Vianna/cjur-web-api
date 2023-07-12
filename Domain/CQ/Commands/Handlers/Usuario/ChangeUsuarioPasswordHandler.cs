using cjuridico.Domain.CQ.Commands.Requests.Usuario;
using cjuridico.Infra;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cjuridico.Domain.CQ.Commands.Handlers.Usuario;

public class ChangeUsuarioPasswordHandler : Commitable, IChangeUsuarioPasswordHandler
{
    private readonly UserManager<IdentityUser> _userManager;

    public ChangeUsuarioPasswordHandler(DataBase commandDb, UserManager<IdentityUser> userManager) : base(commandDb)
    {
        _userManager = userManager;
    }

    public async Task<ActionResult> Handle(ChangeSenhaRequest request)
    {
        try
        {
            await using (CommandDB)
            {
                var usuario = await CommandDB.Usuario.FirstAsync(u => u.Email == request.Email);
                var change = await _userManager.ChangePasswordAsync(usuario, request.Senha, request.NovaSenha);

                if (!change.Succeeded) return new BadRequestObjectResult("Erro ao alterar senha");

                await ChangeFirstAccess(request.Email);

                return new OkObjectResult("Senha alterada com sucesso");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private async Task ChangeFirstAccess(string email)
    {
        try
        {
            await using (CommandDB)
            {
                var usuario = await CommandDB.Usuario.AsTracking().FirstAsync(u => u.Email == email);
                usuario.IsPrimeiroAcesso = false;
                await CommandDB.SaveChangesAsync();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}