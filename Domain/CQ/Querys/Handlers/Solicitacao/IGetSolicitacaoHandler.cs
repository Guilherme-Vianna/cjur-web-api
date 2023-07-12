namespace cjuridico.Domain.CQ.Querys.Handlers.Solicitacao;

public interface IGetSolicitacaoHandler
{
    public Task<List<string>> Handle(string tipoDeTrabalho);
}