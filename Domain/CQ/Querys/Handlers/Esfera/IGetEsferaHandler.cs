using cjuridico.Domain.CQ.Querys.Responses.Esfera;

namespace cjuridico.Domain.CQ.Querys.Handlers.Esfera;

public interface IGetEsferaHandler
{
    public List<GetEsferaResponse> Handle();
}