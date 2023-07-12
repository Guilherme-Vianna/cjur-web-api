namespace cjuridico.Domain.CQ.Querys.Responses.Comarca;

public class ComarcaResponse
{
    public ComarcaResponse(Guid id, string nome, string estadoUf)
    {
        Id = id.ToString();
        Nome = nome;
        EstadoUF = estadoUf;
    }

    public string Id { get; set; }
    public string Nome { get; set; }
    public string EstadoUF { get; set; }
}