using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecuritySystem.Migrations
{
    public partial class AddingStoresDatas_Table4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_StoresDatas_GetStoresId",
                table: "SecurityDatas");

            migrationBuilder.DropIndex(
                name: "IX_SecurityDatas_GetStoresId",
                table: "SecurityDatas");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StoresDatas",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "SecurityDatas",
                newName: "getStoresStoreId");

            migrationBuilder.RenameColumn(
                name: "GetStoresId",
                table: "SecurityDatas",
                newName: "Store_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityDatas_getStoresStoreId",
                table: "SecurityDatas",
                column: "getStoresStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityDatas_StoresDatas_getStoresStoreId",
                table: "SecurityDatas",
                column: "getStoresStoreId",
                principalTable: "StoresDatas",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_StoresDatas_getStoresStoreId",
                table: "SecurityDatas");

            migrationBuilder.DropIndex(
                name: "IX_SecurityDatas_getStoresStoreId",
                table: "SecurityDatas");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "StoresDatas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "getStoresStoreId",
                table: "SecurityDatas",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "Store_Id",
                table: "SecurityDatas",
                newName: "GetStoresId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityDatas_GetStoresId",
                table: "SecurityDatas",
                column: "GetStoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityDatas_StoresDatas_GetStoresId",
                table: "SecurityDatas",
                column: "GetStoresId",
                principalTable: "StoresDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
