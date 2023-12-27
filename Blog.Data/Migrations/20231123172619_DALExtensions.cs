using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class DALExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0bf9480e-35a0-460b-ad3f-faacb3e2577c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("aec0bb1a-73d2-4c4e-a79b-10ff5d809d57"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "categoryId", "viewCount" },
                values: new object[,]
                {
                    { new Guid("104eb9f6-a7f6-4b6a-9f15-12662c6321f9"), "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 23, 20, 26, 19, 347, DateTimeKind.Local).AddTicks(6896), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 },
                    { new Guid("ecd5d45b-984f-41fa-84a4-aa6eed70b231"), "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 23, 20, 26, 19, 347, DateTimeKind.Local).AddTicks(6877), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 20, 26, 19, 347, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 20, 26, 19, 347, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cac76575-24c7-4038-af6d-fe07475023eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 20, 26, 19, 347, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 20, 26, 19, 347, DateTimeKind.Local).AddTicks(7168));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("104eb9f6-a7f6-4b6a-9f15-12662c6321f9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ecd5d45b-984f-41fa-84a4-aa6eed70b231"));

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
    }
}
