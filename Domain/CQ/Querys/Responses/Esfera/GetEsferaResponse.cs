namespace cjuridico.Domain.CQ.Querys.Responses.Esfera;

public class GetEsferaResponse
{
    public GetEsferaResponse(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; private set; }
}