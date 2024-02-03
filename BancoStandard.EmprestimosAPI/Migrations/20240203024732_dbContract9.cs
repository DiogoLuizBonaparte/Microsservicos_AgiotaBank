using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BancoStandard.EmprestimosAPI.Migrations
{
    /// <inheritdoc />
    public partial class dbContract9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "contract",
                columns: new[] { "id", "cliente", "data_acor", "data_emp", "data_final", "observacao", "porcentagem", "tipo_pagamento", "valor_div", "valor_emp", "valor_luc" },
                values: new object[,]
                {
                    { 1L, "Napoleão Bonaparte", 0, 0, 0, "Pagamento em dia", 0.0, "Ramo Diário", 1300.0, 1000.0, 300.0 },
                    { 2L, "Costa Lucas", 0, 0, 0, "Pagamento em dia", 0.0, "Pagamento Mensal", 6500.0, 5000.0, 1500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "contract",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "contract",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
