using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BenefitSeller.API.Migrations
{
    /// <inheritdoc />
    public partial class resetstateindatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 25, 0, 13, 1, 926, DateTimeKind.Local).AddTicks(8377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 22, 23, 42, 0, 960, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8564cf9b-7654-4511-bab9-fe1838085284"), "Company with premium user" },
                    { new Guid("8bde4750-205d-4cec-8819-f84bb9531e4c"), "Company with standard user" },
                    { new Guid("a0e8427b-18b4-4417-a87f-e2b096bf0f2a"), "Company with platinum user" }
                });

            migrationBuilder.InsertData(
                table: "MerchantCategoryGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("283c4592-2e78-4f8c-80a5-552001ca7f67"), "Education" },
                    { new Guid("531382eb-3001-4115-875d-c4baabd6a4e9"), "Culture" },
                    { new Guid("54ebefce-997f-4bd2-a038-b72b08139535"), "Shopping" },
                    { new Guid("98d870de-72e7-4452-868a-58fc6a9a7e99"), "Recreation" },
                    { new Guid("e1f959a2-35f4-4390-a512-4da2f4b2c75d"), "Food and drinks" },
                    { new Guid("fb9971fc-2ee5-4b15-a649-c91babedc015"), "Traveling" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPlans",
                columns: new[] { "Id", "Name", "SubscriptionType" },
                values: new object[,]
                {
                    { new Guid("4bf5967c-e20a-4fe4-be05-f199e14a20a2"), "Premium", 1 },
                    { new Guid("5a472ce6-80c1-4526-91c5-d07d37c26b6f"), "Standard", 0 },
                    { new Guid("a76d72da-d9f5-4ef2-98c4-d2e30c667e1e"), "Platinum", 2 }
                });

            migrationBuilder.InsertData(
                table: "CompanyBenefit",
                columns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                values: new object[,]
                {
                    { new Guid("8564cf9b-7654-4511-bab9-fe1838085284"), new Guid("283c4592-2e78-4f8c-80a5-552001ca7f67") },
                    { new Guid("8564cf9b-7654-4511-bab9-fe1838085284"), new Guid("531382eb-3001-4115-875d-c4baabd6a4e9") },
                    { new Guid("8bde4750-205d-4cec-8819-f84bb9531e4c"), new Guid("98d870de-72e7-4452-868a-58fc6a9a7e99") },
                    { new Guid("8bde4750-205d-4cec-8819-f84bb9531e4c"), new Guid("e1f959a2-35f4-4390-a512-4da2f4b2c75d") },
                    { new Guid("a0e8427b-18b4-4417-a87f-e2b096bf0f2a"), new Guid("54ebefce-997f-4bd2-a038-b72b08139535") },
                    { new Guid("a0e8427b-18b4-4417-a87f-e2b096bf0f2a"), new Guid("e1f959a2-35f4-4390-a512-4da2f4b2c75d") },
                    { new Guid("a0e8427b-18b4-4417-a87f-e2b096bf0f2a"), new Guid("fb9971fc-2ee5-4b15-a649-c91babedc015") }
                });

            migrationBuilder.InsertData(
                table: "MerchantCategories",
                columns: new[] { "Id", "MerchantCategoryGroupId", "Name" },
                values: new object[,]
                {
                    { new Guid("170287d4-69c0-4098-9598-3590a9547cb9"), new Guid("531382eb-3001-4115-875d-c4baabd6a4e9"), "Cinema" },
                    { new Guid("2278a2e2-a428-4ef5-96dd-e55acad78f92"), new Guid("531382eb-3001-4115-875d-c4baabd6a4e9"), "Museum" },
                    { new Guid("352cb2fa-6082-4ca0-ab98-01b3f0ecb50e"), new Guid("fb9971fc-2ee5-4b15-a649-c91babedc015"), "Plane tickets" },
                    { new Guid("5003f547-9e78-42be-aa1f-6f64f419ae19"), new Guid("283c4592-2e78-4f8c-80a5-552001ca7f67"), "Books" },
                    { new Guid("7b5a96d2-e1e2-43a1-9420-392d95fd4317"), new Guid("283c4592-2e78-4f8c-80a5-552001ca7f67"), "Conferences" },
                    { new Guid("7c3c939f-f36d-463a-851a-ddf42a962003"), new Guid("fb9971fc-2ee5-4b15-a649-c91babedc015"), "Train or bus tickets" },
                    { new Guid("8a91b83c-4c90-47c8-9101-948c3e0e0628"), new Guid("fb9971fc-2ee5-4b15-a649-c91babedc015"), "Fuel" },
                    { new Guid("8cd783b3-373a-4443-93b1-678ffd1535b4"), new Guid("283c4592-2e78-4f8c-80a5-552001ca7f67"), "Courses" },
                    { new Guid("8e3409a9-ad39-4143-b548-5dee24ddb557"), new Guid("98d870de-72e7-4452-868a-58fc6a9a7e99"), "Fitness" },
                    { new Guid("9064c00b-ac90-4933-bda7-d843f52e93d7"), new Guid("98d870de-72e7-4452-868a-58fc6a9a7e99"), "Sauna" },
                    { new Guid("b59a99cb-6a93-4599-94e2-4f3db63895ec"), new Guid("531382eb-3001-4115-875d-c4baabd6a4e9"), "Theater" },
                    { new Guid("cd7bfdae-c0ad-411b-bec0-7c10263a034e"), new Guid("e1f959a2-35f4-4390-a512-4da2f4b2c75d"), "Coffee shops" },
                    { new Guid("d997a39c-3040-4f48-850d-3d1d598a6986"), new Guid("e1f959a2-35f4-4390-a512-4da2f4b2c75d"), "Restaurants" },
                    { new Guid("f19a92e2-0e82-40fa-9429-000de24aade4"), new Guid("fb9971fc-2ee5-4b15-a649-c91babedc015"), "Taxi" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Balance", "CompanyId", "SubscriptionPlanId", "UserName" },
                values: new object[,]
                {
                    { new Guid("ae8069c9-1ba5-498e-8359-88c05f364cdb"), 100.0, new Guid("8564cf9b-7654-4511-bab9-fe1838085284"), new Guid("a76d72da-d9f5-4ef2-98c4-d2e30c667e1e"), "PlatinumUser" },
                    { new Guid("bba28a59-4e2c-4d7d-8e12-0a47eba2a7b6"), 100.0, new Guid("8bde4750-205d-4cec-8819-f84bb9531e4c"), new Guid("5a472ce6-80c1-4526-91c5-d07d37c26b6f"), "StandardUser" },
                    { new Guid("e6455511-8025-4683-a089-cc4f60650b05"), 100.0, new Guid("8564cf9b-7654-4511-bab9-fe1838085284"), new Guid("4bf5967c-e20a-4fe4-be05-f199e14a20a2"), "PremiumUser" }
                });

            migrationBuilder.InsertData(
                table: "Merchants",
                columns: new[] { "Id", "DiscountPercentage", "Earnings", "MerchantCategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("04383055-4594-4d64-9245-1a0041b3d00d"), 0.0, 0.0, new Guid("8cd783b3-373a-4443-93b1-678ffd1535b4"), "Merchant5" },
                    { new Guid("1a022bad-ce1c-487e-bea6-4ba94cce218f"), 12.5, 0.0, new Guid("d997a39c-3040-4f48-850d-3d1d598a6986"), "Merchant1" },
                    { new Guid("63fe072f-7520-416f-a89d-96378e510343"), 7.5, 0.0, new Guid("cd7bfdae-c0ad-411b-bec0-7c10263a034e"), "Merchant2" },
                    { new Guid("73a5352d-3502-43ec-9261-b8699226a3e4"), 0.0, 0.0, new Guid("5003f547-9e78-42be-aa1f-6f64f419ae19"), "Merchant6" },
                    { new Guid("75a06bf7-e9a2-40f6-a596-0b5dcd285e97"), 0.0, 0.0, new Guid("8e3409a9-ad39-4143-b548-5dee24ddb557"), "Merchant3" },
                    { new Guid("95e487fb-6539-44f1-a212-8089fae890af"), 0.0, 0.0, new Guid("9064c00b-ac90-4933-bda7-d843f52e93d7"), "Merchant4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("8564cf9b-7654-4511-bab9-fe1838085284"), new Guid("283c4592-2e78-4f8c-80a5-552001ca7f67") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("8564cf9b-7654-4511-bab9-fe1838085284"), new Guid("531382eb-3001-4115-875d-c4baabd6a4e9") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("8bde4750-205d-4cec-8819-f84bb9531e4c"), new Guid("98d870de-72e7-4452-868a-58fc6a9a7e99") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("8bde4750-205d-4cec-8819-f84bb9531e4c"), new Guid("e1f959a2-35f4-4390-a512-4da2f4b2c75d") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("a0e8427b-18b4-4417-a87f-e2b096bf0f2a"), new Guid("54ebefce-997f-4bd2-a038-b72b08139535") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("a0e8427b-18b4-4417-a87f-e2b096bf0f2a"), new Guid("e1f959a2-35f4-4390-a512-4da2f4b2c75d") });

            migrationBuilder.DeleteData(
                table: "CompanyBenefit",
                keyColumns: new[] { "CompaniesId", "MerchantCategoryGroupsId" },
                keyValues: new object[] { new Guid("a0e8427b-18b4-4417-a87f-e2b096bf0f2a"), new Guid("fb9971fc-2ee5-4b15-a649-c91babedc015") });

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("170287d4-69c0-4098-9598-3590a9547cb9"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("2278a2e2-a428-4ef5-96dd-e55acad78f92"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("352cb2fa-6082-4ca0-ab98-01b3f0ecb50e"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("7b5a96d2-e1e2-43a1-9420-392d95fd4317"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("7c3c939f-f36d-463a-851a-ddf42a962003"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("8a91b83c-4c90-47c8-9101-948c3e0e0628"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("b59a99cb-6a93-4599-94e2-4f3db63895ec"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("f19a92e2-0e82-40fa-9429-000de24aade4"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("04383055-4594-4d64-9245-1a0041b3d00d"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("1a022bad-ce1c-487e-bea6-4ba94cce218f"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("63fe072f-7520-416f-a89d-96378e510343"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("73a5352d-3502-43ec-9261-b8699226a3e4"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("75a06bf7-e9a2-40f6-a596-0b5dcd285e97"));

            migrationBuilder.DeleteData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: new Guid("95e487fb-6539-44f1-a212-8089fae890af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae8069c9-1ba5-498e-8359-88c05f364cdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bba28a59-4e2c-4d7d-8e12-0a47eba2a7b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6455511-8025-4683-a089-cc4f60650b05"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("8564cf9b-7654-4511-bab9-fe1838085284"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("8bde4750-205d-4cec-8819-f84bb9531e4c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("a0e8427b-18b4-4417-a87f-e2b096bf0f2a"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("5003f547-9e78-42be-aa1f-6f64f419ae19"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("8cd783b3-373a-4443-93b1-678ffd1535b4"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("8e3409a9-ad39-4143-b548-5dee24ddb557"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("9064c00b-ac90-4933-bda7-d843f52e93d7"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd7bfdae-c0ad-411b-bec0-7c10263a034e"));

            migrationBuilder.DeleteData(
                table: "MerchantCategories",
                keyColumn: "Id",
                keyValue: new Guid("d997a39c-3040-4f48-850d-3d1d598a6986"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("531382eb-3001-4115-875d-c4baabd6a4e9"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("54ebefce-997f-4bd2-a038-b72b08139535"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("fb9971fc-2ee5-4b15-a649-c91babedc015"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("4bf5967c-e20a-4fe4-be05-f199e14a20a2"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("5a472ce6-80c1-4526-91c5-d07d37c26b6f"));

            migrationBuilder.DeleteData(
                table: "SubscriptionPlans",
                keyColumn: "Id",
                keyValue: new Guid("a76d72da-d9f5-4ef2-98c4-d2e30c667e1e"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("283c4592-2e78-4f8c-80a5-552001ca7f67"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("98d870de-72e7-4452-868a-58fc6a9a7e99"));

            migrationBuilder.DeleteData(
                table: "MerchantCategoryGroups",
                keyColumn: "Id",
                keyValue: new Guid("e1f959a2-35f4-4390-a512-4da2f4b2c75d"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 23, 42, 0, 960, DateTimeKind.Local).AddTicks(4539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 25, 0, 13, 1, 926, DateTimeKind.Local).AddTicks(8377));

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
    }
}
