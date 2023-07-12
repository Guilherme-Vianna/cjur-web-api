namespace cjuridico.Domain.CQ.Querys.Responses.ExecutivoDeConta;

public class GetExecutivoDeContaResponse
{
    public GetExecutivoDeContaResponse(string nome, string email, bool isLider, Guid liderId)
    {
        Nome = nome;
        Email = email;
        IsLider = isLider;
        LiderId = liderId;
    }

    public string Nome { get; private set; }
    public string Email { get; private set; }
    public bool IsLider { get; private set; }
    public Guid LiderId { get; private set; }
}