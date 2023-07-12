using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.Models;

public sealed class Comarca : Entity
{
    public Comarca()
    {
    }

    public Comarca(string nome, string estadoUF)
    {
        Nome = nome;
        EstadoUF = estadoUF;
    }

    public string Nome { get; private set; }
    public string EstadoUF { get; private set; }
}