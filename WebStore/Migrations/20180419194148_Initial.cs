using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebStore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoriaNome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Roupas",
                columns: table => new
                {
                    RoupaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoriaId = table.Column<int>(nullable: false),
                    DescricaoLonga = table.Column<string>(nullable: true),
                    DescricaoPequena = table.Column<string>(nullable: true),
                    ImagemThumbnailUrl = table.Column<string>(nullable: true),
                    ImagemUrl = table.Column<string>(nullable: true),
                    InStock = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Preco = table.Column<decimal>(nullable: false),
                    RoupaPrefirada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roupas", x => x.RoupaId);
                    table.ForeignKey(
                        name: "FK_Roupas_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roupas_CategoriaId",
                table: "Roupas",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roupas");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
