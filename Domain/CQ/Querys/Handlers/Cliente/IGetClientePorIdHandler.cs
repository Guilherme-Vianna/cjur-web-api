using cjuridico.Domain.CQ.Querys.Responses.Cliente;

namespace cjuridico.Domain.CQ.Querys.Handlers.Cliente;

public interface IGetClientePorIdHandler
{
    public List<ClientePorIdResponse> Handle(Guid id);
}