using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BenefitSeller.API.Migrations
{
    /// <inheritdoc />
    public partial class removepasswordfromusermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Password",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 23, 42, 0, 960, DateTimeKind.Local).AddTicks(4539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 11, 55, 32, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"), "StandardCompany" },
                    { new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"), "PlatinumCompany" },
                    { new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"), "PremiumCompany" }
                });

            migrationBuilder.InsertData(
                table: "MerchantCategoryGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0dfb8498-ef19-46fd-bd74-e63a42130fa7"), "Recreation" },
                    { new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"), "Traveling" },
                    { new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b"), "Food and drinks" },
                    { new Guid("7c3f5f20-35ae-4699-8637-014b774acc76"), "Education" },
                    { new Guid("ad66e86b-69f0-48db-b95b-65f892f1ba08"), "Shopping" },
                    { new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876"), "Culture" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPlans",
                columns: new[] { "Id", "Name", "SubscriptionType" },
                values: new object[,]
                {
                    { new Guid("87ee4d8e-8ed7-457a-bf1c-ff509e2d3d06"), "Premium", 1 },
                    { new Guid("a208be69-33fa-4fd3-9df0-014c7cc21d05"), "Standard", 0 },
                    { new Guid("dea5afbc-0bd3-4369-b5db-2a9b98bdceef"), "Platinum", 2 }
                });

            migrationBuilder.InsertData(
                table: "CompanyBenefit",
                columns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                values: new object[,]
                {
                    { new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"), new Guid("0dfb8498-ef19-46fd-bd74-e63a42130fa7") },
                    { new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"), new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b") },
                    { new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"), new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e") },
                    { new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"), new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b") },
                    { new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"), new Guid("ad66e86b-69f0-48db-b95b-65f892f1ba08") },
                    { new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"), new Guid("7c3f5f20-35ae-4699-8637-014b774acc76") },
                    { new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"), new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876") }
                });

            migrationBuilder.InsertData(
                table: "MerchantCategories",
                columns: new[] { "Id", "MerchantCategoryGroupId", "Name" },
                values: new object[,]
                {
                    { new Guid("058cf432-c25d-4f46-9607-226ff0a51bf6"), new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b"), "Restaurants" },
                    { new Guid("43e123e2-3ba0-47d9-b148-5c5c0d5313b0"), new Guid("7c3f5f20-35ae-4699-8637-014b774acc76"), "Books" },
                    { new Guid("4d188449-589d-4662-85b1-86e3ca67a3b9"), new Guid("7c3f5f20-35ae-4699-8637-014b774acc76"), "Courses" },
                    { new Guid("65c692b0-99f4-4d2b-9b88-db73bfb52517"), new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"), "Taxi" },
                    { new Guid("b474b3ee-cbaa-4217-b544-278cb9ad6da2"), new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b"), "Coffee shops" },
                    { new Guid("b6dba513-44ab-4212-a3d0-eebd84ed303e"), new Guid("0dfb8498-ef19-46fd-bd74-e63a42130fa7"), "Sauna" },
                    { new Guid("bdee9bc0-835e-457b-bd50-4682593dbf4b"), new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876"), "Cinema" },
                    { new Guid("de9ffa95-2f0e-450d-bd36-a6e0da6c7ef7"), new Guid("7c3f5f20-35ae-4699-8637-014b774acc76"), "Conferences" },
                    { new Guid("e797b656-11b6-4cd1-9324-c84dba20a0fa"), new Guid("0dfb8498-ef19-46fd-bd74-e63a42130fa7"), "Fitness" },
                    { new Guid("e998394e-ce58-4c63-9c80-66058f996794"), new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876"), "Museum" },
                    { new Guid("ec671a57-d222-440f-867d-f34c8004eb3d"), new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876"), "Theater" },
                    { new Guid("f0fdbbba-97b3-4fb2-9f05-477aa973bdd7"), new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"), "Plane tickets" },
                    { new Guid("fa5c3fd4-9d4e-439c-9b4a-cf215175b334"), new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"), "Fuel" },
                    { new Guid("fe657679-8cc5-4df4-80d9-90e98204e055"), new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"), "Train or bus tickets" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Balance", "CompanyId", "SubscriptionPlanId", "UserName" },
                values: new object[,]
                {
                    { new Guid("5490a20c-e8f9-41aa-9606-2944813f0e31"), 100.0, new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"), new Guid("87ee4d8e-8ed7-457a-bf1c-ff509e2d3d06"), "PremiumUser" },
                    { new Guid("9ca58ef1-a790-414d-9421-de6023758d02"), 100.0, new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"), new Guid("dea5afbc-0bd3-4369-b5db-2a9b98bdceef"), "PlatinumUser" },
                    { new Guid("b66e8fec-a94f-4acc-9552-68f2e6eeb8d0"), 100.0, new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"), new Guid("a208be69-33fa-4fd3-9df0-014c7cc21d05"), "StandardUser" }
                });

            migrationBuilder.InsertData(
                table: "Merchants",
                columns: new[] { "Id", "DiscountPercentage", "Earnings", "MerchantCategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("08279196-ff85-4712-81ac-714f435b3dbf"), 7.5, 0.0, new Guid("b474b3ee-cbaa-4217-b544-278cb9ad6da2"), "Merchant2" },
                    { new Guid("668dc37d-4fa9-41e4-a49d-c2c72b9b8821"), 12.5, 0.0, new Guid("058cf432-c25d-4f46-9607-226ff0a51bf6"), "Merchant1" },
                    { new Guid("6947fefc-5c7b-49bd-aa1a-39c5dece97e9"), null, 0.0, new Guid("e797b656-11b6-4cd1-9324-c84dba20a0fa"), "Merchant3" },
                    { new Guid("726b887c-2522-4d8a-b32b-cb0cd520a429"), null, 0.0, new Guid("b6dba513-44ab-4212-a3d0-eebd84ed303e"), "Merchant4" },
                    { new Guid("e7becafc-e057-4981-8f07-4023ed72bca5"), null, 0.0, new Guid("4d188449-589d-4662-85b1-86e3ca67a3b9"), "Merchant5" },
                    { new Guid("f07f87c0-0e2b-45e4-8bce-5068c876a42b"), null, 0.0, new Guid("43e123e2-3ba0-47d9-b148-5c5c0d5313b0"), "Merchant6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"), new Guid("0dfb8498-ef19-46fd-bd74-e63a42130fa7") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"), new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"), new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"), new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"), new Guid("ad66e86b-69f0-48db-b95b-65f892f1ba08") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"), new Guid("7c3f5f20-35ae-4699-8637-014b774acc76") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"), new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876") });

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("65c692b0-99f4-4d2b-9b88-db73bfb52517"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("bdee9bc0-835e-457b-bd50-4682593dbf4b"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("de9ffa95-2f0e-450d-bd36-a6e0da6c7ef7"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("e998394e-ce58-4c63-9c80-66058f996794"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("ec671a57-d222-440f-867d-f34c8004eb3d"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0fdbbba-97b3-4fb2-9f05-477aa973bdd7"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("fa5c3fd4-9d4e-439c-9b4a-cf215175b334"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe657679-8cc5-4df4-80d9-90e98204e055"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("08279196-ff85-4712-81ac-714f435b3dbf"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("668dc37d-4fa9-41e4-a49d-c2c72b9b8821"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("6947fefc-5c7b-49bd-aa1a-39c5dece97e9"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("726b887c-2522-4d8a-b32b-cb0cd520a429"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("e7becafc-e057-4981-8f07-4023ed72bca5"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("f07f87c0-0e2b-45e4-8bce-5068c876a42b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5490a20c-e8f9-41aa-9606-2944813f0e31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ca58ef1-a790-414d-9421-de6023758d02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b66e8fec-a94f-4acc-9552-68f2e6eeb8d0"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("058cf432-c25d-4f46-9607-226ff0a51bf6"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("43e123e2-3ba0-47d9-b148-5c5c0d5313b0"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("4d188449-589d-4662-85b1-86e3ca67a3b9"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("b474b3ee-cbaa-4217-b544-278cb9ad6da2"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6dba513-44ab-4212-a3d0-eebd84ed303e"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("e797b656-11b6-4cd1-9324-c84dba20a0fa"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("ad66e86b-69f0-48db-b95b-65f892f1ba08"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("87ee4d8e-8ed7-457a-bf1c-ff509e2d3d06"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("a208be69-33fa-4fd3-9df0-014c7cc21d05"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("dea5afbc-0bd3-4369-b5db-2a9b98bdceef"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("0dfb8498-ef19-46fd-bd74-e63a42130fa7"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("7c3f5f20-35ae-4699-8637-014b774acc76"));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 11, 55, 32, DateTimeKind.Local).AddTicks(621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 22, 23, 42, 0, 960, DateTimeKind.Local).AddTicks(4539));

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
    }
}
