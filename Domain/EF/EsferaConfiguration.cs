using cjuridico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cjuridico.Domain.EF;

public class EsferaConfiguration : IEntityTypeConfiguration<Esfera>
{
    public void Configure(EntityTypeBuilder<Esfera> builder)
    {
        builder.HasData(
            new Esfera
            {
                Id = new Guid("1467C584-5538-4336-B218-948BD79E839F"),
                Nome = "Federal"
            },
            new Esfera
            {
                Id = new Guid("7270D17A-7C66-4DAF-81DE-AD57CBB8023C "),
                Nome = "Criminal"
            },
            new Esfera
            {
                Id = new Guid("DB9B7097-3140-4179-B8CE-B411CD0675A7"),
                Nome = "Juizado"
            },
            new Esfera
            {
                Id = new Guid("F186A4C7-ED1C-4DF4-AD85-B6FC1E5271AB"),
                Nome = "Procon"
            },
            new Esfera
            {
                Id = new Guid("F1571CEC-7C3C-4A76-953F-C5B6D8514138"),
                Nome = "Cívil"
            },
            new Esfera
            {
                Id = new Guid("41CA3685-F11C-4FBC-B7FC-F95B4F141C4F"),
                Nome = "Trabalhista"
            }
        );
    }
}