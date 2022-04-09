using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecuritySystem.Migrations
{
    public partial class AddingStoresData_Table2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_StoresData_GetStoresId",
                table: "SecurityDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoresData",
                table: "StoresData");

            migrationBuilder.RenameTable(
                name: "StoresData",
                newName: "StoresDatas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoresDatas",
                table: "StoresDatas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityDatas_StoresDatas_GetStoresId",
                table: "SecurityDatas",
                column: "GetStoresId",
                principalTable: "StoresDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_StoresDatas_GetStoresId",
                table: "SecurityDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoresDatas",
                table: "StoresDatas");

            migrationBuilder.RenameTable(
                name: "StoresDatas",
                newName: "StoresData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoresData",
                table: "StoresData",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityDatas_StoresData_GetStoresId",
                table: "SecurityDatas",
                column: "GetStoresId",
                principalTable: "StoresData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
