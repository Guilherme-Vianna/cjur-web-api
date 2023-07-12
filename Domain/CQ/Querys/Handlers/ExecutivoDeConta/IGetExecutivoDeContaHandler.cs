using cjuridico.Domain.CQ.Querys.Responses.ExecutivoDeConta;

namespace cjuridico.Domain.CQ.Querys.Handlers.ExecutivoDeConta;

public interface IGetExecutivoDeContaHandler
{
    public List<GetExecutivoDeContaResponse> Handle();
}