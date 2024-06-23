using Microsoft.EntityFrameworkCore.Migrations;

namespace _3AccessData.Migrations
{
    public partial class migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoriaJuegos",
                columns: new[] { "Id", "CategoriaId", "JuegoId" },
                values: new object[,]
                {
                    { 4, 1, 3 },
                    { 5, 5, 3 },
                    { 6, 4, 4 },
                    { 7, 5, 5 },
                    { 8, 5, 6 },
                    { 9, 6, 6 },
                    { 10, 5, 7 },
                    { 11, 6, 7 },
                    { 12, 3, 8 },
                    { 13, 5, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
