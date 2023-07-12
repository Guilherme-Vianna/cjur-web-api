namespace cjuridico.Domain.Models.Helper;

public static class PassGenerator
{
    public static string GerarSenha()
    {
        const int comprimentoSenha = 14;
        const string listaChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

        var random = new Random();

        var senha = new string(Enumerable.Repeat(listaChar, comprimentoSenha)
            .Select(s => s[random.Next(s.Length)]).ToArray());

        senha += "mC@0";

        return senha;
    }
}