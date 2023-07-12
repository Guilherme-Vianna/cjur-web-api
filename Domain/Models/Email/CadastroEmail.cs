using Newtonsoft.Json.Linq;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace cjuridico.Domain.Models.Email;

public static class CadastroEmail
{
    public static async void EnviarEmail(SendSmtpEmailTo destinatario, string mensagem)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, "https://api.sendinblue.com/v3/smtp/email");

        Configuration.Default.AddApiKey("api-key",
            "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");
        var apiInstance = new TransactionalEmailsApi();
        var sendSmtpEmail = new SendSmtpEmail();

        var apiContact = new ContactsApi();
        string Email = destinatario.Email;
        JObject Attributes = new JObject();
        Attributes.Add("NOME", destinatario.Name);
        Attributes.Add("SENHA", mensagem);
        bool EmailBlacklisted = false;
        bool SmsBlacklisted = false;
        List<long?> ListIds = new List<long?>();
        ListIds.Add(2);
        ListIds.Add(4);
        bool UpdateEnabled = false;
        List<string> SmtpBlacklistSender = new List<string>();

        var createContact = new CreateContact(Email, Attributes, EmailBlacklisted, SmsBlacklisted, ListIds,
            UpdateEnabled, SmtpBlacklistSender);
        await apiContact.CreateContactAsync(createContact);

        var destinatarios = new List<SendSmtpEmailTo>();

        destinatarios.Add(new SendSmtpEmailTo(destinatario.Email, destinatario.Name));

        destinatarios.Add(new SendSmtpEmailTo("guilherme.mataveli@miortec.com.br", "Guilherme"));
        destinatarios.Add(new SendSmtpEmailTo("alehandro.santos@miortec.com.br", "Alehandro"));

        sendSmtpEmail.Sender = new SendSmtpEmailSender("Cjuridico", "mataveli91@gmail.com");
        sendSmtpEmail.Subject = "Confirmacao de Cadastro";
        sendSmtpEmail.TemplateId = 3;
        sendSmtpEmail.To = destinatarios;


        var result = await apiInstance.SendTransacEmailAsync(sendSmtpEmail);

        // request.Content = new StringContent(
        //     "{\n\"" +
        //     "sender\":{\n\"" +
        //         "name\":\"Cjuridico\",\n\"" +
        //         "email\":\"administracao@cjuridico.com.br\"\n},\n\"" +
        //     "to\":[\n{\n\"" +
        //         "email\":\"" + destinatario + "\",\n\"" +
        //         "name\":\""+ destinatario +"\"\n}\n],\n\"" +
        //     "subject\":\"Hello world\",\n\"" +
        //     "htmlContent\":\"<html><head></head><body><p>Hello,</p>Tem que trocar a senha</p></body></html>\"\n}");


        //string responseBody = await response.Content.ReadAsStringAsync();
    }
}