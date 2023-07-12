using cjuridico.Domain.Models;
using cjuridico.Domain.Models.Enuns;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cjuridico.Domain.EF;

public class SolicitacaoConfiguration : IEntityTypeConfiguration<Solicitacao>
{
    public void Configure(EntityTypeBuilder<Solicitacao> builder)
    {
        builder.HasData(
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.DISTRIBUICAO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.PETICAOINICIAL.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.DISTRIBUICAO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.CARTAPRECATORIA.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.AUDIENCIA.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.INSTRUCAOEJULGAMENTO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.AUDIENCIA.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.CONCILIACAO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.AUDIENCIA.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.UNA.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.COPIADEPROCESSO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.PARCIAL.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.COPIADEPROCESSO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.INTEGRAL.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.PROTOCOLO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.FISICO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.PROTOCOLO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.ELETRONICO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.DESPACHO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.DESPACHO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.DILIGENCIAEMCARTORIO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.DILIGENCIAEMCARTORIO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.DILIGENCIAEMCARTORIO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.DILIGENCIAEMCARTORIO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.DILIGENCIAEXTRAJUDICIAL.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.EXTRAJUDICIAL.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.HOMOLOGACAO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.HOMOLOGACAO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.NOTIFICACAO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.NOTIFICACAO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.ALVARA.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.RETIRADAEENVIO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.ALVARA.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.RETIRADAELEVANTAMENTO.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.EMISSAODEGUIA.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.EMISSAODEGUIA.ToString()
            },
            new Solicitacao
            {
                TipoDeTrabalho = ETipoDeTrabalho.EMISSAODECERTIDAO.ToString(),
                TipoDeRequerimento = ETipoDeRequerimento.EMISSAODECERTIDAO.ToString()
            }
        );
    }
}