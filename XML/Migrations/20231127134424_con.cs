using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XML.Migrations
{
    /// <inheritdoc />
    public partial class con : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sISOCode",
                table: "CountryInfo",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryInfo",
                table: "CountryInfo",
                column: "sISOCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryInfo",
                table: "CountryInfo");

            migrationBuilder.AlterColumn<string>(
                name: "sISOCode",
                table: "CountryInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
