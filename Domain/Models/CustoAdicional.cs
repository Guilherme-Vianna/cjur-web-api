using cjuridico.Domain.Models.Helper;

namespace cjuridico.Domain.Models;

public sealed class CustoAdicional : Entity
{
    public CustoAdicional()
    {
    }

    public CustoAdicional(string descricao, decimal valor, DateTime data, Pedido pedido)
    {
        Descricao = descricao;
        Valor = valor;
        Data = data;
        Pedido = pedido;
    }

    public string Descricao { get; private set; }
    public decimal Valor { get; private set; }
    public DateTime Data { get; private set; }
    public Pedido Pedido { get; private set; }
}