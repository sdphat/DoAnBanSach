using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnBanSach.Server.Migrations
{
    public partial class Removeredundantfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "846b0671-887f-4314-a2b2-a9e774619fa4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2759786-d811-49f3-8768-a1e6e1ae9645");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 17, 13, 31, 45, 644, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 15, 13, 31, 45, 644, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 11, 13, 31, 45, 644, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImportDateTime",
                value: new DateTime(2022, 3, 18, 13, 31, 45, 644, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImportDateTime",
                value: new DateTime(2021, 5, 10, 13, 31, 45, 644, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 18, 7, 31, 45, 644, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 17, 14, 31, 45, 644, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 16, 17, 31, 45, 644, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 15, 13, 31, 45, 644, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 11, 13, 31, 45, 644, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "ImportDateTime",
                value: new DateTime(2022, 3, 18, 13, 31, 45, 644, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                column: "ImportDateTime",
                value: new DateTime(2021, 5, 10, 13, 31, 45, 644, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 18, 7, 31, 45, 644, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 17, 14, 31, 45, 644, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 16, 17, 31, 45, 644, DateTimeKind.Local).AddTicks(8409));
        }
    }
}
