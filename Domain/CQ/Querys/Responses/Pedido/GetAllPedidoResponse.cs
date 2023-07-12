namespace cjuridico.Domain.CQ.Querys.Responses.Pedido;

public class GetAllPedidoResponse
{
    public GetAllPedidoResponse(string id, string uFComarca, string emailRequerente, string nPedido, string nProcesso,
        string? nomeCorrespondente, string? nomeExecutivo, DateTime? dataDoPedido, DateTime? dataDeCumprimento,
        string? status)
    {
        Id = id;
        UFComarca = uFComarca;
        EmailRequerente = emailRequerente;
        NPedido = nPedido;
        NProcesso = nProcesso;
        NomeCorrespondente = nomeCorrespondente;
        NomeExecutivo = nomeExecutivo;
        Status = status;
        DataDoPedido = dataDoPedido;
        DataDeCumprimento = dataDeCumprimento;
    }

    public string Id { get; init; }
    public string UFComarca { get; init; }
    public string EmailRequerente { get; init; }
    public string NPedido { get; init; }
    public string NProcesso { get; init; }
    public string? NomeCorrespondente { get; init; }
    public string? NomeExecutivo { get; init; }
    public string Status { get; init; }
    public DateTime? DataDoPedido { get; init; }
    public DateTime? DataDeCumprimento { get; init; }
}