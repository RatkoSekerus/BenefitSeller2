using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenefitSeller.API.Migrations
{
    /// <inheritdoc />
    public partial class addusercardstouser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 20, 22, 7, 20, 236, DateTimeKind.Local).AddTicks(7343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 20, 21, 15, 2, 168, DateTimeKind.Local).AddTicks(6842));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 20, 21, 15, 2, 168, DateTimeKind.Local).AddTicks(6842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 20, 22, 7, 20, 236, DateTimeKind.Local).AddTicks(7343));
        }
    }
}
