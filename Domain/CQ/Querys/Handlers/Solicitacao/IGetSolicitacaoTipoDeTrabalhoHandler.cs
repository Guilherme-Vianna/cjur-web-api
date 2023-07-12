namespace cjuridico.Domain.CQ.Querys.Handlers.Solicitacao;

public interface IGetSolicitacaoTipoDeTrabalhoHandler
{
    public Task<List<string>> Handle();
}