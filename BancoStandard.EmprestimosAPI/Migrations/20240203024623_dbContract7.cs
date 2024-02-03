using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BancoStandard.EmprestimosAPI.Migrations
{
    /// <inheritdoc />
    public partial class dbContract7 : Migration
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
                    data_emp = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    data_acor = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    data_final = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    observacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contract", x => x.id);
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
