using cjuridico.Domain.CQ.Querys.Responses.Comarca;
using cjuridico.Infra;

namespace cjuridico.Domain.CQ.Querys.Handlers.Comarca;

public class GetComarcaHandler : Queryable, IGetComarcaHandler
{
    public GetComarcaHandler(DataBase queryDb) : base(queryDb)
    {
    }

    public async Task<List<ComarcaResponse>> Handle()
    {
        await using (QueryDB)
        {
            var queryResult = from comarca in QueryDB.Comarca
                select comarca;

            var responseResult = (
                    from comarca in queryResult
                    select new ComarcaResponse(comarca.Id, comarca.Nome, comarca.EstadoUF))
                .ToList();

            return responseResult;
        }
    }
}