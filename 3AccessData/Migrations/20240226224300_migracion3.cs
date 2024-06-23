using Microsoft.EntityFrameworkCore.Migrations;

namespace _3AccessData.Migrations
{
    public partial class migracion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoriaJuegos",
                columns: new[] { "Id", "CategoriaId", "JuegoId" },
                values: new object[,]
                {
                    { 14, 3, 9 },
                    { 15, 5, 9 },
                    { 16, 2, 10 },
                    { 17, 5, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CategoriaJuegos",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
