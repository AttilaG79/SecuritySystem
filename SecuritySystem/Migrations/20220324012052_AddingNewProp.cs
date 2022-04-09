﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecuritySystem.Migrations
{
    public partial class AddingNewProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sex",
                table: "SecurityDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stores",
                table: "SecurityDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "SecurityDatas");

            migrationBuilder.DropColumn(
                name: "Stores",
                table: "SecurityDatas");
        }
    }
}
