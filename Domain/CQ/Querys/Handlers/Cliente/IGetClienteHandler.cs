using cjuridico.Domain.CQ.Querys.Responses.Cliente;

namespace cjuridico.Domain.CQ.Querys.Handlers.Cliente;

public interface IGetClienteHandler
{
    public List<ClienteResponse> Handle();
}