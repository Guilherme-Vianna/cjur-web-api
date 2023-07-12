namespace cjuridico.Domain.CQ.Commands.Requests.ExecutivoDeConta;

public class CreateExecutivoDeContaRequest
{
    public CreateExecutivoDeContaRequest(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public string Nome { get; set; }
    public string Email { get; set; }
}