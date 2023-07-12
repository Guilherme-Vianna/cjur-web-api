using cjuridico.Domain.Models;

namespace cjuridico.Domain.CQ.Commands.Responses;

public sealed class CreateUsuarioResponse
{
    public CreateUsuarioResponse(Usuario usuario, string mensagem)
    {
        Usuario = usuario;
        Mensagem = mensagem;
    }

    public Usuario Usuario { get; private set; }
    public string Mensagem { get; private set; }
}