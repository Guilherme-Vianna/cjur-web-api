namespace cjuridico.Domain.CQ.Commands.Requests.Comarca;

public class CreateComarcaRequest
{
    public CreateComarcaRequest(string nome, string estadoUF)
    {
        Nome = nome;
        EstadoUF = estadoUF;
    }

    public string Nome { get; set; }
    public string EstadoUF { get; set; }
}