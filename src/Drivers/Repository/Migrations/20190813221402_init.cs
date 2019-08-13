using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vxTel.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanoTelefonia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HASHCODE = table.Column<Guid>(nullable: false),                   
                    TIPO = table.Column<int>(nullable: false),
                    MinutoPlano = table.Column<int>(nullable: false),
                    TaxaAcrescimo = table.Column<decimal>(nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "DATETIME", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoTelefonia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TarifaTelefonia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HASHCODE = table.Column<Guid>(nullable: false),                    
                    DDD_ORIGEM = table.Column<int>(nullable: false),
                    DDD_DESTINO = table.Column<int>(nullable: false),
                    PRECO_MINUTO = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "DATETIME", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarifaTelefonia", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanoTelefonia");

            migrationBuilder.DropTable(
                name: "TarifaTelefonia");
        }
    }
}
