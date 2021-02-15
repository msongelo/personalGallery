using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalGallery.Migrations
{
    public partial class OwnerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "ImageModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "ImageModel");
        }
    }
}
