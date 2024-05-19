using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeDriversMVC.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDurationType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Reservations",
                type: "nvarchar(200)",
                defaultValue: 0,
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Reservations",
                type: "int",
                defaultValue: 0,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Reservations",
                type: "time",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
