using System.Net;
using System.Net.Mail;

namespace cjuridico.Infra;

public static class EmailService
{
    public static Task EnviarEmail(string assunto, string corpo, string destinatario)
    {
        var sendblueClient = new SmtpClient
        {
            Host = "smtp-relay.sendinblue.com",
            Port = 587,
            Credentials = new NetworkCredential("mataveli91@gmail.com",
                "xsmtpsib-c73fddb10f30b1a9aaefea3bd8abcf970283b0de32d6b5983388fbd9f4f7ecc0-sFpCS1j3ZVN69Myx"),
            EnableSsl = false
        };

        var mensagem = new MailMessage
        {
            From = new MailAddress("guilherme.mataveli@miortec.com.br"),
            To = { destinatario },
            Subject = assunto,
            Body = corpo
        };

        sendblueClient.Send(mensagem);
        return Task.CompletedTask;
    }
}