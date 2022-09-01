using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace phonebook.Migrations
{
    public partial class phone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "family",
                table: "Tbl_Phonebooks");

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "Tbl_Phonebooks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "number",
                table: "Tbl_Phonebooks",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "family",
                table: "Tbl_Phonebooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
