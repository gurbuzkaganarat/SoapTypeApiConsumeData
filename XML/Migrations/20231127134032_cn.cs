using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XML.Migrations
{
    /// <inheritdoc />
    public partial class cn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryInfo",
                columns: table => new
                {
                    sISOCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sCapitalCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sPhoneCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sContinentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sCurrencyISOCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sCountryFlag = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryInfo");
        }
    }
}
