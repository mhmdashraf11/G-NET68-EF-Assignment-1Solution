using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G_NET68_EF_Assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnNameAtBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicationDate",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "PublicationYear",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicationYear",
                table: "Books");

            migrationBuilder.AddColumn<DateOnly>(
                name: "PublicationDate",
                table: "Books",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
