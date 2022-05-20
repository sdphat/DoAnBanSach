using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnBanSach.Server.Migrations
{
    public partial class Removepublisherredundantfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Publisher");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Publisher");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Publisher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Publisher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 14, 20, 14, 42, 151, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 12, 20, 14, 42, 151, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 8, 20, 14, 42, 151, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImportDateTime",
                value: new DateTime(2022, 3, 15, 20, 14, 42, 151, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImportDateTime",
                value: new DateTime(2021, 5, 7, 20, 14, 42, 151, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 15, 14, 14, 42, 151, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 14, 21, 14, 42, 151, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 14, 0, 14, 42, 151, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 12, 20, 14, 42, 151, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 8, 20, 14, 42, 151, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "ImportDateTime",
                value: new DateTime(2022, 3, 15, 20, 14, 42, 151, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                column: "ImportDateTime",
                value: new DateTime(2021, 5, 7, 20, 14, 42, 151, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 15, 14, 14, 42, 151, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 14, 21, 14, 42, 151, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 14, 0, 14, 42, 151, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 1,
                columns: new[] { "Address", "PhoneNumber" },
                values: new object[] { "20 Đ. Nam Kỳ Khởi Nghĩa, Phường 8, Quận 3, Thành phố Hồ Chí Minh", "02838469858" });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 2,
                columns: new[] { "Address", "PhoneNumber" },
                values: new object[] { "Số 55 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội", "1900571595" });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 3,
                columns: new[] { "Address", "PhoneNumber" },
                values: new object[] { "SỐ 65 NGUYỄN DU, QUẬN HAI BÀ TRƯNG, HÀ NỘI", "02438222135" });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: 4,
                columns: new[] { "Address", "PhoneNumber" },
                values: new object[] { "46 Trần Hưng Đạo Str., Hà Nội, Việt Nam", "38253841" });
        }
    }
}
