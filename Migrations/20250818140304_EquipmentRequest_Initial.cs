using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapstoneInventoryProject.Migrations
{
    public partial class EquipmentRequest_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EquipmentRequests_Email_SubmittedAt",
                table: "EquipmentRequests",
                columns: new[] { "Email", "SubmittedAt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EquipmentRequests_Email_SubmittedAt",
                table: "EquipmentRequests");
        }
    }
}
