using cjuridico.Infra;

namespace cjuridico.Domain.CQ.Querys.Handlers.Solicitacao;

public class GetSolicitacaoTipoDeTrabalhoHandler : Queryable, IGetSolicitacaoTipoDeTrabalhoHandler
{
    public GetSolicitacaoTipoDeTrabalhoHandler(DataBase queryDb) : base(queryDb)
    {
    }

    public async Task<List<string>> Handle()
    {
        try
        {
            await using (QueryDB)
            {
                var resultado = (
                        from s in QueryDB.Solicitacao
                        select s.TipoDeTrabalho)
                    .ToList();

                return resultado;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}