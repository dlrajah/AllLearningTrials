using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTrial_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AnimalNameDesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Animals");
        }
    }
}
