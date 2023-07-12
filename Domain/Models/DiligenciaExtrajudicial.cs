using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.Models;

public sealed class DiligenciaExtrajudicial : Entity
{
    public DiligenciaExtrajudicial()
    {
    }

    public DiligenciaExtrajudicial(Guid id, string ato, decimal valor, Pedido pedido, DateTime data)
    {
        Ato = ato;
        Valor = valor;
        Pedido = pedido;
        Data = data;
    }

    public string Ato { get; private set; }
    public decimal Valor { get; private set; }
    public Pedido Pedido { get; private set; }
    public DateTime Data { get; private set; }
}