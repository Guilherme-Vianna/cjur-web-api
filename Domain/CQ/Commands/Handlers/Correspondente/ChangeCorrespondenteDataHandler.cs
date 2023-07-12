using cjuridico.Domain.CQ.Commands.Requests.Correspondente;
using cjuridico.Infra;
using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.CQ.Commands.Handlers.Correspondente
{
    public class ChangeCorrespondenteDataHandler : Commitable,  IChangeCorrespondenteDataHandler
    {
        public ChangeCorrespondenteDataHandler(DataBase commandDb) : base(commandDb)
        {
        }

        public async Task<ActionResult> Handle(ChangeCorrespondenteDataRequest request)
        {
            try
            {
                await using(CommandDB)
                {
                    var correspondente = CommandDB.Correspondente.FindAsync(request.Id).Result;
                    
                    if(correspondente == null)
                        return new BadRequestObjectResult("Correspondente não encontrado");

                    correspondente.Email = request.Email;
                    correspondente.Nome = request.Nome;
                    correspondente.NumeroOAB = request.NumeroOAB;
                    correspondente.OABUF = request.OABUF;
                    correspondente.CPF = request.CPF;
                    correspondente.RG = request.RG;
                    correspondente.Endereco = request.Endereco;
                    correspondente.DadosBancarios = request.DadosBancarios;
                    correspondente.Telefone = request.Telefone;
                
                    CommandDB.Correspondente.Update(correspondente);
                    await CommandDB.SaveChangesAsync(); 

                    return new OkObjectResult("Correspondente atualizado com sucesso");
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}