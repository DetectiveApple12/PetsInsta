using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetInsta.Migrations
{
    /// <inheritdoc />
    public partial class AddedLikesCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Post");
        }
    }
}
