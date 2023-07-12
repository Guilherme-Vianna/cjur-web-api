using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.Models;

public sealed class Cliente : Entity
{
    public Cliente()
    {
    }

    public Cliente(Empresa empresa, string nome, string nomeEscritorio, bool isAvulso, string email, DateTime dataDeCadastro)
    {
        Empresa = empresa;
        Nome = nome;
        NomeEscritorio = nomeEscritorio;
        IsAvulso = isAvulso;
        Email = email;
        DataDeCadastro = dataDeCadastro; 
    }

    public Empresa Empresa { get; private set; }
    public DateTime DataDeCadastro { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string NomeEscritorio { get; private set; }
    public string Telefone { get; }
    public string EstadoUF { get; }
    public bool IsAvulso { get; private set; }
}