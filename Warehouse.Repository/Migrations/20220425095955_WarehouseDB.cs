using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Warehouse.Repository.Migrations
{
    public partial class WarehouseDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnitName = table.Column<string>(type: "TEXT", nullable: true),
                    Inactive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    ContactPerson = table.Column<string>(type: "TEXT", nullable: true),
                    Inactive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Path = table.Column<string>(type: "TEXT", nullable: true),
                    ParentId = table.Column<string>(type: "TEXT", nullable: true),
                    Inactive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseItemCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ParentId = table.Column<string>(type: "TEXT", nullable: true),
                    Path = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Inactive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseItemCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    WarehouseItemCategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    VendorId = table.Column<int>(type: "INTEGER", nullable: true),
                    VendorName = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    UnitId = table.Column<int>(type: "INTEGER", nullable: false),
                    Inactive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarehouseItem_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WarehouseItem_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WarehouseItem_WarehouseItemCategory_WarehouseItemCategoryId",
                        column: x => x.WarehouseItemCategoryId,
                        principalTable: "WarehouseItemCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItem_UnitId",
                table: "WarehouseItem",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItem_VendorId",
                table: "WarehouseItem",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItem_WarehouseItemCategoryId",
                table: "WarehouseItem",
                column: "WarehouseItemCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "WarehouseItem");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "WarehouseItemCategory");
        }
    }
}
