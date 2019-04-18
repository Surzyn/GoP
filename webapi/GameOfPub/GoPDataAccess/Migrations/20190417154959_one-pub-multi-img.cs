using Microsoft.EntityFrameworkCore.Migrations;

namespace GoPDataAccess.Migrations
{
    public partial class onepubmultiimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pubs_Images_ImageId",
                table: "Pubs");

            migrationBuilder.DropIndex(
                name: "IX_Pubs_ImageId",
                table: "Pubs");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Pubs");

            migrationBuilder.AddColumn<int>(
                name: "PubId",
                table: "Images",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_PubId",
                table: "Images",
                column: "PubId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Pubs_PubId",
                table: "Images",
                column: "PubId",
                principalTable: "Pubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Pubs_PubId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_PubId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "PubId",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Pubs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pubs_ImageId",
                table: "Pubs",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pubs_Images_ImageId",
                table: "Pubs",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
