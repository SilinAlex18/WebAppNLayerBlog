using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppNLayerBlog.DataAccessLayer.Migrations
{
    public partial class MyBlogSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "773a524b-99af-4fe3-b950-0f7d8ff82b0e", 0, "da27a8eb-0958-4eec-b69e-ec65f3e690f7", "tester@test.com", true, false, null, "TESTER@TEST.COM", "TESTER", "AQAAAAEAACcQAAAAEBDHr5+AgJ5BIn0fcvWqrjV99HxcOMNPMqARrlxNKHc89cOh/ivS5uCGm+HSZHaRjA==", "123456789", false, "525701ac-da0f-4c85-8b4e-1ba4dd982656", false, "tester" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Travel" }
                });

            migrationBuilder.InsertData(
                table: "TypeMedias",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "video" },
                    { 2, "audio" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "DateTime", "Description", "Subtitle", "Title" },
                values: new object[] { 1, 1, new DateTime(2020, 7, 17, 15, 20, 46, 905, DateTimeKind.Local).AddTicks(9364), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", "Aenean massa", "Lorem ipsum dolor sit amet" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "DateTime", "Description", "Subtitle", "Title" },
                values: new object[] { 2, 2, new DateTime(2020, 7, 17, 15, 20, 46, 909, DateTimeKind.Local).AddTicks(5149), "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Donec quam felis", "Cum sociis natoque penatibus et magnis dis parturient montes" });

            migrationBuilder.InsertData(
                table: "Bookmarks",
                columns: new[] { "Id", "PostId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "773a524b-99af-4fe3-b950-0f7d8ff82b0e" },
                    { 2, 2, "773a524b-99af-4fe3-b950-0f7d8ff82b0e" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "DateTime", "PostId", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 17, 15, 20, 46, 934, DateTimeKind.Local).AddTicks(1692), 1, "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "773a524b-99af-4fe3-b950-0f7d8ff82b0e" },
                    { 2, new DateTime(2020, 7, 17, 15, 20, 46, 934, DateTimeKind.Local).AddTicks(2408), 2, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", "773a524b-99af-4fe3-b950-0f7d8ff82b0e" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Name", "Path", "PostId", "TypeMediaId", "Url" },
                values: new object[,]
                {
                    { 1, "youtube", null, 1, 1, "https://www.youtube.com/watch?v=BggrpKfqh1c" },
                    { 2, "freesound", null, 2, 2, "https://freesound.org/people/Lorem%20Ipsum/downloaded_sounds/" }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Name", "PostId", "Url" },
                values: new object[,]
                {
                    { 1, "blindtextgenerator", 1, "https://www.blindtextgenerator.com/ru" },
                    { 2, "loremipsum", 2, "https://loremipsum.io/ru/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookmarks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookmarks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "773a524b-99af-4fe3-b950-0f7d8ff82b0e");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypeMedias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypeMedias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
