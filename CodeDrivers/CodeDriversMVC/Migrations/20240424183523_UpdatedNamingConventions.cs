using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeDriversMVC.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedNamingConventions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DurationTime",
                table: "Reservations",
                newName: "Duration");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Reservations",
                newName: "DurationTime");
        }
    }
}
