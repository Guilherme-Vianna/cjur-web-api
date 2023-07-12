namespace cjuridico.Domain.CQ.Querys.Responses.Cliente;

public class ClienteResponse
{
    public ClienteResponse(Guid id, string nome, string nomeEscritorio, bool isAvulso)
    {
        Id = id;
        Nome = nome;
        NomeEscritorio = nomeEscritorio;
        IsAvulso = isAvulso;
    }

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string NomeEscritorio { get; set; }
    public bool IsAvulso { get; set; }
}