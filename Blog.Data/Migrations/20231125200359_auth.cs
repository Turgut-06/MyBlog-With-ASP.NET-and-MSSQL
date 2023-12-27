using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class auth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("31d6ed57-2a2a-471c-b80b-a182d32a6a9f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b962a3bb-d1cc-4513-b596-e39c3031a987"));

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "AspNeAppUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                columns: new[] { "ConcurrencyStamp", "ImageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "068f53dc-0383-4168-95c0-70754442ee86", new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), "AQAAAAEAACcQAAAAECdAoYkPQJTeOvzMfLiuDOsj1an5F+CL/wGMp1JzLpKdErYtHlA3bb/VywDVVhloPA==", "6ee0beab-4ab8-4c0c-b8b6-3f03bc3ae0ae" });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"),
                columns: new[] { "ConcurrencyStamp", "ImageId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ece029-0b35-47bc-9ddd-6a704ad17ed8", new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), "AQAAAAEAACcQAAAAEE4iom2EyqXBNpSoZk7Yj2nxBF9IyjpgI0U3QyhxdrzYtiOD5EOGjwKGEJcmSkUImg==", "1441ba75-bfd5-424f-bda1-958c779a41fd" });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNeAppUsers_ImageId",
                table: "AspNeAppUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNeAppUsers_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "AspNeAppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNeAppUsers_Images_ImageId",
                table: "AspNeAppUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNeAppUsers_UserId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNeAppUsers_Images_ImageId",
                table: "AspNeAppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNeAppUsers_ImageId",
                table: "AspNeAppUsers");

            migrationBuilder.DropIndex(
                name: "IX_Articles_UserId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7f75dc5f-ab43-4045-9be8-6ffbc39bd694"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("97293180-6dcc-48ef-9da6-abb7b5687f61"));

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "AspNeAppUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Articles");

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "categoryId", "viewCount" },
                values: new object[,]
                {
                    { new Guid("31d6ed57-2a2a-471c-b80b-a182d32a6a9f"), "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 25, 20, 44, 45, 864, DateTimeKind.Local).AddTicks(5986), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 },
                    { new Guid("b962a3bb-d1cc-4513-b596-e39c3031a987"), "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 25, 20, 44, 45, 864, DateTimeKind.Local).AddTicks(5959), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1207cc8f-0961-4ef7-be13-745611c2a448", "AQAAAAEAACcQAAAAEGL3+O566arY87HdTiKrS1nBGXYG9KuOtcCxwAXHsfMUOETBEOkon08nwgbzrkbbWw==", "8728c57b-7c4b-4a91-b78a-dfcc885f4e2a" });

            migrationBuilder.UpdateData(
                table: "AspNeAppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "306c1e96-e90c-42d0-abd6-a38987e54334", "AQAAAAEAACcQAAAAEC3wCy++SP+truEIFREHlqTE2nUHBS/t7+HK836ybxxhSjGLKQA3EqXCilHFB3gBAw==", "77c4f290-f9d4-4e41-b61f-f0693d010ab0" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5cd396b8-ad64-4104-b054-0e38a668775a"),
                column: "ConcurrencyStamp",
                value: "e9a93e91-7abe-4561-ac3e-5d108851362c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ceafc65b-bd01-4233-8336-29924a3f37c9"),
                column: "ConcurrencyStamp",
                value: "ea67dc59-b921-4653-8987-4609da6bdacd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e17509a7-a029-429a-a933-59bdeec41bc4"),
                column: "ConcurrencyStamp",
                value: "d838ce9f-455e-48fd-bf82-df4e9e288efb");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 20, 44, 45, 864, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 20, 44, 45, 864, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cac76575-24c7-4038-af6d-fe07475023eb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 20, 44, 45, 864, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e2115c08-6adb-4650-bf91-0371f285d695"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 25, 20, 44, 45, 864, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_ImageId",
                table: "Articles",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
