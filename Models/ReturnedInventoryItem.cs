namespace Capstone_Inventory_Project.Models
{
    public class ReturnedInventoryItem
    {
        public int Id { get; set; }
        public string EquipmentType { get; set; } = "";
        public string EquipmentModel { get; set; } = "";
        public string EquipmentSerial { get; set; } = "";
        public DateTime ReturnedAt { get; set; } = DateTime.UtcNow;
    }
}
