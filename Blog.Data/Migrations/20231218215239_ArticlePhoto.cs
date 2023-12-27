using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class ArticlePhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0ac228ee-eaba-4484-8f11-3dfb4aa146ff"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e666da99-bc47-48a1-9479-610fce592648"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "ArticlePhoto",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticlePhoto", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "UserId", "categoryId", "viewCount" },
                values: new object[,]
                {
                    { new Guid("bc37c4e2-bff6-476e-9d03-74dac8ef5aaa"), "safdsf", "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 12, 19, 0, 52, 38, 496, DateTimeKind.Local).AddTicks(1249), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"), new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 },
                    { new Guid("ddff1f76-da59-46f6-a75c-1802f63e5d10"), "safdsf", "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 12, 19, 0, 52, 38, 496, DateTimeKind.Local).AddTicks(1274), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"), new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a4fbce5-03d1-4a67-b6c6-bc7adafafe0e", "AQAAAAEAACcQAAAAECz0xX5+JhimfNqbBfxQ7213YB3+dvOu6+HDd/XCIa11MeBhh3bBGvirEj7MgTDmyg==", "e85590e5-ba9a-4940-8b79-568be34ee320" });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0c04e6-f726-4c5d-b707-7cdbab1819b8", "AQAAAAEAACcQAAAAEIbOMe1Pi0a86pSpkMSiiOWA/jwDIdBidCR8ZJLmRxikaHuuo4qyEZAhjoIQnNcACQ==", "9aaee013-3c2a-4d7d-ba0d-359af1542017" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5cd396b8-ad64-4104-b054-0e38a668775a"),
                column: "ConcurrencyStamp",
                value: "705a1856-b0eb-48a8-8e86-bf37254ae7f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ceafc65b-bd01-4233-8336-29924a3f37c9"),
                column: "ConcurrencyStamp",
                value: "c4bf9e52-0e88-4af3-9e72-84ecb9ea0901");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e17509a7-a029-429a-a933-59bdeec41bc4"),
                column: "ConcurrencyStamp",
                value: "a280608c-170f-4650-a72b-558158c8fae5");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"),
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "Turgut2", new DateTime(2023, 12, 19, 0, 52, 38, 496, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 0, 52, 38, 496, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cac76575-24c7-4038-af6d-fe07475023eb"),
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "Turgut2", new DateTime(2023, 12, 19, 0, 52, 38, 496, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 0, 52, 38, 496, DateTimeKind.Local).AddTicks(1646));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bc37c4e2-bff6-476e-9d03-74dac8ef5aaa"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ddff1f76-da59-46f6-a75c-1802f63e5d10"));

            migrationBuilder.DropColumn(
                name: "ArticlePhoto",
                table: "Articles");

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
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "UserId", "categoryId", "viewCount" },
                values: new object[,]
                {
                    { new Guid("0ac228ee-eaba-4484-8f11-3dfb4aa146ff"), "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 25, 23, 5, 50, 422, DateTimeKind.Local).AddTicks(559), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"), new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 },
                    { new Guid("e666da99-bc47-48a1-9479-610fce592648"), "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 25, 23, 5, 50, 422, DateTimeKind.Local).AddTicks(542), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"), new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d7e2d2e-7265-4efb-bf1f-6eaa8d9c9ea0", "AQAAAAEAACcQAAAAEFtwh5QZ9F8m7u3H5gCmMIzzQsJuvhj2XSRWNu8U/xkQ3KI9aZQFOI35OvFHegTm4g==", "49134633-cd12-4008-aae5-2a7cf0d56bbc" });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fac8a33d-db28-47ce-a900-db75abc69e8d", "AQAAAAEAACcQAAAAENZlQUVNCCD/FXcdTeek/oz0OLnQz/X7GIfNirnHzss/1fvU2QgXxbv6iRwqq+9yOg==", "b7d4190f-600c-4ef3-b4d9-63057e4bf8ae" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5cd396b8-ad64-4104-b054-0e38a668775a"),
                column: "ConcurrencyStamp",
                value: "415371de-3023-4e14-b754-7f8296c0c3c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ceafc65b-bd01-4233-8336-29924a3f37c9"),
                column: "ConcurrencyStamp",
                value: "71d2dc22-81fb-49ff-84ea-a1a64f5f9cc8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e17509a7-a029-429a-a933-59bdeec41bc4"),
                column: "ConcurrencyStamp",
                value: "6e9f5840-f38e-45ca-9f83-586e4214a725");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"),
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "Turgut1", new DateTime(2023, 11, 25, 23, 5, 50, 422, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 23, 5, 50, 422, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cac76575-24c7-4038-af6d-fe07475023eb"),
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "Turgut1", new DateTime(2023, 11, 25, 23, 5, 50, 422, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 23, 5, 50, 422, DateTimeKind.Local).AddTicks(1006));
        }
    }
}
