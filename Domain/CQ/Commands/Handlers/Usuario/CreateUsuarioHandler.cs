using cjuridico.Domain.Models.DTO;
using cjuridico.Domain.Models.Email;
using cjuridico.Domain.Models.Helper;
using cjuridico.Infra;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sib_api_v3_sdk.Model;

namespace cjuridico.Domain.CQ.Commands.Handlers.Usuario;

public sealed class CreateUsuarioHandler : Commitable, ICreateUsuarioHandler
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<IdentityUser> _userManager;

    public CreateUsuarioHandler(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
        DataBase commandDb) : base(commandDb)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        CommandDB = commandDb;
    }

    public async Task<ActionResult> Handle(UsuarioDTO model)
    {
        try
        {
            var newUser = new Models.Usuario
            {
                Cargo = model.Cargo,
                UserName = model.Email,
                Nome = model.Nome,
                Email = model.Email,
                EmailConfirmed = true,
                IsPrimeiroAcesso = true
            };

            await using (CommandDB)
            {
                var result = CommandDB.Usuario.FirstOrDefault(u => u.UserName == model.Email);
                if (result != null)
                    return new BadRequestObjectResult("Usuario ja Cadastrado!");
            }

            var senhaTemporaria = PassGenerator.GerarSenha();
            var register = await _userManager.CreateAsync(newUser, senhaTemporaria);

            if (!register.Succeeded)
                return new BadRequestResult();

            var destinatario = new SendSmtpEmailTo(model.Email, model.Nome);

            await _roleManager.FindByNameAsync(newUser.Cargo);
            await _userManager.AddToRoleAsync(newUser, model.Cargo);
            CadastroEmail.EnviarEmail(destinatario, senhaTemporaria);

            return new OkResult();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}