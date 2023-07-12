﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cjuridico.Infra;

#nullable disable

namespace cjuridico.Migrations
{
    [DbContext(typeof(DataBase))]
    partial class DataBaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c366b811-76a8-4427-97c4-c266229281a1",
                            ConcurrencyStamp = "00db84e3-e32a-4a2e-8a9d-5b84b5a27be8",
                            Name = "Lider",
                            NormalizedName = "Lider"
                        },
                        new
                        {
                            Id = "0b1335ee-105b-4129-ac9a-35bb185eb123",
                            ConcurrencyStamp = "bb03799f-697e-437e-9634-10cb98aa6833",
                            Name = "Colaborador",
                            NormalizedName = "Colaborador"
                        },
                        new
                        {
                            Id = "970068bb-e832-43bc-a86d-57999abbfef0",
                            ConcurrencyStamp = "e944c946-02d8-4c11-9c87-7e7975558a4e",
                            Name = "Administrador",
                            NormalizedName = "Administrador"
                        },
                        new
                        {
                            Id = "42fd6912-0c64-4c2d-82de-7ed7b5ff0834",
                            ConcurrencyStamp = "6c7aab98-82b6-49be-a57f-20c0873d688c",
                            Name = "Comercial",
                            NormalizedName = "Comercial"
                        },
                        new
                        {
                            Id = "955c1333-7e28-424f-86b3-126c6cbb12b5",
                            ConcurrencyStamp = "cf11296a-7c32-401a-8480-818b4bff7aed",
                            Name = "Correspondente",
                            NormalizedName = "Correspondente"
                        },
                        new
                        {
                            Id = "455f43db-fb11-4313-9dda-605c035b6e6d",
                            ConcurrencyStamp = "40fc18ce-393e-4bc2-9fd3-d7df37def0a8",
                            Name = "Financeiro",
                            NormalizedName = "Financeiro"
                        },
                        new
                        {
                            Id = "331f277b-c37d-46dd-a79a-04a1c2517a1f",
                            ConcurrencyStamp = "5430be54-47d2-4688-924d-f95bf4318c5a",
                            Name = "Cliente",
                            NormalizedName = "Cliente"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RoleId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Value")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsAvulso")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NomeEscritorio")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Comarca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EstadoUF")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Comarca");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Correspondente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("ComarcaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DadosBancarios")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsAprovado")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NumeroOAB")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("OABUF")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ComarcaId");

                    b.ToTable("Correspondente");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.CustoAdicional", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("CustoAdicional");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.DiligenciaExtrajudicial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ato")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("DiligenciaExtrajudicial");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Esfera", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Esfera");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1467c584-5538-4336-b218-948bd79e839f"),
                            Nome = "Federal"
                        },
                        new
                        {
                            Id = new Guid("7270d17a-7c66-4daf-81de-ad57cbb8023c"),
                            Nome = "Criminal"
                        },
                        new
                        {
                            Id = new Guid("db9b7097-3140-4179-b8ce-b411cd0675a7"),
                            Nome = "Juizado"
                        },
                        new
                        {
                            Id = new Guid("f186a4c7-ed1c-4df4-ad85-b6fc1e5271ab"),
                            Nome = "Procon"
                        },
                        new
                        {
                            Id = new Guid("f1571cec-7c3c-4a76-953f-c5b6d8514138"),
                            Nome = "Cívil"
                        },
                        new
                        {
                            Id = new Guid("41ca3685-f11c-4fbc-b7fc-f95b4f141c4f"),
                            Nome = "Trabalhista"
                        });
                });

            modelBuilder.Entity("cjuridico.Domain.Models.ExecutivoDeConta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ExecutivoDeConta");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CodigoCliente")
                        .HasColumnType("int");

                    b.Property<Guid>("ComarcaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Conclusao")
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataDeConclusao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataDeCumprimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataDoPedido")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EsferaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExecutivoId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsAvulso")
                        .HasColumnType("bit");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NumeroDoProcesso")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("NumeroPedido")
                        .HasColumnType("int");

                    b.Property<int>("PedidoStatus")
                        .HasColumnType("int");

                    b.Property<string>("PresencialOuVirtual")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("ProfissionalSelecionadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("SolicitacaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Vara")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ComarcaId");

                    b.HasIndex("EsferaId");

                    b.HasIndex("ExecutivoId");

                    b.HasIndex("ProfissionalSelecionadoId");

                    b.HasIndex("SolicitacaoId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.PedidoAuditoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PedidoStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("Responsavel")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("PedidoAuditoria");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Solicitacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TipoDeRequerimento")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TipoDeTrabalho")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Solicitacao");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c71f236c-87e4-4e09-8503-b16b9bea3817"),
                            TipoDeRequerimento = "PETICAOINICIAL",
                            TipoDeTrabalho = "DISTRIBUICAO"
                        },
                        new
                        {
                            Id = new Guid("cd1f62e5-a325-484c-9c9d-1ab340b5330f"),
                            TipoDeRequerimento = "CARTAPRECATORIA",
                            TipoDeTrabalho = "DISTRIBUICAO"
                        },
                        new
                        {
                            Id = new Guid("fd774886-0000-4981-a097-d1a1ef6ce456"),
                            TipoDeRequerimento = "INSTRUCAOEJULGAMENTO",
                            TipoDeTrabalho = "AUDIENCIA"
                        },
                        new
                        {
                            Id = new Guid("52196855-739e-49b5-a07d-897144632412"),
                            TipoDeRequerimento = "CONCILIACAO",
                            TipoDeTrabalho = "AUDIENCIA"
                        },
                        new
                        {
                            Id = new Guid("db9a9612-a128-4a7a-accf-0a16df7242e7"),
                            TipoDeRequerimento = "UNA",
                            TipoDeTrabalho = "AUDIENCIA"
                        },
                        new
                        {
                            Id = new Guid("27d4fe88-e924-4cd5-af42-1da62b9868d5"),
                            TipoDeRequerimento = "PARCIAL",
                            TipoDeTrabalho = "COPIADEPROCESSO"
                        },
                        new
                        {
                            Id = new Guid("4f692c84-a429-41ba-8183-ce83844bed43"),
                            TipoDeRequerimento = "INTEGRAL",
                            TipoDeTrabalho = "COPIADEPROCESSO"
                        },
                        new
                        {
                            Id = new Guid("c03a4d52-8002-43c7-a63d-b66f9883041a"),
                            TipoDeRequerimento = "FISICO",
                            TipoDeTrabalho = "PROTOCOLO"
                        },
                        new
                        {
                            Id = new Guid("66288962-d951-496d-a810-645af30811b7"),
                            TipoDeRequerimento = "ELETRONICO",
                            TipoDeTrabalho = "PROTOCOLO"
                        },
                        new
                        {
                            Id = new Guid("627432d9-db95-40ed-bb13-0a718983313e"),
                            TipoDeRequerimento = "DESPACHO",
                            TipoDeTrabalho = "DESPACHO"
                        },
                        new
                        {
                            Id = new Guid("eb8bf519-9689-41a5-b086-3c81ebda5375"),
                            TipoDeRequerimento = "DILIGENCIAEMCARTORIO",
                            TipoDeTrabalho = "DILIGENCIAEMCARTORIO"
                        },
                        new
                        {
                            Id = new Guid("85d721bb-6df4-4e92-916e-cad5d7fbb232"),
                            TipoDeRequerimento = "DILIGENCIAEMCARTORIO",
                            TipoDeTrabalho = "DILIGENCIAEMCARTORIO"
                        },
                        new
                        {
                            Id = new Guid("c08a4e4a-05ce-4080-97cd-3307ce22c5c2"),
                            TipoDeRequerimento = "EXTRAJUDICIAL",
                            TipoDeTrabalho = "DILIGENCIAEXTRAJUDICIAL"
                        },
                        new
                        {
                            Id = new Guid("03f63a1e-cfb3-454e-b3e0-4398c4c36f3d"),
                            TipoDeRequerimento = "HOMOLOGACAO",
                            TipoDeTrabalho = "HOMOLOGACAO"
                        },
                        new
                        {
                            Id = new Guid("73b74961-93bb-4cac-b24f-588d5d2ff648"),
                            TipoDeRequerimento = "NOTIFICACAO",
                            TipoDeTrabalho = "NOTIFICACAO"
                        },
                        new
                        {
                            Id = new Guid("ad296fe2-6795-4bc2-b026-09dc191ca912"),
                            TipoDeRequerimento = "RETIRADAEENVIO",
                            TipoDeTrabalho = "ALVARA"
                        },
                        new
                        {
                            Id = new Guid("3971405c-15ca-4378-a8bd-d234124f08de"),
                            TipoDeRequerimento = "RETIRADAELEVANTAMENTO",
                            TipoDeTrabalho = "ALVARA"
                        },
                        new
                        {
                            Id = new Guid("4a22c091-4add-42d8-be18-bbae655d683a"),
                            TipoDeRequerimento = "EMISSAODEGUIA",
                            TipoDeTrabalho = "EMISSAODEGUIA"
                        },
                        new
                        {
                            Id = new Guid("a9a7f2bc-e64f-49d6-8b17-44759beddcc4"),
                            TipoDeRequerimento = "EMISSAODECERTIDAO",
                            TipoDeTrabalho = "EMISSAODECERTIDAO"
                        });
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Usuario", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsPrimeiroAcesso")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Cliente", b =>
                {
                    b.HasOne("cjuridico.Domain.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Correspondente", b =>
                {
                    b.HasOne("cjuridico.Domain.Models.Comarca", "Comarca")
                        .WithMany()
                        .HasForeignKey("ComarcaId");

                    b.Navigation("Comarca");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.CustoAdicional", b =>
                {
                    b.HasOne("cjuridico.Domain.Models.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.DiligenciaExtrajudicial", b =>
                {
                    b.HasOne("cjuridico.Domain.Models.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.Pedido", b =>
                {
                    b.HasOne("cjuridico.Domain.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cjuridico.Domain.Models.Comarca", "Comarca")
                        .WithMany()
                        .HasForeignKey("ComarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cjuridico.Domain.Models.Esfera", "Esfera")
                        .WithMany()
                        .HasForeignKey("EsferaId");

                    b.HasOne("cjuridico.Domain.Models.Usuario", "Executivo")
                        .WithMany()
                        .HasForeignKey("ExecutivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cjuridico.Domain.Models.Correspondente", "ProfissionalSelecionado")
                        .WithMany()
                        .HasForeignKey("ProfissionalSelecionadoId");

                    b.HasOne("cjuridico.Domain.Models.Solicitacao", "Solicitacao")
                        .WithMany()
                        .HasForeignKey("SolicitacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Comarca");

                    b.Navigation("Esfera");

                    b.Navigation("Executivo");

                    b.Navigation("ProfissionalSelecionado");

                    b.Navigation("Solicitacao");
                });

            modelBuilder.Entity("cjuridico.Domain.Models.PedidoAuditoria", b =>
                {
                    b.HasOne("cjuridico.Domain.Models.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });
#pragma warning restore 612, 618
        }
    }
}
