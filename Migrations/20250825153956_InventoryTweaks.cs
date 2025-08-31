using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapstoneInventoryProject.Migrations
{
    /// <inheritdoc />
    public partial class InventoryTweaks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "InventoryItems",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                defaultValue: "Available",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItems_EquipmentSerial",
                table: "InventoryItems",
                column: "EquipmentSerial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InventoryItems_EquipmentSerial",
                table: "InventoryItems");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "InventoryItems",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30,
                oldDefaultValue: "Available");
        }
    }
}
