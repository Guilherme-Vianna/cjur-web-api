namespace cjuridico.Domain.CQ.Commands.Requests.Usuario;

public class ChangeSenhaRequest
{
    public ChangeSenhaRequest(string email, string senha, string novaSenha)
    {
        Email = email;
        Senha = senha;
        NovaSenha = novaSenha;
    }

    public string Email { get; private set; }
    public string Senha { get; private set; }
    public string NovaSenha { get; private set; }
}