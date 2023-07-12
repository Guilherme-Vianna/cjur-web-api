using Microsoft.AspNetCore.Identity;

namespace cjuridico.Domain.Models;

public class Usuario : IdentityUser
{
    public Usuario()
    {
    }

    public Usuario(string cargo, string nome)
    {
        Cargo = cargo;
        Nome = nome;
        IsPrimeiroAcesso = true;
    }

    public string Cargo { get; set; }
    public string Nome { get; set; }
    public bool IsPrimeiroAcesso { get; set; }
}