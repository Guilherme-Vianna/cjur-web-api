using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cjuridico.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsPrimeiroAcesso = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comarca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EstadoUF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comarca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Esfera",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Esfera", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExecutivoDeConta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExecutivoDeConta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Solicitacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoDeTrabalho = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TipoDeRequerimento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Correspondente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComarcaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsAprovado = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NumeroOAB = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    OABUF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DadosBancarios = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correspondente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Correspondente_Comarca_ComarcaId",
                        column: x => x.ComarcaId,
                        principalTable: "Comarca",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataDeCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NomeEscritorio = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsAvulso = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExecutivoId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ComarcaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PedidoStatus = table.Column<int>(type: "int", nullable: false),
                    SolicitacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EsferaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NumeroDoProcesso = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Vara = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Reu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Local = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProfissionalSelecionadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PresencialOuVirtual = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    Conclusao = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: true),
                    IsAvulso = table.Column<bool>(type: "bit", nullable: false),
                    NumeroPedido = table.Column<int>(type: "int", nullable: false),
                    CodigoCliente = table.Column<int>(type: "int", nullable: false),
                    DataDoPedido = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataDeCumprimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataDeConclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_AspNetUsers_ExecutivoId",
                        column: x => x.ExecutivoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_Comarca_ComarcaId",
                        column: x => x.ComarcaId,
                        principalTable: "Comarca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_Correspondente_ProfissionalSelecionadoId",
                        column: x => x.ProfissionalSelecionadoId,
                        principalTable: "Correspondente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pedido_Esfera_EsferaId",
                        column: x => x.EsferaId,
                        principalTable: "Esfera",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pedido_Solicitacao_SolicitacaoId",
                        column: x => x.SolicitacaoId,
                        principalTable: "Solicitacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustoAdicional",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustoAdicional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustoAdicional_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiligenciaExtrajudicial",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ato = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiligenciaExtrajudicial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiligenciaExtrajudicial_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoAuditoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Responsavel = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PedidoStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoAuditoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoAuditoria_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b1335ee-105b-4129-ac9a-35bb185eb123", "bb03799f-697e-437e-9634-10cb98aa6833", "Colaborador", "Colaborador" },
                    { "331f277b-c37d-46dd-a79a-04a1c2517a1f", "5430be54-47d2-4688-924d-f95bf4318c5a", "Cliente", "Cliente" },
                    { "42fd6912-0c64-4c2d-82de-7ed7b5ff0834", "6c7aab98-82b6-49be-a57f-20c0873d688c", "Comercial", "Comercial" },
                    { "455f43db-fb11-4313-9dda-605c035b6e6d", "40fc18ce-393e-4bc2-9fd3-d7df37def0a8", "Financeiro", "Financeiro" },
                    { "955c1333-7e28-424f-86b3-126c6cbb12b5", "cf11296a-7c32-401a-8480-818b4bff7aed", "Correspondente", "Correspondente" },
                    { "970068bb-e832-43bc-a86d-57999abbfef0", "e944c946-02d8-4c11-9c87-7e7975558a4e", "Administrador", "Administrador" },
                    { "c366b811-76a8-4427-97c4-c266229281a1", "00db84e3-e32a-4a2e-8a9d-5b84b5a27be8", "Lider", "Lider" }
                });

            migrationBuilder.InsertData(
                table: "Esfera",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("1467c584-5538-4336-b218-948bd79e839f"), "Federal" },
                    { new Guid("41ca3685-f11c-4fbc-b7fc-f95b4f141c4f"), "Trabalhista" },
                    { new Guid("7270d17a-7c66-4daf-81de-ad57cbb8023c"), "Criminal" },
                    { new Guid("db9b7097-3140-4179-b8ce-b411cd0675a7"), "Juizado" },
                    { new Guid("f1571cec-7c3c-4a76-953f-c5b6d8514138"), "Cívil" },
                    { new Guid("f186a4c7-ed1c-4df4-ad85-b6fc1e5271ab"), "Procon" }
                });

            migrationBuilder.InsertData(
                table: "Solicitacao",
                columns: new[] { "Id", "TipoDeRequerimento", "TipoDeTrabalho" },
                values: new object[,]
                {
                    { new Guid("03f63a1e-cfb3-454e-b3e0-4398c4c36f3d"), "HOMOLOGACAO", "HOMOLOGACAO" },
                    { new Guid("27d4fe88-e924-4cd5-af42-1da62b9868d5"), "PARCIAL", "COPIADEPROCESSO" },
                    { new Guid("3971405c-15ca-4378-a8bd-d234124f08de"), "RETIRADAELEVANTAMENTO", "ALVARA" },
                    { new Guid("4a22c091-4add-42d8-be18-bbae655d683a"), "EMISSAODEGUIA", "EMISSAODEGUIA" },
                    { new Guid("4f692c84-a429-41ba-8183-ce83844bed43"), "INTEGRAL", "COPIADEPROCESSO" },
                    { new Guid("52196855-739e-49b5-a07d-897144632412"), "CONCILIACAO", "AUDIENCIA" },
                    { new Guid("627432d9-db95-40ed-bb13-0a718983313e"), "DESPACHO", "DESPACHO" },
                    { new Guid("66288962-d951-496d-a810-645af30811b7"), "ELETRONICO", "PROTOCOLO" },
                    { new Guid("73b74961-93bb-4cac-b24f-588d5d2ff648"), "NOTIFICACAO", "NOTIFICACAO" },
                    { new Guid("85d721bb-6df4-4e92-916e-cad5d7fbb232"), "DILIGENCIAEMCARTORIO", "DILIGENCIAEMCARTORIO" },
                    { new Guid("a9a7f2bc-e64f-49d6-8b17-44759beddcc4"), "EMISSAODECERTIDAO", "EMISSAODECERTIDAO" },
                    { new Guid("ad296fe2-6795-4bc2-b026-09dc191ca912"), "RETIRADAEENVIO", "ALVARA" },
                    { new Guid("c03a4d52-8002-43c7-a63d-b66f9883041a"), "FISICO", "PROTOCOLO" },
                    { new Guid("c08a4e4a-05ce-4080-97cd-3307ce22c5c2"), "EXTRAJUDICIAL", "DILIGENCIAEXTRAJUDICIAL" },
                    { new Guid("c71f236c-87e4-4e09-8503-b16b9bea3817"), "PETICAOINICIAL", "DISTRIBUICAO" },
                    { new Guid("cd1f62e5-a325-484c-9c9d-1ab340b5330f"), "CARTAPRECATORIA", "DISTRIBUICAO" },
                    { new Guid("db9a9612-a128-4a7a-accf-0a16df7242e7"), "UNA", "AUDIENCIA" },
                    { new Guid("eb8bf519-9689-41a5-b086-3c81ebda5375"), "DILIGENCIAEMCARTORIO", "DILIGENCIAEMCARTORIO" },
                    { new Guid("fd774886-0000-4981-a097-d1a1ef6ce456"), "INSTRUCAOEJULGAMENTO", "AUDIENCIA" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EmpresaId",
                table: "Cliente",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondente_ComarcaId",
                table: "Correspondente",
                column: "ComarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_CustoAdicional_PedidoId",
                table: "CustoAdicional",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_DiligenciaExtrajudicial_PedidoId",
                table: "DiligenciaExtrajudicial",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ComarcaId",
                table: "Pedido",
                column: "ComarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_EsferaId",
                table: "Pedido",
                column: "EsferaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ExecutivoId",
                table: "Pedido",
                column: "ExecutivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ProfissionalSelecionadoId",
                table: "Pedido",
                column: "ProfissionalSelecionadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_SolicitacaoId",
                table: "Pedido",
                column: "SolicitacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoAuditoria_PedidoId",
                table: "PedidoAuditoria",
                column: "PedidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CustoAdicional");

            migrationBuilder.DropTable(
                name: "DiligenciaExtrajudicial");

            migrationBuilder.DropTable(
                name: "ExecutivoDeConta");

            migrationBuilder.DropTable(
                name: "PedidoAuditoria");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Correspondente");

            migrationBuilder.DropTable(
                name: "Esfera");

            migrationBuilder.DropTable(
                name: "Solicitacao");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Comarca");
        }
    }
}
