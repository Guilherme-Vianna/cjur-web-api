using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.Models;

public sealed class Empresa : Entity
{
    public Empresa()
    {
    }

    public Empresa(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; private set; }
}