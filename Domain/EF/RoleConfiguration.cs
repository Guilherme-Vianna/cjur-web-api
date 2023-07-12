using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cjuridico.Domain.EF;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Name = "Lider",
                NormalizedName = "Lider"
            },
            new IdentityRole
            {
                Name = "Colaborador",
                NormalizedName = "Colaborador"
            },
            new IdentityRole
            {
                Name = "Administrador",
                NormalizedName = "Administrador"
            },
            new IdentityRole
            {
                Name = "Comercial",
                NormalizedName = "Comercial"
            },
            new IdentityRole
            {
                Name = "Correspondente",
                NormalizedName = "Correspondente"
            },
            new IdentityRole
            {
                Name = "Financeiro",
                NormalizedName = "Financeiro"
            },
            new IdentityRole
            {
                Name = "Cliente",
                NormalizedName = "Cliente"
            }
        );
    }
}