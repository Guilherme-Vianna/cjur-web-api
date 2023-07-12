namespace cjuridico.Domain.CQ.Commands.Requests.Correspondente
{
    public class ChangeCorrespondenteDataRequest
    {
        public ChangeCorrespondenteDataRequest(Guid id, string email, string nome, string numeroOAB, string oabuf, string cpf, string rg, string endereco, string dadosBancarios, string telefone)
        {
            Id = id;
            Email = email;
            Nome = nome;
            NumeroOAB = numeroOAB;
            OABUF = oabuf;
            CPF = cpf;
            RG = rg;
            Endereco = endereco;
            DadosBancarios = dadosBancarios;
            Telefone = telefone;
        }
        
        public Guid Id {get; set;}
        public string Email { get; set; }
        public string Nome { get; set; }
        public string NumeroOAB { get; set; }
        public string OABUF { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string DadosBancarios { get; set; }
        public string Telefone { get; set; }
    }
}