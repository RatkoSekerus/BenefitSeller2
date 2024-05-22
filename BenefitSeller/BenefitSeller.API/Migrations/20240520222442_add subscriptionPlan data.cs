using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BenefitSeller.API.Migrations
{
    /// <inheritdoc />
    public partial class addsubscriptionPlandata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 0, 24, 41, 666, DateTimeKind.Local).AddTicks(2810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 20, 22, 7, 20, 236, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.InsertData(
                table: "SubscriptionPlans",
                columns: new[] { "Id", "Name", "SubscriptionType" },
                values: new object[,]
                {
                    { new Guid("29d4378b-e387-41f2-97b2-fcdcde2eb693"), "Platinum Plan", 2 },
                    { new Guid("7793fed3-a63a-4912-b47b-fa5e6fba1ffe"), "Premium Plan", 1 },
                    { new Guid("f13ac76c-30ec-4365-9830-9d059216fa8c"), "Standard Plan", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("29d4378b-e387-41f2-97b2-fcdcde2eb693"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("7793fed3-a63a-4912-b47b-fa5e6fba1ffe"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("f13ac76c-30ec-4365-9830-9d059216fa8c"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 20, 22, 7, 20, 236, DateTimeKind.Local).AddTicks(7343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 21, 0, 24, 41, 666, DateTimeKind.Local).AddTicks(2810));
        }
    }
}
