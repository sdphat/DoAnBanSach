using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnBanSach.Server.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cus",
                column: "ConcurrencyStamp",
                value: "a5c40b2a-470a-4172-a9e3-5ad52e064a26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "emp",
                column: "ConcurrencyStamp",
                value: "abe57043-6cc6-459a-805f-9b624b5eab3c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6ee7f59-3294-4af7-918d-1cc6b1e92ed9", "AQAAAAEAACcQAAAAEEGzIzwHOk6jugCQ6JrLot1GJZwPCkONMRCamYHYEZsm8GYx+z3ECJLUgdj4T953hQ==", "e792fb52-50d6-4eb3-9f73-26684d374957" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 3, "José Mauro de Vasconcelos" },
                    { 4, "Khotudien" },
                    { 5, "Nhiều tác giả" },
                    { 6, "Andrea Hirata" },
                    { 7, "Nguyễn Nhật Ánh" },
                    { 8, "Khaled Hosseini " },
                    { 9, "Johanna Spyri, Elena Selivano " },
                    { 10, "Shinkai Makoto " }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImportDateTime",
                value: new DateTime(2022, 5, 19, 8, 24, 25, 535, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "ImportDateTime", "Title" },
                values: new object[] { new DateTime(2022, 5, 13, 8, 24, 25, 535, DateTimeKind.Local).AddTicks(9804), "Những người khốn khổ" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageURL", "ImportDateTime", "Title" },
                values: new object[] { 2, "/image_195509_1_75552.jpg", new DateTime(2021, 5, 12, 8, 24, 25, 535, DateTimeKind.Local).AddTicks(9810), "Không Gia Đình" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { "/image_195509_1_00008.jpg", new DateTime(2022, 5, 18, 12, 24, 25, 535, DateTimeKind.Local).AddTicks(9815), 147000m, 1, "Hai Số Phận" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "Title" },
                values: new object[] { 3, "/image_195509_1_21748.jpg", new DateTime(2022, 5, 17, 8, 24, 25, 535, DateTimeKind.Local).AddTicks(9802), 91000m, "Cây Cam Ngọt Của Tôi" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 4, "/image_195509_1_00004.jpg", new DateTime(2022, 3, 20, 8, 24, 25, 535, DateTimeKind.Local).AddTicks(9806), 45000m, 2, "Từ Điển Tiếng Em" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 5, "/image_195509_1_00006.jpg", new DateTime(2022, 5, 20, 2, 24, 25, 535, DateTimeKind.Local).AddTicks(9811), 65000m, 2, "Chuyện Kể Rằng Có Nàng Và Tôi" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "AuthorId", "CategoryId", "ImageURL", "ImportDateTime", "PublisherId", "Title" },
                values: new object[] { 6, 2, "/image_195509_1_36366.jpg", new DateTime(2022, 5, 19, 9, 24, 25, 535, DateTimeKind.Local).AddTicks(9813), 3, "Chiến binh cầu vồng" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "PublisherId", "Title" },
                values: new object[] { 8, "/image_195509_1_18176.jpg", new DateTime(2022, 5, 17, 8, 24, 25, 535, DateTimeKind.Local).AddTicks(9816), 1, "Ngàn mặt trời rực rỡ (Tái bản 2019)" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 7, "/image_195509_1_00010.jpg", new DateTime(2022, 5, 13, 8, 24, 25, 535, DateTimeKind.Local).AddTicks(9818), 100000m, 2, "Mắt Biếc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "PublisherId", "Title" },
                values: new object[] { 9, "/image_195509_1_40336.jpg", new DateTime(2022, 3, 20, 8, 24, 25, 535, DateTimeKind.Local).AddTicks(9819), 1, "Heidi" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 5, "/image_195509_1_00012.jpg", new DateTime(2021, 5, 12, 8, 24, 25, 535, DateTimeKind.Local).AddTicks(9821), 60000m, 2, "Bến Xe" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Title" },
                values: new object[] { 10, "/image_195509_1_70753.jpg", new DateTime(2022, 5, 20, 2, 24, 25, 535, DateTimeKind.Local).AddTicks(9823), "Your name (Tái bản)" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 7, "/image_195509_1_00014.jpg", new DateTime(2022, 5, 19, 9, 24, 25, 535, DateTimeKind.Local).AddTicks(9824), 88000m, 2, "Cảm Ơn Người Lớn" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 7, "/image_195509_1_00015.jpg", new DateTime(2022, 5, 18, 12, 24, 25, 535, DateTimeKind.Local).AddTicks(9826), 120000m, 2, "Con Chim Xanh Biếc Bay Về" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cus",
                column: "ConcurrencyStamp",
                value: "c4f5570c-b845-4718-9ace-fd56a0dc32b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "emp",
                column: "ConcurrencyStamp",
                value: "53cbaaf0-1972-4c3e-8103-4aed82315bb2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed6940ec-94da-40ac-8eae-d2fa3bc003a4", "AQAAAAEAACcQAAAAEDSmY2a5vlu1O0WGPrZiuE3il7YYuRHikWshN0SEYFTDsv6tdbC1DCJvJUsV4aJqkg==", "7c6b04db-5af6-482e-93ed-09c985f48602" });

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
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "Title" },
                values: new object[] { 2, "/image_195509_1_44030.jpg", new DateTime(2022, 5, 16, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5828), 127000m, "book2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "ImportDateTime", "Title" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5829), "book3" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 2, "/image_195509_1_44030.jpg", new DateTime(2022, 3, 19, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5831), 37900m, 4, "book4" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageURL", "ImportDateTime", "Title" },
                values: new object[] { 1, "/image_195509_1_44030.jpg", new DateTime(2021, 5, 11, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5834), "book5" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 2, "/image_195509_1_44030.jpg", new DateTime(2022, 5, 19, 7, 9, 25, 898, DateTimeKind.Local).AddTicks(5836), 312000m, 4, "book6" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "AuthorId", "CategoryId", "ImageURL", "ImportDateTime", "PublisherId", "Title" },
                values: new object[] { 2, 1, "/image_195509_1_44030.jpg", new DateTime(2022, 5, 18, 14, 9, 25, 898, DateTimeKind.Local).AddTicks(5837), 4, "book7" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { "/image_195509_1_44030.jpg", new DateTime(2022, 5, 17, 17, 9, 25, 898, DateTimeKind.Local).AddTicks(5839), 131200m, 4, "book8" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "PublisherId", "Title" },
                values: new object[] { 2, "/image_195509_1_44030.jpg", new DateTime(2022, 5, 16, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5840), 4, "book2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 2, "/image_195509_1_44030.jpg", new DateTime(2022, 5, 12, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5842), 85000m, 4, "book3" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "PublisherId", "Title" },
                values: new object[] { 2, "/image_195509_1_44030.jpg", new DateTime(2022, 3, 19, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5844), 4, "book4" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 2, "/image_195509_1_44030.jpg", new DateTime(2021, 5, 11, 13, 9, 25, 898, DateTimeKind.Local).AddTicks(5846), 259000m, 4, "book5" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Title" },
                values: new object[] { 2, "/image_195509_1_44030.jpg", new DateTime(2022, 5, 19, 7, 9, 25, 898, DateTimeKind.Local).AddTicks(5847), "book6" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 2, "/image_195509_1_44030.jpg", new DateTime(2022, 5, 18, 14, 9, 25, 898, DateTimeKind.Local).AddTicks(5849), 70000m, 4, "book7" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "AuthorId", "ImageURL", "ImportDateTime", "Price", "PublisherId", "Title" },
                values: new object[] { 2, "/image_195509_1_44030.jpg", new DateTime(2022, 5, 17, 17, 9, 25, 898, DateTimeKind.Local).AddTicks(5850), 131200m, 4, "book8" });
        }
    }
}
