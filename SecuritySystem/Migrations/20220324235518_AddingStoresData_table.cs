using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecuritySystem.Migrations
{
    public partial class AddingStoresData_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stores",
                table: "SecurityDatas",
                newName: "StoreId");

            migrationBuilder.AddColumn<int>(
                name: "GetStoresId",
                table: "SecurityDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StoresData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StorePhone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoresData", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SecurityDatas_GetStoresId",
                table: "SecurityDatas",
                column: "GetStoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityDatas_StoresData_GetStoresId",
                table: "SecurityDatas",
                column: "GetStoresId",
                principalTable: "StoresData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecurityDatas_StoresData_GetStoresId",
                table: "SecurityDatas");

            migrationBuilder.DropTable(
                name: "StoresData");

            migrationBuilder.DropIndex(
                name: "IX_SecurityDatas_GetStoresId",
                table: "SecurityDatas");

            migrationBuilder.DropColumn(
                name: "GetStoresId",
                table: "SecurityDatas");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "SecurityDatas",
                newName: "Stores");
        }
    }
}
