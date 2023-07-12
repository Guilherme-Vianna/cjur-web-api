using cjuridico.Domain.CQ.Commands.Requests.Correspondente;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.Correspondente
{
    public interface IChangeCorrespondenteDataHandler
    {
        public Task<ActionResult> Handle(ChangeCorrespondenteDataRequest request); 
    }
}