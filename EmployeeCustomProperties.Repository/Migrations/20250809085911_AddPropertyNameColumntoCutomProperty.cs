using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCustomProperties.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyNameColumntoCutomProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PropertyName",
                table: "CustomProperties",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyName",
                table: "CustomProperties");
        }
    }
}
