using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.Models;

public class ExecutivoDeConta : Entity
{
    public ExecutivoDeConta()
    {
    }

    public ExecutivoDeConta(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; private set; }
}