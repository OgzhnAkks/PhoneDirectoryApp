using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneDirectory.DataAccess.Services.Migrations
{
    /// <inheritdoc />
    public partial class DbTableAddColmn_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_ContactInfo_ContactInfoId",
                schema: "person",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_ContactInfoId",
                schema: "person",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                schema: "person",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                schema: "contact",
                table: "ContactInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfo_Person_PersonId",
                schema: "contact",
                table: "ContactInfo");

            migrationBuilder.DropIndex(
                name: "IX_ContactInfo_PersonId",
                schema: "contact",
                table: "ContactInfo");

            migrationBuilder.DropColumn(
                name: "PersonId",
                schema: "contact",
                table: "ContactInfo");

            migrationBuilder.AddColumn<int>(
                name: "ContactInfoId",
                schema: "person",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_ContactInfoId",
                schema: "person",
                table: "Person",
                column: "ContactInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_ContactInfo_ContactInfoId",
                schema: "person",
                table: "Person",
                column: "ContactInfoId",
                principalSchema: "contact",
                principalTable: "ContactInfo",
                principalColumn: "Id");
        }
    }
}
