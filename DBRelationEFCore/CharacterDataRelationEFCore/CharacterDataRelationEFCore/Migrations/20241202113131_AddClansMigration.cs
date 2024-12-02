using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterDataRelationEFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddClansMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterClan",
                columns: table => new
                {
                    CharactersId = table.Column<int>(type: "int", nullable: false),
                    ClansId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClan", x => new { x.CharactersId, x.ClansId });
                    table.ForeignKey(
                        name: "FK_CharacterClan_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterClan_Clans_ClansId",
                        column: x => x.ClansId,
                        principalTable: "Clans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClan_ClansId",
                table: "CharacterClan",
                column: "ClansId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterClan");

            migrationBuilder.DropTable(
                name: "Clans");
        }
    }
}
