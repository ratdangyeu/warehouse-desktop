using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Warehouse.Repository.Migrations
{
    public partial class WarehouseDB_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Store_StoreId1",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_StoreId1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "StoreId1",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "StoreId",
                table: "User",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_User_StoreId",
                table: "User",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Store_StoreId",
                table: "User",
                column: "StoreId",
                principalTable: "Store",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Store_StoreId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_StoreId",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "User",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreId1",
                table: "User",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_StoreId1",
                table: "User",
                column: "StoreId1");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Store_StoreId1",
                table: "User",
                column: "StoreId1",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
