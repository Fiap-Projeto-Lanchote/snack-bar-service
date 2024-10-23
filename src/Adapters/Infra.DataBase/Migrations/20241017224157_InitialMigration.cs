using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    FkCategoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_FkCategoria",
                        column: x => x.FkCategoria,
                        principalTable: "Categoria",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FkUsuario = table.Column<Guid>(nullable: false),
                    Status = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Fim = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_Usuario_FkUsuario",
                        column: x => x.FkUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoPedido",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FkProduto = table.Column<Guid>(nullable: false),
                    FkPedido = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoPedido_Produto_FkProduto",
                        column: x => x.FkProduto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoPedido_Pedido_FkPedido",
                        column: x => x.FkPedido,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
               });

            migrationBuilder.Sql("INSERT INTO Categoria VALUES (1, 'Lanche')");
            migrationBuilder.Sql("INSERT INTO Categoria VALUES (2, 'Acompanhamento')");
            migrationBuilder.Sql("INSERT INTO Categoria VALUES (3, 'Bebida')");
            migrationBuilder.Sql("INSERT INTO Categoria VALUES (4, 'Sobremesa')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "ProdutoPedido");
            migrationBuilder.DropTable(name: "Pedido");
            migrationBuilder.DropTable(name: "Produto");
            migrationBuilder.DropTable(name: "Usuario");
            migrationBuilder.DropTable(name: "Categoria");
        }
    }
}
