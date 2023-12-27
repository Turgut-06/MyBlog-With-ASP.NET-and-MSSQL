using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8989b1f6-ce34-4b85-882a-22b8ba8b5599"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8c095a56-6708-46a4-9535-279c39e72cda"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "categoryId", "viewCount" },
                values: new object[,]
                {
                    { new Guid("0bf9480e-35a0-460b-ad3f-faacb3e2577c"), "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 22, 0, 5, 43, 205, DateTimeKind.Local).AddTicks(3664), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 },
                    { new Guid("aec0bb1a-73d2-4c4e-a79b-10ff5d809d57"), "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 22, 0, 5, 43, 205, DateTimeKind.Local).AddTicks(3634), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 22, 0, 5, 43, 205, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 22, 0, 5, 43, 205, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cac76575-24c7-4038-af6d-fe07475023eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 22, 0, 5, 43, 205, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 22, 0, 5, 43, 205, DateTimeKind.Local).AddTicks(4487));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0bf9480e-35a0-460b-ad3f-faacb3e2577c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("aec0bb1a-73d2-4c4e-a79b-10ff5d809d57"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "categoryId", "viewCount" },
                values: new object[,]
                {
                    { new Guid("8989b1f6-ce34-4b85-882a-22b8ba8b5599"), "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(980), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 },
                    { new Guid("8c095a56-6708-46a4-9535-279c39e72cda"), "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(958), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cac76575-24c7-4038-af6d-fe07475023eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 23, 57, 43, 657, DateTimeKind.Local).AddTicks(1462));
        }
    }
}
