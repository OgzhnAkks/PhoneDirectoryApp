using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneDirectory.DataAccess.Services.Migrations
{
    /// <inheritdoc />
    public partial class DbTableAddColmn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "Active",
                schema: "person",
                table: "Person",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Active",
                schema: "contact",
                table: "ContactInfo",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                schema: "person",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Active",
                schema: "contact",
                table: "ContactInfo");
        }
    }
}
