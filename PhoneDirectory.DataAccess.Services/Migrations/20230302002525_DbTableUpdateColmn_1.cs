using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneDirectory.DataAccess.Services.Migrations
{
    /// <inheritdoc />
    public partial class DbTableUpdateColmn_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfo_Person_PersonId",
                schema: "contact",
                table: "ContactInfo");

            migrationBuilder.DropIndex(
                name: "IX_ContactInfo_PersonId",
                schema: "contact",
                table: "ContactInfo");

            migrationBuilder.AddColumn<int>(
                name: "ContactInfoId",
                schema: "person",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                schema: "person",
                table: "Person");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfo_PersonId",
                schema: "contact",
                table: "ContactInfo",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInfo_Person_PersonId",
                schema: "contact",
                table: "ContactInfo",
                column: "PersonId",
                principalSchema: "person",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
