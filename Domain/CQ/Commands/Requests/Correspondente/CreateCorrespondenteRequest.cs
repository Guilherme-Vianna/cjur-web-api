namespace cjuridico.Domain.CQ.Commands.Requests.Correspondente;

public class CreateCorrespondenteRequest
{
    public CreateCorrespondenteRequest(Guid? comarcaId, string email, string nome, string numeroOAB, string OABUF,
        string cpf, string rg)
    {
        ComarcaId = comarcaId;
        Email = email;
        Nome = nome;
        NumeroOAB = numeroOAB;
        this.OABUF = OABUF;
        Cpf = cpf;
        Rg = rg;
    }

    public Guid? ComarcaId { get; set; }
    public bool Aprovado { get; set; }
    public string Email { get; private set; }
    public string Nome { get; private set; }
    public string NumeroOAB { get; private set; }
    public string OABUF { get; private set; }
    public string Cpf { get; private set; }
    public string Rg { get; private set; }
}