using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneDirectory.DataAccess.Services.Migrations
{
    /// <inheritdoc />
    public partial class TableColUpdatedMigraiton_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNuber",
                schema: "contact",
                table: "ContactInfo",
                newName: "PhoneNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                schema: "contact",
                table: "ContactInfo",
                newName: "PhoneNuber");
        }
    }
}
