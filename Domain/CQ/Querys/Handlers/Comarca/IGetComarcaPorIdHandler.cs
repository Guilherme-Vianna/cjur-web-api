using cjuridico.Domain.CQ.Querys.Responses.Comarca;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Querys.Handlers.Comarca;

public interface IGetComarcaPorIdHandler
{
    public Task<ActionResult<ComarcaResponse>> Handle(Guid Id);
}