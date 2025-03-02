using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea_Práctica_2_.Migrations
{
    /// <inheritdoc />
    public partial class x : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Categoria",
                columns: table => new
                {
                    idCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Categoria", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Consola",
                columns: table => new
                {
                    idConsola = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Consola", x => x.idConsola);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Producto",
                columns: table => new
                {
                    idProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idCategoria = table.Column<int>(type: "int", nullable: false),
                    idConsola = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Producto", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK_tbl_Producto_tbl_Categoria_idCategoria",
                        column: x => x.idCategoria,
                        principalTable: "tbl_Categoria",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Producto_tbl_Consola_idConsola",
                        column: x => x.idConsola,
                        principalTable: "tbl_Consola",
                        principalColumn: "idConsola",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Producto_idCategoria",
                table: "tbl_Producto",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Producto_idConsola",
                table: "tbl_Producto",
                column: "idConsola");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Producto");

            migrationBuilder.DropTable(
                name: "tbl_Categoria");

            migrationBuilder.DropTable(
                name: "tbl_Consola");
        }
    }
}
