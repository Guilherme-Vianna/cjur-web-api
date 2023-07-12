using cjuridico.Domain.Models.Enuns;

namespace cjuridico.Domain.Models;

public sealed class Pedido
{
    public Pedido()
    {
    }

    public Pedido(Cliente cliente, Usuario executivo, Comarca comarca, Solicitacao solicitacao, Esfera? esfera, string numeroProcesso,
        string vara, string autor, string reu, string local, Correspondente? profissionalSelecionado,
        string presencialOuVirtual, string? descricao, string? conclusao, bool isAvulso, int numPedido, int codCliente,
        DateTime? dataPedido, DateTime? dataCumprimento, DateTime? dataConclusao)
    {
        Id = Guid.NewGuid();
        PedidoStatus = EPedidoStatus.VALIDACAO;
        Cliente = cliente;
        Comarca = comarca;
        Solicitacao = solicitacao;
        Esfera = esfera;
        NumeroDoProcesso = numeroProcesso;
        Vara = vara;
        Autor = autor;
        Reu = reu;
        Local = local;
        ProfissionalSelecionado = profissionalSelecionado;
        PresencialOuVirtual = presencialOuVirtual;
        Executivo = executivo;
        Descricao = descricao;
        Conclusao = conclusao;
        IsAvulso = isAvulso;
        NumeroPedido = numPedido;
        CodigoCliente = codCliente;
        DataDoPedido = DateTime.Now;
        DataDeCumprimento = null;
        DataDeConclusao = null;
    }

    public Guid Id { get; private set; }
    public Cliente Cliente { get; private set; }
    public Usuario Executivo { get; private set; }
    public Comarca Comarca { get; set; }
    public EPedidoStatus PedidoStatus { get; set; }
    public Solicitacao Solicitacao { get; private set; }
    public Esfera? Esfera { get; private set; }
    public string NumeroDoProcesso { get; private set; }
    public string Vara { get; private set; }
    public string Autor { get; private set; }
    public string Reu { get; private set; }
    public string Local { get; private set; }
    public Correspondente? ProfissionalSelecionado { get; set; }
    public string PresencialOuVirtual { get; private set; }
    public string? Descricao { get; set; }
    public string? Conclusao { get; set; }
    public bool IsAvulso { get; private set; }
    public int NumeroPedido { get; private set; }
    public int CodigoCliente { get; private set; }
    public DateTime? DataDoPedido { get; private set; }
    public DateTime? DataDeCumprimento { get; private set; }
    public DateTime? DataDeConclusao { get; private set; }
}