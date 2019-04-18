using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoPDataAccess.Migrations
{
    public partial class withdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreationDate", "PubId", "Rate", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "Najlepsze burgery w miescie" },
                    { 2, new DateTime(2019, 4, 18, 18, 26, 4, 128, DateTimeKind.Local), null, 10, "Nie polecam" }
                });

            migrationBuilder.InsertData(
                table: "Pubs",
                columns: new[] { "Id", "CreationDate", "Description", "Name", "Rate", "Street" },
                values: new object[,]
                {
                    { 1, new DateTime(2017, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miejsce gdzie mozna zjesc dobrego burgera", "M22", 10.0, "Marka" },
                    { 2, new DateTime(2017, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miejsce gdzie mozna zjesc burgera", "Moa", 4.0, "Mikołajska" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CommentId", "ImageUrl", "PubId" },
                values: new object[,]
                {
                    { 2, 1, "https://img.grouponcdn.com/deal/iAwMo3Nro6CReRkvnkj7/jL-2048x1229/v1/c700x420.jpg", null },
                    { 3, 1, "http://streetfoodpolska.pl/web/wp-content/uploads/2017/07/blu-przekr%C4%98j.jpg", null },
                    { 4, 2, "https://www.likealocalguide.com/media/cache/1e/52/1e52677c916d0d345e0897a5455d80a6.jpg", null },
                    { 1, null, "https://media-cdn.tripadvisor.com/media/photo-s/15/4b/fd/3d/gotta-love-that-monster.jpg", 1 },
                    { 5, null, "http://wroclawskiejedzenie.pl/wp-content/uploads/2015/10/IMG_3731.jpg", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pubs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pubs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
