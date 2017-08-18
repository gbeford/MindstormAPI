using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MindstormApi.Migrations
{
    public partial class AllowNullablesInAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "year",
                table: "Points",
                type: "int",
                nullable: false,
                defaultValue: 0);

          
            migrationBuilder.DropColumn(
        name: "MatchYear",
        table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "MatchYear",
                table: "Matches",
                nullable: true);

          
            migrationBuilder.DropColumn(
        name: "MatchYear",
        table: "MatchDetails");

            migrationBuilder.AddColumn<int>(
                name: "MatchYear",
                table: "MatchDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "year",
                table: "Points");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MatchYear",
                table: "Matches",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MatchYear",
                table: "MatchDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
