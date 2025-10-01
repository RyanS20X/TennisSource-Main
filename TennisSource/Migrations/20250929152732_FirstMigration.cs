using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisSource.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TennisPlayer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisPlayer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TennisTournament",
                columns: table => new
                {
                    TennisTournamentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TennisPlayerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisTournament", x => x.TennisTournamentId);
                });

            migrationBuilder.CreateTable(
                name: "TennisPlayerTennisTournament",
                columns: table => new
                {
                    EventsParticipatedInTennisTournamentId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TennisPlayerTennisTournament", x => new { x.EventsParticipatedInTennisTournamentId, x.PlayersId });
                    table.ForeignKey(
                        name: "FK_TennisPlayerTennisTournament_TennisPlayer_PlayersId",
                        column: x => x.PlayersId,
                        principalTable: "TennisPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TennisPlayerTennisTournament_TennisTournament_EventsParticipatedInTennisTournamentId",
                        column: x => x.EventsParticipatedInTennisTournamentId,
                        principalTable: "TennisTournament",
                        principalColumn: "TennisTournamentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TennisPlayerTennisTournament_PlayersId",
                table: "TennisPlayerTennisTournament",
                column: "PlayersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TennisPlayerTennisTournament");

            migrationBuilder.DropTable(
                name: "TennisPlayer");

            migrationBuilder.DropTable(
                name: "TennisTournament");
        }
    }
}
