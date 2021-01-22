using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class remove_default_value : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72d8cc26-363d-4186-854c-f865db448b2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8054647c-4cd8-4075-8a32-cad7f1e3180a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce127fe0-58e3-4ea7-a754-f799181831de");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c5d52259-bdfa-4578-befc-fb5fc722f1df", "c5d52259-bdfa-4578-befc-fb5fc722f1df" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5d52259-bdfa-4578-befc-fb5fc722f1df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5d52259-bdfa-4578-befc-fb5fc722f1df");

            migrationBuilder.AlterColumn<bool>(
                name: "StickTop",
                table: "Blogs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "Blogs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18f0eb56-5cc8-4deb-b5df-f0af928f80ce", "218b388f-4159-4fa5-89b7-0c7345a7af5a", "LBlogRole", "root", "ROOT" },
                    { "54344d57-ab54-4890-a9a1-a4a35bffc99c", "0e58e42c-ba55-4105-bc0d-0cf1f4614613", "LBlogRole", "admin", "ADMIN" },
                    { "062d4907-0581-4593-b078-39c38c314975", "763c7e96-905e-4ddd-86f5-b79170c25fb6", "LBlogRole", "VIP", "VIP" },
                    { "40e8f8c7-50c3-4839-97be-7e5e4eea40f8", "0e40422a-7f18-4731-b1bc-5fb67489ef5c", "LBlogRole", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NickName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "18f0eb56-5cc8-4deb-b5df-f0af928f80ce", 0, true, "9ab7053c-2818-4dfc-9a31-c6548ed457bb", "admin@test.com", true, false, null, "louis", "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEIuYWFoJAgK3Zj+jjCOmAiMQlanHpnNo4mFkx70Mzp8jLIh9rseC72kNe57jp40RFQ==", null, false, "", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "18f0eb56-5cc8-4deb-b5df-f0af928f80ce", "18f0eb56-5cc8-4deb-b5df-f0af928f80ce" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "062d4907-0581-4593-b078-39c38c314975");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40e8f8c7-50c3-4839-97be-7e5e4eea40f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54344d57-ab54-4890-a9a1-a4a35bffc99c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "18f0eb56-5cc8-4deb-b5df-f0af928f80ce", "18f0eb56-5cc8-4deb-b5df-f0af928f80ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18f0eb56-5cc8-4deb-b5df-f0af928f80ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18f0eb56-5cc8-4deb-b5df-f0af928f80ce");

            migrationBuilder.AlterColumn<bool>(
                name: "StickTop",
                table: "Blogs",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "Blogs",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c5d52259-bdfa-4578-befc-fb5fc722f1df", "10349c13-b2aa-4656-8769-c790951a537b", "LBlogRole", "root", "ROOT" },
                    { "ce127fe0-58e3-4ea7-a754-f799181831de", "345758a7-8616-4cae-aa35-8d834121c4a4", "LBlogRole", "admin", "ADMIN" },
                    { "72d8cc26-363d-4186-854c-f865db448b2a", "6c976fd5-e9ed-43bb-be83-64c73d345a64", "LBlogRole", "VIP", "VIP" },
                    { "8054647c-4cd8-4075-8a32-cad7f1e3180a", "19c3fae2-c3df-4a44-ac05-56e7cd2b5f3b", "LBlogRole", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NickName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c5d52259-bdfa-4578-befc-fb5fc722f1df", 0, true, "6d932560-6dad-4330-925e-5f1ca1ecbd22", "admin@test.com", true, false, null, "louis", "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEIL+MmzXeftFMhSpumQ203vo1ps44jbKoh8PeMOdiXgL8uK5POLOVJvF++I0nJdDqA==", null, false, "", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c5d52259-bdfa-4578-befc-fb5fc722f1df", "c5d52259-bdfa-4578-befc-fb5fc722f1df" });
        }
    }
}
