using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebStore.Migrations
{
    public partial class Compras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    DataCompra = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    PrimeiroNome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    TotalCompra = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                });

            migrationBuilder.CreateTable(
                name: "DetalhesCompras",
                columns: table => new
                {
                    DetalhesCompraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompraId = table.Column<int>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    RoupaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalhesCompras", x => x.DetalhesCompraId);
                    table.ForeignKey(
                        name: "FK_DetalhesCompras_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalhesCompras_Roupas_RoupaId",
                        column: x => x.RoupaId,
                        principalTable: "Roupas",
                        principalColumn: "RoupaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalhesCompras_CompraId",
                table: "DetalhesCompras",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhesCompras_RoupaId",
                table: "DetalhesCompras",
                column: "RoupaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalhesCompras");

            migrationBuilder.DropTable(
                name: "Compras");
        }
    }
}
