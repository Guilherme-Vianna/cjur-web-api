namespace cjuridico.Domain.CQ.Querys.Responses.Correspondente;

public class CorrespondenteResponse
{
    public CorrespondenteResponse(string id, bool isAprovado, string email, string nome, string numeroOab, string oabuf,
        string cpf, string rg, string endereco, string dadosBancarios, string telefone)
    {
        Id = id;
        IsAprovado = isAprovado;
        Email = email;
        Nome = nome;
        NumeroOAB = numeroOab;
        OABUF = oabuf;
        CPF = cpf;
        RG = rg;
        Endereco = endereco;
        DadosBancarios = dadosBancarios;
        Telefone = telefone;
    }

    public string Id { get; private set; }
    public bool IsAprovado { get; private set; }
    public string Email { get; private set; }
    public string Nome { get; private set; }
    public string NumeroOAB { get; private set; }
    public string OABUF { get; private set; }
    public string CPF { get; private set; }
    public string RG { get; private set; }
    public string Endereco { get; private set; }
    public string DadosBancarios { get; private set; }
    public string Telefone { get; private set; }
}