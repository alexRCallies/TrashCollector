using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionApp.Migrations
{
    public partial class CheckBoxForPickUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c588a41-d1de-44b3-aedb-53a66c6e9c8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cd3b825-5ac6-425a-86cf-f894d3aa5856");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74e3b670-ff2f-4be1-b849-26a9bbd34d6c");

            migrationBuilder.AddColumn<bool>(
                name: "IsPickedUp",
                table: "customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca4aceea-a345-4cbc-8d9f-22ca8963e85a", "ab3678c3-fa91-4489-b390-7495c428ef8c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d75311ab-8fff-4668-91c9-927c3cb8d481", "b952fd99-fc66-4637-98af-8a89aee041a2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f7e161a-31f3-4049-b0e2-9cf0ab9a2a10", "4a40877d-6b16-43d3-a0d5-937e22a7f482", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f7e161a-31f3-4049-b0e2-9cf0ab9a2a10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca4aceea-a345-4cbc-8d9f-22ca8963e85a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d75311ab-8fff-4668-91c9-927c3cb8d481");

            migrationBuilder.DropColumn(
                name: "IsPickedUp",
                table: "customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74e3b670-ff2f-4be1-b849-26a9bbd34d6c", "bf8b94ba-5835-4eb0-b484-e86dcfb98dec", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cd3b825-5ac6-425a-86cf-f894d3aa5856", "0abad20a-0c66-4169-9d10-865530cc6bfa", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c588a41-d1de-44b3-aedb-53a66c6e9c8b", "97cc30fb-41da-4eac-9633-28ddcb80f58b", "Employee", "EMPLOYEE" });
        }
    }
}
