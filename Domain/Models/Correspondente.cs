using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.Models;

public sealed class Correspondente : Entity
{
    public Correspondente()
    {
    }

    public Correspondente(bool isAprovado, string email, string nome, string numeroOab, string oabuf, string cpf,
        string rg, string endereco, string dadosBancarios, string telefone)
    {
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

    public Correspondente(Comarca? comarca, bool isAprovado, string email, string nome, string numeroOab, string oabuf,
        string cpf,
        string rg)
    {
        Comarca = comarca;
        IsAprovado = isAprovado;
        Email = email;
        Nome = nome;
        NumeroOAB = numeroOab;
        OABUF = oabuf;
        CPF = cpf;
        RG = rg;
    }

    public Comarca? Comarca { get; set; }
    public bool IsAprovado { get; set; }
    public string Email { get; set; }
    public string Nome { get; set; }
    public string NumeroOAB { get; set; }
    public string OABUF { get; set; }
    public string CPF { get; set; }
    public string RG { get; set; }
    public string? Endereco { get; set; }
    public string? DadosBancarios { get; set; }
    public string? Telefone { get; set; }
}