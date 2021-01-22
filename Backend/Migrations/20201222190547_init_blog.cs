using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class init_blog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12af32b0-edcd-4423-8078-ef408269312d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "704e2977-4f83-4060-aac4-9be049af7c3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "906c8128-29c2-4216-9191-74fb7368c9e8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8af2925-2020-42e2-8a01-467fa7c1285e", "b8af2925-2020-42e2-8a01-467fa7c1285e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8af2925-2020-42e2-8a01-467fa7c1285e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8af2925-2020-42e2-8a01-467fa7c1285e");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    TagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TagDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => x.TagID);
                });

            migrationBuilder.CreateTable(
                name: "BlogTypes",
                columns: table => new
                {
                    BlogTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTypes", x => x.BlogTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BlogTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogContent = table.Column<string>(type: "text", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    TypeBlogTypeID = table.Column<int>(type: "int", nullable: true),
                    StickTop = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                    table.ForeignKey(
                        name: "FK_Blogs_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_BlogTypes_TypeBlogTypeID",
                        column: x => x.TypeBlogTypeID,
                        principalTable: "BlogTypes",
                        principalColumn: "BlogTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogBlogTag",
                columns: table => new
                {
                    BlogsBlogID = table.Column<int>(type: "int", nullable: false),
                    TagsTagID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogBlogTag", x => new { x.BlogsBlogID, x.TagsTagID });
                    table.ForeignKey(
                        name: "FK_BlogBlogTag_Blogs_BlogsBlogID",
                        column: x => x.BlogsBlogID,
                        principalTable: "Blogs",
                        principalColumn: "BlogID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogBlogTag_BlogTags_TagsTagID",
                        column: x => x.TagsTagID,
                        principalTable: "BlogTags",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BlogBlogTag_TagsTagID",
                table: "BlogBlogTag",
                column: "TagsTagID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorId",
                table: "Blogs",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_TypeBlogTypeID",
                table: "Blogs",
                column: "TypeBlogTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogBlogTag");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.DropTable(
                name: "BlogTypes");

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

            migrationBuilder.DropColumn(
                name: "Active",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b8af2925-2020-42e2-8a01-467fa7c1285e", "d9202550-553e-48f3-8f6f-198897a5f61b", "LBlogRole", "root", "ROOT" },
                    { "906c8128-29c2-4216-9191-74fb7368c9e8", "7c3ce3a7-7edc-4fa0-9419-22dc228ec14a", "LBlogRole", "admin", "ADMIN" },
                    { "704e2977-4f83-4060-aac4-9be049af7c3d", "acfbc58d-85fb-465d-a020-156f65ed95fb", "LBlogRole", "VIP", "VIP" },
                    { "12af32b0-edcd-4423-8078-ef408269312d", "1ab46bf3-43a0-40d0-90c0-bdd819d400bc", "LBlogRole", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NickName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b8af2925-2020-42e2-8a01-467fa7c1285e", 0, "76e5a147-5661-47b8-9b51-bd39fa98b953", "admin@x.com", true, "Admin", "Admin", false, null, "louis", "ADMIN@X.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEPUBLDatt3bS18fu1e4DMw1fuHdwQvesgrdsD+hiMF0JvLldvxTZlJoq8nISQ8Z1mA==", null, false, "", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b8af2925-2020-42e2-8a01-467fa7c1285e", "b8af2925-2020-42e2-8a01-467fa7c1285e" });
        }
    }
}
