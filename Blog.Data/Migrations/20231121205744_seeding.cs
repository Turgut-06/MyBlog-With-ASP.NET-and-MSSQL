using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), "Turgut1", new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(1288), null, null, false, null, null, "Visual Studio" },
                    { new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), "Turgut1", new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(1280), null, null, false, null, null, "ASP.NET Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModidifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), "Turgut1", new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(1466), null, null, "images/testImages2", "png", false, null, null },
                    { new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), "Turgut1", new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(1462), null, null, "images/testImages", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "categoryId", "viewCount" },
                values: new object[] { new Guid("8989b1f6-ce34-4b85-882a-22b8ba8b5599"), "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(980), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "categoryId", "viewCount" },
                values: new object[] { new Guid("8c095a56-6708-46a4-9535-279c39e72cda"), "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(958), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8989b1f6-ce34-4b85-882a-22b8ba8b5599"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8c095a56-6708-46a4-9535-279c39e72cda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cac76575-24c7-4038-af6d-fe07475023eb"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
