using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BancoStandard.EmprestimosAPI.Migrations
{
    /// <inheritdoc />
    public partial class ContAPIDados3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contract",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    valor_emp = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    valor_div = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    valor_luc = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    porcentagem = table.Column<double>(type: "float", maxLength: 50, nullable: false),
                    tipo_pagamento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    data_emp = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    data_acor = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    data_final = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    observacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contract", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "contract",
                columns: new[] { "id", "cliente", "data_acor", "data_emp", "data_final", "observacao", "porcentagem", "tipo_pagamento", "valor_div", "valor_emp", "valor_luc" },
                values: new object[,]
                {
                    { 1L, "Napoleão Bonaparte", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pagamento em dia", 30.0, "Ramo Diário", 1300.0, 1000.0, 300.0 },
                    { 2L, "Costa Lucas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pagamento em dia", 30.0, "Pagamento Mensal", 6500.0, 5000.0, 1500.0 },
                    { 3L, "James de Paris", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pagamento em dia", 30.0, "Pagamento Mensal", 6500.0, 5000.0, 1500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contract");
        }
    }
}
