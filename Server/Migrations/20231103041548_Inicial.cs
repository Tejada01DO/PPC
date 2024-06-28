using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PPC.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    EntradaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadProducida = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.EntradaId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    precioCompra = table.Column<double>(type: "REAL", nullable: false),
                    precioVenta = table.Column<double>(type: "REAL", nullable: false),
                    Existencia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "EntradasDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntradaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadUtilizada = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradasDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_EntradasDetalle_Entradas_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Entradas",
                        principalColumn: "EntradaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Descripcion", "Existencia", "precioCompra", "precioVenta" },
                values: new object[,]
                {
                    { 1, "Leche", 200, 8.0, 15.0 },
                    { 2, "Pan", 200, 15.0, 30.0 },
                    { 3, "Huevos", 200, 10.0, 25.0 },
                    { 4, "Arroz", 200, 25.0, 50.0 },
                    { 5, "Pasta", 200, 30.0, 60.0 },
                    { 6, "Frutas", 200, 30.0, 60.0 },
                    { 7, "Verduras", 200, 25.0, 50.0 },
                    { 8, "Carne", 200, 50.0, 100.0 },
                    { 10, "Pescado", 200, 40.0, 80.0 },
                    { 11, "Aceite de oliva", 200, 35.0, 70.0 },
                    { 12, "Yogurt", 200, 30.0, 60.0 },
                    { 13, "Queso", 200, 40.0, 80.0 },
                    { 14, "Mantequilla", 200, 30.0, 60.0 },
                    { 15, "Galletas", 200, 20.0, 40.0 },
                    { 16, "Cereal", 200, 25.0, 50.0 },
                    { 17, "Jugo", 200, 20.0, 40.0 },
                    { 18, "Refresco", 200, 20.0, 40.0 },
                    { 19, "Cerveza", 200, 20.0, 40.0 },
                    { 20, "Vino", 200, 30.0, 60.0 },
                    { 21, "Café", 200, 20.0, 40.0 },
                    { 22, "Azúcar", 200, 15.0, 30.0 },
                    { 23, "Sal", 200, 10.0, 20.0 },
                    { 24, "Papel Higienico", 200, 15.0, 30.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntradasDetalle_EntradaId",
                table: "EntradasDetalle",
                column: "EntradaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntradasDetalle");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Entradas");
        }
    }
}
