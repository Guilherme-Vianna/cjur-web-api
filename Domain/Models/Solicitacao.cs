using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.Models;

public sealed class Solicitacao : Entity
{
    public Solicitacao()
    {
    }

    public Solicitacao(string tipoDeTrabalho, string tipoDeRequerimento)
    {
        TipoDeTrabalho = tipoDeTrabalho;
        TipoDeRequerimento = tipoDeRequerimento;
    }

    public string TipoDeTrabalho { get; init; }
    public string TipoDeRequerimento { get; init; }
}