using cjuridico.Domain.CQ.Querys.Responses.Correspondente;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Querys.Handlers.Correspondente;

public class GetAllCorrespondenteHandler : Queryable, IGetAllCorrespondenteHandler
{
    public GetAllCorrespondenteHandler(DataBase queryDb) : base(queryDb)
    {
    }

    public async Task<ActionResult<List<CorrespondenteResponse>>> Handle(string UF)
    {
        try
        {
            if (UF != null)
            {
                await using (QueryDB)
                {
                    var result = (
                        from c in QueryDB.Correspondente
                        where c.Comarca.EstadoUF == UF
                        select new CorrespondenteResponse(
                            c.Id.ToString(),
                            c.IsAprovado,
                            c.Email,
                            c.Nome,
                            c.NumeroOAB,
                            c.OABUF,
                            c.CPF,
                            c.RG,
                            c.Endereco,
                            c.DadosBancarios,
                            c.Telefone
                        )).ToList();

                    return result;
                }
            }

            await using (QueryDB)
            {
                var responseResult = (
                        from correspondente in QueryDB.Correspondente
                        select new CorrespondenteResponse(
                            correspondente.Id.ToString(),
                            correspondente.IsAprovado,
                            correspondente.Email,
                            correspondente.Nome,
                            correspondente.NumeroOAB,
                            correspondente.OABUF,
                            correspondente.CPF,
                            correspondente.RG,
                            correspondente.Endereco,
                            correspondente.DadosBancarios,
                            correspondente.Telefone))
                    .ToList();

                return new OkObjectResult(responseResult);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}