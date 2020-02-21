using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionApp.Data.Migrations
{
    public partial class ReDoIt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04b86354-42bb-4b97-9e38-4a76f131d5b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2c58362-bf57-4985-8425-9723471fd946");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7656c12-b3d8-4ae6-a1ce-16168550e661");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5f7a51e-9af8-4696-b457-1994852a2ece", "8f99dc39-c7ac-4bbb-9b46-51922b44d094", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba2cde65-129f-40e6-a569-3b072469af65", "8eb3bc81-a021-4afc-85b9-0c4f1dcab3b5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2de4043e-8e2b-4954-963b-db6129b01699", "90c15b4e-53d2-490c-9b15-147b9a06b312", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2de4043e-8e2b-4954-963b-db6129b01699");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba2cde65-129f-40e6-a569-3b072469af65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5f7a51e-9af8-4696-b457-1994852a2ece");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7656c12-b3d8-4ae6-a1ce-16168550e661", "4bbecd42-91e9-4e8c-bcf3-c3f63130bec0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2c58362-bf57-4985-8425-9723471fd946", "62adc3ca-2c6d-4c25-92a8-c8ef50c3aa2b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04b86354-42bb-4b97-9e38-4a76f131d5b8", "a6370389-e11e-46b9-9547-376a8cd299f1", "Employee", "EMPLOYEE" });
        }
    }
}
