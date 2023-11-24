using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneDirectory.DataAccess.Services.Migrations
{
    /// <inheritdoc />
    public partial class DbTableUpdatedColmnType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                schema: "person",
                table: "Person",
                type: "bit",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                schema: "contact",
                table: "ContactInfo",
                type: "bit",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Active",
                schema: "person",
                table: "Person",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<short>(
                name: "Active",
                schema: "contact",
                table: "ContactInfo",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
