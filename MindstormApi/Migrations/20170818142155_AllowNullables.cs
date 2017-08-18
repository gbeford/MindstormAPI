using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MindstormApi.Migrations
{
    public partial class AllowNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MinRange",
                table: "MatchDefinition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MaxRange",
                table: "MatchDefinition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.DropColumn(
            name: "MatchYear",
            table: "MatchDefinition");

            migrationBuilder.AddColumn<int>(
                name: "MatchYear",
                table: "MatchDefinition",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MinRange",
                table: "MatchDefinition",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaxRange",
                table: "MatchDefinition",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MatchYear",
                table: "MatchDefinition",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "DateTime");
        }
    }
}
