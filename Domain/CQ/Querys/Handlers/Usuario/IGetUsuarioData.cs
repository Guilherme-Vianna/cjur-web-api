using cjuridico.Domain.CQ.Commands.Responses;

namespace cjuridico.Domain.CQ.Querys.Handlers.Usuario;

public interface IGetUsuarioData
{
    public Task<UserData> Handle(string id);
}