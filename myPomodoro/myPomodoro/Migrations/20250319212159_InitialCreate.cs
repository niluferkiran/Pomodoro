using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myPomodoro.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sayaclar",
                columns: table => new
                {
                    PomodoroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaslaBitir = table.Column<bool>(type: "bit", nullable: false),
                    Sure = table.Column<TimeSpan>(type: "time", nullable: false),
                    Toplam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sayaclar", x => x.PomodoroID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sayaclar");
        }
    }
}
