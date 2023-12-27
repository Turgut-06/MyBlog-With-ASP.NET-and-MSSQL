using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class userCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("104eb9f6-a7f6-4b6a-9f15-12662c6321f9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ecd5d45b-984f-41fa-84a4-aa6eed70b231"));

            migrationBuilder.CreateTable(
                name: "AspNeAppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNeAppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNeAppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNeAppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNeAppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNeAppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNeAppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNeAppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNeAppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNeAppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModidifiedBy", "ModifiedDate", "Title", "categoryId", "viewCount" },
                values: new object[,]
                {
                    { new Guid("31d6ed57-2a2a-471c-b80b-a182d32a6a9f"), "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 25, 20, 44, 45, 864, DateTimeKind.Local).AddTicks(5986), null, null, new Guid("cac76575-24c7-4038-af6d-fe07475023eb"), false, null, null, "Asp.net makalesi 2", new Guid("79f69f6c-ab9f-4ce9-93cf-d6d4d8865ef6"), 15 },
                    { new Guid("b962a3bb-d1cc-4513-b596-e39c3031a987"), "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds", "Turgut1", new DateTime(2023, 11, 25, 20, 44, 45, 864, DateTimeKind.Local).AddTicks(5959), null, null, new Guid("e2115c08-6adb-4650-bf91-0371f285d695"), false, null, null, "Asp.net makalesi 1", new Guid("fdca4000-618b-4071-8309-93d79f1ebd9a"), 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNeAppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af"), 0, "1207cc8f-0961-4ef7-be13-745611c2a448", "admin@gmail.com", true, "Admin", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGL3+O566arY87HdTiKrS1nBGXYG9KuOtcCxwAXHsfMUOETBEOkon08nwgbzrkbbWw==", "+05349999988", true, "8728c57b-7c4b-4a91-b78a-dfcc885f4e2a", false, "admin@gmail.com" },
                    { new Guid("fb4aef20-2643-442d-8840-a32e17477cb1"), 0, "306c1e96-e90c-42d0-abd6-a38987e54334", "superadmin@gmail.com", true, "turgut", "köksal", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEC3wCy++SP+truEIFREHlqTE2nUHBS/t7+HK836ybxxhSjGLKQA3EqXCilHFB3gBAw==", "+05349999999", true, "77c4f290-f9d4-4e41-b61f-f0693d010ab0", false, "superadmin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5cd396b8-ad64-4104-b054-0e38a668775a"), "e9a93e91-7abe-4561-ac3e-5d108851362c", "Admin", "ADMIN" },
                    { new Guid("ceafc65b-bd01-4233-8336-29924a3f37c9"), "ea67dc59-b921-4653-8987-4609da6bdacd", "User", "USER" },
                    { new Guid("e17509a7-a029-429a-a933-59bdeec41bc4"), "d838ce9f-455e-48fd-bf82-df4e9e288efb", "Superadmin", "SUPERADMIN" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("5cd396b8-ad64-4104-b054-0e38a668775a"), new Guid("c76a84d9-93a1-44b1-9a2c-c7db4c55d9af") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e17509a7-a029-429a-a933-59bdeec41bc4"), new Guid("fb4aef20-2643-442d-8840-a32e17477cb1") });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNeAppUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNeAppUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNeAppUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("31d6ed57-2a2a-471c-b80b-a182d32a6a9f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b962a3bb-d1cc-4513-b596-e39c3031a987"));

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
    }
}
