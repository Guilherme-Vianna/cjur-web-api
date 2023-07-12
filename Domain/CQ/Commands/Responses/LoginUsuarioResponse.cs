using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.CQ.Commands.Responses;

public class LoginUsuarioResponse
{
    public LoginUsuarioResponse(UserToken tokenUsuario, string response, UserData userData)
    {
        UserToken = tokenUsuario;
        LoginResponse = response;
        UserData = userData;
    }

    public LoginUsuarioResponse(string response)
    {
        LoginResponse = response;
    }

    public UserData? UserData { get; private set; }

    public string LoginResponse { get; private set; }

    public UserToken? UserToken { get; private set; }
}

public class UserData
{
    public UserData(string id, string cargo, string username, string name)
    {
        Cargo = cargo;
        Id = id;
        Username = username;
        Name = name;
    }

    public string Cargo { get; init; }
    public string Id { get; init; }
    public string Username { get; init; }
    public string Name { get; init; }
}