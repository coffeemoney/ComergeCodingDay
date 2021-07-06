using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingDay.Data.Migrations
{
    public partial class AddDefaultDataForUserTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Coding Day Team", "Coding Day Team" });

            migrationBuilder.InsertData(
                table: "UserTeams",
                columns: new[] { "TeamId", "UserId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
