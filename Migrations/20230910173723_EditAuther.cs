using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDEFDay2.Migrations
{
    /// <inheritdoc />
    public partial class EditAuther : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "image",
                table: "Authors",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Authors");
        }
    }
}
