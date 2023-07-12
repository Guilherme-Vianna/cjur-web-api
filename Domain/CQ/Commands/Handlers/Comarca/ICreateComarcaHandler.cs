using cjuridico.Domain.CQ.Commands.Requests.Comarca;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.Comarca;

public interface ICreateComarcaHandler
{
    public Task<ActionResult> Handle(CreateComarcaRequest request);
}