using cjuridico.Domain.Models.Helper;
using Microsoft.AspNetCore.Http.Features;

namespace cjuridico.Domain.CQ.Querys.Responses.Login;

public class LoginResponse : IHttpResponseFeature
{
    public LoginResponse(UserToken tokenUsuario, string resposta)
    {
        TokenUsuario = tokenUsuario;
        LoginResposta = resposta;
    }

    public string LoginResposta { get; private set; }

    public UserToken? TokenUsuario { get; private set; }

    public void OnStarting(Func<object, Task> callback, object state)
    {
        throw new NotImplementedException();
    }

    public void OnCompleted(Func<object, Task> callback, object state)
    {
        throw new NotImplementedException();
    }

    public int StatusCode { get; set; }
    public string? ReasonPhrase { get; set; }
    public IHeaderDictionary Headers { get; set; }
    public Stream Body { get; set; }
    public bool HasStarted { get; }
}