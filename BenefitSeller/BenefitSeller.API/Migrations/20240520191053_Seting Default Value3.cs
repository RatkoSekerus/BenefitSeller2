using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenefitSeller.API.Migrations
{
    /// <inheritdoc />
    public partial class SetingDefaultValue3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TransactionStatus",
                table: "Transactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 20, 21, 10, 52, 690, DateTimeKind.Local).AddTicks(6714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 20, 20, 58, 6, 578, DateTimeKind.Local).AddTicks(3083));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TransactionStatus",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 20, 20, 58, 6, 578, DateTimeKind.Local).AddTicks(3083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 20, 21, 10, 52, 690, DateTimeKind.Local).AddTicks(6714));
        }
    }
}
