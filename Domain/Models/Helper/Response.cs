using Microsoft.AspNetCore.Mvc;

namespace cjuridico.Domain.Models.Helper;

public class Response : ContentResult
{
    public Response(string mensagem, StatusCodeResult statusCode)
    {
        Mensagem = mensagem;
        StatusCode = statusCode;
    }

    public string Mensagem { get; private set; }
    public StatusCodeResult StatusCode { get; private set; }
}