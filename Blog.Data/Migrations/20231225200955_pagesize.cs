using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class pagesize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("16f6f729-a3b9-4060-8073-2bcc7bcdeaca"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7b4391d9-84b6-42e7-9fdd-fc7c4a05922b"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "UserId", "categoryId", "viewCount" },
                values: new object[,]
                {
                    { new Guid("4f01cc3b-7bff-4a4c-ba5d-731d4713b143"), "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 12, 25, 23, 9, 54, 668, DateTimeKind.Local).AddTicks(252), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"), new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 },
                    { new Guid("fe2a8d76-8a5f-4a4b-aab2-c374940ef16d"), "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 12, 25, 23, 9, 54, 668, DateTimeKind.Local).AddTicks(228), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"), new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9920b8d-4e74-4686-8417-dd3bfb0178bb", "AQAAAAEAACcQAAAAENCHx9xsu+cRo+b3NmZm+04IfSSgFAoMuYt6aGbtXrVQX4qDkaarA+aNpCHYw0UiTw==", "14e6d851-fdc9-4ef7-8b90-655e7e98897a" });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cbcc5b4-0228-4c42-86db-ba51f2f71583", "AQAAAAEAACcQAAAAEGrc7hY0kIa1Bg+mqdr0NN12QvdIfRjmIrx3Heex8LVmsTXnTPtKk2lbQRPD6mO5BQ==", "4d0ba991-9ced-4900-adc9-5f1fe921bc12" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5cd396b8-ad64-4104-b054-0e38a668775a"),
                column: "ConcurrencyStamp",
                value: "a14d9f58-aabb-4970-b2fa-bb2cadbc2b10");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ceafc65b-bd01-4233-8336-29924a3f37c9"),
                column: "ConcurrencyStamp",
                value: "09c304e6-b228-45bb-8af2-097f9c53df69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e17509a7-a029-429a-a933-59bdeec41bc4"),
                column: "ConcurrencyStamp",
                value: "eebb7565-c16f-42d5-a44f-98045c705ffc");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 23, 9, 54, 668, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 23, 9, 54, 668, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cac76575-24c7-4038-af6d-fe07475023eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 23, 9, 54, 668, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 23, 9, 54, 668, DateTimeKind.Local).AddTicks(789));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4f01cc3b-7bff-4a4c-ba5d-731d4713b143"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fe2a8d76-8a5f-4a4b-aab2-c374940ef16d"));

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
    }
}
