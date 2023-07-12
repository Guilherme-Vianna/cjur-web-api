namespace cjuridico.Domain.CQ.Querys.Responses.Cliente;

public class EsferaResponse
{
    public EsferaResponse(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
}