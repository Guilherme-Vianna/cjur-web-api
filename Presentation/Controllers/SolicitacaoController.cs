using cjuridico.Domain.CQ.Querys.Handlers.Solicitacao;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Presentation.Controllers;

[ApiController]
[Route("v1/solicitacao")]
public class SolicitacaoController
{
    [HttpGet]
    [Route("{tipoDeTrabalho}")]
    public async Task<List<string>> Listar([FromServices] IGetSolicitacaoHandler handler, string tipoDeTrabalho)
    {
        return await handler.Handle(tipoDeTrabalho);
    }

    [HttpGet]
    [Route("")]
    public async Task<List<string>> Listar([FromServices] IGetSolicitacaoTipoDeTrabalhoHandler handler)
    {
        return await handler.Handle();
    }
}