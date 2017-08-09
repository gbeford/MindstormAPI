using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MindstormApi.Migrations
{
    public partial class updateTeamsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Coach",
                table: "Teams",
                newName: "CompetitionID");

            migrationBuilder.AddColumn<string>(
                name: "AltCoachEmail",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AltCoachFirstName",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AltCoachlastName",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoachFirstName",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoachLastName",
                table: "Teams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AltCoachEmail",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "AltCoachFirstName",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "AltCoachlastName",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "CoachFirstName",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "CoachLastName",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "CompetitionID",
                table: "Teams",
                newName: "Coach");
        }
    }
}
