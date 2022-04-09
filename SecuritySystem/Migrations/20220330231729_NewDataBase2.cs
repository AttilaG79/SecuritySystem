using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecuritySystem.Migrations
{
    public partial class NewDataBase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_StoresDatas_getStoresStoreId",
                table: "SecurityDatas");

            migrationBuilder.DropColumn(
                name: "OfficerName",
                table: "SecurityDatas");

            migrationBuilder.RenameColumn(
                name: "getStoresStoreId",
                table: "SecurityDatas",
                newName: "GetStoresStoreId");

            migrationBuilder.RenameIndex(
                name: "IX_SecurityDatas_getStoresStoreId",
                table: "SecurityDatas",
                newName: "IX_SecurityDatas_GetStoresStoreId");

            migrationBuilder.AddColumn<DateTime>(
                name: "StoreRegistrationTime",
                table: "StoresDatas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GetOfficersOfficerId",
                table: "SecurityDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Officer_Id",
                table: "SecurityDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OfficerDatas",
                columns: table => new
                {
                    OfficerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficerGender = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficerRegistrationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficerDatas", x => x.OfficerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SecurityDatas_GetOfficersOfficerId",
                table: "SecurityDatas",
                column: "GetOfficersOfficerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityDatas_OfficerDatas_GetOfficersOfficerId",
                table: "SecurityDatas",
                column: "GetOfficersOfficerId",
                principalTable: "OfficerDatas",
                principalColumn: "OfficerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityDatas_StoresDatas_GetStoresStoreId",
                table: "SecurityDatas",
                column: "GetStoresStoreId",
                principalTable: "StoresDatas",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_OfficerDatas_GetOfficersOfficerId",
                table: "SecurityDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_StoresDatas_GetStoresStoreId",
                table: "SecurityDatas");

            migrationBuilder.DropTable(
                name: "OfficerDatas");

            migrationBuilder.DropIndex(
                name: "IX_SecurityDatas_GetOfficersOfficerId",
                table: "SecurityDatas");

            migrationBuilder.DropColumn(
                name: "StoreRegistrationTime",
                table: "StoresDatas");

            migrationBuilder.DropColumn(
                name: "GetOfficersOfficerId",
                table: "SecurityDatas");

            migrationBuilder.DropColumn(
                name: "Officer_Id",
                table: "SecurityDatas");

            migrationBuilder.RenameColumn(
                name: "GetStoresStoreId",
                table: "SecurityDatas",
                newName: "getStoresStoreId");

            migrationBuilder.RenameIndex(
                name: "IX_SecurityDatas_GetStoresStoreId",
                table: "SecurityDatas",
                newName: "IX_SecurityDatas_getStoresStoreId");

            migrationBuilder.AddColumn<string>(
                name: "OfficerName",
                table: "SecurityDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityDatas_StoresDatas_getStoresStoreId",
                table: "SecurityDatas",
                column: "getStoresStoreId",
                principalTable: "StoresDatas",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
