namespace Capstone_Inventory_Project.Models
{
    public class EquipmentRequest
    {
        public int Id { get; set; }
        public string RequesterName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Department { get; set; } = "";
        public string ManagerEmail { get; set; } = "";
        public string EquipmentType { get; set; } = "";
        public string Reason { get; set; } = "";
        public string Status { get; set; } = "Pending"; // Approved / Denied / Needs More Info
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}
