namespace cjuridico.Domain.Models.Helper;

public class UserToken
{
    public DateTime Expiration { get; set; }
    public string Token { get; set; }
}