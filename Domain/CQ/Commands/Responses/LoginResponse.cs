using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.CQ.Commands.Responses;

public class LoginResponse
{
    public LoginResponse(UserToken tokenUsuario, string resposta)
    {
        TokenUsuario = tokenUsuario;
        LoginResposta = resposta;
    }

    public string LoginResposta { get; private set; }

    public UserToken? TokenUsuario { get; private set; }
}