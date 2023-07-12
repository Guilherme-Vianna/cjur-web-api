using cjuridico.Domain.CQ.Querys.Responses.Correspondente;
using cjuridico.Infra;

namespace cjuridico.Domain.CQ.Querys.Handlers.Correspondente;

public class GetCorrespondentePorUFHandler : Queryable, IGetCorrespondentePorUFHandler
{
    public GetCorrespondentePorUFHandler(DataBase queryDb) : base(queryDb)
    {
    }

    public async Task<List<CorrespondenteResponse>> Handle(string UF)
    {
        try
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
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}