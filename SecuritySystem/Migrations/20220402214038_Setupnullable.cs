using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecuritySystem.Migrations
{
    public partial class Setupnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_OfficerDatas_GetOfficersOfficerId",
                table: "SecurityDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_StoresDatas_GetStoresStoreId",
                table: "SecurityDatas");

            migrationBuilder.AlterColumn<string>(
                name: "PoliceName",
                table: "SecurityDatas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "GetStoresStoreId",
                table: "SecurityDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GetOfficersOfficerId",
                table: "SecurityDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityDatas_OfficerDatas_GetOfficersOfficerId",
                table: "SecurityDatas",
                column: "GetOfficersOfficerId",
                principalTable: "OfficerDatas",
                principalColumn: "OfficerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityDatas_StoresDatas_GetStoresStoreId",
                table: "SecurityDatas",
                column: "GetStoresStoreId",
                principalTable: "StoresDatas",
                principalColumn: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_OfficerDatas_GetOfficersOfficerId",
                table: "SecurityDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_StoresDatas_GetStoresStoreId",
                table: "SecurityDatas");

            migrationBuilder.AlterColumn<string>(
                name: "PoliceName",
                table: "SecurityDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GetStoresStoreId",
                table: "SecurityDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GetOfficersOfficerId",
                table: "SecurityDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
