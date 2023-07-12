using cjuridico.Infra;

namespace cjuridico.Domain.CQ.Querys.Handlers.Solicitacao;

public class GetSolicitacaoHandler : Queryable, IGetSolicitacaoHandler
{
    public GetSolicitacaoHandler(DataBase queryDb) : base(queryDb)
    {
    }

    public async Task<List<string>> Handle(string tipoDeTrabalho)
    {
        await using (QueryDB)
        {
            var resultado = (
                    from s in QueryDB.Solicitacao
                    where s.TipoDeTrabalho == tipoDeTrabalho
                    select s.TipoDeRequerimento)
                .ToList();

            return resultado;
        }
    }
}