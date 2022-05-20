using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnBanSach.Server.Migrations
{
    public partial class Addroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "846b0671-887f-4314-a2b2-a9e774619fa4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2759786-d811-49f3-8768-a1e6e1ae9645");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cus", "c4f5570c-b845-4718-9ace-fd56a0dc32b3", "Khách hàng", "USER" },
                    { "emp", "53cbaaf0-1972-4c3e-8103-4aed82315bb2", "Nhân viên", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "admin", 0, "ed6940ec-94da-40ac-8eae-d2fa3bc003a4", "admin@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEDSmY2a5vlu1O0WGPrZiuE3il7YYuRHikWshN0SEYFTDsv6tdbC1DCJvJUsV4aJqkg==", null, false, "7c6b04db-5af6-482e-93ed-09c985f48602", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 18, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 16, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 12, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImportDateTime",
                value: new DateTime(2022, 3, 19, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImportDateTime",
                value: new DateTime(2021, 5, 11, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 19, 7, 9, 25, 898, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 18, 14, 9, 25, 898, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 17, 17, 9, 25, 898, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 16, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 12, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "ImportDateTime",
                value: new DateTime(2022, 3, 19, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                column: "ImportDateTime",
                value: new DateTime(2021, 5, 11, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 19, 7, 9, 25, 898, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 18, 14, 9, 25, 898, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 17, 17, 9, 25, 898, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "emp", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cus");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "emp", "admin" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "emp");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "846b0671-887f-4314-a2b2-a9e774619fa4", "a4dc3b17-fb0c-4aa4-a42e-02e950eb525d", "Nhân viên", "EMPLOYEE" },
                    { "f2759786-d811-49f3-8768-a1e6e1ae9645", "051a6706-645b-48a3-bc73-fe477b04b85c", "Khách hàng", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 18, 9, 33, 48, 50, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 16, 9, 33, 48, 50, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 12, 9, 33, 48, 50, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImportDateTime",
                value: new DateTime(2022, 3, 19, 9, 33, 48, 50, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImportDateTime",
                value: new DateTime(2021, 5, 11, 9, 33, 48, 50, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 19, 3, 33, 48, 50, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 18, 10, 33, 48, 50, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 17, 13, 33, 48, 50, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 16, 9, 33, 48, 50, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 12, 9, 33, 48, 50, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "ImportDateTime",
                value: new DateTime(2022, 3, 19, 9, 33, 48, 50, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                column: "ImportDateTime",
                value: new DateTime(2021, 5, 11, 9, 33, 48, 50, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 19, 3, 33, 48, 50, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 18, 10, 33, 48, 50, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 17, 13, 33, 48, 50, DateTimeKind.Local).AddTicks(1034));
        }
    }
}
