using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapstoneInventoryProject.Migrations
{
    /// <inheritdoc />
    public partial class SyncModels_20250823 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SerialNumber",
                table: "InventoryItems",
                newName: "EquipmentSerial");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "InventoryItems",
                newName: "EquipmentModel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EquipmentSerial",
                table: "InventoryItems",
                newName: "SerialNumber");

            migrationBuilder.RenameColumn(
                name: "EquipmentModel",
                table: "InventoryItems",
                newName: "Model");
        }
    }
}
