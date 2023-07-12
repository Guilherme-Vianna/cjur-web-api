namespace cjuridico.Domain.CQ.Querys.Responses.Cliente;

public class ClientePorIdResponse
{
    public ClientePorIdResponse(string nome, string nomeEscritorio, bool isAvulso, string nomeGrupo,
        string nomeExecutivoDeConta)
    {
        Nome = nome;
        NomeEscritorio = nomeEscritorio;
        IsAvulso = isAvulso;
        NomeGrupo = nomeGrupo;
        NomeExecutivoDeConta = nomeExecutivoDeConta;
    }

    public string Nome { get; set; }
    public string NomeEscritorio { get; set; }
    public bool IsAvulso { get; set; }
    public string NomeGrupo { get; set; }
    public string NomeExecutivoDeConta { get; set; }
}