using cjuridico.Domain.CQ.Querys.Responses.Correspondente;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Querys.Handlers.Correspondente;

public interface IGetAllCorrespondenteHandler
{
    public Task<ActionResult<List<CorrespondenteResponse>>> Handle(string UF);
}