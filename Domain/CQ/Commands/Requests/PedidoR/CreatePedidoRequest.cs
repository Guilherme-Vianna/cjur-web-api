using cjuridico.Domain.Models;

namespace cjuridico.Domain.CQ.Commands.Requests.Pedido;

public class CreatePedidoRequest
{
    public CreatePedidoRequest(Guid clienteId, Guid comarcaId, Guid correspondenteId, Guid executivoDeConta,
        Solicitacao solicitacao,
        string numeroDoProcesso,
        string vara, string autor, string reu, string local, string profissionalSelecionado, string presencialOuVirtual,
        string? descricao, string conclusao, bool isAvulso, int numeroPedido, int codigoCliente, string esfera, DateTime dataDeCumprimento)
    {
        ClienteId = clienteId;
        ComarcaId = comarcaId;
        CorrespondenteId = correspondenteId;
        Solicitacao = solicitacao;
        NumeroDoProcesso = numeroDoProcesso;
        Vara = vara;
        Autor = autor;
        Reu = reu;
        Local = local;
        ProfissionalSelecionado = profissionalSelecionado;
        PresencialOuVirtual = presencialOuVirtual;
        Descricao = descricao;
        Conclusao = conclusao;
        ExecutivoDeContaId = executivoDeConta;
        IsAvulso = isAvulso;
        NumeroPedido = numeroPedido;
        CodigoCliente = codigoCliente;
        Esfera = esfera;
        DataDeCumprimento = dataDeCumprimento;
    }

    public Guid ClienteId { get; private set; }
    public Guid ComarcaId { get; private set; }
    public Guid CorrespondenteId { get; private set; }
    public Guid ExecutivoDeContaId { get; private set; }
    public Solicitacao? Solicitacao { get; private set; }
    public string Esfera { get; private set; }
    public string NumeroDoProcesso { get; private set; }
    public string Vara { get; private set; }
    public string Autor { get; private set; }
    public string Reu { get; private set; }
    public string Local { get; private set; }
    public string ProfissionalSelecionado { get; private set; }
    public string PresencialOuVirtual { get; private set; }
    public string? Descricao { get; private set; }
    public string Conclusao { get; private set; }
    public bool IsAvulso { get; private set; }
    public int NumeroPedido { get; private set; }
    public int CodigoCliente { get; private set; }

    public DateTime? DataDeCumprimento { get; }
    public DateTime? DataDeConclusao { get; }
}