using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3AccessData.Migrations
{
    public partial class migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    categoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.categoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Juegos",
                columns: table => new
                {
                    juegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(40)", nullable: false),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    imagen = table.Column<string>(type: "varchar(500)", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.juegoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(15)", nullable: false),
                    apellido = table.Column<string>(type: "varchar(15)", nullable: false),
                    dni = table.Column<string>(type: "varchar(15)", nullable: false),
                    email = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.usuarioId);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaJuegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuegoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaJuegos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriaJuegos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "categoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaJuegos_Juegos_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juegos",
                        principalColumn: "juegoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carritos",
                columns: table => new
                {
                    carritoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carritos", x => x.carritoId);
                    table.ForeignKey(
                        name: "FK_Carritos_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarritoJuegos",
                columns: table => new
                {
                    carritoJuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    juegoId = table.Column<int>(type: "int", nullable: false),
                    carritoId = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoJuegos", x => x.carritoJuegoId);
                    table.ForeignKey(
                        name: "FK_CarritoJuegos_Carritos_carritoId",
                        column: x => x.carritoId,
                        principalTable: "Carritos",
                        principalColumn: "carritoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarritoJuegos_Juegos_juegoId",
                        column: x => x.juegoId,
                        principalTable: "Juegos",
                        principalColumn: "juegoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "categoriaId", "tipo" },
                values: new object[,]
                {
                    { 1, "RPG" },
                    { 2, "FPS" },
                    { 3, "Terror" },
                    { 4, "Pelea" },
                    { 5, "Accion" },
                    { 6, "Fantasia" }
                });

            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "juegoId", "descripcion", "imagen", "nombre", "precio" },
                values: new object[,]
                {
                    { 10, "PlayStation", "https://uvejuegos.com/img/caratulas/61051/Battlefield-V-PS4.jpg", "Battlefield V", 8000m },
                    { 9, "PlayStation", "https://cybergamesemanuel.com/wp-content/uploads/2020/04/Resident-evil-3-2.jpg", "Resident Evil 3", 8000m },
                    { 8, "PlayStation", "https://uvejuegos.com/img/caratulas/56484/ps4.jpg", "Resident Evil 4", 8000m },
                    { 7, "PlayStation", "https://uvejuegos.com/img/caratulas/61273/control_ps4.jpg", "Control", 8000m },
                    { 6, "PlayStation", "https://uvejuegos.com/img/caratulas/59884/ghostps4.jpg", "Ghost of Tsushima", 8000m },
                    { 4, "PlayStation", "https://media.vandal.net/m/68948/granblue-fantasy-versus-20202281558476_1.jpg", "Grand Blue Fantasy VS", 80000m },
                    { 3, "PlayStation", "https://media.vandal.net/m/31670/nier-automata-201739151954_1.jpg", "Nier Automata", 12000m },
                    { 2, "PlayStation", "https://d3ugyf2ht6aenh.cloudfront.net/stores/001/054/804/products/final-fantasy-xv-1pre1-1d968ea8634df9059016615194247849-1024-1024.jpg", "Final Fantasy XV", 10000m },
                    { 1, "PlayStation", "https://kalimagames.com/wp-content/uploads/2022/06/god-of-war-cover-ps4.jpg", "God of War", 9000m },
                    { 5, "PlayStation", "https://img.asmedia.epimg.net/resizer/nLnnwOnepXsO4SxQi5clD-OMDU4=/1472x0/cloudfront-eu-central-1.images.arcpublishing.com/diarioas/UXT2MHW3GZIZVICCIMPIDDZEBQ.jpg", "Uncharted 4", 8000m }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "usuarioId", "apellido", "dni", "email", "nombre" },
                values: new object[,]
                {
                    { 3, "Rodriguez", "30457999", "email@falso.com", "Julio" },
                    { 1, "Martinez", "30456789", "email@falso.com", "Diego" },
                    { 2, "Martinez", "30458889", "email@falso.com", "Alberto" },
                    { 4, "Bros", "30321789", "email@falso.com", "Mario" }
                });

            migrationBuilder.InsertData(
                table: "Carritos",
                columns: new[] { "carritoId", "total", "usuarioId" },
                values: new object[,]
                {
                    { 1, 1650m, 1 },
                    { 2, 1750m, 2 }
                });

            migrationBuilder.InsertData(
                table: "CategoriaJuegos",
                columns: new[] { "Id", "CategoriaId", "JuegoId" },
                values: new object[,]
                {
                    { 2, 5, 1 },
                    { 3, 6, 1 },
                    { 1, 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarritoJuegos_carritoId",
                table: "CarritoJuegos",
                column: "carritoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoJuegos_juegoId",
                table: "CarritoJuegos",
                column: "juegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_usuarioId",
                table: "Carritos",
                column: "usuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaJuegos_CategoriaId",
                table: "CategoriaJuegos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaJuegos_JuegoId",
                table: "CategoriaJuegos",
                column: "JuegoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarritoJuegos");

            migrationBuilder.DropTable(
                name: "CategoriaJuegos");

            migrationBuilder.DropTable(
                name: "Carritos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Juegos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
