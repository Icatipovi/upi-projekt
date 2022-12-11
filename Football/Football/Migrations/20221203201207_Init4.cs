using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Football.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_Teams_TeamId",
                table: "Coaches");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Positions_PositionId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Cities_CityIdCity_ID",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Scales_Scale_ID1",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_CityIdCity_ID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Scale_ID1",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_TeamId",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "CityIdCity_ID",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Scale_ID1",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Coaches");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Players",
                newName: "Team_ID");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "Players",
                newName: "Position_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                newName: "IX_Players_Team_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Players_PositionId",
                table: "Players",
                newName: "IX_Players_Position_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_City_ID",
                table: "Teams",
                column: "City_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Coach_ID",
                table: "Teams",
                column: "Coach_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Scale_ID",
                table: "Teams",
                column: "Scale_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Positions_Position_ID",
                table: "Players",
                column: "Position_ID",
                principalTable: "Positions",
                principalColumn: "Position_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_Team_ID",
                table: "Players",
                column: "Team_ID",
                principalTable: "Teams",
                principalColumn: "Team_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Cities_City_ID",
                table: "Teams",
                column: "City_ID",
                principalTable: "Cities",
                principalColumn: "City_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Coaches_Coach_ID",
                table: "Teams",
                column: "Coach_ID",
                principalTable: "Coaches",
                principalColumn: "Coach_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Scales_Scale_ID",
                table: "Teams",
                column: "Scale_ID",
                principalTable: "Scales",
                principalColumn: "Scale_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Positions_Position_ID",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_Team_ID",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Cities_City_ID",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Coaches_Coach_ID",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Scales_Scale_ID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_City_ID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Coach_ID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Scale_ID",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "Team_ID",
                table: "Players",
                newName: "TeamId");

            migrationBuilder.RenameColumn(
                name: "Position_ID",
                table: "Players",
                newName: "PositionId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_Team_ID",
                table: "Players",
                newName: "IX_Players_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_Position_ID",
                table: "Players",
                newName: "IX_Players_PositionId");

            migrationBuilder.AddColumn<int>(
                name: "CityIdCity_ID",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Scale_ID1",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Coaches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CityIdCity_ID",
                table: "Teams",
                column: "CityIdCity_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Scale_ID1",
                table: "Teams",
                column: "Scale_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_TeamId",
                table: "Coaches",
                column: "TeamId",
                unique: true,
                filter: "[TeamId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Coaches_Teams_TeamId",
                table: "Coaches",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Team_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Positions_PositionId",
                table: "Players",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Position_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Team_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Cities_CityIdCity_ID",
                table: "Teams",
                column: "CityIdCity_ID",
                principalTable: "Cities",
                principalColumn: "City_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Scales_Scale_ID1",
                table: "Teams",
                column: "Scale_ID1",
                principalTable: "Scales",
                principalColumn: "Scale_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
