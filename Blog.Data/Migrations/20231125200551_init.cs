using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7f75dc5f-ab43-4045-9be8-6ffbc39bd694"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("97293180-6dcc-48ef-9da6-abb7b5687f61"));

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
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 23, 5, 50, 422, DateTimeKind.Local).AddTicks(874));

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
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 23, 5, 50, 422, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 23, 5, 50, 422, DateTimeKind.Local).AddTicks(1006));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0ac228ee-eaba-4484-8f11-3dfb4aa146ff"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e666da99-bc47-48a1-9479-610fce592648"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "UserId", "categoryId", "viewCount" },
                values: new object[,]
                {
                    { new Guid("7f75dc5f-ab43-4045-9be8-6ffbc39bd694"), "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 25, 23, 3, 58, 606, DateTimeKind.Local).AddTicks(6735), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"), new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 },
                    { new Guid("97293180-6dcc-48ef-9da6-abb7b5687f61"), "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 25, 23, 3, 58, 606, DateTimeKind.Local).AddTicks(6752), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"), new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "068f53dc-0383-4168-95c0-70754442ee86", "AQAAAAEAACcQAAAAECdAoYkPQJTeOvzMfLiuDOsj1an5F+CL/wGMp1JzLpKdErYtHlA3bb/VywDVVhloPA==", "6ee0beab-4ab8-4c0c-b8b6-3f03bc3ae0ae" });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ece029-0b35-47bc-9ddd-6a704ad17ed8", "AQAAAAEAACcQAAAAEE4iom2EyqXBNpSoZk7Yj2nxBF9IyjpgI0U3QyhxdrzYtiOD5EOGjwKGEJcmSkUImg==", "1441ba75-bfd5-424f-bda1-958c779a41fd" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5cd396b8-ad64-4104-b054-0e38a668775a"),
                column: "ConcurrencyStamp",
                value: "7713de4c-9ecc-401b-af09-82d2a1c243c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ceafc65b-bd01-4233-8336-29924a3f37c9"),
                column: "ConcurrencyStamp",
                value: "6d9676e0-b909-4f9a-b860-fdb5a33cd326");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e17509a7-a029-429a-a933-59bdeec41bc4"),
                column: "ConcurrencyStamp",
                value: "4f1f6dad-688b-42cc-9cf3-64907a5eb15f");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 23, 3, 58, 606, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 23, 3, 58, 606, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cac76575-24c7-4038-af6d-fe07475023eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 23, 3, 58, 606, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 23, 3, 58, 606, DateTimeKind.Local).AddTicks(7080));
        }
    }
}
