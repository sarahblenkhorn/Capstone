using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapstoneInventoryProject.Migrations
{
    /// <inheritdoc />
    public partial class AddEquipmentModelAndSerialToRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EquipmentModel",
                table: "EquipmentRequests",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentSerial",
                table: "EquipmentRequests",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipmentModel",
                table: "EquipmentRequests");

            migrationBuilder.DropColumn(
                name: "EquipmentSerial",
                table: "EquipmentRequests");
        }
    }
}
