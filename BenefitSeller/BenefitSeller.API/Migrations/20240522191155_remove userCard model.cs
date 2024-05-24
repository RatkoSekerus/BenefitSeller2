using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BenefitSeller.API.Migrations
{
    /// <inheritdoc />
    public partial class removeuserCardmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCards");

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
                keyValue: new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"));

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

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 11, 55, 32, DateTimeKind.Local).AddTicks(621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 21, 21, 14, 15, 778, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.AddColumn<double>(
                name: "Earnings",
                table: "Merchants",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2869f08c-a8e0-4d67-a153-76f232a154b5"), "PremiumCompany" },
                    { new Guid("ce7d8146-02e5-4ffe-bf7c-0013643b30e2"), "StandardCompany" },
                    { new Guid("e0506eb7-4a85-4dc4-8705-92ce99688440"), "PlatinumCompany" }
                });

            migrationBuilder.InsertData(
                table: "MerchantCategoryGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("169bcab1-0c3c-42e8-a2ce-06d57da9213a"), "Culture" },
                    { new Guid("8981a714-dbb0-461c-b434-2e640811bf14"), "Shopping" },
                    { new Guid("a4ec0845-6db0-4b6b-a346-6ecc3f2c504e"), "Recreation" },
                    { new Guid("b3999514-210f-4942-895c-d760d9423542"), "Traveling" },
                    { new Guid("b8068328-48b6-47c7-a57a-bc346b7e09ae"), "Food and drinks" },
                    { new Guid("f61eb6bf-11b1-4954-b3bd-aa57a88aa83b"), "Education" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPlans",
                columns: new[] { "Id", "Name", "SubscriptionType" },
                values: new object[,]
                {
                    { new Guid("5373457e-862f-48f3-839a-31f539aa02c7"), "Standard", 0 },
                    { new Guid("6c3209c7-a1d5-4788-8607-50cec3b23c4f"), "Platinum", 2 },
                    { new Guid("7dee61e2-c5d6-4bc1-935b-34f99ab970f4"), "Premium", 1 }
                });

            migrationBuilder.InsertData(
                table: "CompanyBenefit",
                columns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                values: new object[,]
                {
                    { new Guid("2869f08c-a8e0-4d67-a153-76f232a154b5"), new Guid("169bcab1-0c3c-42e8-a2ce-06d57da9213a") },
                    { new Guid("2869f08c-a8e0-4d67-a153-76f232a154b5"), new Guid("f61eb6bf-11b1-4954-b3bd-aa57a88aa83b") },
                    { new Guid("ce7d8146-02e5-4ffe-bf7c-0013643b30e2"), new Guid("a4ec0845-6db0-4b6b-a346-6ecc3f2c504e") },
                    { new Guid("ce7d8146-02e5-4ffe-bf7c-0013643b30e2"), new Guid("b8068328-48b6-47c7-a57a-bc346b7e09ae") },
                    { new Guid("e0506eb7-4a85-4dc4-8705-92ce99688440"), new Guid("8981a714-dbb0-461c-b434-2e640811bf14") },
                    { new Guid("e0506eb7-4a85-4dc4-8705-92ce99688440"), new Guid("b3999514-210f-4942-895c-d760d9423542") },
                    { new Guid("e0506eb7-4a85-4dc4-8705-92ce99688440"), new Guid("b8068328-48b6-47c7-a57a-bc346b7e09ae") }
                });

            migrationBuilder.InsertData(
                table: "MerchantCategories",
                columns: new[] { "Id", "MerchantCategoryGroupId", "Name" },
                values: new object[,]
                {
                    { new Guid("3d3e67ce-2f96-4f73-8002-4f0b107f6b73"), new Guid("b3999514-210f-4942-895c-d760d9423542"), "Taxi" },
                    { new Guid("501940da-a849-46f0-a260-409f9511392d"), new Guid("a4ec0845-6db0-4b6b-a346-6ecc3f2c504e"), "Sauna" },
                    { new Guid("58b517eb-5d34-4789-bb42-ec40a366b8e9"), new Guid("f61eb6bf-11b1-4954-b3bd-aa57a88aa83b"), "Books" },
                    { new Guid("591fb82e-b2b1-42ee-98e7-8e84b9cc90fc"), new Guid("169bcab1-0c3c-42e8-a2ce-06d57da9213a"), "Museum" },
                    { new Guid("5c30bbb9-9148-4c7e-8ade-d083f24e5c39"), new Guid("b3999514-210f-4942-895c-d760d9423542"), "Train or bus tickets" },
                    { new Guid("91a1f401-dbf0-435c-9eed-4d0e9debb14c"), new Guid("169bcab1-0c3c-42e8-a2ce-06d57da9213a"), "Cinema" },
                    { new Guid("9eaa49a7-8e46-4ee9-a4cd-5e7799d1baf0"), new Guid("b8068328-48b6-47c7-a57a-bc346b7e09ae"), "Coffee shops" },
                    { new Guid("c0f1215c-01d3-423b-88d7-4b469f205648"), new Guid("b3999514-210f-4942-895c-d760d9423542"), "Fuel" },
                    { new Guid("ca66a2c3-7ff4-4ff0-9876-67be7e33f691"), new Guid("f61eb6bf-11b1-4954-b3bd-aa57a88aa83b"), "Conferences" },
                    { new Guid("da072d76-a96d-413d-b12c-33be3deb6952"), new Guid("b8068328-48b6-47c7-a57a-bc346b7e09ae"), "Restaurants" },
                    { new Guid("ec3eed74-f9ee-49d5-bd76-d9f129ad8639"), new Guid("f61eb6bf-11b1-4954-b3bd-aa57a88aa83b"), "Courses" },
                    { new Guid("f469a0d6-ae97-4621-984c-f79682bc452e"), new Guid("a4ec0845-6db0-4b6b-a346-6ecc3f2c504e"), "Fitness" },
                    { new Guid("f6f0671f-4b98-43b1-bba3-b5b650826e0a"), new Guid("169bcab1-0c3c-42e8-a2ce-06d57da9213a"), "Theater" },
                    { new Guid("fb67e8ac-c34a-490e-84b3-b7368c5218e0"), new Guid("b3999514-210f-4942-895c-d760d9423542"), "Plane tickets" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Balance", "CompanyId", "Password", "SubscriptionPlanId", "UserName" },
                values: new object[,]
                {
                    { new Guid("846b7416-7756-4f9e-9fa5-269d440cc29e"), 100.0, new Guid("2869f08c-a8e0-4d67-a153-76f232a154b5"), "password", new Guid("6c3209c7-a1d5-4788-8607-50cec3b23c4f"), "PlatinumUser" },
                    { new Guid("8e44050a-1330-445b-8d06-638334857d3c"), 100.0, new Guid("2869f08c-a8e0-4d67-a153-76f232a154b5"), "password", new Guid("7dee61e2-c5d6-4bc1-935b-34f99ab970f4"), "PremiumUser" },
                    { new Guid("f88e4ea7-f2bf-45dc-b70d-9abdf871f293"), 100.0, new Guid("ce7d8146-02e5-4ffe-bf7c-0013643b30e2"), "password", new Guid("5373457e-862f-48f3-839a-31f539aa02c7"), "StandardUser" }
                });

            migrationBuilder.InsertData(
                table: "Merchants",
                columns: new[] { "Id", "DiscountPercentage", "Earnings", "MerchantCategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("03712d7e-beac-43a7-a446-e7d555c0bcda"), 7.5, 0.0, new Guid("9eaa49a7-8e46-4ee9-a4cd-5e7799d1baf0"), "Merchant2" },
                    { new Guid("43134a0b-61e5-4e89-8c32-dcd29aa11f69"), null, 0.0, new Guid("f469a0d6-ae97-4621-984c-f79682bc452e"), "Merchant3" },
                    { new Guid("93d43fb0-19e4-4a53-a538-271dab787d30"), null, 0.0, new Guid("ec3eed74-f9ee-49d5-bd76-d9f129ad8639"), "Merchant5" },
                    { new Guid("9c9880b6-9750-42d6-8ace-483728fb3f4c"), null, 0.0, new Guid("501940da-a849-46f0-a260-409f9511392d"), "Merchant4" },
                    { new Guid("a4a4bb29-af9e-4b1c-99be-2f4b6ef05225"), null, 0.0, new Guid("58b517eb-5d34-4789-bb42-ec40a366b8e9"), "Merchant6" },
                    { new Guid("fdfd4b01-7d58-4d37-bda5-dfd68b9c3f24"), 12.5, 0.0, new Guid("da072d76-a96d-413d-b12c-33be3deb6952"), "Merchant1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("2869f08c-a8e0-4d67-a153-76f232a154b5"), new Guid("169bcab1-0c3c-42e8-a2ce-06d57da9213a") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("2869f08c-a8e0-4d67-a153-76f232a154b5"), new Guid("f61eb6bf-11b1-4954-b3bd-aa57a88aa83b") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("ce7d8146-02e5-4ffe-bf7c-0013643b30e2"), new Guid("a4ec0845-6db0-4b6b-a346-6ecc3f2c504e") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("ce7d8146-02e5-4ffe-bf7c-0013643b30e2"), new Guid("b8068328-48b6-47c7-a57a-bc346b7e09ae") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("e0506eb7-4a85-4dc4-8705-92ce99688440"), new Guid("8981a714-dbb0-461c-b434-2e640811bf14") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("e0506eb7-4a85-4dc4-8705-92ce99688440"), new Guid("b3999514-210f-4942-895c-d760d9423542") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("e0506eb7-4a85-4dc4-8705-92ce99688440"), new Guid("b8068328-48b6-47c7-a57a-bc346b7e09ae") });

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d3e67ce-2f96-4f73-8002-4f0b107f6b73"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("591fb82e-b2b1-42ee-98e7-8e84b9cc90fc"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c30bbb9-9148-4c7e-8ade-d083f24e5c39"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("91a1f401-dbf0-435c-9eed-4d0e9debb14c"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0f1215c-01d3-423b-88d7-4b469f205648"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca66a2c3-7ff4-4ff0-9876-67be7e33f691"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6f0671f-4b98-43b1-bba3-b5b650826e0a"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb67e8ac-c34a-490e-84b3-b7368c5218e0"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("03712d7e-beac-43a7-a446-e7d555c0bcda"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("43134a0b-61e5-4e89-8c32-dcd29aa11f69"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("93d43fb0-19e4-4a53-a538-271dab787d30"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("9c9880b6-9750-42d6-8ace-483728fb3f4c"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("a4a4bb29-af9e-4b1c-99be-2f4b6ef05225"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("fdfd4b01-7d58-4d37-bda5-dfd68b9c3f24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("846b7416-7756-4f9e-9fa5-269d440cc29e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e44050a-1330-445b-8d06-638334857d3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f88e4ea7-f2bf-45dc-b70d-9abdf871f293"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("2869f08c-a8e0-4d67-a153-76f232a154b5"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ce7d8146-02e5-4ffe-bf7c-0013643b30e2"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("e0506eb7-4a85-4dc4-8705-92ce99688440"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("501940da-a849-46f0-a260-409f9511392d"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("58b517eb-5d34-4789-bb42-ec40a366b8e9"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("9eaa49a7-8e46-4ee9-a4cd-5e7799d1baf0"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("da072d76-a96d-413d-b12c-33be3deb6952"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("ec3eed74-f9ee-49d5-bd76-d9f129ad8639"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("f469a0d6-ae97-4621-984c-f79682bc452e"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("169bcab1-0c3c-42e8-a2ce-06d57da9213a"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("8981a714-dbb0-461c-b434-2e640811bf14"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("b3999514-210f-4942-895c-d760d9423542"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("5373457e-862f-48f3-839a-31f539aa02c7"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("6c3209c7-a1d5-4788-8607-50cec3b23c4f"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("7dee61e2-c5d6-4bc1-935b-34f99ab970f4"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("a4ec0845-6db0-4b6b-a346-6ecc3f2c504e"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("b8068328-48b6-47c7-a57a-bc346b7e09ae"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("f61eb6bf-11b1-4954-b3bd-aa57a88aa83b"));

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Earnings",
                table: "Merchants");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 21, 14, 15, 778, DateTimeKind.Local).AddTicks(4995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 11, 55, 32, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.CreateTable(
                name: "UserCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserCards_UserId",
                table: "UserCards",
                column: "UserId");
        }
    }
}
