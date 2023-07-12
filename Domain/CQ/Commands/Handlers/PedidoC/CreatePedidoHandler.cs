using cjuridico.Domain.CQ.Commands.Requests.Pedido;
using cjuridico.Domain.Models;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cjuridico.Domain.CQ.Commands.Handlers.PedidoC;

public class CreatePedidoHandler : Commitable, ICreatePedidoHandler
{
    public CreatePedidoHandler(DataBase commandDb) : base(commandDb)
    {
    }

    public async Task<ActionResult> Handle(CreatePedidoRequest request)
    {
        try
        {
            await using (CommandDB)
            {
                var cliente = await CommandDB.Cliente.FirstAsync(c => c.Id == request.ClienteId);
                var executivoDeConta = await CommandDB.Usuario.FindAsync(request.ExecutivoDeContaId);
                var comarca = await CommandDB.Comarca.FirstAsync(c => c.Id == request.ComarcaId);
                var esfera = (
                    from e in CommandDB.Esfera
                    where e.Nome == request.Esfera
                    select e
                ).First();

                var solicitacao = (
                    from s in CommandDB.Solicitacao
                    where s.TipoDeTrabalho == request.Solicitacao.TipoDeTrabalho
                          && s.TipoDeRequerimento == request.Solicitacao.TipoDeRequerimento
                    select s
                ).First();

                var correspondente = await CommandDB.Correspondente.FirstAsync(c => c.Id == request.CorrespondenteId);

                var newPedido = new Pedido(
                    cliente,
                    executivoDeConta,
                    comarca,
                    solicitacao,
                    esfera,
                    request.NumeroDoProcesso,
                    request.Vara,
                    request.Autor,
                    request.Reu,
                    request.Local,
                    correspondente,
                    request.PresencialOuVirtual,
                    request.Descricao,
                    null,
                    request.IsAvulso,
                    request.NumeroPedido,
                    request.CodigoCliente,
                    DateTime.Now,
                    request.DataDeCumprimento,
                    null
                );

                await CommandDB.Pedido.AddAsync(newPedido);
                await CommandDB.SaveChangesAsync();

                await EmailService.EnviarEmail("Pedido Cadastrado, " + cliente.Nome, request.NumeroPedido.ToString(),
                    "guilherme.mataveli@miortec.com.br");

                return new OkObjectResult("Pedido cadastrado com Sucesso");
            }
        }
        catch
        {
            return new OkObjectResult("Erro ao cadastrar o pedido");
        }
    }
}