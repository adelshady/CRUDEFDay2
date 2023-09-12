﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDEFDay2.Migrations
{
    /// <inheritdoc />
    public partial class EditPost2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "image",
                table: "Posts",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Posts");
        }
    }
}
