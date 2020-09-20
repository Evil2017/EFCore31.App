using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore31.Data.Migrations
{
    public partial class addgame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GamePlayer",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false),
                    GamePlayerGameId = table.Column<int>(nullable: true),
                    GamePlayerPlayerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlayer", x => new { x.GameId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_GamePlayer_players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlayer_GamePlayer_GamePlayerGameId_GamePlayerPlayerId",
                        columns: x => new { x.GamePlayerGameId, x.GamePlayerPlayerId },
                        principalTable: "GamePlayer",
                        principalColumns: new[] { "GameId", "PlayerId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayer_PlayerId",
                table: "GamePlayer",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayer_GamePlayerGameId_GamePlayerPlayerId",
                table: "GamePlayer",
                columns: new[] { "GamePlayerGameId", "GamePlayerPlayerId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamePlayer");
        }
    }
}
