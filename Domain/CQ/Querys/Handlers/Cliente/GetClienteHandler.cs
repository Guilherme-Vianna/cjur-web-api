using cjuridico.Domain.CQ.Querys.Responses.Cliente;
using cjuridico.Infra;

namespace cjuridico.Domain.CQ.Querys.Handlers.Cliente;

public class GetClienteHandler : Queryable, IGetClienteHandler
{
    public GetClienteHandler(DataBase queryDb) : base(queryDb)
    {
    }

    public List<ClienteResponse> Handle()
    {
        using (QueryDB)
        {
            var queryResult = (
                from cliente in QueryDB.Cliente
                select cliente
            ).ToList();

            var responseResult = (
                from cliente in queryResult
                select new ClienteResponse(
                    cliente.Id, cliente.Nome, cliente.NomeEscritorio, cliente.IsAvulso)).ToList();

            return responseResult;
        }
    }
}