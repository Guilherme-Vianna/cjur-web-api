using cjuridico.Domain.CQ.Querys.Responses.Comarca;

namespace cjuridico.Domain.CQ.Querys.Handlers.Comarca;

public interface IGetComarcaHandler
{
    public Task<List<ComarcaResponse>> Handle();
}