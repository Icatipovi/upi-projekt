using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Football.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(name: "City_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionID = table.Column<int>(name: "Position_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfPosition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "Scales",
                columns: table => new
                {
                    ScaleID = table.Column<int>(name: "Scale_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Points = table.Column<int>(type: "int", nullable: false),
                    ScalePosition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scales", x => x.ScaleID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(name: "Team_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfTeam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityID = table.Column<int>(name: "City_ID", type: "int", nullable: false),
                    CityIdCityID = table.Column<int>(name: "CityIdCity_ID", type: "int", nullable: false),
                    CoachID = table.Column<int>(name: "Coach_ID", type: "int", nullable: false),
                    ScaleID = table.Column<int>(name: "Scale_ID", type: "int", nullable: false),
                    ScaleID1 = table.Column<int>(name: "Scale_ID1", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                    table.ForeignKey(
                        name: "FK_Teams_Cities_CityIdCity_ID",
                        column: x => x.CityIdCityID,
                        principalTable: "Cities",
                        principalColumn: "City_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_Scales_Scale_ID1",
                        column: x => x.ScaleID1,
                        principalTable: "Scales",
                        principalColumn: "Scale_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    CoachID = table.Column<int>(name: "Coach_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoachName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoachLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.CoachID);
                    table.ForeignKey(
                        name: "FK_Coaches_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Team_ID");
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<int>(name: "Game_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeTeamID = table.Column<int>(name: "HomeTeam_ID", type: "int", nullable: true),
                    GuestTeamID = table.Column<int>(name: "GuestTeam_ID", type: "int", nullable: true),
                    HomeScore = table.Column<int>(type: "int", nullable: false),
                    GuestScore = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                    table.ForeignKey(
                        name: "FK_Games_Teams_GuestTeam_ID",
                        column: x => x.GuestTeamID,
                        principalTable: "Teams",
                        principalColumn: "Team_ID");
                    table.ForeignKey(
                        name: "FK_Games_Teams_HomeTeam_ID",
                        column: x => x.HomeTeamID,
                        principalTable: "Teams",
                        principalColumn: "Team_ID");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<int>(name: "Player_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerNumber = table.Column<int>(type: "int", nullable: false),
                    AverageMark = table.Column<double>(type: "float", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                    table.ForeignKey(
                        name: "FK_Players_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Position_ID");
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Team_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_TeamId",
                table: "Coaches",
                column: "TeamId",
                unique: true,
                filter: "[TeamId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GuestTeam_ID",
                table: "Games",
                column: "GuestTeam_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_HomeTeam_ID",
                table: "Games",
                column: "HomeTeam_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_PositionId",
                table: "Players",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CityIdCity_ID",
                table: "Teams",
                column: "CityIdCity_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Scale_ID1",
                table: "Teams",
                column: "Scale_ID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Scales");
        }
    }
}
