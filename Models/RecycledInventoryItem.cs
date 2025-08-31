namespace Capstone_Inventory_Project.Models
{
    public class RecycledInventoryItem
    {
        public int Id { get; set; }
        public string EquipmentType { get; set; } = "";
        public string EquipmentModel { get; set; } = "";
        public string EquipmentSerial { get; set; } = "";
        public DateTime RecycledAt { get; set; } = DateTime.UtcNow;
    }
}
