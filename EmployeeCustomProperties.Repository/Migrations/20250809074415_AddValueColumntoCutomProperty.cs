using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCustomProperties.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddValueColumntoCutomProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "CustomProperties",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "CustomProperties");
        }
    }
}
