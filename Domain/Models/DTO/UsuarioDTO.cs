namespace cjuridico.Domain.Models.DTO;

public class UsuarioDTO
{
    public UsuarioDTO(string email, string cargo, string nome)
    {
        Email = email;
        Cargo = cargo;
        Nome = nome;
    }

    public string Email { get; init; }
    public string Nome { get; init; }
    public string Cargo { get; init; }
}