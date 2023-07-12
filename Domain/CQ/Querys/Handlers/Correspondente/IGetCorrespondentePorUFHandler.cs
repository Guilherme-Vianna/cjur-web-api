using cjuridico.Domain.CQ.Querys.Responses.Correspondente;

namespace cjuridico.Domain.CQ.Querys.Handlers.Correspondente;

public interface IGetCorrespondentePorUFHandler
{
    public Task<List<CorrespondenteResponse>> Handle(string UF);
}