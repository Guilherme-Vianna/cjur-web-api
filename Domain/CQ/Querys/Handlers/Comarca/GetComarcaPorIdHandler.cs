using cjuridico.Domain.CQ.Querys.Responses.Comarca;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Querys.Handlers.Comarca;

public class GetComarcaPorIdHandler : Queryable, IGetComarcaPorIdHandler
{
    public GetComarcaPorIdHandler(DataBase queryDb) : base(queryDb)
    {
    }

    public async Task<ActionResult<ComarcaResponse>> Handle(Guid id)
    {
        await using (QueryDB)
        {
            var queryResult = QueryDB.Comarca.First(c => c.Id == id);

            var response = new ComarcaResponse(queryResult.Id, queryResult.Nome, queryResult.EstadoUF);

            return response;
        }
    }
}