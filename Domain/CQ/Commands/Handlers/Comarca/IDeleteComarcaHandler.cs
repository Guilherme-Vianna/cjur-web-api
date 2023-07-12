using cjuridico.Domain.CQ.Commands.Requests;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.Comarca
{
    public interface IDeleteComarcaHandler
    {
        public Task<ActionResult> Handle(DeleteRequest request);
    }
}