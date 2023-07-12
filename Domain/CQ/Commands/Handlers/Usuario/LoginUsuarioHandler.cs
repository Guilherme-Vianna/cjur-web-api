using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using cjuridico.Domain.CQ.Commands.Responses;
using cjuridico.Domain.Models.DTO;
using cjuridico.Domain.Models.Helper;
using cjuridico.Infra;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace cjuridico.Domain.CQ.Commands.Handlers.Usuario;

public class LoginUsuarioHandler : Commitable, ILoginUsuarioHandler
{
    private readonly IConfiguration _configuration;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public LoginUsuarioHandler(SignInManager<IdentityUser> signInManager, IConfiguration configuration,
        DataBase commandDb, UserManager<IdentityUser> userManager) : base(commandDb)
    {
        _signInManager = signInManager;
        _configuration = configuration;
        CommandDB = commandDb;
        _userManager = userManager;
    }


    public async Task<ActionResult<LoginUsuarioResponse>> Handle(UsuarioLogin userInfo)
    {
        try
        {
            await using (CommandDB)
            {
                var result = await _signInManager.PasswordSignInAsync(userInfo.Email, userInfo.Password, false, false);

                if (result.IsNotAllowed) return new UnauthorizedResult();

                if (result.Succeeded)
                {
                    var userFind = CommandDB.Usuario.First(c => c.Email == userInfo.Email);

                    if (userFind.IsPrimeiroAcesso)
                        return new AcceptedResult("",
                            new LoginUsuarioResponse("Login Bem Sucedido, Necessario Troca de Senha"));

                    var roleFind = CommandDB.UserRoles.First(u => u.UserId == userFind.Id);
                    var roleName = CommandDB.Roles.First(r => r.Id == roleFind.RoleId);

                    var newDTO = new UsuarioDTO(userInfo.Email, roleName.NormalizedName, userFind.Nome);

                    var userData = new UserData(userFind.Id, roleName.NormalizedName, userFind.UserName, userFind.Nome);

                    return new LoginUsuarioResponse(GenerateToken(newDTO), "Login Bem Sucedido", userData);
                }
            }

            throw new Exception();
        }
        catch
        {
            return new UnauthorizedResult();
        }
    }

    private UserToken GenerateToken(UsuarioDTO userInfo)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("role", userInfo.Cargo)
        };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_configuration["Jwt:key"]));

        var credenciais = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var expiracao = _configuration["TokenConfiguration:ExpireHours"];
        var expiration = DateTime.UtcNow.AddHours(double.Parse(expiracao));

        var token = new JwtSecurityToken(
            _configuration["TokenConfiguration:Issuer"],
            _configuration["TokenConfiguration:Audience"],
            claims,
            expires: expiration,
            signingCredentials: credenciais);

        return new UserToken
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            Expiration = expiration,
        };
    }
}