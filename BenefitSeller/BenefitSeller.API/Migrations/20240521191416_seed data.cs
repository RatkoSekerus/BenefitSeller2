using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BenefitSeller.API.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "balance",
                table: "UserCards",
                newName: "Balance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 21, 14, 15, 778, DateTimeKind.Local).AddTicks(4995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 21, 0, 24, 41, 666, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "S");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"), "PlatinumCompany" },
                    { new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"), "StandardCompany" },
                    { new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"), "PremiumCompany" }
                });

            migrationBuilder.InsertData(
                table: "MerchantCategoryGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3"), "Food and drinks" },
                    { new Guid("284120ff-9afe-4cb4-9261-6beeac48b0b3"), "Recreation" },
                    { new Guid("28c37842-82f1-479e-aedc-bcf9dca36092"), "Shopping" },
                    { new Guid("510a7082-29ce-4155-b73c-528ba29875f3"), "Traveling" },
                    { new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7"), "Culture" },
                    { new Guid("dd240346-816a-4153-8636-7feabe1aed10"), "Education" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPlans",
                columns: new[] { "Id", "Name", "SubscriptionType" },
                values: new object[,]
                {
                    { new Guid("d85e0cb1-acea-488e-b583-76cf88e272ed"), "Premium", 1 },
                    { new Guid("daf621c3-2f1d-459a-b6ca-3207005fd585"), "Platinum", 2 },
                    { new Guid("dba735ac-78a6-44d2-8904-226f9e3fdc5f"), "Standard", 0 }
                });

            migrationBuilder.InsertData(
                table: "CompanyBenefit",
                columns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                values: new object[,]
                {
                    { new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"), new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3") },
                    { new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"), new Guid("28c37842-82f1-479e-aedc-bcf9dca36092") },
                    { new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"), new Guid("510a7082-29ce-4155-b73c-528ba29875f3") },
                    { new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"), new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3") },
                    { new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"), new Guid("284120ff-9afe-4cb4-9261-6beeac48b0b3") },
                    { new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"), new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7") },
                    { new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"), new Guid("dd240346-816a-4153-8636-7feabe1aed10") }
                });

            migrationBuilder.InsertData(
                table: "MerchantCategories",
                columns: new[] { "Id", "MerchantCategoryGroupId", "Name" },
                values: new object[,]
                {
                    { new Guid("41706e95-912e-49cd-b159-43c9d793b3d3"), new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3"), "Coffee shops" },
                    { new Guid("4aa06b0f-a75c-4f20-8856-ed30599ffe51"), new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3"), "Restaurants" },
                    { new Guid("598e3758-3d24-4c02-b094-ebfeabbca8ad"), new Guid("510a7082-29ce-4155-b73c-528ba29875f3"), "Fuel" },
                    { new Guid("714f01c2-796f-47b7-bf21-f44be23fb637"), new Guid("510a7082-29ce-4155-b73c-528ba29875f3"), "Plane tickets" },
                    { new Guid("7cd4858a-985d-4baf-bdee-79198e8ea2ca"), new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7"), "Theater" },
                    { new Guid("81b2c9b0-537f-4153-adc4-5fd955bc4b0a"), new Guid("284120ff-9afe-4cb4-9261-6beeac48b0b3"), "Sauna" },
                    { new Guid("91661a10-d661-4091-89e7-be860647a72d"), new Guid("510a7082-29ce-4155-b73c-528ba29875f3"), "Train or bus tickets" },
                    { new Guid("9a001141-bcf8-46d6-b736-fad01a257cf9"), new Guid("dd240346-816a-4153-8636-7feabe1aed10"), "Conferences" },
                    { new Guid("b167e44e-7bf3-48eb-a9f8-2f3ab12093f4"), new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7"), "Cinema" },
                    { new Guid("d2460aa2-8f34-45ed-8d90-2630c913b752"), new Guid("284120ff-9afe-4cb4-9261-6beeac48b0b3"), "Fitness" },
                    { new Guid("e45c40dc-fbfe-4ef0-adca-e33858c01515"), new Guid("510a7082-29ce-4155-b73c-528ba29875f3"), "Taxi" },
                    { new Guid("ea5b0448-732d-48f6-92b4-5d4b7ad768f5"), new Guid("dd240346-816a-4153-8636-7feabe1aed10"), "Courses" },
                    { new Guid("f8211f11-c9ef-45e4-8da4-06679291ac99"), new Guid("dd240346-816a-4153-8636-7feabe1aed10"), "Books" },
                    { new Guid("ffdcc4f4-dee5-4fd7-9079-9da572dca9ad"), new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7"), "Museum" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyId", "Password", "SubscriptionPlanId", "UserName" },
                values: new object[,]
                {
                    { new Guid("0de53f81-cb88-4251-bdfa-7e1fcba4988d"), new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"), "password", new Guid("dba735ac-78a6-44d2-8904-226f9e3fdc5f"), "StandardUser" },
                    { new Guid("453baa8a-67d8-4cdf-a5be-2854861f8de3"), new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"), "password", new Guid("daf621c3-2f1d-459a-b6ca-3207005fd585"), "PlatinumUser" },
                    { new Guid("8cd0b9f0-5f18-4cc1-bcc9-965166292e3a"), new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"), "password", new Guid("d85e0cb1-acea-488e-b583-76cf88e272ed"), "PremiumUser" }
                });

            migrationBuilder.InsertData(
                table: "Merchants",
                columns: new[] { "Id", "DiscountPercentage", "MerchantCategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("3e555ccc-39ce-46c9-a889-00ea4efdc3d5"), null, new Guid("ea5b0448-732d-48f6-92b4-5d4b7ad768f5"), "Merchant5" },
                    { new Guid("46ef13f1-e224-4246-9e86-0992854baa3d"), null, new Guid("d2460aa2-8f34-45ed-8d90-2630c913b752"), "Merchant3" },
                    { new Guid("6121e599-8014-4e82-a9ed-8cd3518910da"), null, new Guid("81b2c9b0-537f-4153-adc4-5fd955bc4b0a"), "Merchant4" },
                    { new Guid("6d1c54f3-22a0-4efc-9722-8cf974b0cb16"), 12.5, new Guid("4aa06b0f-a75c-4f20-8856-ed30599ffe51"), "Merchant1" },
                    { new Guid("79f06b3c-31fd-4f01-83e8-101652e9ac96"), null, new Guid("f8211f11-c9ef-45e4-8da4-06679291ac99"), "Merchant6" },
                    { new Guid("7cecf6c1-5769-45a2-af97-14bff65936d6"), 7.5, new Guid("41706e95-912e-49cd-b159-43c9d793b3d3"), "Merchant2" }
                });

            migrationBuilder.InsertData(
                table: "UserCards",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("1afe9403-26f6-4118-bae0-a93c0edbefbc"), new Guid("8cd0b9f0-5f18-4cc1-bcc9-965166292e3a") },
                    { new Guid("730db7eb-8962-4c4d-ae33-52d152b877a3"), new Guid("453baa8a-67d8-4cdf-a5be-2854861f8de3") },
                    { new Guid("dc5bc907-af4b-4870-bf87-743c2a6148cd"), new Guid("0de53f81-cb88-4251-bdfa-7e1fcba4988d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"), new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"), new Guid("28c37842-82f1-479e-aedc-bcf9dca36092") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"), new Guid("510a7082-29ce-4155-b73c-528ba29875f3") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"), new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"), new Guid("284120ff-9afe-4cb4-9261-6beeac48b0b3") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"), new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"), new Guid("dd240346-816a-4153-8636-7feabe1aed10") });

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("598e3758-3d24-4c02-b094-ebfeabbca8ad"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("714f01c2-796f-47b7-bf21-f44be23fb637"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("7cd4858a-985d-4baf-bdee-79198e8ea2ca"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("91661a10-d661-4091-89e7-be860647a72d"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a001141-bcf8-46d6-b736-fad01a257cf9"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("b167e44e-7bf3-48eb-a9f8-2f3ab12093f4"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("e45c40dc-fbfe-4ef0-adca-e33858c01515"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("ffdcc4f4-dee5-4fd7-9079-9da572dca9ad"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("3e555ccc-39ce-46c9-a889-00ea4efdc3d5"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("46ef13f1-e224-4246-9e86-0992854baa3d"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("6121e599-8014-4e82-a9ed-8cd3518910da"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("6d1c54f3-22a0-4efc-9722-8cf974b0cb16"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("79f06b3c-31fd-4f01-83e8-101652e9ac96"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("7cecf6c1-5769-45a2-af97-14bff65936d6"));

            migrationBuilder.DeleteData(
                table: "UserCards",
                keyColumn: "Id",
                keyValue: new Guid("1afe9403-26f6-4118-bae0-a93c0edbefbc"));

            migrationBuilder.DeleteData(
                table: "UserCards",
                keyColumn: "Id",
                keyValue: new Guid("730db7eb-8962-4c4d-ae33-52d152b877a3"));

            migrationBuilder.DeleteData(
                table: "UserCards",
                keyColumn: "Id",
                keyValue: new Guid("dc5bc907-af4b-4870-bf87-743c2a6148cd"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("41706e95-912e-49cd-b159-43c9d793b3d3"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("4aa06b0f-a75c-4f20-8856-ed30599ffe51"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("81b2c9b0-537f-4153-adc4-5fd955bc4b0a"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2460aa2-8f34-45ed-8d90-2630c913b752"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea5b0448-732d-48f6-92b4-5d4b7ad768f5"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8211f11-c9ef-45e4-8da4-06679291ac99"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("28c37842-82f1-479e-aedc-bcf9dca36092"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("510a7082-29ce-4155-b73c-528ba29875f3"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0de53f81-cb88-4251-bdfa-7e1fcba4988d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("453baa8a-67d8-4cdf-a5be-2854861f8de3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cd0b9f0-5f18-4cc1-bcc9-965166292e3a"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("284120ff-9afe-4cb4-9261-6beeac48b0b3"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("dd240346-816a-4153-8636-7feabe1aed10"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("d85e0cb1-acea-488e-b583-76cf88e272ed"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("daf621c3-2f1d-459a-b6ca-3207005fd585"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("dba735ac-78a6-44d2-8904-226f9e3fdc5f"));

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "UserCards",
                newName: "balance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 0, 24, 41, 666, DateTimeKind.Local).AddTicks(2810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 21, 21, 14, 15, 778, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "S",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
