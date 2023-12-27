using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class son : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "UserId", "categoryId", "viewCount" },
                values: new object[,]
                {
                    { new Guid("16f6f729-a3b9-4060-8073-2bcc7bcdeaca"), "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 12, 19, 13, 58, 46, 886, DateTimeKind.Local).AddTicks(2867), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"), new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 },
                    { new Guid("7b4391d9-84b6-42e7-9fdd-fc7c4a05922b"), "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 12, 19, 13, 58, 46, 886, DateTimeKind.Local).AddTicks(2901), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"), new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f40cdb67-adef-4251-a5cb-c3a2817a02cb", "AQAAAAEAACcQAAAAENXD2f+I/gYBEpZscZzybiEdlVSk2jpa5IBFa2wYATpCroVT0Jn5J/K4vjSWLqRmyA==", "4dfcad0e-4f9d-486c-8852-b433f32e5d73" });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11648dfb-6e84-4d96-8657-6380d243703b", "AQAAAAEAACcQAAAAENi65f5JY7hmJ0V/lCRVH4HloqhTkC+q7FA961gH/AccrBiYP7VYjszMf6Mwf6JFnA==", "0a34f9d7-ecd3-4965-95f9-a82c5ffa4a18" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5cd396b8-ad64-4104-b054-0e38a668775a"),
                column: "ConcurrencyStamp",
                value: "14480de1-a932-4521-b2e2-ba75dcdd57a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ceafc65b-bd01-4233-8336-29924a3f37c9"),
                column: "ConcurrencyStamp",
                value: "19c771fb-ec71-47e5-84f8-54f69fac45ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e17509a7-a029-429a-a933-59bdeec41bc4"),
                column: "ConcurrencyStamp",
                value: "c235758b-0e78-40ba-b0dc-552e1a8723a6");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 13, 58, 46, 886, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 13, 58, 46, 886, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cac76575-24c7-4038-af6d-fe07475023eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 13, 58, 46, 886, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 13, 58, 46, 886, DateTimeKind.Local).AddTicks(3623));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("16f6f729-a3b9-4060-8073-2bcc7bcdeaca"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7b4391d9-84b6-42e7-9fdd-fc7c4a05922b"));

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
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 0, 52, 38, 496, DateTimeKind.Local).AddTicks(1523));

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
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 0, 52, 38, 496, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 0, 52, 38, 496, DateTimeKind.Local).AddTicks(1646));
        }
    }
}
