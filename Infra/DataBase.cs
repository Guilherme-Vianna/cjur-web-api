using cjuridico.Domain.EF;
using cjuridico.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace cjuridico.Infra;

public class DataBase : IdentityDbContext
{
    public DataBase(DbContextOptions<DataBase> options) : base(options)
    {
    }

    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<CustoAdicional> CustoAdicional { get; set; }
    public DbSet<Comarca> Comarca { get; set; }
    public DbSet<Empresa> Empresa { get; set; }
    public DbSet<Correspondente> Correspondente { get; set; }
    public DbSet<Esfera> Esfera { get; set; }
    public DbSet<Pedido> Pedido { get; set; }
    public DbSet<Solicitacao> Solicitacao { get; set; }
    public DbSet<ExecutivoDeConta> ExecutivoDeConta { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<PedidoAuditoria> PedidoAuditoria { get; set; }
    public DbSet<DiligenciaExtrajudicial> DiligenciaExtrajudicial { get; set; }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
        configurationBuilder.Properties<string>()
            .HaveMaxLength(255);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Adicionando Roles
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        //Adicionado Solicitacoes
        modelBuilder.ApplyConfiguration(new SolicitacaoConfiguration());
        //Adicionado Esferas
        modelBuilder.ApplyConfiguration(new EsferaConfiguration());


        modelBuilder.Entity<Pedido>()
            .Property(b => b.Descricao).HasMaxLength(8000);
        modelBuilder.Entity<Pedido>()
            .Property(b => b.Conclusao).HasMaxLength(8000);
        modelBuilder.Entity<CustoAdicional>()
            .Property(b => b.Descricao).HasMaxLength(8000);
    }
}