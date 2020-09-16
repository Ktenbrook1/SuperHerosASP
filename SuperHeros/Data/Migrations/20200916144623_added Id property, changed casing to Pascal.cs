using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeros.Data.Migrations
{
    public partial class addedIdpropertychangedcasingtoPascal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperHeros",
                table: "SuperHeros");

            migrationBuilder.RenameColumn(
                name: "secondaryAbility",
                table: "SuperHeros",
                newName: "SecondaryAbility");

            migrationBuilder.RenameColumn(
                name: "primaryAbility",
                table: "SuperHeros",
                newName: "PrimaryAbility");

            migrationBuilder.RenameColumn(
                name: "catchPhrase",
                table: "SuperHeros",
                newName: "CatchPhrase");

            migrationBuilder.RenameColumn(
                name: "alterEgo",
                table: "SuperHeros",
                newName: "AlterEgo");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "SuperHeros",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SuperHeros",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SuperHeros",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperHeros",
                table: "SuperHeros",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperHeros",
                table: "SuperHeros");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SuperHeros");

            migrationBuilder.RenameColumn(
                name: "SecondaryAbility",
                table: "SuperHeros",
                newName: "secondaryAbility");

            migrationBuilder.RenameColumn(
                name: "PrimaryAbility",
                table: "SuperHeros",
                newName: "primaryAbility");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SuperHeros",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CatchPhrase",
                table: "SuperHeros",
                newName: "catchPhrase");

            migrationBuilder.RenameColumn(
                name: "AlterEgo",
                table: "SuperHeros",
                newName: "alterEgo");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "SuperHeros",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperHeros",
                table: "SuperHeros",
                column: "name");
        }
    }
}
