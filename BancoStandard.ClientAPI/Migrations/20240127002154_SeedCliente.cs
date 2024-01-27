using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BancoStandard.CadastroAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "cliente",
                columns: new[] { "id", "name", "profissao" },
                values: new object[,]
                {
                    { 3L, "Napoleão Bonaparte", "Imperador" },
                    { 4L, "Edmond Safra", "Banqueiro" },
                    { 5L, "Geroge H. Bush", "Político" },
                    { 6L, "John Rockefeller", "Industrial" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cliente",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "cliente",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "cliente",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "cliente",
                keyColumn: "id",
                keyValue: 6L);
        }
    }
}
