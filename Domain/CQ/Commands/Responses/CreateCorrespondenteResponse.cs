namespace cjuridico.Domain.CQ.Commands.Responses;

public sealed class CreateCorrespondenteResponse
{
    public CreateCorrespondenteResponse(string mensagem)
    {
        Mensagem = mensagem;
    }

    private string Mensagem { get; set; }
}