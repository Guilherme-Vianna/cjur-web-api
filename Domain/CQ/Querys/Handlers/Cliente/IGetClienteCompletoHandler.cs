using cjuridico.Domain.CQ.Querys.Responses.Cliente;

namespace cjuridico.Domain.CQ.Querys.Handlers.Cliente;

public interface IGetClienteCompletoHandler
{
    public List<ClienteCompletoResponse> Handle();
}