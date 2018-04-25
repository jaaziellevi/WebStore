using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebStore.Migrations
{
    public partial class ItemCarrinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItensDoCarrinho",
                columns: table => new
                {
                    ItemDoCarrinhoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarrinhoDeComprasId = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    RoupaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensDoCarrinho", x => x.ItemDoCarrinhoId);
                    table.ForeignKey(
                        name: "FK_ItensDoCarrinho_Roupas_RoupaId",
                        column: x => x.RoupaId,
                        principalTable: "Roupas",
                        principalColumn: "RoupaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensDoCarrinho_RoupaId",
                table: "ItensDoCarrinho",
                column: "RoupaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensDoCarrinho");
        }
    }
}
