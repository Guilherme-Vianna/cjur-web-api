using cjuridico.Domain.CQ.Commands.Responses;
using cjuridico.Infra;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace cjuridico.Domain.CQ.Querys.Handlers.Usuario;

public class GetUsuarioData : Queryable, IGetUsuarioData
{
    private readonly UserManager<IdentityUser> _userManager;

    public GetUsuarioData(DataBase queryDb, UserManager<IdentityUser> userManager) : base(queryDb)
    {
        _userManager = userManager;
    }

    public async Task<UserData> Handle(string id)
    {
        try
        {
            await using (QueryDB)
            {
                var usuario = QueryDB.Usuario.AsNoTracking().FirstAsync(u => u.Id == id).Result;

                var data = new UserData(usuario.Id, usuario.Cargo, usuario.Email, usuario.Nome);
                return data;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}